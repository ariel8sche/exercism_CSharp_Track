public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] reversedChars = input.Reverse().ToArray();
        return new string(reversedChars);
    }
}