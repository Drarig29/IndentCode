# IndentCode

## Description

This is an **easy VB.NET tool to increase code indentation** for **StackOverflow**.

Initially, I made it for me, but I'll share it.<br>

It serves to **increase your code indentation by 4 spaces** when you are **writing a question or an answer**, to create **code blocks or other preformatted text**.

**Like the following:**

```vb
Public Class Form1

  Dim WithEvents Class1 As New Class1

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Class1.OnTimeExpired("Your time has run out")
  End Sub

End Class
```

On startup, the application will **automatically load the text contained in the Clipboard**.

# A little tip!

If you like [this tool](https://raw.githubusercontent.com/Drarig29/IndentCode/master/IndentCode/bin/Release/IndentCode.exe), you can **add it as external tool in Visual Studio** :

* In the Tools menu, click "External Tools...",
* Click "Add",
* In the Title box, type for example "&Indent the code for StackOverflow",
* In the Command box, browse to the previously downloaded tool,
* Click OK, then the tool is added to External Tools.
