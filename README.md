# YoutubeMusicLoader
A tiny UI for the "youtube-dl" console app

### What it is:

- It is just a simple UI tool for the "youtube-dl" console app, to download and convert Youtube videos into mp3 files.
- It needs .NET Core 3.1 to run.
- It is developed with Visual Studio 2019 as .NET Core WPF app in C#.

### How to use:

#### Step 1
- Download release and extract contents of zip file into some folder.
- Create a subfolder named "Tools" in that folder.
- Create a subfolder named "Music" in that folder.

#### Step 2
- Download "youtube-dl.exe" (see "youtube-dl" project on GitHub at https://github.com/ytdl-org/youtube-dl).
- Put the "youtube-dl.exe" into the "Tools" folder mentioned above.

#### Step 3
- Download the "ffmpeg" binaries ("ffmpeg.exe" and "ffprobe.exe") from https://www.ffmpeg.org because the "youtube-dl" app needs them to work properly (see project site of "youtube-dl").
- Put them also into the "Tools" folder mentioned above.

#### Step 4
- Make sure you have .NET Core 3.1 installed on your machine.
- Start the program, insert some Youtube link and click the "Download" button.
- You will find your mp3 file in the "Music" subfolder.

#### Step 5
- Have fun.

### License infos:

- This software is made to use the "youtube-dl" console app (https://github.com/ytdl-org/youtube-dl), which is under the "The Unlicense" license.
- Also the "youtube-dl" app needs to use the "ffmpeg" tools (https://ffmpeg.org), which are under the "GNU Lesser General Public License, Version 2.1 (or later)" license.

A big THX to the authors of this nice pieces of software!
