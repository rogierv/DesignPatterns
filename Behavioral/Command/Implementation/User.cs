﻿using Command.Interfaces;

namespace Command.Implementation;

internal class User
{
	private int _current = 0;
	private readonly Calculator _calculator = new();
	private readonly List<ICommand> _commands = [];

	/// <summary>
	/// Redoes the specified levels.
	/// </summary>
	/// <param name="levels">The levels.</param>
	public void Redo(int levels)
	{
		Console.WriteLine($"\n---- Redo {levels} levels");
		for (var index = 0; index < levels; index++)
		{
			if (_current < _commands.Count)
			{
				_commands[_current++].Execute();
			}
		}
	}

	/// <summary>
	/// Undoes the specified levels.
	/// </summary>
	/// <param name="levels">The levels.</param>
	public void Undo(int levels)
	{
		Console.WriteLine($"\n---- Undo {levels} levels");
		for (var index = 0; index < levels; index++)
		{
			if (_current > 0)
			{
				_commands[--_current].UnExecute();
			}
		}
	}

	/// <summary>
	/// This method is responsible for creating
	/// and executing command.
	/// </summary>
	/// <param name="operand">The operand.</param>
	/// <param name="operator">The operator.</param>
	public void Compute(int operand, char @operator)
	{
		CalculatorCommand command = new(operand, @operator, _calculator);
		command.Execute();

		if (_current < _commands.Count)
		{
			_commands.RemoveRange(_current, _commands.Count - _current);
		}

		_commands.Add(command);
		_current++;
	}
}