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

            Classes.Field.OnCreateGame += Handlers.CreateGame.ViewField;            //Вывод поля
            Classes.Field.OnCreateGame += Handlers.CreateGame.ViewMines;            //Вывод мин
            Classes.Field.OnCreateGame += Handlers.CreateGame.ViewNum;              //вывод цифр

            
        }

        private void ButtonStartGame_Click(object sender, EventArgs e)
        {
            Classes.Field field = new Classes.Field();
            field.CreateField(Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxHeight.Text), Convert.ToInt32(textBoxNumOfBomb.Text));
            
        }
        
       
    }
}
