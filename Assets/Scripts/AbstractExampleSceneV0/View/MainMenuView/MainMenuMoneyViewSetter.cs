namespace AbstractExampleSceneV0
{
    public class MainMenuMoneyViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetMoneyImage(Config.MainMenuConfig.MoneySprite);
    }
}
