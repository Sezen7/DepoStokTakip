using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DepoStokTakip
{
    public static class FormNavigator
    {
        // Yeni form aç ve mevcut formu gizle
        public static void OpenForm(Form currentForm, Form targetForm)
        {
            targetForm.Show();
            currentForm.Hide();
        }

        // Formu dialog olarak aç
        public static void OpenFormAsDialog(Form targetForm)
        {
            targetForm.ShowDialog();
        }

        // Logout: login formunu aç ve mevcut formu kapat
        public static void Logout(Form currentForm)
        {
            FormLogin login = new FormLogin();
            login.Show();
            currentForm.Close();
        }

        // Ana menüye dön: rol bilgisi ile form aç
        public static void ReturnToMainMenu(Form currentForm, int rolID)
        {
            if (rolID == 1) // Admin
            {
                FormAdmin adminMenu = new FormAdmin();
                adminMenu.Show();
            }
            else // Personel
            {
                FormPersonel personelMenu = new FormPersonel();
                personelMenu.Show();
            }
            currentForm.Close();
        }
    }
}

