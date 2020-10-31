using System.Windows.Forms;

namespace VirtualCash
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LinkNuevoRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro _registro = new Registro();
            this.Hide();
            _registro.ShowDialog();
        }
    }
}
