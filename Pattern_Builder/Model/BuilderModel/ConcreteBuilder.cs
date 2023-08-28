using Pattern_Builder.Model.HouseModel;

namespace Pattern_Builder.Model.BuilderModel
{
    class ConcreteBuilder : Builder
    {
        public House house = new House();
        public override void CreateBasement()
        {
            house.Add(new Basement());
        }
        public override void CreateStorey()
        {
            house.Add(new Storey());
        }
        public override void CreateRoof()
        {
            house.Add(new Roof());
        }
        public override House GetResult()
        {
            return house;
        }
    }
}
