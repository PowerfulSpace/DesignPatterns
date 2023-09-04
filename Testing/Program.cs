

TwoColorFlag flag = new UkraineFlag();
flag.Draw();

Console.WriteLine();

flag = new PolangFlag();
flag.Draw();


Console.ReadLine();



abstract class TwoColorFlag
{
    public void Draw()
    {
        DrawTopPart();
        DrawBottomPart();
    }
    protected abstract void DrawTopPart();
    protected abstract void DrawBottomPart();
}

class UkraineFlag : TwoColorFlag
{
    protected override void DrawBottomPart()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(new string(' ',7));
    }

    protected override void DrawTopPart()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine(new string(' ', 7));
    }
}

class PolangFlag : TwoColorFlag
{
    protected override void DrawBottomPart()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine(new string(' ', 7));
    }

    protected override void DrawTopPart()
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(new string(' ', 7));
    }
}