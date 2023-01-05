using Prism.Ioc;
using Prism.Modularity;
using RevitLinks.ViewModels;
using RevitLinks.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitLinks
{
    public class ModuleRevitProfile : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA,ViewAViewModel>();
        }
    }
}
