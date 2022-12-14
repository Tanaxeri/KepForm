using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KepForm
{
    public partial class KepGUI : Form
    {
        public KepGUI()
        {
            InitializeComponent();
        }

        private void MegnyitButton_Click(object sender, EventArgs e)
        {

            FileOpenDialog.Filter = "Minden fájl (*.*)|*.*|PNG fájl (*.png)|*.png|JPG fájl (*.jpg)|*.jpg|WEBP fájl (*.webp)|*.webp";
            if (FileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                string fajl = FileOpenDialog.FileName;
                KepBox.Image = Image.FromFile(fajl);

            }

        }
    }
}
