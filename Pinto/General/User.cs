﻿using System.Drawing;

namespace PintoNS.General
{
    public class User
    {
        public string Name;
        public UserStatus Status = UserStatus.OFFLINE;
        public string MOTD;

        public static Bitmap StatusToBitmap(UserStatus status) 
        {
            switch (status) 
            {
                case UserStatus.ONLINE:
                    return Statuses.ONLINE;
                case UserStatus.AWAY:
                    return Statuses.AWAY;
                case UserStatus.BUSY: 
                    return Statuses.BUSY;
                case UserStatus.INVISIBLE: 
                    return Statuses.INVISIBLE;
                case UserStatus.CONNECTING:
                    return Statuses.CONNECTING;
                default:
                    return Statuses.OFFLINE;
            }
        }

        public static Icon StatusToIcon(UserStatus status)
        {
            switch (status)
            {
                case UserStatus.ONLINE:
                    return Statuses.ONLINE1;
                case UserStatus.AWAY:
                    return Statuses.AWAY1;
                case UserStatus.BUSY:
                    return Statuses.BUSY1;
                case UserStatus.INVISIBLE:
                    return Statuses.INVISIBLE1;
                case UserStatus.CONNECTING:
                    return Statuses.CONNECTING1;
                default:
                    return Statuses.OFFLINE1;
            }
        }

        public static string StatusToText(UserStatus status)
        {
            switch (status)
            {
                case UserStatus.ONLINE:
                    return "Online";
                case UserStatus.AWAY:
                    return "Away";
                case UserStatus.BUSY:
                    return "Busy";
                case UserStatus.INVISIBLE:
                    return "Invisible";
                case UserStatus.CONNECTING:
                    return "Connecting...";
                default:
                    return "Offline";
            }
        }
    }
}
