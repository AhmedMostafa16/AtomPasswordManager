namespace AtomPasswordManager.View;

public partial class ChangePasswordForm : Form
{
    public ChangePasswordForm()
    {
        InitializeComponent();
    }

    private void Toggle(bool val)
    {
        OldPasswordTextBox.UseSystemPasswordChar = val;
        NewPasswordTextBox.UseSystemPasswordChar = val;
    }

    private void PasswordToggleButton_Click(object sender, EventArgs e)
    {
        if (OldPasswordTextBox.UseSystemPasswordChar)
        {
            Toggle(false);
            PasswordToggleButton.Text = "Hide";
        }
        else
        {
            Toggle(true);
            PasswordToggleButton.Text = "Show";
        }
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
        {
            MessageBox.Show("Confirm the password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (OldPasswordTextBox.Text == "" || NewPasswordTextBox.Text == "" || ConfirmPasswordTextBox.Text == "")
        {
            MessageBox.Show("One or more fields are empty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (OldPasswordTextBox.Text != Manager.MasterPassword)
        {
            MessageBox.Show("Old password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
            Manager.SaveAccounts(Manager.FileLocation, NewPasswordTextBox.Text);
            Manager.MasterPassword = NewPasswordTextBox.Text;
            MessageBox.Show("Password has been changed successfully!", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }
    }
}