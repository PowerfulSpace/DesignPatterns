namespace Pattern_Behavior_ChainOfResponsibility.Models.Handlers
{
    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 2)
            {
                Console.WriteLine("ConcreteHandler2");
            }
            else if (Successor != null)
            {
                this.Successor.HandleRequest(request);
            }
        }
    }
}
