namespace AbstractExampleSceneV0
{
    public class ShopMenuMoneyViewSetter : CanvasViewSetter
    {
        public override void SetMenuView() => CanvasView.SetMoneyImage(Config.ShopMenuConfig.MoneySprite);
    }
}
