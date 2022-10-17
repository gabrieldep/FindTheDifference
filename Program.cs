class Program
{
    static void Main()
    {
        Console.WriteLine(GetChar("abcd", "ceadb"));
        Console.WriteLine(GetChar("abbdd", "dabadb"));
        Console.WriteLine(GetChar("", "y"));
        Console.WriteLine(GetChar("aaaa", "aabaa"));
        Console.WriteLine(GetChar("ae", "aabaa"));
    }

    internal static char GetChar(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
            for (int j = 0; j < t.Length; j++)
                if (s[i] == t[j])
                {
                    t = t.Remove(j, 1);
                    break;
                }
        return t[0];
    }
}