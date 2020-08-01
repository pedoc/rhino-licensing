using System;
using System.Collections.Generic;

namespace Rhino.Licensing
{
    /// <summary>
    /// Factory method used to resolve all services. For multiple instances, it will resolve against <see cref="IEnumerable{T}" />
    /// </summary>
    /// <param name="serviceType">Type of service to resolve</param>
    /// <returns>An instance of type <paramref name="serviceType" /></returns>
    public delegate object ServiceFactory(Type serviceType);

    /// <summary>
    /// ServiceFactoryExtensions
    /// </summary>
    public static class ServiceFactoryExtensions
    {
        /// <summary>
        /// GetInstances
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static T GetInstance<T>(this ServiceFactory factory) => (T)factory(typeof(T));

        /// <summary>
        /// GetInstances
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="factory"></param>
        /// <returns></returns>
        public static IEnumerable<T> GetInstances<T>(this ServiceFactory factory) => (IEnumerable<T>)factory(typeof(IEnumerable<T>));
    }
}
