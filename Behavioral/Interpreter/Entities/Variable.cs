namespace Interpreter.Entities;

internal class Variable(string name) : IExpression
{
	public int Interpret(Context context) => string.IsNullOrEmpty(name) ? 0 : context[name].Interpret(context);
}