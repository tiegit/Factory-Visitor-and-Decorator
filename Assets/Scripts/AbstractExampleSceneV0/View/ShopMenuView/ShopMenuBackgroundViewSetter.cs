namespace AbstractExampleSceneV0
{
    public class ShopMenuBackgroundViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetBackgroundColor(Config.ShopMenuConfig.BackgroundColor);
    }
}
