using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Classes
{
    class Field
    {
        public delegate void CreateGameHandler(Cell[,] field);
        public static event CreateGameHandler OnCreateGame;
        //поле
        public void CreateField(int width, int height, int numBomb)
        {

            int SizeCell = 20;
            int locX = 100;
            int locY = 0;

            //List<List<Cell>> field = new List<List<Cell>>();
            Cell[,] field = new Cell[height, width];
            

            for (int i = 0; i<height; i++)
            {
                //List<Cell> cells = new List<Cell>();
                locX = 100;
                

                for (int j = 0; j<width; j++)
                {
                    locX = locX + SizeCell;
                    
                    field[i,j] = (new Cell(i, j, SizeCell, locX, locY));

                    Handlers.ClickCellHandler OnClick = new Handlers.ClickCellHandler();

                    field[i, j].Click += new System.EventHandler(OnClick.ButtonCell_Click);
                    field[i, j].num.Click += new System.EventHandler(OnClick.ButtonCell_Click);
                }

                locY = locY + SizeCell;
            }

            PositionMines(field, numBomb, width, height);
            NumOfBombCell(field,width,height);

            OnCreateGame(field);
        }
        
        void PositionMines (Cell[,] field, int limitBomb, int limitX, int limitY)
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
        
        void NumOfBombCell(Cell[,] field, int limitX, int limitY)
        {
            
            

            foreach(Cell cell in field)
            {
                int num = 0;
                if (!cell.bomb)
                {
                    for (int i = cell.IndexI - 1; i <= cell.IndexI + 1; i++)
                    {
                        for (int j = cell.IndexJ - 1; j <= cell.IndexJ + 1; j++)
                        {
                            if ((i == cell.IndexI & j == cell.IndexJ) | (i < 0 | j < 0 | i >= limitX | j >= limitX))
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
    }
}
