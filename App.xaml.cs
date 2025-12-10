using Microsoft.Maui.Controls;
using TodoMauiMacApp.ViewModels;

namespace TodoMauiMacApp;

public partial class App : Application
{
    public App(TodoListViewModel vm)
    {
        InitializeComponent();
        MainPage = new NavigationPage(new Views.MainPage()) { BindingContext = vm };
    }
}