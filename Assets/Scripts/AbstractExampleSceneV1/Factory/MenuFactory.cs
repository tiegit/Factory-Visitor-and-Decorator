namespace AbstractExampleSceneV1
{
    public abstract class MenuFactory
    {
        public abstract CanvasViewSetter Create(ResourceType resourceType);
    }
}