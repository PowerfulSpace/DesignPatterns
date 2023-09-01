namespace Pattern_Behavior_ChainOfResponsibility.Models
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int request);
    }
}
