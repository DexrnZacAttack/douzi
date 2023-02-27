﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PintoNS.Networking
{
    public class PacketMessage : IPacket
    {
        public string ContactName { get; protected set; }
        public string Message { get; protected set; }

        public PacketMessage() { }

        public PacketMessage(string contactName, string message)
        {
            ContactName = contactName;
            Message = message;
        }

        public void Read(BinaryReader reader)
        {
            ContactName = reader.ReadUTF8String();
            Message = reader.ReadUTF8String();
        }

        public void Write(BinaryWriter writer)
        {
            writer.WriteUTF8String(ContactName);
            writer.WriteUTF8String(Message);
        }

        public int GetID()
        {
            return 3;
        }
    }
}
