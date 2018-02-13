using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miner.Handlers
{

    class ViewField
    {
         
        public static void View(object sender)
        {
			int SizeCell = 20;
			Classes.Cell[,] field = sender as Classes.Cell[,];
			
			System.Windows.Forms.Panel menu = FormMiner.ActiveForm.Controls["panelMenu"] as System.Windows.Forms.Panel;
			menu.Visible = false;

			FormMiner.ActiveForm.Size = new System.Drawing.Size(SizeCell * Classes.Field.Width + 55, SizeCell * Classes.Field.Height + 80);
			
			System.Windows.Forms.Button buttonNewField = FormMiner.ActiveForm.Controls["buttonNewField"] as System.Windows.Forms.Button;
			buttonNewField.Location = new System.Drawing.Point(FormMiner.ActiveForm.Size.Width - 105, FormMiner.ActiveForm.Size.Height - 65);
			buttonNewField.Visible = true;

			System.Windows.Forms.Label labelNumBombLeft = FormMiner.ActiveForm.Controls["labelNumBombLeft"] as System.Windows.Forms.Label;
			labelNumBombLeft.Location = new System.Drawing.Point(5, FormMiner.ActiveForm.Size.Height - 65);
			labelNumBombLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			labelNumBombLeft.Visible = true;

			//ViewField
			int locationX = 0;
			int locationY = 10;

			for (int j = 0; j < Classes.Field.Height; j++)
			{
				locationX = 0;

				for (int i = 0; i < Classes.Field.Width; i++)
				{
					locationX = locationX + SizeCell;

					field[i, j].Location = new System.Drawing.Point(locationX, locationY);
					field[i, j].Size = new System.Drawing.Size(SizeCell, SizeCell);
					field[i, j].BackColor = System.Drawing.Color.White;
					field[i, j].Visible = true;
				}
				locationY = locationY + SizeCell;
			}
        }
    }
}
