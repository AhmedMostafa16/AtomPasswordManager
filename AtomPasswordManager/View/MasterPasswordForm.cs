namespace AtomPasswordManager.View;

public partial class MasterPasswordForm : Form
{
    public MasterPasswordForm()
    {
        InitializeComponent();
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (PasswordTextbox.Text.Length == 0)
        {
            MessageBox.Show("Please enter your master password!", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            Manager.MasterPassword = PasswordTextbox.Text;
            Close();
        }
    }

    private void ShowToggleButton_Click(object sender, EventArgs e)
    {
        if (PasswordTextbox.UseSystemPasswordChar)
        {
            PasswordTextbox.UseSystemPasswordChar = false;
            ShowToggleButton.Text = "Hide";
        }
        else
        {
            PasswordTextbox.UseSystemPasswordChar = true;
            ShowToggleButton.Text = "Show";
        }
    }
}