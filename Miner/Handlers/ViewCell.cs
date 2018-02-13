using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Handlers
{
    public class ViewCell
    {
        public static void View()
        {
            System.Drawing.Color emptyCell = System.Drawing.Color.Gray;
            System.Drawing.Color bomb = System.Drawing.Color.Red;
            System.Drawing.Color flag = System.Drawing.Color.Green;

            foreach (System.Windows.Forms.Control elm in FormMiner.ActiveForm.Controls)
            {
                Classes.Cell cell = elm as Classes.Cell;
                if(cell != null)
                {
                    if (cell.Flag)
                    {
                        cell.BackColor = flag;
                    }
                    else
                    {
                        if (cell.IsOpen == true)
                        {
                            if (cell.Bomb)
                            {
                                cell.BackColor = bomb;
                            }
                            else
                            {
                                cell.BackColor = emptyCell;
                                if (cell.Num.Text != 0.ToString())
                                {
                                    cell.Num.Visible = true;
                                    cell.Num.BringToFront();
                                }
                            }
                        }
                        else
                        {
                            cell.BackColor = System.Drawing.Color.White;
                        }
                    }
                    
                }
            }
        }
    }
}
