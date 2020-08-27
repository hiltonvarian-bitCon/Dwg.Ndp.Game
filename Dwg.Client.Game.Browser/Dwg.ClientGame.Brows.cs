using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dwg.Client.Game.Browser
{
    public class TDwgClientGameBrowser:Form
    {
        private WebBrowser TheGameWebBrowser;

        private void InitializeComponent()
        {
            this.TheGameWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // TheGameWebBrowser
            // 
            this.TheGameWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheGameWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.TheGameWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.TheGameWebBrowser.Name = "TheGameWebBrowser";
            this.TheGameWebBrowser.Size = new System.Drawing.Size(742, 701);
            this.TheGameWebBrowser.TabIndex = 0;
            // 
            // TDwgClientGameBrowser
            // 
            this.ClientSize = new System.Drawing.Size(742, 701);
            this.Controls.Add(this.TheGameWebBrowser);
            this.Name = "TDwgClientGameBrowser";
            this.Tag = "The_Web_Browse";
            this.Load += new System.EventHandler(this.OnGameBrowserLoad);
            this.ResumeLayout(false);
        
        }
        public TDwgClientGameBrowser(object browsweb)
        {
        Tag = browsweb;
        }
        public object TheBrowserTag
        {
      get
        {
        return Tag;
        }
        }
        private void OnGameBrowserLoad(object sender, EventArgs e)
        {
        
        }
        }
        }
