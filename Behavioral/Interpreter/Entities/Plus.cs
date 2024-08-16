namespace Interpreter.Entities;

internal class Plus(IExpression leftOperand, IExpression rightOperand) : IExpression
{
	public int Interpret(Context context) => leftOperand.Interpret(context) + rightOperand.Interpret(context);
}