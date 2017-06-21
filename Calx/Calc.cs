using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calx
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            int inp1 = 0;
            int inp2 = 0;
            if (int.TryParse(input1Text.Text, out inp1) && (int.TryParse(input2Text.Text, out inp2))) {
                ouputText.Text = (inp1 + inp2).ToString();
            } else
            {
                ouputText.Text = "Ошибка. Введите целочисленные числа.";
            }
        }
    }
}
