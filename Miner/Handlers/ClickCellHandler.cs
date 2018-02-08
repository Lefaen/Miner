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
        public void ButtonCell_Click(object sender, EventArgs e)
        {
            try
            {
                Classes.Cell cell = sender as Classes.Cell;
                Miner.FormMiner.ActiveForm.Controls[cell.Name].BackColor = System.Drawing.Color.Red;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Label cell = sender as Label;
                Miner.FormMiner.ActiveForm.Controls[cell.Name].BackColor = System.Drawing.Color.Green;
                
            }
            
        }
    }
}
