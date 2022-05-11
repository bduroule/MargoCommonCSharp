namespace AlgorithmAndDataStruct;
public class Class1
{
    public static bool AreAnagrams(string s1, string s2)
    {
        Dictionary<char, int> code = new Dictionary<char, int>();

        foreach (var elem in s2) {
            if (code.TryGetValue(elem, out int count))
                code[elem]++;
            else
                code.Add(elem, 0);
        }
        foreach (var elem in s1) {
            if (code.TryGetValue(elem, out int count)) {
                code[elem]--;
                if (code[elem] == 0)
                    code.Remove(elem);
            }
            else
                return false;
        }
        return code.Count == 0;
    }
}
