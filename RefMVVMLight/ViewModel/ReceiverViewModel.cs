using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using RefMVVMLight.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefMVVMLight.ViewModel
{
    public class ReceiverViewModel : ViewModelBase
    {
        private string _contentText;

        public string ContentText
        {
            get { return _contentText; }
            set
            {
                _contentText = value;
                RaisePropertyChanged("ContentText");
            }
        }

        public ReceiverViewModel()
        {
            Messenger.Default.Register<ViewModelMessage>(this, OnRecieveMessageAction);
        }

        private void OnRecieveMessageAction(ViewModelMessage obj)
        {
            ContentText = obj.Text;
        }
    }
}
