A BepInEx plugin that makes unity apps manage their memory more tightly,

it works by telling the OS every 200ms that the process needs at least 256kb of memory, instead of letting the minimum memory grow out of control

Make sure to install bepinex first,
To install drop the dll in "your game"\BepInEx\plugins
Heres the download link to the dll:
https://github.com/naxaras/BepInAgressiveGC/blob/9bd2ee7526af950c61be465d0a7089edf9c9cee4/BepInAgressiveGC.zip

Version thats lighter on CPU usage:
https://github.com/naxaras/BepInAgressiveGC/blob/c98e74a8541187404693f513441aa55fa38c013e/BepInAgressiveGCLite.zip
