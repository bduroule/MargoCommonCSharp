namespace Kata;

public class CodeCracker
{
    public static string Decrypte(string message, string key)
    {
        if (key.Length != 26)
            throw new Exception($"Invalide key {key}");
        char[] result = new char[message.Length];

        for (int i = 0; i < message.Length; i++) {
            if (key.Contains(message[i]))
                result[i] = (char)('a' + key.IndexOf(message[i]));
            else
                result[i] = '�';
        }
        return new string(result);
    }

    public static string Encrypte(string message, string key)
    {
        if (key.Length != 26)
            throw new Exception($"Invalide key {key}");
        message = message.ToLower();
        char[] result = new char[message.Length];

        for (int i = 0; i < message.Length; i++) {
            if (message[i] >= 'a' && message[i] <= 'z')
                result[i] = key[message[i] - 'a'];
        }
        return new string(result);
    }
}