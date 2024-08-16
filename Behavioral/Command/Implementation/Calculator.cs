namespace Command.Implementation;

internal class Calculator
{
	private int _currentValue = 0;

	/// <summary>
	/// This method is responsible for calculating
	/// the result and displaying it.
	/// </summary>
	/// <param name="operator">The math operator like minus or plus.</param>
	/// <param name="operand">The operand.</param>
	public void Operation(char @operator, int operand)
	{
		var oldValue = _currentValue;

		_currentValue = @operator switch
		{
			'+' => _currentValue + operand,
			'-' => _currentValue - operand,
			'*' => _currentValue * operand,
			'/' => _currentValue / operand,
			_ => throw new NotImplementedException()
		};

		Console.WriteLine($"Operation: {oldValue} {@operator} {operand} = {_currentValue}");
	}
}