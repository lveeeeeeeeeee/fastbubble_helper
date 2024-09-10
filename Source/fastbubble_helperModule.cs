using System;

namespace Celeste.Mod.fastbubble_helper;

public class fastbubble_helperModule : EverestModule {
    public static fastbubble_helperModule Instance { get; private set; }

    public override Type SettingsType => typeof(fastbubble_helperModuleSettings);
    public static fastbubble_helperModuleSettings Settings => (fastbubble_helperModuleSettings) Instance._Settings;

    public override Type SessionType => typeof(fastbubble_helperModuleSession);
    public static fastbubble_helperModuleSession Session => (fastbubble_helperModuleSession) Instance._Session;

    public override Type SaveDataType => typeof(fastbubble_helperModuleSaveData);
    public static fastbubble_helperModuleSaveData SaveData => (fastbubble_helperModuleSaveData) Instance._SaveData;

    public fastbubble_helperModule() {
        Instance = this;
#if DEBUG
        // debug builds use verbose logging
        Logger.SetLogLevel(nameof(fastbubble_helperModule), LogLevel.Verbose);
#else
        // release builds use info logging to reduce spam in log files
        Logger.SetLogLevel(nameof(fastbubble_helperModule), LogLevel.Info);
#endif
    }

    public override void Load() {
        // TODO: apply any hooks that should always be active
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}