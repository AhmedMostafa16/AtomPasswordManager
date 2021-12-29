namespace AtomPasswordManager
{
    public class Account
    {
        public static List<Account> Accounts = new();
        public string email;
        public string password;
        public string website;
        public string notes;

        public Account(string email, string password, string website, string notes)
        {
            this.email = email;
            this.password = password;
            this.website = website;
            this.notes = notes;
        }
    }
}
