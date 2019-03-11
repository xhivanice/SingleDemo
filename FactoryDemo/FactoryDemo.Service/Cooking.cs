using System;
namespace FactoryDemo.Service
{
    /// <summary>
    /// Cooking.
    /// </summary>
    public abstract class Cooking
    {
        public EnterOrder OrderFood(string sFood)
        {
            EnterOrder enterOrder = this.CookingFood(sFood);
            enterOrder.CreateOrder(sFood);

            enterOrder.FoodLoading();
            enterOrder.CallBack();
            enterOrder.Transmit();

            return enterOrder;

        }
        public abstract EnterOrder CookingFood(string sFood);
    }
}
