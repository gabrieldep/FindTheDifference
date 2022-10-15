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
        int sizeS = s.Length;
        int sizeT = t.Length;
        for (int i = 0; i < sizeS; i++)
        {
            for (int j = 0; j < sizeT; j++)
            {
                if (s[i] == t[j])
                {
                    t = t.Remove(j, 1);
                    sizeT--;
                    break;
                }
            }
        }
        return t[0];
    }
}