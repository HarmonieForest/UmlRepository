using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RevitLinks.ViewModels
{
    public class ViewAViewModel : BindableBase,IConfirmNavigationRequest
    {


        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; RaisePropertyChanged(); }
        }

        public void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            bool result = true;
            if (MessageBox.Show("确认导航?", "温馨提示", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                result= false;
            }
            continuationCallback(result);
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if (navigationContext.Parameters.ContainsKey("Title"))
            {
                Title = navigationContext.Parameters.GetValue<string>("Title");
            }

        }
    }
}
