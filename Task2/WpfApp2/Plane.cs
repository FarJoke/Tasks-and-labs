namespace WpfApp2;

public class Plane : Aircraft
{
    public double RunwayLength { get; set; }

    public override bool TakeOff()
    {
        if (RunwayLength > 1000)
        {
            Altitude = 10000;
            OnFlightStatusChanged("Airplane has taken off.");
            return true;
        }
        OnFlightStatusChanged("Airplane failed to take off.");
        return false;
    }

    public override void Land()
    {
        Altitude = 0;
        OnFlightStatusChanged("Airplane has landed.");
    }
}