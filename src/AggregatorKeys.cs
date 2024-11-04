using System.Collections.Generic;

namespace Aggregator;

/// <summary>
/// Uses keys of type <typeparamref name="TKey"/> to determine equality between aggregated objects of type <typeparamref name="T"/>.
/// </summary>
/// <typeparam name="T">The type of objects being aggregated.</typeparam>
/// <typeparam name="TKey">The type of keys used to determine equality of objects being aggregated.</typeparam>
public abstract class AggregatorKeys<T, TKey> : AggregatorEqualityComparison<T, TKey>
{
    protected override IEnumerable<T> GetElementsUniquely(IEnumerable<T> elements)
    {
        HashSet<TKey> uniqueKeys = new(EqualityComparer);

        foreach (T element in elements)
        {
            TKey uniqueKey = GenerateUniqueKey(element);

            if (uniqueKeys.Add(uniqueKey))
            {
                yield return element;
            }
        }
    }

    /// <summary>
    /// Generate a unique key of type <typeparamref name="TKey"/> for the element of type <typeparamref name="T"/> based on critical attributes.
    /// </summary>
    /// <param name="element">The element to generate a unique key for.</param>
    /// <returns>A key of type <typeparamref name="TKey"/> representing the critical information in element <paramref name="element"/>.</returns>
    protected abstract TKey GenerateUniqueKey(T element);
}
