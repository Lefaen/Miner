using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Handlers
{
    class CreateGame
    {
        public static void ViewField(Classes.Cell[,] field)
        {
            foreach(Classes.Cell cell in field)
            {
                   Miner.FormMiner.ActiveForm.Controls.Add(cell);
            }
        }
        public static void ViewMines(Classes.Cell[,] field)
        {
            foreach (Classes.Cell cell in field)
            {
                if (cell.bomb)
                {
                    Miner.FormMiner.ActiveForm.Controls[cell.Name].BackColor = System.Drawing.Color.Blue;
                }
            }
        }
        public static void ViewNum(Classes.Cell[,] field)
        {
            foreach (Classes.Cell cell in field)
            {
                if (cell.num.Text != 0.ToString())
                {
                    cell.Controls.Add(cell.num);
                }
            }
        }
    }
}
