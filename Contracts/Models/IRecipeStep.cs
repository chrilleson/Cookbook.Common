using System.ComponentModel.DataAnnotations;
using Cookbook.Common.Contracts.Models;

namespace Cookbook.Common.Contracts.Contracts.Models;

public interface IRecipeStep : IBaseEntity
{
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
    
    [ForeignKey(nameof(RecipePartId))] [AllowNull]
    public RecipePart? RecipePart { get; set; }

    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe);
    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, Guid recipePartId);
    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, Guid recipePartId, RecipePart recipePart);
    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate);
    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId);
    public RecipeStep Create(int stepNumber, string description, Guid recipeId, Recipe recipe, DateOnly updatedDate, Guid recipePartId, RecipePart recipePart);
}