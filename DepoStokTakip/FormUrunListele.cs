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
    public partial class FormUrunListele : Form
    {
        public FormUrunListele()
        {
            InitializeComponent();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            int rolID = 1; // Örnek: Admin rolü
            FormNavigator.ReturnToMainMenu(this, rolID);
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            FormNavigator.Logout(this);
        }
    }
}
