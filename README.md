# How-to-set-Office2019-theme-to-WF-RibbonControlAdv
You can set the Office2019 theme for WinForms RibbonControlAdv using ThemeName property in and load the respective assembly in Program class. Theme Assembly needs to be loaded before the theme is set.

# C#
    //Loading theme assembly
    SkinManager.LoadAssembly(typeof(Syncfusion.WinForms.Themes.Office2019Theme).Assembly);
    
 For more details please refer [How to set Office2019 theme in RibbonControlAdv](https://www.syncfusion.com/kb/12156/how-to-set-office2019-theme-to-winforms-ribboncontroladv).

![Office2019 Theme](Ribbon_Office2019Theme/Image/Office2019%20Theme.png)

