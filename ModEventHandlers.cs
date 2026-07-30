using Bark.Event;
using Bark.Events;
using Bark.Tool;

namespace Quantum;

[EventBusSubscriber(Plugin.Guid)]
public class ModEventHandlers
{
    private static bool _updateChecked;

    public static void OnMainMenuLoaded(MainMenuLoadedEvent _)
    {
        if (_updateChecked)
            return;
        UpdateUtil.Check("CNCUMC/Quantum", Plugin.Name, Plugin.Version, Plugin.Logger);
        _updateChecked = true;
    }
}