//[assembly: WebActivator.PostApplicationStartMethod(typeof(ActiveMidia.Servicos.REST.ModeloAPI.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace ActiveMidia.Apresentacao.BatchSample {
    using SimpleInjector;
    using Infra.CrossCutting.IoC;
    public static class SimpleInjectorWindowsServiceInitializer {
        public static Container container;

        /// <summary>Initialize the container and register it as Web API Dependency Resolver.</summary>
        public static void Initialize() {
            container = new Container();
            container.Options.DefaultScopedLifestyle = new SimpleInjector.Lifestyles.ThreadScopedLifestyle();

            InitializeContainer(container);
            
            container.Verify();
                      
        }

        private static void InitializeContainer(Container container) {
            BootStrapper.Register(container);
        }
    }
}