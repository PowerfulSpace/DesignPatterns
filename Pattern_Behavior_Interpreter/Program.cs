

using Pattern_Behavior_Interpreter.Models.Expressions;
using Pattern_Behavior_Interpreter.Models;

Context context = new Context
{
    Vocabulary = 'a',
    Source = "aaa"
};

NonTerminalExpression expression = new NonTerminalExpression();
expression.Interpret(context);

Console.WriteLine(context.Result);


Console.ReadLine();