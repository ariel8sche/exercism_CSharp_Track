class RemoteControlCar
{

    private int _distance = 0;
    private int _battery = 100;

    public static RemoteControlCar Buy()
    {
        return new();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        switch (_battery)
        {
            case 0:
                return $"Battery empty";
            default:
                return $"Battery at {_battery}%";
        }
        
    }

    public void Drive()
    {
        if (_battery > 0)
        {
            _distance += 20;
            _battery -= 1;   
        }
    }
}
