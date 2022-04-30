using System.Text;
using System.Text.Json;

namespace AtomPasswordManager;

public static class Manager
{
    private static readonly Random random = new();
    public static string MasterPassword = "";
    public static string Extension = ".atom";
    public static string PackageName = "ATOM";
    public static string FileLocation = "";
    public static int PasswordLength = 16;
    public static int ClearPasswordSeconds = 5;

    public static string AllowedCharacters =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-=+;[]{}:.,<>/?";


    public static void SaveAccounts(string path, string password)
    {
        var json = JsonSerializer.Serialize(Account.Accounts);
        File.WriteAllText(path, json);
        Encrypter.EncryptFile(path, password);
    }

    public static bool LoadAccounts(string path, string password)
    {
        // Convert to JSON
        var bkallowedChar = AllowedCharacters;
        AllowedCharacters = "ABCDEFHIJKLMNOPQRSTUVWXYZ1234567890";

        var tempFilePath = Path.GetTempPath() + $"atomtemp{RandomString(8)}.atom";
        AllowedCharacters = bkallowedChar;
        File.Copy(path, tempFilePath);
        try
        {
            Encrypter.DecryptFile(tempFilePath, MasterPassword);

            var convertMe = File.ReadAllText(tempFilePath);
            File.Delete(tempFilePath);
            Account.Accounts = JsonSerializer.Deserialize<List<Account>>(convertMe)!;
        }
        catch
        {
            if (File.Exists(tempFilePath)) File.Delete(tempFilePath);

            return false;
        }

        return true;
    }


    public static string RandomString(int length)
    {
        StringBuilder result = new();

        var randomInteger = random.Next(0, AllowedCharacters.Length);
        while (0 < length--)
        {
            if (randomInteger >= 0 && randomInteger < AllowedCharacters.Length)
                result.Append(AllowedCharacters[randomInteger]);
            randomInteger = random.Next(0, AllowedCharacters.Length);
        }

        return result.ToString();
    }
}