using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismPractice2.Modules.ViewModels;
using PrismPractice2.Modules.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismPractice2.Modules
{
    public class StartupModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            //View Register Only
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("LoginRegion", typeof(LoginView));
            regionManager.RegisterViewWithRegion("DashboardRegion", typeof(DashboardView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //View Register Only
            containerRegistry.RegisterForNavigation<LoginView, LoginViewModel>();
            containerRegistry.RegisterForNavigation<DashboardView, DashboardViewModel>();
        }


    }
}
