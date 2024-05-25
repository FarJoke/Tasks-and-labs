namespace WpfApp2;

public abstract class Aircraft
{
    public double Altitude { get; set; }
    public abstract bool TakeOff();
    public abstract void Land();

    public event EventHandler<string> FlightStatusChanged;

    protected void OnFlightStatusChanged(string status)
    {
        FlightStatusChanged?.Invoke(this, status);
    }
}