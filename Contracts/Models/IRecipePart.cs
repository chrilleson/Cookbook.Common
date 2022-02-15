using Cookbook.Common.Contracts.Models;

namespace Cookbook.Common.Contracts.Contracts.Models;

public interface IRecipePart : IBaseEntity
{
    public string Name { get; set; }
    public Guid RecipeId { get; set; }
    
    [ForeignKey(nameof(RecipeId))]
    public IRecipe Recipe { get; set; }
    public ICollection<IIngredient> Ingredients { get; set; }

    public RecipePart Create(string name, Guid recipeId, Recipe recipe);
    public RecipePart Create(string name, Guid recipeId, Recipe recipe, DateOnly updatedDate);
}