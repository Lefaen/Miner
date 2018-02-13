using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner.Classes
{
    class Cell : Panel
    {
        public int IndexI, IndexJ;


        public bool Flag { get; set; }
        public bool IsOpen { get; set; }
        public bool Bomb { get; set; }
        public bool IsBombs { get; set; }
        public Label Num { get; set; }


        public Cell(int i, int j)
        {
            this.IndexI = i;
            this.IndexJ = j;
            this.Bomb = false;
            this.Flag = false;
            this.IsOpen = false;
            this.IsBombs = false;
            this.Visible = false;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "Cell" + this.IndexI.ToString() + this.IndexJ.ToString();
            this.Num = new Label();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Num.BackColor = System.Drawing.Color.Transparent;
            this.Num.Name = "Label" + this.IndexI.ToString() + this.IndexJ.ToString();
            this.Num.Visible = false;
            this.Num.Text = 0.ToString();
            
            FormMiner.ActiveForm.Controls.Add(this);
            this.Controls.Add(this.Num);
            
        }
    }

}
