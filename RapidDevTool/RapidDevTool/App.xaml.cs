using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RapidDevTool.Views;
using RevitLinks;
using System;
using System.Windows;

namespace RapidDevTool
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewC>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleRevitProfile>();

            base.ConfigureModuleCatalog(moduleCatalog);
        }
        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        //}
    }
}
