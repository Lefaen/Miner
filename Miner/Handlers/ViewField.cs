using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Miner.Handlers
{

    class CreateGame
    {
         
        public static void ViewField(object sender)
        {
            ResetField();

            Classes.Cell[,] field = sender as Classes.Cell[,];

            foreach (Classes.Cell cell in field)
            {
                
                if (cell != null)
                {
                    cell.BackColor = System.Drawing.Color.White;
                    cell.Visible = true;
                }
            }
        }

        static void ResetField()
        {
            System.Windows.Forms.Panel menu = FormMiner.ActiveForm.Controls["panelMenu"] as System.Windows.Forms.Panel;
            System.Windows.Forms.Button buttonNewField = FormMiner.ActiveForm.Controls["buttonNewField"] as System.Windows.Forms.Button;
            System.Windows.Forms.Label labelNumBombLeft = FormMiner.ActiveForm.Controls["labelNumBombLeft"] as System.Windows.Forms.Label;

            buttonNewField.Location = new System.Drawing.Point(FormMiner.ActiveForm.Size.Width-105, FormMiner.ActiveForm.Size.Height - 65);
            buttonNewField.Visible = true;

            labelNumBombLeft.Location = new System.Drawing.Point(5, FormMiner.ActiveForm.Size.Height - 65);
            labelNumBombLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelNumBombLeft.Visible = true;
            menu.Visible = false;
        
        }
    }
}
