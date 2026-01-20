static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return DateTime.Now > appointmentDate;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        string description = "You have an appointment on ";
        return description + appointmentDate.ToString() + ".";
    }

    public static DateTime AnniversaryDate()
    {

        int actualYear = DateTime.Now.Year;
        return new DateTime(actualYear, 9, 15, 0, 0, 0);
    }
}
