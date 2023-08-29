namespace Pattern_Structural_Adapter.Model.ProviderModel
{
    class ProviderA : Provider
    {
        public override void Request()
        {
            Console.WriteLine("ProviderA");
        }
    }
}
