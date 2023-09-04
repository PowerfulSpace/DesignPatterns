
using Pattern_Behavior_TemplateMethod.Models.TwoColorFlags.Flags;
using Pattern_Behavior_TemplateMethod.Models.TwoColorFlags;

TwoColorFlag flag = new UkraineFlag();
flag.Draw();

Console.WriteLine();

flag = new PolangFlag();
flag.Draw();


Console.ReadLine();
