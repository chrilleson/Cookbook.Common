
using Cookbook.Common.Contracts.Contracts.Models;

namespace Cookbook.Common.Contracts.Models;

public record Recipe : IRecipe
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateOnly CreatedDate { get; init; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly UpdatedDate { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Enumerators.Enumerators.DifficultyLevel DifficultyLevel { get; set; }
    public TimeSpan EstimatedCompletionTime { get; set; }
    public int NrOfPortions { get; set; }
    
    public ICollection<RecipePart> RecipeParts { get; set; }
    public ICollection<Ingredient> Ingredients { get; set; }
    public ICollection<RecipeStep> RecipeSteps { get; set; }
    
    public Recipe Create(string name, string description, Enumerators.Enumerators.DifficultyLevel difficultyLevel, TimeSpan estimatedCompletionTime, int nrOfPortions) => 
        new(name, description, difficultyLevel, estimatedCompletionTime, nrOfPortions, DateOnly.FromDateTime(DateTime.Now));
    
    public Recipe Create(string name, string description, Enumerators.Enumerators.DifficultyLevel difficultyLevel, TimeSpan estimatedCompletionTime, int nrOfPortions, DateOnly updatedDate) => 
        new(name, description, difficultyLevel, estimatedCompletionTime, nrOfPortions, updatedDate);

    private Recipe(string name, string description, Enumerators.Enumerators.DifficultyLevel difficultyLevel, TimeSpan estimatedCompletionTime, int nrOfPortions, DateOnly updatedDate)
    {
        Name = name;
        Description = description;
        DifficultyLevel = difficultyLevel;
        EstimatedCompletionTime = estimatedCompletionTime;
        NrOfPortions = nrOfPortions;
        UpdatedDate = updatedDate;
    }
}