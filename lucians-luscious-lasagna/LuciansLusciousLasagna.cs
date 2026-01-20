class Lasagna
{
    private int timeInOven;

    public Lasagna()
    {
        this.timeInOven = 40;
    }

    public int ExpectedMinutesInOven()
    {
        return timeInOven;
    }

    public int RemainingMinutesInOven(int actualMinutesInOven)
    {
        return timeInOven-actualMinutesInOven;
    }

    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return 2*numberOfLayers;
    }

    public int ElapsedTimeInMinutes(int numberOfLayers, int time)
    {
        return (numberOfLayers*2 + time);
    }
}
