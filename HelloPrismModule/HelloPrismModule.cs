using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace HelloPrismModule
{
    public class HelloPrismModule : IModule
    {
        private readonly IRegionManager _regionManager;
        
        public HelloPrismModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloPrismView));
            _regionManager.RegisterViewWithRegion("LowerRegion", typeof(Views.LowerRegionView));
        }

    }
}
