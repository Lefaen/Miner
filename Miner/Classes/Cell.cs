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


        public bool flag;
        public bool isOpen;
        public bool bomb;
        public bool isBombs;
        public Label num;
        

        public Cell(int i, int j, int size, int LocationX, int LocationY)
        {
            this.IndexI = i;
            this.IndexJ = j;
            this.bomb = false;
            this.flag = false;
            this.isOpen = false;
            this.isBombs = false;
            this.Visible = false;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackColor = System.Drawing.Color.White;

            this.Size = new System.Drawing.Size(size, size);

            this.num = new Label();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Name = "Label" + this.IndexI.ToString() + this.IndexJ.ToString();
            this.num.Visible = false;
            this.num.Text = 0.ToString();

            this.Location = new System.Drawing.Point(LocationX, LocationY);

            this.Name = "Cell" + this.IndexI.ToString() + this.IndexJ.ToString();
            FormMiner.ActiveForm.Controls.Add(this);
            this.Controls.Add(this.num);
            
        }
    }

}
