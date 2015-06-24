using System;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using MyAABExample.Views;

namespace MyAABExample
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ModuleInit));
        }
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            this.Container.RegisterType<Object, CustomerAddUpdateView>("CustomerAddUpdateView");
            this.Container.RegisterType<Object, CategoryView>("CategoryView");
            this.Container.RegisterType<Object, CompanyView>("CompanyView");
            
        }
        protected override DependencyObject CreateShell()
        {
            // Use the container to create an instance of the shell.
            ShellView view = this.Container.TryResolve<ShellView>();
            return view;
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)this.Shell;
            App.Current.MainWindow.Show();
        }

    }
}
