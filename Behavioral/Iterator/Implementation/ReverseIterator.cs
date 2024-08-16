using System.Collections;

namespace Iterator.Implementation;

internal class ReverseIterator<T> : IEnumerator<T>
{
	private int _currentIndex;
	private readonly ReverseContainer<T> _reversContainer;

	public ReverseIterator(ReverseContainer<T> reversContainer)
	{
		_reversContainer = reversContainer;
		_currentIndex = _reversContainer.Count;
	}

	/// <summary>
	/// Gets the element in the collection at the current position of the enumerator.
	/// </summary>
	/// <exception cref="InvalidOperationException"></exception>
	public T Current => _currentIndex == -1 || _currentIndex == _reversContainer.Count
				? throw new InvalidOperationException()
				: _reversContainer[_currentIndex];

	/// <summary>
	/// Gets the element in the collection at the current position of the enumerator.
	/// </summary>
	object IEnumerator.Current => Current;

	/// <summary>
	/// Advances the enumerator to the next element of the collection.
	/// </summary>
	/// <returns>
	/// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
	/// </returns>
	public bool MoveNext()
	{
		if (_currentIndex != -1)
		{
			_currentIndex--;
		}

		return _currentIndex >= 0;
	}

	/// <summary>
	/// Sets the enumerator to its initial position, which is before the first element in the collection.
	/// </summary>
	public void Reset()
	{
		_currentIndex = _reversContainer.Count;
	}

	public void Dispose()
	{
		// Ignored.
	}
}