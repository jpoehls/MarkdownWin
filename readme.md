## MarkdownWin

-----------------------------------------------------

*A [Markdown](http://daringfireball.net/projects/markdown/) editor and compiler with live-preview for Windows.*

**Download the binary by tapping [right here](https://github.com/jpoehls/MarkdownWin/raw/master/dist/MarkdownWin.exe).**

I built this because [MarkedApp](http://www.markedapp.com) isn't available for Windows.
Like MarkedApp, MarkdownWin will monitor a file for changes and keep the live preview
in sync with your file. You can use whatever editor you want.

We use [MarkdownSharp](http://code.google.com/p/markdownsharp/) to render the live preview.


### Features

* Preview your Markdown file live, while you edit it.
* Copy the HTML source to your clipboard with `CTRL+C`.
* Print it with `CTRL+P`.
* Float the preview window on top of other applications for easy viewing.
* MarkdownWin also to be used as a Markdown build tool via its simple CLI interface:

		usage -in <inputPath> [-out <outputPath>] [-raw]
	      -in:  Path to the markdown file
	      -out: (Optional) Path to the output html file (uses <in>.html by default)
	      -raw: (Optional) Don't stylize the output.

---------------------------------------------------------

![Screenshot](https://raw.github.com/cynosura/MarkdownWin/master/screenshot.png)

**Dev Requirements**  
VS 2010, NuGet

Run `psake.bat` to build for release and update the `/dist` folder.

**Notes**

*The icon was borrowed without permission from [dashkards.com](http://dashkards.com).*

*ICO created with [converticon.com](http://converticon.com).*