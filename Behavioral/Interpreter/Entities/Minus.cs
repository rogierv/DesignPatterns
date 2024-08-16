namespace Interpreter.Entities;

internal class Minus(IExpression leftOperand, IExpression rightOperand) : IExpression
{
	public int Interpret(Context context)
	{
		return leftOperand.Interpret(context) - rightOperand.Interpret(context);
	}
}