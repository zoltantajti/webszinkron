using System;
using System.Windows.Forms;

namespace EHandler
{
    public class Handler
    {
        public void show(string text, string title, string _i)
        {
            try
            {
                ToolTipIcon icon;
                switch (_i)
                {
                    case "error": icon = ToolTipIcon.Error; break;
                    case "info": icon = ToolTipIcon.Info; break;
                    case "warning": icon = ToolTipIcon.Warning; break;
                    case "none": icon = ToolTipIcon.None; break;
                    default: icon = ToolTipIcon.None; break;
                }
                NotifyIcon notif = new NotifyIcon();
                notif.BalloonTipIcon = icon;
                notif.BalloonTipText = text;
                notif.BalloonTipTitle = title;
                notif.ShowBalloonTip(1000);
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
