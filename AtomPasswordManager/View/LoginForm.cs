using AtomPasswordManager.View;

namespace AtomPasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            MasterPasswordForm PasswordForm = new();
            PasswordForm.ShowDialog();

            if (Manager.MasterPassword.Length == 0)
            {
                return;
            }

            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = $@"{Manager.PackageName} files |*{Manager.Extension}";
            saveFileDialog.DefaultExt = Manager.Extension;
            saveFileDialog.AddExtension = true;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Manager.SaveAccounts(saveFileDialog.FileName, Manager.MasterPassword);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = $@"{Manager.PackageName} files |*{Manager.Extension}",
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Manager.FileLocation = openFileDialog.FileName;

            MasterPasswordForm masterPasswordForm = new();
            masterPasswordForm.ShowDialog();


            if (Manager.MasterPassword.Length == 0)
            {
                return;
            }

            if (Manager.LoadAccounts(Manager.FileLocation, Manager.MasterPassword))
            {
                Close();
                Program.CorrectPassword = true;
            }
            else
            {
                if (Manager.MasterPassword.Length != 0)
                {
                    MessageBox.Show("Password is wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}