using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Classes
{
    class Field
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int SizeCell { get; set; }
        public static int NumBomb { get; set; }


        public static Classes.Cell[,] CreateField(int numBomb, int width, int height)
        {
            ResetField();

            SizeCell = 20;
            int locX = 0;
            int locY = 10;
            
            Cell[,] field = new Cell[width, height];
            

            for (int j = 0; j<height; j++)
            {
                locX = 0;
                

                for (int i = 0; i<width; i++)
                {
                    locX = locX + SizeCell;
                    
                    field[i,j] = (new Cell(i, j, SizeCell, locX, locY));

                    Handlers.ClickCellHandler OnClick = new Handlers.ClickCellHandler();
                    field[i, j].Click += new System.EventHandler(OnClick.ButtonCell_Click);
                }
                locY = locY + SizeCell;
                
            }

            FormMiner.ActiveForm.Size = new System.Drawing.Size(SizeCell * width+55, SizeCell * height+80);

            PositionMines(field, numBomb, width, height);
            NumOfBombCell(field, width, height);

            Data.EvantHandler(field);
            return field;
        }
        
        static void PositionMines (Classes.Cell[,] field, int limitBomb, int limitX, int limitY)
        {

            while(limitBomb > 0)
            {
                int x, y;
                Random RandomNum = new Random();
                x = RandomNum.Next(limitX);
                y = RandomNum.Next(limitY);
                
                    foreach (Cell cell in field)
                    {
                        if (cell.IndexI == x & cell.IndexJ == y & !cell.Bomb)
                        {
                            cell.Bomb = true;
                            limitBomb = limitBomb - 1;
                            break;
                        }
                    }
                
                
            }
        }
        
        static void NumOfBombCell(Classes.Cell[,] field, int limitX, int limitY)
        {
            
            

            foreach(Cell cell in field)
            {
                int num = 0;
                if (!cell.Bomb)
                {
                    for (int j = cell.IndexJ - 1; j <= cell.IndexJ + 1; j++)
                    {
                        for (int i = cell.IndexI - 1; i <= cell.IndexI + 1; i++)
                        {
                            if ((i == cell.IndexI & j == cell.IndexJ) | (i < 0 | j < 0 | i >= limitX | j >= limitY))
                            {
                                continue;
                            }

                            if (field[i, j].Bomb)
                            {
                                num = num + 1;
                            }
                        }
                    }
                    cell.Num.Text = num.ToString();
                }
            }
        }

        public static void ResetField()
        {
                
            
            
        }
    }
}
