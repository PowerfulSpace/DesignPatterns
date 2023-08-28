namespace Pattern_Builder.Model
{
    using Pattern_Builder.Model.BuilderModel;
    class Foreman
    {
        Builder builder;
        public Foreman(Builder builder)
        {
            this.builder = builder;
        }
        public void Construct()
        {
            builder.CreateBasement();
            builder.CreateStorey();
            builder.CreateRoof();
        }
    }
}
