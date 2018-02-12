using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Classes
{
    class Field
    {
        public Classes.Cell[,] CreateField(int width, int height, int numBomb)
        {
            ResetField();

            int SizeCell = 20;
            int locX = 100;
            int locY = 0;
            
            Cell[,] field = new Cell[width, height];
            

            for (int j = 0; j<height; j++)
            {
                locX = 100;
                

                for (int i = 0; i<width; i++)
                {
                    locX = locX + SizeCell;
                    
                    field[i,j] = (new Cell(i, j, SizeCell, locX, locY));

                    Handlers.ClickCellHandler OnClick = new Handlers.ClickCellHandler();
                    field[i, j].Click += new System.EventHandler(OnClick.ButtonCell_Click);
                }
                locY = locY + SizeCell;
            }

            PositionMines(field, numBomb, width, height);
            NumOfBombCell(field,width,height);

            Data.EvantHandler(field);
            return field;
        }
        
        void PositionMines (Classes.Cell[,] field, int limitBomb, int limitX, int limitY)
        {

            while(limitBomb > 0)
            {
                int x, y;
                Random RandomNum = new Random();
                x = RandomNum.Next(limitX);
                y = RandomNum.Next(limitY);
                
                    foreach (Cell cell in field)
                    {
                        if (cell.IndexI == x & cell.IndexJ == y & !cell.bomb)
                        {
                            cell.bomb = true;
                            limitBomb = limitBomb - 1;
                            break;
                        }
                    }
                
                
            }
        }
        
        void NumOfBombCell(Classes.Cell[,] field, int limitX, int limitY)
        {
            
            

            foreach(Cell cell in field)
            {
                int num = 0;
                if (!cell.bomb)
                {
                    for (int j = cell.IndexJ - 1; j <= cell.IndexJ + 1; j++)
                    {
                        for (int i = cell.IndexI - 1; i <= cell.IndexI + 1; i++)
                        {
                            if ((i == cell.IndexI & j == cell.IndexJ) | (i < 0 | j < 0 | i >= limitX | j >= limitY))
                            {
                                continue;
                            }

                            if (field[i, j].bomb)
                            {
                                num = num + 1;
                            }
                        }
                    }
                    cell.num.Text = num.ToString();
                }
            }
        }

        static void ResetField()
        {

            foreach (System.Windows.Forms.Control elm in FormMiner.ActiveForm.Controls)
            {
                Classes.Cell cell = elm as Classes.Cell;
                if (cell != null)
                {
                    FormMiner.ActiveForm.Controls.Remove(cell);
                    FormMiner.ActiveForm.Controls.Remove(cell.num);
                }
            }
        }
    }
}
