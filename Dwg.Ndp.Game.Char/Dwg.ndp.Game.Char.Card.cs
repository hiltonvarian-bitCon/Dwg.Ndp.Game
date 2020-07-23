    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace Dwg.Ndp.Game.Char
    {
    using Dwg.Game.AI;
    public class TDwgNdpCharCard:Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TDwgNdpCharCard
            // 
            this.ClientSize = new System.Drawing.Size(305, 652);
            this.Name = "TDwgNdpCharCard";
            this.Text = "Game Charitors Card";
            this.Load += new System.EventHandler(this.TDwgNdpCharCard_Load);
            this.ResumeLayout(false);

        }

        public  class TDwgNdpGameCharCardThread
        {
       
        }

        private void TDwgNdpCharCard_Load(object sender, EventArgs e)
        {

        }
        }
        }
