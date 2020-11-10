﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MobileDevice.Enumerates;

namespace MobileDevice.Struct
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct AMDeviceNotificationCallbackInfo
    {
        internal IntPtr DevicePtr;
        public ConnectNotificationMessage Msg;
        public uint NotificationId;
    }
}
