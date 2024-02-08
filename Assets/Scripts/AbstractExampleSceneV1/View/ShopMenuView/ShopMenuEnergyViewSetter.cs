namespace AbstractExampleSceneV1
{
    public class ShopMenuEnergyViewSetter : CanvasViewSetter
    {
        public override void SetView() => CanvasView.SetEnergyImageColor(Config.ShopMenuConfig.EnergyColor);
    }
}
