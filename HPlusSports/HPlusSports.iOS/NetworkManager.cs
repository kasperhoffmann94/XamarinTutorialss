﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using SystemConfiguration;

using Foundation;
using UIKit;


[assembly: Xamarin.Forms.Dependency(typeof(HPlusSports.iOS.NetworkManager))]
namespace HPlusSports.iOS
{
    public class NetworkManager : INetworkManager
    {
        public bool IsNetworkConnected()
        {
            NetworkReachabilityFlags flags;
            var adress = new IPAddress(0);
            var reachability = new NetworkReachability(adress);
            if (reachability.TryGetFlags(out flags))
            {
                return (flags & NetworkReachabilityFlags.Reachable) != 0;
            }
            else
            {
                return false;
            }
        }
    }
}