using System;
using System.Text;
using System.Configuration;

namespace FactoryDemo.FrameWork
{
    public class StaticConfiguration
    {
        public readonly static string AssemblyConfiguration = ConfigurationManager.AppSettings["AssemblyConfiguration"];
        public readonly static string AssemblyPath = AssemblyConfiguration.Split(',')[0];
        public readonly static string AssemblyClassPath = AssemblyConfiguration.Split(',')[1];
    }
}
