using Pattern_Builder.Model.HouseModel;

namespace Pattern_Builder.Model.BuilderModel
{
    abstract class Builder
    {
        public abstract void CreateBasement();
        public abstract void CreateStorey();
        public abstract void CreateRoof();
        public abstract House GetResult();

    }
}
