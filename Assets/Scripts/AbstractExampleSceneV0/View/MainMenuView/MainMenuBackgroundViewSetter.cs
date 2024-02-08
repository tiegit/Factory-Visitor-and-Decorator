namespace AbstractExampleSceneV0
{
    public class MainMenuBackgroundViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetBackgroundColor(Config.MainMenuConfig.BackgroundColor);
    }
}
