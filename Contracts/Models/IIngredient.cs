using Cookbook.Common.Contracts.Models;

namespace Cookbook.Common.Contracts.Contracts.Models;

public interface IIngredient : IBaseEntity
{
    public string Name { get; set; }

    public decimal Amount { get; set; }

    public Enumerators.Enumerators.MassTypes MassType { get; set; }

    [MaybeNull]
    public Guid? RecipePartId { get; set; }
        
    [MaybeNull]
    [ForeignKey(nameof(RecipePartId))]
    public IRecipePart RecipePart { get; set; }

    [NotNull]
    public Guid RecipeId { get; set; }

    [NotNull]
    [ForeignKey(nameof(RecipeId))]
    public IRecipe Recipe { get; set; }
    
    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, Guid? recipePartId);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid? recipePartId);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, Guid? recipePartId, RecipePart? recipePart);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid? recipePartId, RecipePart? recipePart);
}