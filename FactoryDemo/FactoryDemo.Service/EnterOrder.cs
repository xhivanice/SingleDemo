using System;
using FactoryDemo.Model;

namespace FactoryDemo.Service
{
    public class EnterOrder : Order
    {
        public void CreateOrder(string sFood)
        {
            Console.WriteLine($"客户{this.MemberName}开始点餐");
            Console.WriteLine($"点餐时间为：「{DateTime.Now.ToString("yyyy-MM-dd")}」");
            Console.WriteLine($"就餐于饭桌：{this.Table}");
            Console.WriteLine($"服务人员：{this.Service}");
        }
        public void FoodLoading()
        {
            Console.WriteLine("开始装盘");
        }
        public void CallBack()
        {
            Console.WriteLine("通知取餐");
        }
        public void Transmit()
        {
            Console.WriteLine("送给客户");
        }
    }
}
