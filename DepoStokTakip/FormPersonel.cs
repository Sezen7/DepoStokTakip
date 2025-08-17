using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepoStokTakip
{
    public partial class FormPersonel : Form
    {
        public FormPersonel()
        {
            InitializeComponent();
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormUrunListele());
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormUrunEkle());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNavigator.Logout(this);
        }
    }
}
