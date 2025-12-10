using Foundation;
using Microsoft.Maui;
using TodoMauiMacApp;

namespace ToDoList;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}