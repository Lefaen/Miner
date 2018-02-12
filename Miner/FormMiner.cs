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

            Classes.Field field = new Classes.Field();
            field.CreateField(Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), Convert.ToInt32(textBoxNumOfBomb.Text));
        }


    }
}
