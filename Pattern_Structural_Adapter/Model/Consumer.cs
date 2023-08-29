using Pattern_Structural_Adapter.Model.ProviderModel;

namespace Pattern_Structural_Adapter.Model
{
    class Consumer
    {
        Provider provider;
        public Consumer(Provider provider)
        {
            this.provider = provider;
        }
        public void Use()
        {
            provider.Request();
        }
    }
}
