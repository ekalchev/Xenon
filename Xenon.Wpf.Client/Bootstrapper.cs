using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xenon.Common;
using Xenon.Server;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Modularity;

namespace Xenon.Wpf.Client
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override System.Windows.DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<XenonShell>();
        }

        protected override IModuleCatalog CreateModuleCatalog() 
        {
            return new ConfigurationModuleCatalog(); 
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (XenonShell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            this.Container.RegisterType<IUnitOfWork, QuestionnaireRepositoryManager>();
        }
    }
}
