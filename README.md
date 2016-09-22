# logger
A kernel based keylogger.

![Logger Task Manager](https://i.imgur.com/N0JWyxL.png)

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
* Windows Form Application (.NET Framework v4.0)
* Reference System
* Reference System.Core
* Reference Microsoft.CSharp
* Reference System.Deployment
* Reference System.Drawing
* Reference System.Windows.Forms

## How It Works

This software uses .NET Framework v4.0 to interact with `user32.dll` and `kernel32.dll` from `System` library and intercept all keys pressed by the input user and saving all the output to `log.txt` within the application path.

## Updates
###1.0.0.0
* First release.
* New logo.

###1.2.0.0
* Less code, better RAM usage.
* Added a blank space after each capture.

## License

This is a free and open source software. As my personal project, you are able to copy and distribute, but not to modify it.

For any concerns, critics, ideas and more, contact me at [felipebocolowski@outlook.com.br](mailto:felipebocolowski@outlook.com.br).

[GNU GENERAL PUBLIC LICENSE](https://github.com/felipebocolowski/logger/blob/master/LICENSE/)

Thanks for reading and downloading! :)
