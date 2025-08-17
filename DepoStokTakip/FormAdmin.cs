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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormUrunEkle());
        }

        private void btnUrunListele_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormUrunListele());
        }

        private void btnStokGuncelle_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormStokGuncelle());
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormUrunSil());
        }

        private void btnKullaniciYonet_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm(this, new FormKullaniciYonet());
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormNavigator.Logout(this);
        }
    }
}
