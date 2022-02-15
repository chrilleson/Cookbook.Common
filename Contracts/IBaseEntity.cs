namespace Cookbook.Common.Contracts.Contracts;

public interface IBaseEntity : IEntity
{
    public DateOnly CreatedDate { get; init; }

    public DateOnly UpdatedDate { get; set; }
}