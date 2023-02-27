﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PintoNS.Networking
{
    public class PacketLogin : IPacket
    {
        public byte ProtocolVersion { get; protected set; }
        public string Name { get; protected set; }
        public string PasswordHash { get; protected set; }

        public PacketLogin() { }

        public PacketLogin(byte protocolVersion, string name, string passwordHash)
        {
            ProtocolVersion = protocolVersion;
            Name = name;
            PasswordHash = passwordHash;
        }

        public void Read(BinaryReader reader)
        {
            ProtocolVersion = reader.ReadByte();
            Name = reader.ReadUTF8String();
            PasswordHash = reader.ReadUTF8String();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(ProtocolVersion);  
            writer.WriteUTF8String(Name);
            writer.WriteUTF8String(PasswordHash);
        }

        public int GetID()
        {
            return 0;
        }
    }
}
