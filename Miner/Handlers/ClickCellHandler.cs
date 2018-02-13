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
		int numCellsIsOpen = 0;

		public void ButtonCell_Click(object sender, EventArgs e)
        {
            try
            {
                GetViewCell += Handlers.ViewCellClick.ViewCell;
                Boom += Handlers.GameOverHandler.ShowMessageBoom;
                Win += Handlers.GameOverHandler.ShowMessageWin;

                Classes.Cell cell = sender as Classes.Cell;
                MouseEventArgs mouse = e as MouseEventArgs;

				//PlaceFlag
				if ((e as MouseEventArgs).Button == MouseButtons.Right & !cell.IsOpen)
                {
                    System.Windows.Forms.Label labelNumBombLeft = FormMiner.ActiveForm.Controls["labelNumBombLeft"] as System.Windows.Forms.Label;
                    
                    if (!cell.Flag & Classes.Field.Flags > 0)
                    {
                        cell.Flag = !cell.Flag;
						Classes.Field.Flags = Classes.Field.Flags - 1;
                    }
                    else
						if(cell.Flag)
						{
							cell.Flag = !cell.Flag;
							Classes.Field.Flags = Classes.Field.Flags + 1;
						}
					labelNumBombLeft.Text = Classes.Field.Flags.ToString();
				}

				//OpenCell
                else
                {
					if (cell.Bomb & !cell.Flag)
                    {
                        cell.IsOpen = true;
						GetViewCell();
                        Boom();
					}
                    else
                    {
                        EmptyCellsOpen(cell);
					}
                }
                GetViewCell();

				//CheckWin
				foreach (System.Windows.Forms.Control elm in FormMiner.ActiveForm.Controls)
				{
					if (elm is Classes.Cell & elm != null)
					{
						Classes.Cell checkCell = elm as Classes.Cell;
						if (!checkCell.Bomb & checkCell.IsOpen)
						{
							numCellsIsOpen = numCellsIsOpen + 1;
						}
					}
				}
				if (numCellsIsOpen == Classes.Field.Width * Classes.Field.Height - Classes.Field.NumBomb)
				{
					Win();
				}

			}
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
		
        void EmptyCellsOpen(Classes.Cell cell)
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
                        checkCell = FormMiner.ActiveForm.Controls["Cell" + i.ToString() + j.ToString()] as Classes.Cell;
                        if (checkCell.Bomb)
                        {
                            cell.IsBombs = true;
                        }
                        if(cell.IsBombs == false & 
                            checkCell.IsOpen == false & 
                            cell.Num.Text == 0.ToString())
                        {
                            EmptyCellsOpen(checkCell);
                        }
                    }
                }
            }
        }
    }
}
