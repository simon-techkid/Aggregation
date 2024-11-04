using System;
using System.Collections.Generic;

namespace Aggregator;

/// <summary>
/// Represents an object aggregator for elements of type <typeparamref name="T"/>, aggregated using keys of type <typeparamref name="TKey"/>.
/// </summary>
/// <typeparam name="T">The type of elements to aggregate.</typeparam>
/// <typeparam name="TKey">The type of keys of the elements to use for aggregation.</typeparam>
public abstract class Aggregator<T> : IAggregator<T>
{
    public IEnumerable<T> GetUniqueElements() => GetElementsUniquely(GetElements());

    /// <summary>
    /// Get the elements of type <typeparamref name="T"/> to aggregate.
    /// </summary>
    /// <returns>A collection of type <see cref="IEnumerable{T}"/> of elements of type <typeparamref name="T"/>.</returns>
    protected abstract IEnumerable<T> GetElements();

    /// <summary>
    /// Gets the unique elements of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>A collection of type <see cref="IEnumerable{T}"/> of elements of type <typeparamref name="T"/>.</returns>
    protected abstract IEnumerable<T> GetElementsUniquely(IEnumerable<T> elements);
}
