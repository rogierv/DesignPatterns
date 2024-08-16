using System.Collections;

namespace Iterator.Implementation;

internal class ReverseContainer<T>(int arrayLength) : IEnumerable<T>
{
	private readonly T[] _internalArray = new T[arrayLength];

	/// <summary>
	/// Gets the <see cref="T"/> at the specified index.
	/// </summary>
	/// <value>The <see cref="T"/>.</value>
	/// <param name="index">The index.</param>
	/// <returns>The current item.</returns>
	/// <exception cref="IndexOutOfRangeException">Index out of range.</exception>
	public T this[int index] => _internalArray.Length > index
		? _internalArray[index]
		: throw new IndexOutOfRangeException("Index out of range.");

	/// <summary>
	/// Gets the count.
	/// </summary>
	/// <value>The count.</value>
	public int Count { get; private set; }

	/// <summary>
	/// Adds the specified item.
	/// </summary>
	/// <param name="item">The item.</param>
	/// <exception cref="ArgumentException">Internal array is full.</exception>
	public void Add(T item)
	{
		if (_internalArray.Length <= Count)
		{
			throw new ArgumentException("Internal array is full");
		}

		_internalArray[Count] = item;
		Count++;
	}

	/// <summary>
	/// Returns an enumerator that iterates through the collection.
	/// </summary>
	/// <returns>
	/// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
	/// </returns>
	public IEnumerator<T> GetEnumerator()
	{
		for (var currentIndex = Count - 1; currentIndex >= 0; currentIndex--)
		{
			yield return _internalArray[currentIndex];
		}
	}

	/// <summary>
	/// Returns an enumerator that iterates through a collection.
	/// </summary>
	/// <returns>
	/// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
	/// </returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new ReverseIterator<T>(this);
	}
}