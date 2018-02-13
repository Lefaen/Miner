using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miner.Classes
{
    class Field
    {
		public delegate void Event (int numBomb, int width, int height);
		public static Event delCreateField = CreateField;


		public static int Width { get; set; }
        public static int Height { get; set; }
        public static int NumBomb { get; set; }
		public static int Flags { get; set; }
		

		static void CreateField(int numBomb, int width, int height)
        {
            Cell[,] field = new Cell[width, height];
            

            for (int j = 0; j<height; j++)
            {
                for (int i = 0; i<width; i++)
                {
                    field[i,j] = (new Cell(i, j));

                    Handlers.ClickCellHandler OnClick = new Handlers.ClickCellHandler();
                    field[i, j].Click += new System.EventHandler(OnClick.ButtonCell_Click);
                }
            }

            PositionMines(field, numBomb, width, height);
            PositionNumOfBombCell(field, width, height);

            Data.EvantHandler(field);
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
        
        static void PositionNumOfBombCell(Classes.Cell[,] field, int limitX, int limitY)
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
		
    }
}
