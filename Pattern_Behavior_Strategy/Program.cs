
using Pattern_Behavior_Strategy.Models.Strategyes;
using Pattern_Behavior_Strategy.Models;

BubbleSort sort1 = new BubbleSort();
InsertionSort sort2 = new InsertionSort();
SelectionSort sort3 = new SelectionSort();

Context context = new Context(sort1);
//Context context = new Context(sort2);
//Context context = new Context(sort3);

context.Sort();
context.PrintArray();


Console.ReadLine();
