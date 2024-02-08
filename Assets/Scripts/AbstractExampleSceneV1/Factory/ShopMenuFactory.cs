using System;

namespace AbstractExampleSceneV1
{
    public class ShopMenuFactory : MenuFactory
    {
        public override CanvasViewSetter Create(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Money:
                    return new ShopMenuMoneyViewSetter();

                case ResourceType.Energy:
                    return new ShopMenuEnergyViewSetter();

                default:
                    throw new ArgumentException(nameof(resourceType));
            }
        }
    }
}