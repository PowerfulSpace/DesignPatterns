namespace Pattern_Behavior_TemplateMethod.Models.TwoColorFlags
{
    abstract class TwoColorFlag
    {
        public void Draw()
        {
            DrawTopPart();
            DrawBottomPart();
        }
        protected abstract void DrawTopPart();
        protected abstract void DrawBottomPart();
    }
}
