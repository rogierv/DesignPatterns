using Interpreter.Entities;
using Interpreter.Implementation;

var expression = "one + three - two";
Evaluator evaluator = new(expression);
var expressionResult = evaluator.Interpret(new Context());

Console.WriteLine($"The result of expression '{expression}' is {expressionResult}");
Console.ReadKey();