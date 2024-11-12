using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace itl_wpf_test.Helper
{
    public class NavigationService : INavigationService
    {
        private Frame _frame;
        public NavigationService(Frame frame) 
        {
            _frame = frame;
        }

        public void Navigate(Page page)
        {
            _frame.Navigate(page);
        }
    }
}
