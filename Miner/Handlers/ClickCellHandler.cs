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
        delegate void GameOver();
        GameOver Boom;
        GameOver Win;

        public void ButtonCell_Click(object sender, EventArgs e)
        {
            try
            {
                GetViewCell += Handlers.ViewCell.View;
                Boom += Handlers.BoomHandler.ShowMessage;
                Win += Handlers.BoomHandler.WinMessage;

                Classes.Cell cell = sender as Classes.Cell;
                MouseEventArgs mouse = e as MouseEventArgs;

                if ((e as MouseEventArgs).Button == MouseButtons.Right & !cell.IsOpen)
                {
                    System.Windows.Forms.Label labelNumBombLeft = FormMiner.ActiveForm.Controls["labelNumBombLeft"] as System.Windows.Forms.Label;
                    
                    if (!cell.Flag & Classes.Field.NumBomb > 0)
                    {
                        cell.Flag = !cell.Flag;
                        Classes.Field.NumBomb = Classes.Field.NumBomb - 1;
                        labelNumBombLeft.Text = Classes.Field.NumBomb.ToString();
                        GetViewCell();
                    }
                    else
                    if(cell.Flag)
                    {
                        cell.Flag = !cell.Flag;
                        Classes.Field.NumBomb = Classes.Field.NumBomb + 1;
                        labelNumBombLeft.Text = Classes.Field.NumBomb.ToString();
                        GetViewCell();
                    }
                    
                    
                }
                else
                {

                    if (cell.Bomb & !cell.Flag)
                    {
                        cell.IsOpen = true;
                        Boom();
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
            if (!cell.Bomb & !cell.Flag)
            {
                cell.IsOpen = true;
                for (int j = cell.IndexJ - 1; j <= cell.IndexJ + 1; j++)
                {
                    for (int i = cell.IndexI - 1; i <= cell.IndexI + 1; i++)
                    {
                        if ((i == cell.IndexI & j == cell.IndexJ) | 
                            (i < 0 | j < 0 | 
                            i >= Classes.Field.Width | 
                            j >= Classes.Field.Height))
                        {
                            continue;
                        }
                        checkCell = Miner.FormMiner.ActiveForm.Controls["Cell" + i.ToString() + j.ToString()] as Classes.Cell;
                        if (checkCell.Bomb)
                        {
                            cell.IsBombs = true;
                        }
                        if(cell.IsBombs == false & 
                            checkCell.IsOpen == false & 
                            cell.Num.Text == 0.ToString())
                        {
                            EmptyCell(checkCell);
                        }
                    }
                }
            }
        }
    }
}
