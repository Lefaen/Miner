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
                    if (cell.flag)
                    {
                        cell.BackColor = flag;
                    }
                    else
                    {
                        if (cell.isOpen == true)
                        {
                            if (cell.bomb)
                            {
                                cell.BackColor = bomb;
                            }
                            else
                            {
                                cell.BackColor = emptyCell;
                                if (cell.num.Text != 0.ToString())
                                {
                                    cell.num.Visible = true;
                                    cell.num.BringToFront();
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
