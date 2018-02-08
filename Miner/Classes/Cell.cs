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

        

        public bool bomb;
        public Label num;
        

        public Cell(int i, int j, int size, int LocationX, int LocationY)
        {
            this.IndexI = i;
            this.IndexJ = j;
            this.bomb = false;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.Size = new System.Drawing.Size(size, size);

            this.num = new Label();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.num.BackColor = System.Drawing.Color.Transparent;
            this.num.Name = "Label" + this.IndexI.ToString() + this.IndexJ.ToString();

            this.Location = new System.Drawing.Point(LocationX, LocationY);

            this.Name = "Cell" + this.IndexI.ToString() + this.IndexJ.ToString();
            
            
            
        }
    }

}
