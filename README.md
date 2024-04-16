# One-lesson

One Lesson is an app to store and edit course sheets.  
[One Lesson WebSite](https://supertolek.github.io/One-lesson/)  
I will soon release a functionnal version of the One Lesson application.

## Why?

I first decided to create this application beacause of a video from the YouTuber [Aywen](https://youtube.com/@AywenVideos).  
He gave us the ability to remix and createe a whole new version of his own programms, and I chose [Remember](https://github.com/Aywen1/remember).  
[Remember](https://github.com/Aywen1/remember) was my choice because when i create a programm, I wannt it to be the most usefull for everyone, and this one could help some students looking for a free, open-source and distraction-free service for writing their lessons.

## How?

I might explain later, right now i don't have that much time.

## For who?

[One Lesson](https://supertolek.github.io) is for students who want a pretty simple, yet complete application for writing their notes or their lessons.

## Credits

Credits to:  
| Username / name                             | Reason                     |
|---------------------------------------------|----------------------------|
| [Aywen](https://youtube.com/@AywenVideos)   | For the initial idea       |
| [Supertolek](https://github.com/Supertolek) | For coding the application |
| LMC                                         | Later...                   |

## Features / Bug fixes comming

| State | Type | Description |
| ----- | ---- | ----------- |
| 🟩 Solved   | 🔴 Bug     | Fix saving as .rtf `olb.0001` |
| 🟥 Unsolved | 🔴 Bug     | Fix colors when saved from dark mode `olb.0002` |
| 🟩 Solved   | 🔴 Bug     | 🌐 Issues between tabview / titlebar `olb.0003` |
| 🟥 Unsolved | 🔵 Deploy  | Create website `old.001` |
| 🟥 Unsolved | 🔵 Deploy  | Create installer `old.002` |
| 🟩 Solved   | 🟢 Feature | Add icon to .olf files `ola.0001` |
| 🟥 Unsolved | 🟢 Feature | Text formating options `ola.0002` |
| 🟥 Unsolved | 🟢 Feature | Tabs system `ola.0003` |
| 🟩 Solved   | 🟢 Feature | 🌐 Keyboard accelerators `ola.0004` |

🌐: used an answer from internet (stack overflow for example)

## Bugs

### Fix saving as .rtf `olb.0001`

**Description:**  
When saving a file with .rtf extension, the file won't be saved.

**Patch:**  
I check if the file extension is correct, but only .olf is considered as correct.

### Fix colors when saved from dark mode `olb.0002`

**Description:**  
When saving using One Lesson with dark mode, the text is saved as white.

### 🌐 Issues between tabview / titlebar `olb.0003`

**Description:**  
Cannot interact with the tab bar because of the titlebar.

**Patch:**
Using the Footer only as titlebar. (cannot longer interact with the footer, but there is nothing on it to interact with)

🌐: from stack overflow

## Deploy

### Create website `old.001`

**Description:**
- 🟥 Add a download source `old.001.1`
- 🟥 Add pages `old.001.2`
- 🟥 Make it reesponsive `old.001.3`

### Create installer `old.002`

**Description:**
- 🟥 Add a download source `old.001.1`
- 🟥 Create the installer `old.002.1`

## Features

### Add icon to .olf files `ola.0001`

**Description:**  
The application have icons, but not the files.

**Patch:**  
I added more images using the toll included in visual studio.

### Text formating options `ola.0002`

**Description:**  
Add more options for formating text (eg. color, size...)

### Tabs system `ola.0003`

**Description:**  
Make the tab bar usefull (store the document, title etc... in a variable in order to re-open the document when you open the tab)

### 🌐 Keyboard accelerators `ola.0004`

**Description:**  
Add keyboard shortcuts to increase the productivity.

**Patch:**  
Add functions for the keyboard shortcut and add them into the element.

🌐: winui 3 gallery
