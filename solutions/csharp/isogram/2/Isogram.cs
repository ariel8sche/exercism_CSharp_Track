public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var letters = word
        .ToLowerInvariant()
        .Where(char.IsLetter);

        return letters.Count() == new HashSet<char>(letters).Count;
    }
}
