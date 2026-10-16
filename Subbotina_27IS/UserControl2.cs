using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Subbotina_27IS.FolderforModel;

namespace Subbotina_27IS
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }
        public void Fill(Table_Motorbike Motorbike)
        {
            labellDData.Text = Motorbike.ID.ToString();
            label8.Text = Motorbike.Model;
            label9.Text = Motorbike.Brand;
            label10.Text = Motorbike.Price.ToString();
            label11.Text = Motorbike.Horsepower.ToString();
            label12.Text = Motorbike.Mileage.ToString();
            pictureBox1.Image = Image.FromFile($@"Pictures\{Motorbike.Picture}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
