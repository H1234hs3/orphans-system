using orphans.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphans.Code
{
    public class MessagCollections
    {
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText,Resources.EmptyMessageCaption,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public static void ShowErrorServer()
        {
            MessageBox.Show(Resources.ServerErorrText, Resources.ServerErrorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFiledRequired()
        {
            MessageBox.Show(Resources.FiledsReqText, Resources.FiledsReqCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
