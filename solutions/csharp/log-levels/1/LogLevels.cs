static class LogLine
{
    public static string Message(string logLine)
    {
        if (logLine.Contains("INFO"))
        {
            return logLine.Substring(7).Trim();
        }
        else if (logLine.Contains("WARNING"))
        {
            return logLine.Substring(10).Trim();
        }
        else if (logLine.Contains("ERROR"))
        {
            return logLine.Substring(8).Trim();
        }
        else
        {
            return "";
        }
    }

    public static string LogLevel(string logLine)
    {
        if (logLine.Contains("INFO"))
        {
            return "info";
        }
        else if (logLine.Contains("WARNING"))
        {
            return "warning";
        }
        else if (logLine.Contains("ERROR"))
        {
            return "error";
        }
        else
        {
            return "";
        }
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
