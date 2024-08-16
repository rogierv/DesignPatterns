namespace Interpreter.Entities;

internal class Number(int number) : IExpression
{
	public int Interpret(Context context) => number;
}