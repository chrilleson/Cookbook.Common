
using Cookbook.Common.Contracts.Contracts.Models;

namespace Cookbook.Common.Contracts.Models;

public record RecipePart : IRecipePart
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateOnly CreatedDate { get; init; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly UpdatedDate { get; set; }
    public string Name { get; set; }
    public Guid RecipeId { get; set; }
    
    [ForeignKey(nameof(RecipeId))]
    public IRecipe Recipe { get; set; }

    public ICollection<IIngredient> Ingredients { get; set; }

    public RecipePart Create(string name, Guid recipeId, Recipe recipe) =>
        new(name, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now));

    public RecipePart Create(string name, Guid recipeId, Recipe recipe, DateOnly updatedDate) => 
        new(name, recipeId, recipe, updatedDate);

    private RecipePart(string name, Guid recipeId, Recipe recipe, DateOnly updatedDate)
    {
        Name = name;
        RecipeId = recipeId;
        Recipe = recipe;
        UpdatedDate = updatedDate;
    }
}