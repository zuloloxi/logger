# Logger
A kernel-based keylogger for Windows.

![Logger Logo](https://i.imgur.com/mfjwg4e.png)

## DOWNLOAD

[DOWNLOAD EXE HERE](https://github.com/felipebocolowski/logger/releases/)

**Note:** This software should not be considered as a malware and/or spyware. Please report if it does.

## How to Use

You can either:

A. [Download the executable and run.](https://github.com/felipebocolowski/logger/releases/)

B. Download the source code and compile using the options you'd like.

## Dependencies
For running, you'll need:
* Windows 7 or higher (Tested on Windows 8.1 and Windows 10)
* .NET Framework v4.0

For compiling, you'll need:
* Visual Studio 12 or higher (Compiled with Visual Studio 2015 Community Update 3)
* Windows Form Application Base with .NET Framework v4.0

## How It Works

This software uses .NET Framework v4.0 to interact with `user32.dll` and `kernel32.dll` from `System` library and intercept all keys pressed by the input user and saving all the output to `log.txt` within the application path.

Since 1.3.0.0, Logger is shown at the system tray, to hide it, start it passing the `-s` parameter (`"Logger.exe" -s`).

## Updates
###1.0.0.0
* First release.
* New logo.

###1.2.0.0
* Less code, better RAM usage.
* Added a blank space after each capture.

###1.3.0.0
* Better instace.
* NEW! System tray icon.
* NEW! Stealth mode passed by "-s" parameter.

## License

This is a free and open source software. As my personal project, you are able to copy and distribute, but not to modify it.

For any concerns, critics, ideas and more, contact me at [felipebocolowski@outlook.com.br](mailto:felipebocolowski@outlook.com.br).

[GNU GENERAL PUBLIC LICENSE](https://github.com/felipebocolowski/logger/blob/master/LICENSE/)

Thanks for reading and downloading! :)
Please share and contact for contributing.