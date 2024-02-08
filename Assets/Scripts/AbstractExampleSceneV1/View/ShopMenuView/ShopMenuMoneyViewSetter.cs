namespace AbstractExampleSceneV1
{
    public class ShopMenuMoneyViewSetter : CanvasViewSetter
    {
        public override void SetView() => CanvasView.SetMoneyImage(Config.ShopMenuConfig.MoneySprite);
    }
}
