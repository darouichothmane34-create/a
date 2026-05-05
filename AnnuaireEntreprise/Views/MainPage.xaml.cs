using AnnuaireEntreprise.ViewModels;
using Microsoft.Maui.Controls;

namespace AnnuaireEntreprise.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
