using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miner.Handlers
{

    class CreateGame
    {
         
        public static void ViewField(object sender)
        {
            Classes.Cell[,] field = sender as Classes.Cell[,];

            foreach (System.Windows.Forms.Control elm in FormMiner.ActiveForm.Controls)
            {
                Classes.Cell cell = elm as Classes.Cell;
                if (cell != null)
                {
                    cell.BackColor = System.Drawing.Color.White;
                    cell.Visible = true;
                }
            }
        }
    }
}
