# How to set Office 2019 theme to WinForms RibbonControlAdv

This sample demonstrates how to apply Office 2019 visual styles to the Syncfusion WinForms RibbonControlAdv, hosted inside a RibbonForm. It shows how to switch between Colorful, DarkGray, Black, and White variants at design time or runtime so you can match Microsoft Office 2019’s look-and-feel in your Windows Forms applications.

## Features
- Office 2019 theme variants: Colorful, DarkGray, Black, White
- One-line setup using the ThemeName property on RibbonControlAdv
- Works with RibbonForm, BackStageView, tabs, context tabs, and QAT
- Runtime theme switching with instant UI refresh
- High DPI-aware rendering for crisp visuals
- Optional per-control theming via ThemeName for other Syncfusion Tool controls

## Getting Started
1. Open the solution: Ribbon_Office2019Theme/Ribbon_theme.sln
2. Restore NuGet packages.
3. Ensure the Syncfusion WinForms Tools package is installed:
   - NuGet: Syncfusion.Tools.Windows
4. Build and run the sample.

- Keep theme names consistent across other Syncfusion Tool controls by setting their ThemeName property to the same Office2019 variant.
- For best results, use RibbonForm as your main form base class when hosting RibbonControlAdv.

## About the Sample
This sample is a minimal reference showing how to enable Office 2019 theming on RibbonControlAdv:
- Project: Ribbon_Office2019Theme
- Main form: Form1 (inherits RibbonForm)
- Key line: ribbonControlAdv1.ThemeName = "Office2019Colorful" in Form1.cs

Extend it by wiring a settings menu or backstage option that lets users switch themes at runtime, and by applying the same ThemeName to other Syncfusion WinForms Tool controls in your application for a consistent, modern UI.

