using Interpreter.Entities;

namespace Interpreter.Implementation;

internal class Evaluator : IExpression
{
	private readonly IExpression _expressionTree;

	public Evaluator(string expression)
	{
		if (!string.IsNullOrEmpty(expression))
		{
			var tokens = expression.Split(' ');
			Stack<IExpression> stack = new();

			for (var currentTokenIndex = 0; currentTokenIndex < tokens.Length; currentTokenIndex++)
			{
				var currentToken = tokens[currentTokenIndex];

				stack.Push(currentToken switch
				{
					"one" or "two" or "three" => new Variable(currentToken),
					"-" when currentTokenIndex + 1 < tokens.Length => new Minus(stack.Pop(), new Variable(tokens[++currentTokenIndex])),
					"+" when currentTokenIndex + 1 < tokens.Length => new Plus(stack.Pop(), new Variable(tokens[++currentTokenIndex])),
					_ => throw new InvalidOperationException("Invalid token")
				});
			}

			_expressionTree = stack.Pop();
		}
	}

	public int Interpret(Context context) => _expressionTree.Interpret(context);
}