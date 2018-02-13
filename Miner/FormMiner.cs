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
            Data.EvantHandler += new Data.Event(Handlers.CreateGame.ViewField);


            Classes.Field.Width = Convert.ToInt32(textBoxWidth.Text);
            Classes.Field.Height = Convert.ToInt32(textBoxHeight.Text);
            Classes.Field.NumBomb = Convert.ToInt32(textBoxNumOfBomb.Text);
            labelNumBombLeft.Text = textBoxNumOfBomb.Text;

            Classes.Field.CreateField(Classes.Field.NumBomb, Classes.Field.Width, Classes.Field.Height);
        }
        
        private void ButtonNewField_Click(object sender, EventArgs e)
        {
            Miner.FormMiner.ActiveForm.Controls.Clear();
            InitializeComponent();
        }
    }
}
