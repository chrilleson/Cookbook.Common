using System.ComponentModel.DataAnnotations;
using Cookbook.Common.Contracts.Contracts.Models;

namespace Cookbook.Common.Contracts.Models;

public record RecipeStep : IRecipeStep
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public DateOnly CreatedDate { get; init; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly UpdatedDate { get; set; }
    public Guid RecipeId { get; set; }
    
    [ForeignKey(nameof(RecipeId))]
    [NotNull]
    public IRecipe Recipe { get; set; }
    public int StepNumber { get; set; }

    [MaxLength(300)]
    [NotNull]
    public string Description { get; set; }
    
    [AllowNull]
    public Guid? RecipePartId { get; set; }

    [ForeignKey(nameof(RecipePartId))]
    [AllowNull]
    public RecipePart? RecipePart { get; set; }

    private RecipeStep(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId, RecipePart? recipePart)
    {
        StepNumber = stepNumber;
        Description = description;
        RecipeId = recipeId;
        Recipe = recipe;
        UpdatedDate = updatedDate;
        RecipePartId = recipePartId;
        RecipePart = recipePart;
    }

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe) =>
        new(stepNumber, description, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), Guid.Empty, default);

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, Guid recipePartId) =>
        new(stepNumber, description, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), recipePartId, default);

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, Guid recipePartId, RecipePart recipePart) =>
        new(stepNumber, description, recipeId, recipe, DateOnly.FromDateTime(DateTime.Now), recipePartId, recipePart);

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate) =>
        new(stepNumber, description, recipeId, recipe, updatedDate, Guid.Empty, default);

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId) =>
        new(stepNumber, description, recipeId, recipe, updatedDate, recipePartId, default);

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId, RecipePart recipePart) =>
        new(stepNumber, description, recipeId, recipe, updatedDate, recipePartId, recipePart);
}