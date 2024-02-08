namespace AbstractExampleSceneV1
{
    public class MenuSwitcher
    {
        private CanvasView _canvasView;
        private CanvasesConfig _config;
        private CanvasViewSetter _canvasViewSetter;

        public MenuSwitcher(CanvasView canvasView, CanvasesConfig config)
        {
            _canvasView = canvasView;
            _config = config;
        }

        internal void SetResource(CanvasViewSetter canvasViewSetter)
        {
            _canvasViewSetter = canvasViewSetter;
            _canvasViewSetter.SetResourceView(_canvasView, _config);
        }
    }
}
