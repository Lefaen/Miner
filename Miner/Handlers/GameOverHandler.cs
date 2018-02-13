using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner.Handlers
{
    class GameOverHandler
    {
        public static void ShowMessageBoom()
        {
            MessageBox.Show("Бум");
			System.Windows.Forms.Application.Restart();
		}
        public static void ShowMessageWin()
        {
            MessageBox.Show("Вы выйграли");
			System.Windows.Forms.Application.Restart();
		}
    }
}
