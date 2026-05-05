using Microsoft.Maui.Controls;

namespace AnnuaireEntreprise;

public partial class App : Application
{
    public App(AppShell appShell)
    {
        InitializeComponent();
        MainPage = appShell;
    }
}
