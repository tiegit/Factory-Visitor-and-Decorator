namespace AbstractExampleSceneV1
{
    public abstract class CanvasViewSetter
    {
        private CanvasView _canvasView;
        private CanvasesConfig _config;

        public CanvasView CanvasView => _canvasView;
        public CanvasesConfig Config => _config;

        public virtual void SetResourceView(CanvasView canvasView, CanvasesConfig canvasesConfig)
        {
            _canvasView = canvasView;
            _config = canvasesConfig;

            SetView();
        }

        public abstract void SetView();
    }
}
