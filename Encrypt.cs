var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Skriv in namn eller ord, utan å, ä eller ö:");

app.MapGet("/encrypt", (string myName, int shift) => Encrypt(myName, shift));

app.MapGet("/decrypt", (string myName, int shift) => Decrypt(myName, shift));

app.Run();

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

    static string Decrypt(string text, int shift)
{
        return Encrypt(text, 26 - shift);
}