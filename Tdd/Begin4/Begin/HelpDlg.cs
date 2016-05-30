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
    public partial class HelpDlg : Form
    {
        // Класс диалогового окна помощи пользователю
        public HelpDlg()
        {
            InitializeComponent();
        }
        public Image ImageDuplicate = null;

        // Загрузка картинки на форму посредством PictureBox.
        public void ImageCopy()
        {
            pictureBox1.Image = ImageDuplicate;
        }
        public void HelpDlg_Load(object sender, EventArgs e)
        {
            ImageCopy();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
