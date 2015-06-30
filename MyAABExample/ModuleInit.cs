using Microsoft.Practices.Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.UnityExtensions;
using MyAABExample.Views;
using Microsoft.Practices.Unity;
using BBL;

namespace MyAABExample
{
    class ModuleInit : IModule
        
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;
        public ModuleInit(IRegionManager regionManager, IUnityContainer container)
        {
            this.container = container;
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            //regionManager.RequestNavigate("MainRegion", "CustList");
            
            this.regionManager.RegisterViewWithRegion(RegionNames.MainRegion, () => this.container.Resolve<CustList>());
            this.regionManager.RegisterViewWithRegion(RegionNames.LeftRegion, typeof(NavigationView));
            
        }
        
    }
}
