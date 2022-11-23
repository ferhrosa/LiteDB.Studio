using Avalonia.Controls;

namespace LiteDB.Studio.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        // set assembly version on window title
        Title += $" (v{typeof(MainWindow).Assembly.GetName().Version})";
    }
}
