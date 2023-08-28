using Pattern_FactoryMethod.Model.ProductModel;

namespace Pattern_FactoryMethod.Model.CreatorModel
{
    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
