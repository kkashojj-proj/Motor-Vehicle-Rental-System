using System;
using System.Windows.Forms;

namespace MVRS_Project
{
    class TablessControl : TabControl
    {
        protected override void WndProc(ref Message e)
        {
            // Hide tabs by trapping the TCM_ADJUSTRECT message
            if (e.Msg == 0x1328 && !DesignMode) e.Result = (IntPtr)1;
            else base.WndProc(ref e);
        }
    }
}
