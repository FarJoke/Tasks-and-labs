namespace WpfApp2;

public class Helicopter: Aircraft
{
        public override bool TakeOff()
    {
        Altitude = 5000;
        OnFlightStatusChanged("Helicopter has taken off.");
        return true;
    }

    public override void Land()
    {
        Altitude = 0;
        OnFlightStatusChanged("Helicopter has landed.");
    }
}
