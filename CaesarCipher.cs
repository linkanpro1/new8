using System;

class CaesarCipher
{
    static string Encrypt(string text, int shift)
    {
        string result = "";

        foreach (char ch in text)
        {
            if (!char.IsLetter(ch))
            {
                result += ch;
                continue;
            }

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            char encrypted = (char)((((ch + shift) - offset) % 26) + offset);
            result += encrypted;
        }

        return result;
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }

    static void Main()
    {
        Console.WriteLine("Vänligen skriv in din text:");
        string text = Console.ReadLine();

        Console.WriteLine("Välj ett förflyttningsvärde för kryptering:");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(text, shift);
        Console.WriteLine("Krypterad text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine("Avkrypterad text: " + decryptedText);
    }
}
