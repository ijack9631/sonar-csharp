Imports System
Imports System.IO

Namespace Tests.Diagnostics
    Class Program
        Private Sub InvalidCases(s1 As String, s2 As String)
            Dim fileLiteral = "file://blah.txt" ' Noncompliant {{Refactor your code not to use hardcoded absolute paths or URIs.}}
'                             ^^^^^^^^^^^^^^^^^
            Dim webUri1 = "http://www.mywebsite.com" ' Noncompliant
            Dim webUri2 = "https://www.mywebsite.com" ' Noncompliant
            Dim webUri3 = "ftp://www.mywebsite.com" ' Noncompliant
            Dim windowsDrivePath1 = "c:\blah\blah\blah.txt" ' Noncompliant
            Dim windowsDrivePath2 = "C:\blah\blah\blah.txt" ' Noncompliant
            Dim windowsDrivePath3 = "C:/blah/blah/blah.txt" ' Noncompliant
            Dim windowsDrivePath4 = "C:\blah\blah\blah.txt" ' Noncompliant
            Dim windowsDrivePath5 = "C:\%foo%\Documents and Settings\file.txt" ' Noncompliant
            Dim windowsSharedDrivePath1 = "\\my-network-drive\folder\file.txt" ' Noncompliant
            Dim windowsSharedDrivePath2 = "\\my-network-drive\Documents and Settings\file.txt" ' Noncompliant
            Dim windowsSharedDrivePath3 = "\\my-network-drive\folder\file.txt" ' Noncompliant
            Dim windowsSharedDrivePath4 = "\\my-network-drive\%foo%\file.txt" ' Noncompliant
            Dim windowsSharedDrivePath5 = "\\my-network-drive/folder/file.txt" ' Noncompliant
            Dim unixPath1 = "/my/other/folder" ' Noncompliant
            Dim unixPath2 = "~/blah/blah/blah.txt" ' Noncompliant
            Dim unixPath3 = "~\blah\blah\blah.txt" ' Noncompliant
            Dim concatWithDelimiterUri2 = s1 & "\" & s2 ' Noncompliant
            Dim concatWithDelimiterUri3 = s1 & "/" & s2 ' Noncompliant
'                                              ^^^
            Dim concatWithDelimiterUri4 = s1 + "\" + s2 ' Noncompliant
            Dim concatWithDelimiterUri5 = s1 + "/" + s2 ' Noncompliant

            Dim x = New Uri("C:/test.txt") ' Noncompliant
            Dim z = New Uri(New Uri("a"), ("C:/test.txt")) ' Noncompliant
            File.OpenRead("\\drive\foo.csv") ' Noncompliant
        End Sub

        Private Sub ValidCases(s As String)
            Dim windowsPathStartingWithVariable = "%AppData%\Adobe"
            Dim windowsPathWithVariable = "%appdata%"

            Dim relativePath1 = "./my/folder"
            Dim relativePath2 = ".\my\folder"
            Dim relativePath3 = "..\..\Documents"
            Dim relativePath4 = "../../Documents"
            Dim file = "file.txt"

            Dim driveLetterPath = "C:"

            Dim concat1 = Convert.ToString(s & Convert.ToString("\")) & s
        End Sub
    End Class
End Namespace
