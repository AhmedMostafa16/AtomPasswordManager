namespace AtomPasswordManager.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NotesTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WebsiteTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowToggleButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComplexityBar = new System.Windows.Forms.ProgressBar();
            this.ComplexityLabel = new System.Windows.Forms.Label();
            this.PasswordLengthTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AcceptedCharactersTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CheckComplexityButton = new System.Windows.Forms.Button();
            this.ChangeMasterPasswordButton = new System.Windows.Forms.Button();
            this.TogglePasswordsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(177, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(638, 351);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView1_KeyDown);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NotesTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.WebsiteTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ShowToggleButton);
            this.groupBox1.Controls.Add(this.GenerateButton);
            this.groupBox1.Controls.Add(this.PasswordTextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EmailTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(177, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Data";
            // 
            // NotesTextbox
            // 
            this.NotesTextbox.Location = new System.Drawing.Point(82, 114);
            this.NotesTextbox.Multiline = true;
            this.NotesTextbox.Name = "NotesTextbox";
            this.NotesTextbox.Size = new System.Drawing.Size(372, 81);
            this.NotesTextbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes:";
            // 
            // WebsiteTextbox
            // 
            this.WebsiteTextbox.Location = new System.Drawing.Point(82, 23);
            this.WebsiteTextbox.Name = "WebsiteTextbox";
            this.WebsiteTextbox.Size = new System.Drawing.Size(372, 23);
            this.WebsiteTextbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Website:";
            // 
            // ShowToggleButton
            // 
            this.ShowToggleButton.Location = new System.Drawing.Point(557, 85);
            this.ShowToggleButton.Name = "ShowToggleButton";
            this.ShowToggleButton.Size = new System.Drawing.Size(75, 23);
            this.ShowToggleButton.TabIndex = 5;
            this.ShowToggleButton.Text = "Show";
            this.ShowToggleButton.UseVisualStyleBackColor = true;
            this.ShowToggleButton.Click += new System.EventHandler(this.ShowToggleButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(476, 84);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(75, 23);
            this.GenerateButton.TabIndex = 4;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(82, 85);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(372, 23);
            this.PasswordTextbox.TabIndex = 3;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(82, 52);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(372, 23);
            this.EmailTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ComplexityBar);
            this.groupBox2.Controls.Add(this.ComplexityLabel);
            this.groupBox2.Controls.Add(this.PasswordLengthTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.AcceptedCharactersTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(176, 587);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(638, 104);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // ComplexityBar
            // 
            this.ComplexityBar.Location = new System.Drawing.Point(461, 69);
            this.ComplexityBar.Name = "ComplexityBar";
            this.ComplexityBar.Size = new System.Drawing.Size(158, 23);
            this.ComplexityBar.TabIndex = 9;
            // 
            // ComplexityLabel
            // 
            this.ComplexityLabel.AutoSize = true;
            this.ComplexityLabel.Location = new System.Drawing.Point(333, 72);
            this.ComplexityLabel.Name = "ComplexityLabel";
            this.ComplexityLabel.Size = new System.Drawing.Size(111, 15);
            this.ComplexityLabel.TabIndex = 8;
            this.ComplexityLabel.Text = "Complexity (0/100):";
            // 
            // PasswordLengthTextbox
            // 
            this.PasswordLengthTextbox.Location = new System.Drawing.Point(207, 69);
            this.PasswordLengthTextbox.Name = "PasswordLengthTextbox";
            this.PasswordLengthTextbox.Size = new System.Drawing.Size(120, 23);
            this.PasswordLengthTextbox.TabIndex = 7;
            this.PasswordLengthTextbox.TextChanged += new System.EventHandler(this.PasswordLengthTextbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password Length:";
            // 
            // AcceptedCharactersTextbox
            // 
            this.AcceptedCharactersTextbox.Location = new System.Drawing.Point(207, 31);
            this.AcceptedCharactersTextbox.Name = "AcceptedCharactersTextbox";
            this.AcceptedCharactersTextbox.Size = new System.Drawing.Size(412, 23);
            this.AcceptedCharactersTextbox.TabIndex = 5;
            this.AcceptedCharactersTextbox.TextChanged += new System.EventHandler(this.AcceptedCharactersTextbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Accepted Characters for password:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.CheckComplexityButton);
            this.panel1.Controls.Add(this.ChangeMasterPasswordButton);
            this.panel1.Controls.Add(this.TogglePasswordsButton);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DeleteAccountButton);
            this.panel1.Controls.Add(this.EditAccountButton);
            this.panel1.Controls.Add(this.AddAccountButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 703);
            this.panel1.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(3, 656);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(154, 43);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save changes";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CheckComplexityButton
            // 
            this.CheckComplexityButton.Location = new System.Drawing.Point(3, 318);
            this.CheckComplexityButton.Name = "CheckComplexityButton";
            this.CheckComplexityButton.Size = new System.Drawing.Size(154, 43);
            this.CheckComplexityButton.TabIndex = 7;
            this.CheckComplexityButton.Text = "Check complexity";
            this.CheckComplexityButton.UseVisualStyleBackColor = true;
            this.CheckComplexityButton.Click += new System.EventHandler(this.CheckComplexityButton_Click);
            // 
            // ChangeMasterPasswordButton
            // 
            this.ChangeMasterPasswordButton.Location = new System.Drawing.Point(3, 269);
            this.ChangeMasterPasswordButton.Name = "ChangeMasterPasswordButton";
            this.ChangeMasterPasswordButton.Size = new System.Drawing.Size(154, 43);
            this.ChangeMasterPasswordButton.TabIndex = 6;
            this.ChangeMasterPasswordButton.Text = "Change master password";
            this.ChangeMasterPasswordButton.UseVisualStyleBackColor = true;
            this.ChangeMasterPasswordButton.Click += new System.EventHandler(this.ChangeMasterPasswordButton_Click);
            // 
            // TogglePasswordsButton
            // 
            this.TogglePasswordsButton.Location = new System.Drawing.Point(3, 220);
            this.TogglePasswordsButton.Name = "TogglePasswordsButton";
            this.TogglePasswordsButton.Size = new System.Drawing.Size(154, 43);
            this.TogglePasswordsButton.TabIndex = 5;
            this.TogglePasswordsButton.Text = "Show passwords";
            this.TogglePasswordsButton.UseVisualStyleBackColor = true;
            this.TogglePasswordsButton.Click += new System.EventHandler(this.TogglePasswordsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Options";
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.Location = new System.Drawing.Point(3, 126);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(154, 43);
            this.DeleteAccountButton.TabIndex = 3;
            this.DeleteAccountButton.Text = "Delete account";
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.Location = new System.Drawing.Point(3, 77);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(154, 43);
            this.EditAccountButton.TabIndex = 2;
            this.EditAccountButton.Text = "Edit account";
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(3, 28);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(154, 43);
            this.AddAccountButton.TabIndex = 1;
            this.AddAccountButton.Text = "Add account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Edit Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Atom Password Manager - Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listView1;
        private GroupBox groupBox1;
        private TextBox EmailTextbox;
        private Label label1;
        private TextBox NotesTextbox;
        private Label label3;
        private TextBox WebsiteTextbox;
        private Label label4;
        private Button ShowToggleButton;
        private Button GenerateButton;
        private TextBox PasswordTextbox;
        private Label label2;
        private GroupBox groupBox2;
        private ProgressBar ComplexityBar;
        private Label ComplexityLabel;
        private TextBox PasswordLengthTextbox;
        private Label label8;
        private TextBox AcceptedCharactersTextbox;
        private Label label5;
        private Panel panel1;
        private Button SaveButton;
        private Button CheckComplexityButton;
        private Button ChangeMasterPasswordButton;
        private Button TogglePasswordsButton;
        private Label label7;
        private Button DeleteAccountButton;
        private Button EditAccountButton;
        private Button AddAccountButton;
        private Label label6;
    }
}