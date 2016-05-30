using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Begin
{
    public partial class SetDlg : Form
    {
        // Класс диалогового окна настроек программы
        public SetDlg()
        {
            InitializeComponent();
        }
        public int LengthSides = 3;
        // Загрузка предыдущих настроек.
        private void SetDlg_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = LengthSides;
        }

        // Изменение настроек программы.
        public void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            LengthSides = (int)numericUpDown1.Value;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
