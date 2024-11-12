using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace itl_wpf_test.Helper
{
    public static class Ioc
    {
        public static NavigationService NavigationService { get; private set; }

        public static void Init(Frame frame)
        {
            NavigationService = new NavigationService(frame);
        }
    }
}
