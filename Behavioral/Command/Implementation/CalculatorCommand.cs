using Command.Interfaces;

namespace Command.Implementation;

internal class CalculatorCommand(int operand, char @operator, Calculator calculator) : ICommand
{
	public void Execute()
	{
		calculator.Operation(@operator, operand);
	}

	public void UnExecute()
	{
		calculator.Operation(Undo(@operator), operand);
	}

	#region Private methods

	private static char Undo(char @operator)
	{
		return @operator switch
		{
			'+' => '-',
			'-' => '+',
			'*' => '/',
			'/' => '*',
			_ => ' '
		};
	}

	#endregion Private methods
}