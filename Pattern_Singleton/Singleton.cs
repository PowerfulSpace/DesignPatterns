namespace Pattern_Singleton
{
    class Singleton
    {
        static private Singleton uniqueInstance;
        protected Singleton()
        {
        }
        static public Singleton Instance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
