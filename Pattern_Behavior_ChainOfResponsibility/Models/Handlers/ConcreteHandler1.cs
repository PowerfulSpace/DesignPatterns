namespace Pattern_Behavior_ChainOfResponsibility.Models.Handlers
{
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request == 1)
            {
                Console.WriteLine("ConcreteHandler1");
            }
            else if (Successor != null)
            {
                this.Successor.HandleRequest(request);
            }
        }
    }
}
