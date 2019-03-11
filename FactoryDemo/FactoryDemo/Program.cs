using System;
using FactoryDemo.FrameWork;

namespace FactoryDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Factory start");
            #region Simple Factory
            {

                string configuratonS = StaticConfiguration.AssemblyPath;
                Console.WriteLine($"输出配置文件参数{configuratonS}");
                Console.ReadLine();
            }
            #endregion
            Console.WriteLine("Factory end");
        }
    }
}
