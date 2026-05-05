using CommunityToolkit.Mvvm.ComponentModel;

namespace AnnuaireEntreprise.ViewModels;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    public partial bool EstOccupe { get; set; }

    [ObservableProperty]
    public partial string Titre { get; set; } = string.Empty;
}
