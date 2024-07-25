namespace Domain.Common;

public interface IIdentifiable<TKey> where TKey : IComparable, IEquatable<TKey>
{
    TKey Id { get; set; }
}

public interface IIdentifiable : IIdentifiable<long> { }

public interface IIdentifiableGuid : IIdentifiable<Guid> { }