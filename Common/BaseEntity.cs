using System.ComponentModel.DataAnnotations;
using Cookbook.Common.Contracts.Contracts;

namespace Cookbook.Common.Contracts.Common;

public record BaseEntity : IBaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; init; }

    public DateOnly CreatedDate { get; init; }

    public DateOnly UpdatedDate { get; set; }
}