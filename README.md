A BepInEx plugin that makes unity apps manage their memory more tightly,

it works by telling the OS every 200ms that the process needs at least 256kb of memory, instead of letting the minimum memory grow out of control

Make sure to install bepinex first,
To install drop the dll in "your game"\BepInEx\plugins
Heres the download link to the dll:

Version thats lighter on CPU usage (cleanup every 2000ms):
https://github.com/naxaras/BepInAgressiveGC/blob/c98e74a8541187404693f513441aa55fa38c013e/BepInAgressiveGCLite.zip

Version that uses more CPU for more frequent memory cleanup (cleanup every 200ms)
https://github.com/naxaras/BepInAgressiveGC/blob/68ab5a6d0444c291b81ac37e425e4c821774dde3/BepInAgressiveGC.zip
