using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT
{
    public class TabControlHelper
    {
        private TabControl tc;
        private List<TabPage> pages;
        public TabControlHelper(TabControl tabControl)
        {
            tc = tabControl;
            pages = new List<TabPage>();
            foreach (TabPage p in tc.TabPages)
            {
                pages.Add(p);
            }
        }

        public static void HideAllPages(TabControl tabControl, string tp)
        {
            foreach (TabPage p in tabControl.TabPages)
            {
                if (!p.Name.Equals(tp))
                {
                    tabControl.TabPages.Remove(p);
                }
            }
        }

        public void ShowAllPages()
        {
            foreach (TabPage p in pages)
            {
                tc.TabPages.Add(p);
            }
        }

        public void HidePage(TabPage tp)
        {
            tc.TabPages.Remove(tp);
        }

        public static void ShowPage(TabControl tabControl, TabPage tp)
        {
            tabControl.TabPages.Add(tp);
        }
    }  
}
