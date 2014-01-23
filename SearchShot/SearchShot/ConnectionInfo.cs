﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace SearchShot
{
    public partial class ConnectionMode
    {
        public static int Id { get; set; }
        public static string ConnectWith { get; set; }
        public static string Token { get; set; }
        public static string Name { get; set; }
        public static byte[] Image { get; set; }
        public static string TwitterLogin { get; set; }
        public static bool IsModifInfos { get; set; }
        public static bool IsModifPicture { get; set; }

        // public static Dictionary<string, object> FacebookData { get; set; }
    }
}
