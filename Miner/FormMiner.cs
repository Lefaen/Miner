using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner
{
    public partial class FormMiner : Form
    {

		public FormMiner()
        {
            InitializeComponent();
		}

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            Data.EvantHandler += new Data.Event(Handlers.ViewField.View);

			Classes.Field.Width = Convert.ToInt32(textBoxWidth.Text);
			Classes.Field.Height = Convert.ToInt32(textBoxHeight.Text);
			Classes.Field.NumBomb = Convert.ToInt32(textBoxNumOfBomb.Text);
			Classes.Field.Flags = Classes.Field.NumBomb;

			labelNumBombLeft.Text = Classes.Field.Flags.ToString();
			Classes.Field.delCreateField(Classes.Field.NumBomb, Classes.Field.Width, Classes.Field.Height);
        }
		
		private void ButtonNewField_Click(object sender, EventArgs e)
        {
			System.Windows.Forms.Application.Restart();
		}

    }
}
