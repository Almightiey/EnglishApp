namespace Domain.Common;

public abstract class Entity : IIdentifiable
{
    public long Id { get; set; }
}

public abstract class EntityGuid : IIdentifiableGuid
{
    public Guid Id { get; set; }
}