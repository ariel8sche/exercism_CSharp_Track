public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word.ToCharArray().Length == new HashSet<char>(word.ToCharArray()).Count;
    }
}
