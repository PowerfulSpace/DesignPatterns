namespace Pattern_Structural_Adapter.Model.ProviderModel
{
    class ProviderB : Provider
    {
        public override void Request()
        {
            Console.WriteLine("ProviderB");
        }
    }
}
