using Pattern_Behavior_Strategy.Models.Strategyes;

namespace Pattern_Behavior_Strategy.Models
{
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
}
