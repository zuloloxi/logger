using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Logger
{
    public class SystemTray
    {
        private NotifyIcon trayIcon;

        public SystemTray()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Text = "Logger";
            trayIcon.Icon = new Icon(GetType(), "tray.ico");

            ContextMenuStrip menuStrip = new ContextMenuStrip();

            ToolStripMenuItem menuItem_About = new ToolStripMenuItem("About");
            menuItem_About.Click += new EventHandler(menuItem_About_Click);
            menuStrip.Items.Add(menuItem_About);

            ToolStripMenuItem menuItem_Exit = new ToolStripMenuItem("Exit");
            menuItem_Exit.Click += new EventHandler(menuItem_Exit_Click);
            menuStrip.Items.Add(menuItem_Exit);

            trayIcon.ContextMenuStrip = menuStrip;

            trayIcon.Visible = true;
        }

        private void menuItem_Exit_Click(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void menuItem_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logger 1.3.0.0\nFelipe Bocolowski © 2016", "About");
        }
    }
}
