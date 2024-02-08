namespace AbstractExampleSceneV1
{
    public class MainMenuEnergyViewSetter : CanvasViewSetter
    {
        public override void SetView() => CanvasView.SetEnergyImageColor(Config.MainMenuConfig.EnergyColor);
    }
}
