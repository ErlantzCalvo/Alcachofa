# Alcachofa
YouTube video and audio downloader csharp made.

Friendly program to download videos or music from YouTube. This application has only 3 buttons to do it easier to use:
1) Download video: After you put the Youtube video link in the text box, press this button and the video will start downloading.
2) Download audio: After you put the Youtube video link in the text box, press this button to download the audio of the video and convert it to mp3 file.
3) Choose folder: Press this button to choose the folder where you want to download your video/audio file (the default folder is the user's desktop).

<strong>Since version 1.0.2 you can download Playlists!</strong>
<p align="center">
  <img src="https://i.imgur.com/TOxmoLO.jpg" alt="Alcachofa main screen">
</p>

# Translations
This program is translated into Spanish and English.

<p align="center">
  <img src="https://i.imgur.com/12vxfhi.jpg" alt="Languages">
</p>

# Run the program

1) Download this repo (the binaries).<br>
2) Compile. This program has some exernal libraries you have to download:
<li><ul> <a href="https://www.nuget.org/packages/MediaToolkit/1.0.0.3">MediaToolKit</a></ul>
  <ul><a href="https://github.com/hig-dev/libvideo.git">libvideo</a></ul>
  <ul><a href="https://www.newtonsoft.com/json">Newtonsoft</a></ul>
</li>

3) Run the program!

##### Download dependencies with the NuGet package manager
To download depencencies directly to your Visual Studio project, open the NuGet console which you can open through <b>Tools --> NuGet Package manager</b>. Then write the next commands:
```
$ Install-Package MediaToolkit -version 1.0.0.3
$ Install-Package VideoLibrary -Version 2.0.0
$ Install-Package Newtonsoft.Json -Version 11.0.2
```


# License
GNU © [Erlantz Calvo](https://github.com/ErlantzCalvo)
