using System.Threading;
using FirLib.Core.Infrastructure;
using FirLib.Core.Patterns.Messaging;

namespace FirLib.Core;

internal static class FirLibExtensionsAvalonia
{
    internal static FirLibApplicationLoader AttachToAvaloniaEnvironment(this FirLibApplicationLoader loader)
    {
        var uiMessenger = new FirLibMessenger();

        loader.AddLoadAction(() =>
        {
            uiMessenger.ConnectToGlobalMessaging(
                FirLibMessengerThreadingBehavior.EnsureMainSyncContextOnSyncCalls,
                FirLibConstants.MESSENGER_NAME_GUI,
                SynchronizationContext.Current);
        });
        loader.AddUnloadAction(() =>
        {
            uiMessenger.DisconnectFromGlobalMessaging();
        });
            
        return loader;
    }
}