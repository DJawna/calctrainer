using CalcTrainer.Core.models;
using CalcTrainer.Core.ViewModels;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTrainer.Core.Services
{
    public class MessageService: BaseViewModel
    {

        private readonly ConcurrentQueue<Message> messageQueue;

        public MessageService()
        {
            messageQueue = new ConcurrentQueue<Message>();
        }

    }
}
