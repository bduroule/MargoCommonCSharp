using System;
namespace Kata;

public static class DictionaryReplacer
{
    private static string CopyArea(this string str, int start, int end)
    {

        if (start >= end || end > str.Length || start >= str.Length)
            return "";
        char[] strArray = new char[end - start];
        int j = 0;

        for (int i = start; i < end; i++) {
            strArray[j++] = str[i];
        }
        return new string(strArray);
    }

    private static int LastElement(this string str, int start)
    {
        int count = 0;

        for (int i = start; i < str.Length && str[i] != '$'; i++)
            count++;
        return start + count;
    }

    public static string Replacer(string str, Dictionary<string, string> dictionary)
    {
        if (dictionary == null)
            return "";
        string result = "";
        int start = 0;

        for (int i = 0; i < str.Length; i++) {
            if (str[i] == '$') {
                if (i != 0)
                    result += str.CopyArea(start, i);
                int end = str.LastElement(i + 1); // + 1
                if (!dictionary.TryGetValue(str.CopyArea(i + 1, end), out string value))
                    throw new Exception($"key not found: {str.CopyArea(i + 1, end)}");
                result += value;
                start = end + 1;
                i = end;
            }
            if (i + 1 == str.Length)
                result += str.CopyArea(start, i + 1);
        }
        return result;
    }
}