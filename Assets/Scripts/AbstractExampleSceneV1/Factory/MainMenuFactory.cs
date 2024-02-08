using System;

namespace AbstractExampleSceneV1
{
    public class MainMenuFactory : MenuFactory
    {
        public override CanvasViewSetter Create(ResourceType resourceType)
        {
            switch (resourceType)
            {
                case ResourceType.Money:
                    return new MainMenuMoneyViewSetter();

                case ResourceType.Energy:
                    return new MainMenuEnergyViewSetter();

                default:
                    throw new ArgumentException(nameof(resourceType));
            }
        }
    }
}