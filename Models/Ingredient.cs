using Cookbook.Common.Contracts.Contracts.Models;

namespace Cookbook.Common.Contracts.Models;

public record Ingredient : IIngredient
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateOnly CreatedDate { get; init; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly UpdatedDate { get; set; }
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

    private Ingredient(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId, RecipePart? recipePart)
    {
        Name = name;
        Amount = amount;
        MassType = massType;
        RecipeId = recipeId;
        Recipe = recipe;
        UpdatedDate = updatedDate;
        RecipePartId = recipePartId;
        RecipePart = recipePart;
    }

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe) =>
        new(name, amount, massType, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), Guid.Empty, default);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate) =>
        new(name, amount, massType, recipeId, recipe, updatedDate, Guid.Empty, default);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, Guid? recipePartId) =>
        new(name, amount, massType, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), recipePartId ?? Guid.Empty, default);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid? recipePartId) =>
        new(name, amount, massType, recipeId, recipe, updatedDate, recipePartId ?? Guid.Empty, default);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, Guid? recipePartId, RecipePart? recipePart) =>
        new(name, amount, massType, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), recipePartId ?? Guid.Empty, recipePart ?? default);

    public Ingredient Create(string name, decimal amount, Enumerators.Enumerators.MassTypes massType, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid? recipePartId, RecipePart? recipePart) =>
        new(name, amount, massType, recipeId, recipe, updatedDate, recipePartId ?? Guid.Empty, recipePart ?? default);
}