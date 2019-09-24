using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTrainer.Core.models
{
    public enum MessageType
    {
        Info =0,
        Warning,
        Error
    }

    public struct Message
    {


        public Message(string messageText, MessageType messageType)
        {
            MessageText = messageText;
            Type = messageType;

        }
        public string MessageText { get; private set; }

        public MessageType Type { get; private set; }
    }
}
