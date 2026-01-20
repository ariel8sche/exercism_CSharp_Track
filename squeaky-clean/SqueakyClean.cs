using System.Text;
using System.Globalization;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("");

        for (int i=0; i < identifier.Length;i++)
        {
            char c = identifier[i];

            if (c == ' ')
            {
                sb.Append('_');
            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            else if (c == '-'){
                sb.Append(char.ToUpper(identifier[i+1],CultureInfo.CreateSpecificCulture("en-US")));
                i++;
            }
            else if (char.IsLetter(c))
            {
                if (c >= 'α' && c <= 'ω')
                {
                   
                }
                else
                {
                    sb.Append(c);
                }
            }

        }

        return sb.ToString();
    }
}
