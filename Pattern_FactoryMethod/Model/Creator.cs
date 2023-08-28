namespace Pattern_FactoryMethod.Model
{
   abstract class Creator
    {
        Product product;
        public abstract Product FactoryMethod();
    }
}
