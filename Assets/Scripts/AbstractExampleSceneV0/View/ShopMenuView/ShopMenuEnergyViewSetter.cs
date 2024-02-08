namespace AbstractExampleSceneV0
{
    public class ShopMenuEnergyViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetEnergyImageColor(Config.ShopMenuConfig.EnergyColor);
    }
}
