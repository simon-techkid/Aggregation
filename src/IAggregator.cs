using System.Collections.Generic;

namespace Aggregator;

public interface IAggregator<T>
{
    /// <summary>
    /// Gets the unique elements of type <typeparamref name="T"/>.
    /// </summary>
    /// <returns>A collection of type <see cref="IEnumerable{T}"/> of elements of type <typeparamref name="T"/>.</returns>
    public IEnumerable<T> GetUniqueElements();
}
