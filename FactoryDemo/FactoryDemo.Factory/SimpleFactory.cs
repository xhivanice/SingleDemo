using System;
namespace FactoryDemo.Factory
{
    public static class SimpleFactory
    {
        /// <summary>
        /// 泛型简单工厂
        /// </summary>
        /// <returns>The instance.</returns>
        /// <param name="type">T.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static T CreateInstance<T>(this Type type) where T : class
        {
            return (T)Activator.CreateInstance(type);
        }
    }
}
