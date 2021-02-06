using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using RefMVVMLight.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefMVVMLight.ViewModel
{
    public class SenderViewModel : ViewModelBase
    {
        private string _textBoxText;

        public RelayCommand OnClickCommand { get; set; }

        public string TextBoxText
        {
            get { return _textBoxText; }
            set
            {
                _textBoxText = value;
                RaisePropertyChanged("TextBoxText");
            }
        }
        public SenderViewModel()
        {
            OnClickCommand = new RelayCommand(OnClickCommandAction, null);
        }

        private void OnClickCommandAction()
        {
            var viewModelMessage = new ViewModelMessage()
            {
                Text = TextBoxText
            };
            Messenger.Default.Send(viewModelMessage);
        }
    }
}
