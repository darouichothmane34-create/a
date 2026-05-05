using CommunityToolkit.Mvvm.ComponentModel;

namespace AnnuaireEntreprise.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    private bool estOccupe;

    [ObservableProperty]
    private string titre = string.Empty;
}
