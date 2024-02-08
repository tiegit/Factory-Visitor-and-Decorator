namespace AbstractExampleSceneV0
{
    public abstract class CanvasViewSetter
    {
        private CanvasView _canvasView;
        private CanvasesConfig _config;

        public CanvasView CanvasView => _canvasView;
        public CanvasesConfig Config => _config;

        public virtual void SetCanvasView(CanvasView canvasView, CanvasesConfig canvasesConfig)
        {
            _canvasView = canvasView;
            _config = canvasesConfig;

            SetMenuView();
        }

        public abstract void SetMenuView();
    }
}
