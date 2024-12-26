using System;
using BepInEx;
using System.Threading;
using System.Diagnostics;

namespace BepInAgressiveGC
{
    [BepInPlugin("org.bepinex.plugins.agressivegcplugin", "Agressive GC Plug-in", "1.0.0.0")]
    public class AgressiveGCPlugin : BaseUnityPlugin
    {
        private Timer _timer;

        void Awake()
        {
            //tell the OS every 200ms that this process needs at least 256kb memory
            _timer = new Timer(
                (object o) =>
                {
                    Process prs = Process.GetCurrentProcess();
                    prs.MinWorkingSet = (IntPtr)(1 << 18);
                },
            null, 0, 2000);
        }
    }
}
