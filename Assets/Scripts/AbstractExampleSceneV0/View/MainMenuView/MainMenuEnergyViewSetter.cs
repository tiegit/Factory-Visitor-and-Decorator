namespace AbstractExampleSceneV0
{
    public class MainMenuEnergyViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetEnergyImageColor(Config.MainMenuConfig.EnergyColor);
    }
}
