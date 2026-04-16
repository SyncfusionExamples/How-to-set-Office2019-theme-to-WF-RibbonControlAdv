# How-to-set-Office2019-theme-to-WF-RibbonControlAdv

This repository contains a sample that shows how to apply an Office 2019 theme to the Syncfusion WinForms RibbonControlAdv. The sample creates a RibbonForm with a RibbonControlAdv that contains multiple tabs and ToolStripEx groups, and then applies the Office 2019 appearance programmatically during form initialization.

In this example, the theme is assigned by setting the `ThemeName` property of the `RibbonControlAdv` to `Office2019Colorful` in the form constructor after `InitializeComponent()` is called. Once the theme is applied, the ribbon uses the Office 2019 visual style across its tabs, menu button, and tool strip items, giving the application a modern Microsoft Office-like look and feel.

The sample ribbon includes Home and View tabs with grouped tool strip items, making it easy to verify the theme change visually. This approach is useful for WinForms applications that use RibbonControlAdv and require a consistent themed user interface without changing the existing ribbon structure or control layout.