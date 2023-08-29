using Pattern_Structural_Adapter.Model.ProviderModel;

namespace Pattern_Structural_Adapter.Model
{
    class Adapter : Provider
    {
        SuperProvider superProvider = new SuperProvider();
        public override void Request()
        {
            superProvider.SpecificRequest();
        }
    }
}
