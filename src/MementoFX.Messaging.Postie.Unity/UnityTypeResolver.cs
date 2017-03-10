using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Messaging.Postie.Unity
{
    /// <summary>
    /// Defines a Unity-based type resolver for Postie
    /// </summary>
    public class UnityTypeResolver : ITypeResolver
    {
        /// <summary>
        /// The container instance used ty resolver types
        /// </summary>
        public IUnityContainer Container { get; private set; }

        /// <summary>
        /// Creates a new instance of the type resolver
        /// </summary>
        /// <param name="container">The container instance used to resolve types</param>
        public UnityTypeResolver(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));
            Container = container;
        }

        /// <summary>
        /// Resolves an instance of the requested type with the given name from the container.
        /// </summary>
        /// <param name="t">Type of object to get from the container.</param>
        /// <returns>The retrieved object.</returns>
        public object Resolve(Type t)
        {
            return Container.Resolve(t);
        }
    }
}
