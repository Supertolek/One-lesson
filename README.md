# One-lesson

One Lesson is an app to store and edit course sheets.  
[One Lesson WebSite](https://supertolek.github.io/One-lesson/)  
I will soon release a functionnal version of the One Lesson application.  
[bug report / recommend features / show your hype](https://forms.gle/s9gmoJmgTwSaUUyA9)  
[discord](https://discord.gg/JffuMqubE7)  
My email adress: supertolekmc@gmail.com

## Why?

I first decided to create this application beacause of a video from the YouTuber [Aywen](https://youtube.com/@AywenVideos).  
He gave us the ability to remix and createe a whole new version of his own programms, and I chose [Remember](https://github.com/Aywen1/remember).  
[Remember](https://github.com/Aywen1/remember) was my choice because when i create a programm, I wannt it to be the most usefull for everyone, and this one could help some students looking for a free, open-source and distraction-free service for writing their lessons.

## How?

I might explain later, right now i don't have that much time.

## For who?

[One Lesson](https://github.com/Supertolek/One-lesson) is for students who want a pretty simple, yet complete application for writing their notes or their lessons.

## Credits

Credits to:  
| Username / name                             | Reason                     |
|---------------------------------------------|----------------------------|
| [Aywen](https://youtube.com/@AywenVideos)   | For the initial idea       |
| [Supertolek](https://github.com/Supertolek) | For coding the application |
| LMC                                         | Later...                   |

---

## Features / Bug fixes comming

| State | Type | Description |
| ----- | ---- | ----------- |
| 🟩 Solved   | 🔴 Bug     | Fix saving as .rtf `olb.0001` |
| 🟥 Unsolved | 🔴 Bug     | Fix colors when saved from dark mode `olb.0002` |
| 🟩 Solved   | 🔴 Bug     | 🌐 Issues between tabview / titlebar `olb.0003` |
| 🟩 Solved   | 🔴 Bug     | RichEditBox height doesn't automaticaly adapt when opening a file `olb.0004` |
| 🟥 Unsolved | 🔵 Deploy  | Create website `old.001` |
| 🟥 Unsolved | 🔵 Deploy  | Create installer `old.002` |
| 🟩 Solved   | 🟢 Feature | Add icon to .olf files `ola.0001` |
| 🟥 Unsolved | 🟢 Feature | Text formating options `ola.0002` |
| 🟥 Unsolved | 🟢 Feature | Tabs system `ola.0003` |
| 🟩 Solved   | 🟢 Feature | 🌐 Keyboard accelerators `ola.0004` |
| 🟥 Unsolved | 🟢 Feature | Pseudo-ai for multiple usages `ola.0005` |
| 🟥 Unsolved | 🟢 Feature | A menu to change keybinds `ola.0006` |
| 🟥 Unsolved | 🟢 Feature | A mind map designer `ola.0007` |

🌐: used an answer from internet (stack overflow for example)

## Bugs

### 🟩 Fix saving as .rtf `olb.0001`

**Description:**  
When saving a file with .rtf extension, the file won't be saved.

**Patch:**  
I check if the file extension is correct, but only .olf is considered as correct.

### 🟥 Fix colors when saved from dark mode `olb.0002`

**Description:**  
When saving using One Lesson with dark mode, the text is saved as white.

### 🟩 🌐 Issues between tabview / titlebar `olb.0003`

**Description:**  
Cannot interact with the tab bar because of the titlebar.

**Patch:**
Using the Footer only as titlebar. (cannot longer interact with the footer, but there is nothing on it to interact with)

MainWindow.xaml:
```xaml
<TabView>
    <TabView.TabStripHeader>
        <Grid x:Name="ShellTitlebarInset" Background="Transparent"/>
    </TabView.TabStripHeader>
    <TabView.TabStripFooter>
        <Grid x:Name="CustomDragRegion" Background="Transparent" MinWidth="188"/>
    </TabView.TabStripFooter>
    <...>
    </...>
</TabView>
```
MainWindow.xaml.cs:
```cs
namespace One_Lesson
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetTitleBar(CustomDragRegion);
            ExtendsContentIntoTitleBar = true;
        }
        ...
    }
}
```

🌐: from stack overflow

## Deploy

### 🟥 Create website `old.001`

**Description:**
- 🟥 Add a download source `old.001.1`
- 🟥 Add pages `old.001.2`
- 🟥 Make it reesponsive `old.001.3`

### 🟥 Create installer `old.002`

**Description:**
- 🟥 Add a download source `old.001.1`
- 🟥 Create the installer `old.002.1`

## Features

### 🟩 Add icon to .olf files `ola.0001`

**Description:**  
The application have icons, but not the files.

**Patch:**  
I added more images using the toll included in visual studio.

### 🟥 Text formating options `ola.0002`

**Description:**  
Add more options for formating text (eg. color, size...)

### 🟥 Tabs system `ola.0003`

**Description:**  
Make the tab bar usefull (store the document, title etc... in a variable in order to re-open the document when you open the tab)

### 🟩 🌐 Keyboard accelerators `ola.0004`

**Description:**  
Add keyboard shortcuts to increase the productivity.

**Patch:**  
Add functions for the keyboard shortcut and add them into the element.

MainWindow.xaml:
```xaml
<MenuBar x:Name="MenuBarContainer">
    <MenuBarItem>
        <MenuFlyoutItem>
            <MenuFlyoutItem.KeyboardAccelerators>
                <KeyboardAccelerator Modifiers="Control" Key="O"/>
            </MenuFlyoutItem.KeyboardAccelerators>
        </MenuFlyoutItem>
        <MenuFlyoutItem>
            <MenuFlyoutItem.KeyboardAccelerators>
                <KeyboardAccelerator Modifiers="Control" Key="S"/>
            </MenuFlyoutItem.KeyboardAccelerators>
        </MenuFlyoutItem>
    </MenuBarItem>
    <...></...>
</MenuBar>
```

🌐: winui 3 gallery

### 🟥 Pseudo-ai for multiple usages `ola.0005`

**Description:**  
I will try to create a language parser. I will use it to resume automatically the lesson, create quiz to memorize the lesson etc...  
It might take a while, so if you have an idea, tell me. (and I already know [NLTK](https://www.nltk.org), but it doesn't work as i want and have no implementation for winui at my knowledge)

## Contact

### Dev (main)

[✉️ Email : supertolekmc@gmail.com](mailto:supertolekmc@gmail.com)  
🟣 Discord : @supertolek

### Personal (if urgent)

**⚠️ Please use this email adress only with an important reason.**  
[✉️ Email : lequereth@gmail.com](mailto:lequereth@gmail.com)  
🟣 Discord : @thomaslequere

### Discord server

[🟣 Discord server (invitation id: FZx4c528jY)](https://discord.gg/FZx4c528jY)
