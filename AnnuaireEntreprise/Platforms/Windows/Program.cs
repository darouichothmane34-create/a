using Microsoft.UI.Xaml;

namespace AnnuaireEntreprise.WinUI;

public static class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Application.Start(_ =>
        {
            var context = new DispatcherQueueSynchronizationContext(Microsoft.UI.Dispatching.DispatcherQueue.GetForCurrentThread());
            SynchronizationContext.SetSynchronizationContext(context);
            _ = new App();
        });
    }
}
