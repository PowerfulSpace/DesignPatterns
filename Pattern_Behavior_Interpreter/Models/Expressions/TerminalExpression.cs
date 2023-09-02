namespace Pattern_Behavior_Interpreter.Models.Expressions
{
    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Result = context.Source[context.Position] == context.Vocabulary;
        }
    }
}
