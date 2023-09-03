
BubbleSort sort1 = new BubbleSort();
InsertionSort sort2 = new InsertionSort();
SelectionSort sort3 = new SelectionSort();

Context context = new Context(sort1);
//Context context = new Context(sort2);
//Context context = new Context(sort3);

context.Sort();
context.PrintArray();


Console.ReadLine();



class Context
{
    int[] array = { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
    Strategy strategy;
    public Context(Strategy strategy)
    {
        this.strategy = strategy;

    }
    public void Sort()
    {
        strategy.Sort(ref array);
    }
    public void PrintArray()
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
abstract class Strategy
{
    public abstract void Sort(ref int[] array);
}
class BubbleSort : Strategy
{
    public override void Sort(ref int[] array)
    {
        Console.WriteLine("BubbleSort");

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = array.Length - 1; j > i; j--)
            {
                if (array[j] < array[j - 1])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
        }
    }
}
class InsertionSort : Strategy
{
    public override void Sort(ref int[] array)
    {
        Console.WriteLine("InsertionSort");

        for (int i = 1; i < array.Length; i++)
        {
            int j = 0;
            int buffer = array[i];

            for (j = i - 1; j >= 0; j--)
            {
                if (array[j] < buffer)
                {
                    break;
                }

                array[j + 1] = array[j];
            }
            array[j + 1] = buffer;
        }
    }
}
class SelectionSort : Strategy
{
    public override void Sort(ref int[] array)
    {
        Console.WriteLine("SelectionSort");

        for (int i = 0; i < array.Length; i++)
        {
            int k = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[k] > array[j])
                {
                    k = j;
                }
            }
            if (k != i)
            {
                int temp = array[k];
                array[k] = array[i];
                array[i] = temp;
            }
        }
    }
}