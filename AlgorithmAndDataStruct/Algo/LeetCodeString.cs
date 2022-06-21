namespace AlgorithmAndDataStruct;
using System;
using System.Collections.Generic;
public static class LeetCodeString
{
    public static int FirstUniqChar(string s) {
        if (!(s.Count() >= 1 && s.Count() <= 100000))
            return -1;
        Dictionary<char, int> chars = new Dictionary<char, int>();
        for (char c = 'a'; c <= 'z'; c++) {
            chars.Add(c, -1);
        }
        
        for (int i = 0; i < s.Count(); i++) {
            if (!chars.TryGetValue(s[i], out int value))
                continue ;
            if (value == -1)
                chars[s[i]] = i;
            else 
                chars.Remove(s[i]);
        }
        int result = -1;
        foreach (var elem in chars) {
            if (elem.Value != -1 && (elem.Value < result || result == -1))
                result = elem.Value;
        }
        return result;
    }

    public static bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (!map.TryAdd(s[i], 1))
                map[s[i]]++;       
        }
        for (int i = 0; i < t.Length; i++) {
            if (!map.TryGetValue(t[i], out int value))
                return false;
            map[t[i]]--;
            if (map[t[i]] == 0)
                map.Remove(t[i]);
        }
        return map.Count() == 0 ? true : false;
    }

    private static string epureStr(this string str)
    {
        List<char> array = new List<char>();

        for (int i = 0; i < str.Length; i++) {
            if (!Char.IsLetter(str[i]) && !Char.IsDigit(str[i]))
                continue ;
            array.Add(str[i]);
        }
        return new string(array.ToArray());
    }

    public static bool IsPalindrome(string s) {
        string epureStr = s.epureStr().ToLower();
        int j = epureStr.Length - 1;

        for (int i = 0; i <= j; i++) {
            if (epureStr[i] != epureStr[j])
                return false;
            j--;
        }
        return true;
    }

        public static int StrStr(string haystack, string needle) {
        if (haystack.Length < needle.Length)
            return -1;
        int start = 0;
        
        for (int i = 0; i < haystack.Length; i++) {
            if (haystack[i] == needle[0]) {
                start = i;
                Console.WriteLine($"start {start}");
                for (int j = 0; j < needle.Length && i < haystack.Length; j++) {
                    if (needle[j] != haystack[i++])
                        break ;
                    if (j == needle.Length - 1)
                        return start;
                }
                i = start;
            }
        }
        return -1;
    }

    // A revoir next time 
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
            return "";
        int minLenth = strs[0].Length;
        int maxIndex = 0;

        foreach (var elem in strs) {
            if (elem.Length < minLenth)
                minLenth = elem.Length;
        }
        for (int i = 0; i <  minLenth; i++) {
            char target = strs[0][i];
            for (int j = 1; j < strs.Length; j++) {
                if (strs[j][i] != target) {
                    char[] tmp = new char[maxIndex + 1];
                    strs[0].CopyTo(0, tmp, 0, maxIndex + 1);
                    return new string(tmp);
                }
                Console.WriteLine($"TAR {target} STR {strs[j][i]} MAX {maxIndex} J{i}");
                if (i > maxIndex)
                    maxIndex = i;
            }
        }
        char[] result = new char[maxIndex + 1];
        strs[0].CopyTo(0, result, 0, maxIndex + 1);
        return new string(result);
    }

    public static int MyAtoi(this string s)
    {
        bool IsNeg = s.Contains('-');
        s = s.ToLower();
        int res = 0;
        
        for (int i = 0; i < s.Length; i++) {
            int number = (int)Char.GetNumericValue(s[i]);
            if (!Char.IsDigit(s[i]))
                continue ;
            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && int.MaxValue % 10 == number))
                return IsNeg ? -int.MaxValue - 1 : int.MaxValue;
            res = res * 10 + number;
        }
        return IsNeg ? -res : res;
    }

    public static int AtoiLeet(this string s)
    {
        if (s.Contains('-') && s.Contains('+'))
            return 0;
        bool IsNeg = s.Contains('-');
        s = s.ToLower();
        int res = 0;
        int count = 0;

        while (count < s.Length &&  (s[count] == ' ' || s[count] == '-' || s[count] == '+' || s[count] == '0')) {
           count++;
        }
        for (int i = count; i < s.Length; i++) {
            if (!Char.IsDigit(s[i]))
                return res;
            int number = (int)Char.GetNumericValue(s[i]);
            if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && int.MaxValue % 10 == number))
                return IsNeg ? -int.MaxValue - 1 : int.MaxValue;
            res = res * 10 + (int)Char.GetNumericValue(s[i]);
        }
        return IsNeg ? -res : res;
    }

    public static string ReverseString(char[] s) {
        for (int i = 0; i < s.Length / 2; i++) {
            char tmp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = tmp;
        }
        return new string(s);
    }
    
    public static string ReverseWords(string s) {
        if (String.IsNullOrEmpty(s))
            return s;
        string[] words = s.Split(' ');
        s = "";
        
        for (int i = 0; i < words.Length; i++) {
            s += ReverseString(words[i].ToCharArray());
            if (i != words.Length - 1)
                s += ' ';
        }
        return s;
    }

    public static int LengthOfLongestSubstring(string s) {
        if (String.IsNullOrEmpty(s))
            return 0;
        int count = 0;
        HashSet<char> hashMap = new HashSet<char>();
        
        for (int i = 0; i < s.Length; i++) {
            int tmp = 0;
            for (int j = i; j < s.Length && !hashMap.TryGetValue(s[j], out char _); j++) {
                hashMap.Add(s[j]);
                tmp++;
            }
            hashMap.Clear();
            if (tmp > count)
                count = tmp;
        }
        return count;
    }
}