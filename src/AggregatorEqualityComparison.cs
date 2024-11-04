using System.Collections.Generic;

namespace Aggregator;

/// <summary>
/// An abstract class serving to provide equality comparers for aggregations of objects of type <typeparamref name="T"/> using equality comparers of type <typeparamref name="TEquality"/>.
/// </summary>
/// <typeparam name="T">The type of elements being aggregated.</typeparam>
/// <typeparam name="TEquality">The type of objects used for equality comparison.</typeparam>
public abstract class AggregatorEqualityComparison<T, TEquality> : Aggregator<T>
{
    /// <summary>
    /// The equality comparer to use for keys of type <typeparamref name="TEquality"/>.
    /// If <see cref="OverridenEqualityComparer"/> is <see langword="null"/>, use <see cref="DefaultEqualityComparer"/>.
    /// </summary>
    protected IEqualityComparer<TEquality> EqualityComparer => OverridenEqualityComparer ?? DefaultEqualityComparer;

    /// <summary>
    /// The equality comparer to use for keys of type <typeparamref name="TEquality"/>.
    /// Default value: <see langword="null"/>, override to change.
    /// </summary>
    protected virtual IEqualityComparer<TEquality>? OverridenEqualityComparer { get; } = null;

    /// <summary>
    /// The default equality comparer.
    /// Default value: <see cref="EqualityComparer{T}.Default"/>, override to change.
    /// </summary>
    protected virtual IEqualityComparer<TEquality> DefaultEqualityComparer { get; } = EqualityComparer<TEquality>.Default;
}
