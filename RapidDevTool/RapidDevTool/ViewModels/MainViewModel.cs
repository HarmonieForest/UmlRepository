using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using RapidDevTool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapidDevTool.ViewModels
{
    public class MainViewModel:BindableBase
    {
        private readonly IRegionManager regionManager;
        private IRegionNavigationJournal journal;
        public DelegateCommand<string> OpenCommand { get; set; }
        public DelegateCommand BackCommand { get; set; }
        public MainViewModel(IRegionManager regionManager)
        {
            BackCommand = new DelegateCommand(Back);
            OpenCommand = new DelegateCommand<string>(Open);
            this.regionManager = regionManager;
        }

        private void Back()
        {
            if(journal.CanGoBack)
            {
                journal.GoBack();
            }
        }

        private void Open(string obj)
        {
            //通过IRegionManager接口获取到全局定义可用区域
            //往这个区域动态设置内容
            //设置内容的方式是通过依赖注入

            //NavigationParameters keys= new NavigationParameters();
            //keys.Add("Title","Hello");


            //regionManager.Regions["ContentRegion"].RequestNavigate(obj, callback =>
            //{
            //    if ((bool)callback.Result)
            //    {
            //        journal=callback.Context.NavigationService.Journal;
            //    }
            //},keys);

            new ViewD().ShowDialog();
        }
    }
} 
