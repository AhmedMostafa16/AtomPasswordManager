namespace AtomPasswordManager.View;

public partial class MainForm : Form
{
    private bool showToggle;

    public MainForm()
    {
        InitializeComponent();
    }

    private void RefreshList(bool replacePassword)
    {
        listView1.Items.Clear();
        foreach (var currentAccount in Account.Accounts)
        {
            string password;
            if (replacePassword)
                password = currentAccount.password;
            else
                password = "********";

            ListViewItem Date = new(new[]
            {
                currentAccount.email,
                password,
                currentAccount.website,
                currentAccount.notes
            });
            Date.Tag = currentAccount.password;
            listView1.Items.Add(Date);
        }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        AcceptedCharactersTextbox.Text = Manager.AllowedCharacters;
        PasswordLengthTextbox.Text = Manager.PasswordLength.ToString();
        listView1.FullRowSelect = true;
        listView1.GridLines = true;
        listView1.Columns.Add("Login", 143, HorizontalAlignment.Left);
        listView1.Columns.Add("Password", 122, HorizontalAlignment.Left);
        listView1.Columns.Add("Site", 136, HorizontalAlignment.Left);
        listView1.Columns.Add("Notes", 198, HorizontalAlignment.Left);
        RefreshList(showToggle);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        Manager.SaveAccounts(Manager.FileLocation, Manager.MasterPassword);
    }

    private void ChangeMasterPasswordButton_Click(object sender, EventArgs e)
    {
        ChangePasswordForm changePasswordForm = new();
        changePasswordForm.Show();
    }

    public async void ClipboardCopyPassword()
    {
        if (listView1.SelectedItems.Count != 0)
        {
            Clipboard.SetText(listView1.SelectedItems[0].Tag.ToString() ?? string.Empty);
            await Task.Delay(TimeSpan.FromSeconds(Manager.ClearPasswordSeconds));
            Clipboard.Clear();
        }
    }

    private void listView1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Control && e.KeyCode == Keys.C) ClipboardCopyPassword();
    }

    private void AcceptedCharactersTextbox_TextChanged(object sender, EventArgs e)
    {
        if (PasswordLengthTextbox.Text.Length >= 8) Manager.AllowedCharacters = AcceptedCharactersTextbox.Text;
    }

    private void PasswordLengthTextbox_TextChanged(object sender, EventArgs e)
    {
        if (PasswordLengthTextbox.Text.Length >= 8)
            try
            {
                Manager.PasswordLength = Convert.ToInt32(PasswordLengthTextbox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a number greater than or equals 8");
                PasswordLengthTextbox.Text = string.Empty;
            }
    }

    private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
        ClipboardCopyPassword();
    }

    private void CheckComplexityButton_Click(object sender, EventArgs e)
    {
        var complexity = 0;
        if (PasswordTextbox.Text.Length >= 4) complexity += 10;

        if (PasswordTextbox.Text.Length >= 8) complexity += 10;

        if (PasswordTextbox.Text.IndexOfAny("abcdefghijklmnopqrstuvwxyz".ToCharArray()) >= 0) complexity += 15;

        if (PasswordTextbox.Text.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) >= 0) complexity += 15;

        if (PasswordTextbox.Text.IndexOfAny("0123456789".ToCharArray()) >= 0) complexity += 25;

        if (PasswordTextbox.Text.IndexOfAny("!@#$%^&*()_-=+;[]{}:.,<>/?".ToCharArray()) >= 0) complexity += 25;

        ComplexityBar.Value = complexity;
        ComplexityLabel.Text = $"Complexity ({complexity}/100):";
        complexity = 0;
    }

    private void GenerateButton_Click(object sender, EventArgs e)
    {
        PasswordTextbox.Text = Manager.RandomString(Manager.PasswordLength);
    }

    private void EditAccountButton_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please choose an account you want to edit!", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            Account.Accounts.RemoveAt(listView1.SelectedItems[0].Index);
            var email = EmailTextbox.Text;
            var password = PasswordTextbox.Text;
            var website = WebsiteTextbox.Text;
            var notes = NotesTextbox.Text;

            Account.Accounts.Insert(listView1.SelectedItems[0].Index, new Account(email, password, website, notes));
            email = password = website = notes = EmailTextbox.Text =
                PasswordTextbox.Text = WebsiteTextbox.Text = NotesTextbox.Text = string.Empty;
            RefreshList(showToggle);
            GC.Collect();
        }
    }

    private void DeleteAccountButton_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please choose an account you want to edit!", "Info", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        else
        {
            var res = MessageBox.Show("Are you sure you want to delete the selected data?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Account.Accounts.RemoveAt(listView1.SelectedItems[0].Index);
                RefreshList(showToggle);
                EmailTextbox.Text = PasswordTextbox.Text = WebsiteTextbox.Text = NotesTextbox.Text = string.Empty;
                GC.Collect();
            }
        }
    }

    private void AddAccountButton_Click(object sender, EventArgs e)
    {
        var email = EmailTextbox.Text;
        var password = PasswordTextbox.Text;
        var website = WebsiteTextbox.Text;
        var notes = NotesTextbox.Text;
        if (email == "" && password == "" && website == "")
        {
            MessageBox.Show("Please fill all the forms!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            Account.Accounts.Add(new Account(email, password, website, notes));
            email = password = website = notes = EmailTextbox.Text =
                PasswordTextbox.Text = WebsiteTextbox.Text = NotesTextbox.Text = string.Empty;
            RefreshList(showToggle);
            GC.Collect();
        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count == 0)
        {
            EmailTextbox.Text = PasswordTextbox.Text = WebsiteTextbox.Text = NotesTextbox.Text = string.Empty;
        }
        else
        {
            EmailTextbox.Text = listView1.SelectedItems[0].SubItems[0].Text;
            PasswordTextbox.Text = listView1.SelectedItems[0].Tag.ToString();
            WebsiteTextbox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            NotesTextbox.Text = listView1.SelectedItems[0].SubItems[3].Text;
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

    private void TogglePasswordsButton_Click(object sender, EventArgs e)
    {
        if (TogglePasswordsButton.Text == "  Show passwords")
        {
            showToggle = true;
            TogglePasswordsButton.Text = "  Hide passwords";
        }
        else
        {
            showToggle = false;
            TogglePasswordsButton.Text = "  Show passwords";
        }

        RefreshList(showToggle);
    }
}