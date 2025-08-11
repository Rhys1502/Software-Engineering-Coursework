using StarterApp.ViewModels;

namespace StarterApp.Views;

public partial class AdminDashboardPage : ContentPage
{
    public AdminDashboardPage()
    {
        InitializeComponent();
        BindingContext = new AdminDashboardViewModel();
    }
}
