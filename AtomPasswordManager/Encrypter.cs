using System.Security.Cryptography;
using System.Text;

namespace AtomPasswordManager;

public static class Encrypter
{
    // Based on:
    // https://www.codeproject.com/Articles/769741/Csharp-AES-bits-Encryption-Library-with-Salt

    private static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
    {
        byte[]? encryptedBytes;
        byte[] saltBytes = { 1, 2, 3, 4, 5, 6, 7, 8 };
        using (MemoryStream ms = new())
        {
            using (var aes = Aes.Create("AesManaged")!)
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;

                Rfc2898DeriveBytes key = new(passwordBytes, saltBytes, 10000);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                aes.Mode = CipherMode.CBC;

                using (CryptoStream cs = new(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    cs.Close();
                }

                encryptedBytes = ms.ToArray();
            }
        }

        return encryptedBytes;
    }

    private static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
    {
        byte[]? decryptedBytes;

        byte[] saltBytes = { 1, 2, 3, 4, 5, 6, 7, 8 };

        using (MemoryStream ms = new())
        {
            using (var aes = Aes.Create("AesManaged")!)
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;

                Rfc2898DeriveBytes key = new(passwordBytes, saltBytes, 10000);
                aes.Key = key.GetBytes(aes.KeySize / 8);
                aes.IV = key.GetBytes(aes.BlockSize / 8);

                aes.Mode = CipherMode.CBC;

                using (CryptoStream cs = new(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                    cs.Close();
                }

                decryptedBytes = ms.ToArray();
            }
        }

        return decryptedBytes;
    }

    public static void EncryptFile(string file, string password)
    {
        if (file == null || password == null) throw new ArgumentNullException(nameof(file));

        var bytesToBeEncrypted = File.ReadAllBytes(file);
        var passwordBytes = Encoding.UTF8.GetBytes(password);

        // hash password with SHA256
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        var bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);
        File.WriteAllBytes(file, bytesEncrypted);
    }

    public static void DecryptFile(string file, string password)
    {
        if (file == null || password == null) throw new ArgumentNullException(nameof(file));

        var bytesToBeDecrypted = File.ReadAllBytes(file);
        var passwordBytes = Encoding.UTF8.GetBytes(password);
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        var bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

        File.WriteAllBytes(file, bytesDecrypted);
        var extension = Path.GetExtension(file);
        var result = file[..^extension.Length];
        File.Move(file, result + Manager.Extension);
    }
}