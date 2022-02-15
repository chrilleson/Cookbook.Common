using Cookbook.Common.Contracts.Models;

namespace Cookbook.Common.Contracts.Contracts.Models;

public interface IRecipe : IBaseEntity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public Enumerators.Enumerators.DifficultyLevel DifficultyLevel { get; set; }
    
    public TimeSpan EstimatedCompletionTime { get; set; }
    
    public int NrOfPortions { get; set; }

    public ICollection<RecipePart> RecipeParts { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public ICollection<RecipeStep> RecipeSteps { get; set; }

    public Recipe Create(string name, string description, Enumerators.Enumerators.DifficultyLevel difficultyLevel, TimeSpan estimatedCompletionTime, int nrOfPortions);
    public Recipe Create(string name, string description, Enumerators.Enumerators.DifficultyLevel difficultyLevel, TimeSpan estimatedCompletionTime, int nrOfPortions, DateOnly updatedDate);
}