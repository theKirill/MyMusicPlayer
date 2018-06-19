using System;
using MetroFramework.Forms;

namespace Музыкальный_плеер
{
    public partial class AddSongFromSite : MetroForm
    {
        public string URL;
        public bool input;

        public AddSongFromSite()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            input = false;
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextFieldURL.Text != "")
            {
                URL = TextFieldURL.Text;
                input = true;
                this.Close();
            }
            else
            {
                MetroMessageBox mb = new MetroMessageBox();
                mb.Text = "Введён пустой URL - адрес";
                mb.Show();
            }
        }
    }
}
