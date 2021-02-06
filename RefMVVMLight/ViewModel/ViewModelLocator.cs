/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:RefMVVMLight"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace RefMVVMLight.ViewModel
{
    public class ViewModelLocator
    {

        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<ReceiverViewModel>();
            SimpleIoc.Default.Register<SenderViewModel>();
        }

        public SenderViewModel SenderViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<SenderViewModel>();
            }
        }

        public ReceiverViewModel ReceiverViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ReceiverViewModel>();
            }
        }
        
        public static void Cleanup()
        {
        }
    }
}