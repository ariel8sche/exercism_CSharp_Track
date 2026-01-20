class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _battery;
    private int _distance_driven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
        _distance_driven = 0;
    } 

    public bool BatteryDrained()
    {
        return _battery < _batteryDrain;
    }

    public int DistanceDriven()
    {
        return _distance_driven;
    }

    public void Drive()
    {
        if (_batteryDrain <= _battery) {
            _distance_driven += _speed;
            _battery -= _batteryDrain;
        } 
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < _distance && !car.BatteryDrained())
        {
            car.Drive();
        }

        return !car.BatteryDrained() || (car.DistanceDriven() == _distance);
    }
}
