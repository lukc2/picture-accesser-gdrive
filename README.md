# Picture-Accesser-Gdrive

GUI app to upload, download, resize and access images (gifs too) from personal google drive folder 
Written as uni .NET project and for self usage

* [General Info](#General-Info)
* [Before building](#Before)

## General Info

Uses Google Drive API and OAuth 2.0 v3 (credidentials not included) 

Basically makes folder on your Google Drive where you can upload images, download from and edit stored images (well, only name and resize).

Allows to access files on Google Drive and: 
 - Resize images (gifs too)
 - Copy images as files or thumbnails 
 - Get link to content or thumbnail (useful for posting on Discord for example)
 - Delete images
 - Stay on as try icon for fast access
 - Save size presets for fast resizing
 - Upload multiple files at once (drag&drop too)
 
Backup checkbox makes it save changed images into another folder (on Google Drive of course)

It was uni project so don't expect the cleanest clode, even though was trying to separate it somehow into files
Could be useful for those that need to learn V3 Drive api things, because actually finding how to do those actions was kind of time consuming...

## Before building
API credidentials in folder "Projekt" are necessary to connect to Google Drive
You can get those (as of rn, v3) from 

https://developers.google.com/drive/api/v3/quickstart/dotnet

It's possible to change images folder from withing program of in "config.json" file

### Author
https://github.com/lukc2
