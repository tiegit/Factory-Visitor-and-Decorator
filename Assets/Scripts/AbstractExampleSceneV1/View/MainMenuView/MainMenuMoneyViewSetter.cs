namespace AbstractExampleSceneV1
{
    public class MainMenuMoneyViewSetter : CanvasViewSetter
    {
        public override void SetView() => CanvasView.SetMoneyImage(Config.MainMenuConfig.MoneySprite);
    }
}
