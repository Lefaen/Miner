using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner.Handlers
{
    class ClickCellHandler
    {

        delegate void ViewCell();
        ViewCell GetViewCell;
        ViewCell GameOver;

        public void ButtonCell_Click(object sender, EventArgs e)
        {
            try
            {
                GetViewCell += Handlers.ViewCell.View;
                GameOver += Handlers.BoomHandler.TheEnd;

                Classes.Cell cell = sender as Classes.Cell;
                MouseEventArgs mouse = e as MouseEventArgs;

                if ((e as MouseEventArgs).Button == MouseButtons.Right & !cell.isOpen)
                {
                    cell.flag = !cell.flag;
                    GetViewCell();
                }
                else
                {
                    if (cell.bomb & !cell.flag)
                    {
                        cell.isOpen = true;
                        GameOver();
                    }
                    else
                    {
                        EmptyCell(cell);
                    }
                }
                GetViewCell();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        void EmptyCell(Classes.Cell cell)
        {
            Classes.Cell checkCell = null;
            if (!cell.bomb & !cell.flag)
            {
                cell.isOpen = true;
                for (int j = cell.IndexJ - 1; j <= cell.IndexJ + 1; j++)
                {
                    for (int i = cell.IndexI - 1; i <= cell.IndexI + 1; i++)
                    {
                        if ((i == cell.IndexI & j == cell.IndexJ) | (i < 0 | j < 0 | i >= 10 | j >= 12))
                        {
                            continue;
                        }
                        checkCell = Miner.FormMiner.ActiveForm.Controls["Cell" + i.ToString() + j.ToString()] as Classes.Cell;
                        if (checkCell.bomb)
                        {
                            cell.isBombs = true;
                        }
                        if(cell.isBombs == false & 
                            checkCell.isOpen == false & 
                            cell.num.Text == 0.ToString())
                        {
                            EmptyCell(checkCell);
                        }
                    }
                }
            }
        }
    }
}
