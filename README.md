# WinForms Targets for NLog [![AppVeyor][appveyor-img]][appveyor-url] [![NuGet][nuget-img]][nuget-url] [![Discord][discord-img]][discord-url]

This is a simple library for .NET Framework 3.5 and higher that adds NLog Targets for System.Windows.Forms controls. It was created to make them a library instead of a couple of snippets that I had lying around.

The NLog Targets available are:

* `Lemon.NLog.WinForms.TextBoxTarget` for `System.Windows.Forms.TextBox`
* `Lemon.NLog.WinForms.ToolStripStatusLabelTarget` for `System.Windows.Forms.ToolStripStatusLabel`

All of the targets with the exception of `TextBoxTarget` have no settings that can be changed.

On `TextBoxTarget`, you can change the following properties:

* AddNewLine: If a new line character should be added at the end of the message (uses `Environment.NewLine`)
* Append: If the text should be appended instead of replaced

[appveyor-img]: https://img.shields.io/appveyor/ci/justalemon/lemon-nlog-winforms.svg?label=appveyor
[appveyor-url]: https://ci.appveyor.com/project/justalemon/lemon-nlog-winforms
[nuget-img]: https://img.shields.io/nuget/v/Lemon.NLog.WinForms?label=nuget
[nuget-url]: https://www.nuget.org/packages/Lemon.NLog.WinForms/
[discord-img]: https://img.shields.io/badge/discord-join-7289DA.svg
[discord-url]: https://discord.gg/Cf6sspj
