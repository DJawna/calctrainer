using Calctrainer.Core.models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calctrainer.Core.Services
{
    public class MessageService: INotifyPropertyChanged
    {

        private readonly ConcurrentQueue<Message> messageQueue;

        public MessageService()
        {
            messageQueue = new ConcurrentQueue<Message>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void PushMessage(Message message)
        {
            messageQueue.Enqueue(message);
        }
    }
}
