using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Xamore.Controls.iOS
{
    public static class LinkerPleaseInclude
    {
        private static DateTime initDate;
        public static void Init()
        {
            initDate = DateTime.UtcNow;
        }
    }
}