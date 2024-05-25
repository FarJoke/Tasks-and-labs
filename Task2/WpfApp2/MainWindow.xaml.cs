using System.Windows;


namespace WpfApp2;
    public partial class MainWindow : Window
    {
        private readonly Plane _plane;
        private readonly Helicopter _helicopter;

    public MainWindow()
    {
        InitializeComponent();
        _plane = new Plane { RunwayLength = 1500 };
        _helicopter = new Helicopter();

        _plane.FlightStatusChanged += OnFlightStatusChanged;
        _helicopter.FlightStatusChanged += OnFlightStatusChanged;
    }

    private void OnFlightStatusChanged(object sender, string status)
    {
        StatusTextBlock.Text = status;
    }

    private void PlaneTakeOff_Click(object sender, RoutedEventArgs e)
    {
        _plane.TakeOff();
    }

    private void PlaneLand_Click(object sender, RoutedEventArgs e)
    {
        _plane.Land();
    }

    private void HelicopterTakeOff_Click(object sender, RoutedEventArgs e)
    {
        _helicopter.TakeOff();
    }

    private void HelicopterLand_Click(object sender, RoutedEventArgs e)
    {
        _helicopter.Land();
    }
}