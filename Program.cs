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
        {
            int index = t.IndexOf(s[i]);
            if (index == -1)
                return s[i];
            t = t.Remove(index, 1);
        }
        return t[0];
    }
}