using System.Collections.Generic;
using System.Linq;

namespace Aggregator;

/// <summary>
/// Uses <see cref="System.Linq"/> to determine distinct objects of type <typeparamref name="T"/> during aggregation.
/// </summary>
/// <typeparam name="T">The type of objects being compared.</typeparam>
public abstract class AggregatorLinq<T> : AggregatorEqualityComparison<T, T>
{
    protected override IEnumerable<T> GetElementsUniquely(IEnumerable<T> elements) => elements.Distinct(EqualityComparer);
}
