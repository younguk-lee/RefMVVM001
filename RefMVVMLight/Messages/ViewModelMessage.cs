﻿using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefMVVMLight.Messages
{
    class ViewModelMessage : MessageBase
    {
        public string Text { get; set; }
    }
}
