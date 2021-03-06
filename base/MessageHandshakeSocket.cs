﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Microservices
{
    [Serializable]
    public class MessageHandshakeSocket
    {
        public MessageHandshakeSocket()
        {

        }

        public MessageHandshakeSocket(Guid serviceId)
        {
            ServiceId = serviceId;
        }

        public Guid ServiceId { get; set; } 

        public List<string> MessageSubscriptions = new List<string>();

        [NonSerialized]
        public TcpClient Client;
    }
}
