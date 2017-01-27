using System.Windows.Forms;
using System.Web.Security;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string NewPassword()
        {
            return Membership.GeneratePassword(12, 1);
        }

        private void btnNewPasswordClick(object sender, System.EventArgs e)
        {
            tbxPassword.Text = NewPassword();
        }

        private void btnCopyToClipboardClick (object sender, System.EventArgs e)
        {
            Clipboard.SetText(tbxPassword.Text);
        }
    }
}
