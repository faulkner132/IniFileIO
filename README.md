# IniFileIO
.NET object class for handling creation, reading, and writing of INI Files.

Features:
- Full read/write/creation support.
- Easy to use: most operations can be done with a single line of code.
- Supports comments at the section and key level.
- Supports implied and manual ordering of sections and keys.
- Full intellisense comments included.

_Important Notice_

The save operation will refactor existing INI files according to the object's style logic (which should be pretty standard).



## Usage Example

Assuming the following contents for "MyFile.ini".

```ini
[Section 1]
Key1=This value
Key2=That value

[Section 2]
Key1=Section key
Another key=Here
```

### Sample in VB.NET

```vb.net
Dim iniTest As New IniFileIO.IniFile("MyFile.ini")

With iniTest

    ' value1 is set to 'This value'.
    Dim value1 As String = .GetKeyValue("Section 1", "Key1")

    ' value2 is set to 'That value'.
    Dim value2 As String = .GetKeyValue("Section 1", "Key2",
                                        defaultValue:="n/a")

    ' value3 is set to 'n/a'.
    Dim value3 As String = .GetKeyValue("Section 1", "Key3",
                                        defaultValue:="n/a")

    If value3 = "n/a" Then
        value3 = "This and That value"
    End If

    .SetKeyData("Section 1", "Key2",
                value:=value2 & "-updated")

    ' Default behavior is to create if the path doesn't exist.
    ' 'Key3' will be added to 'Section 1'.
    .SetKeyData("Section 1", "Key3",
                value:=value3)


    ' 'Key3' does not exist in 'Section 2' and the option to
    ' automatically create is disabled.
    .SetKeyData("Section 2", "Key3",
                value:="Will not be created.",
                createIfNotExist:=False)


    ' 'New Section' and the specified keys will be created.
    .SetKeyData("New Section", "New Key 1",
                value:="Created key 1",
                comments:="This key did not previously exist.")

    .SetKeyData("New Section", "New Key 2",
                value:="Created key 2",
                comments:="This key didn't exist either.")

    ' Update the comments on the newly created section.
    .SetSectionData("New Section",
                    comments:="This section was created on the fly.")

    ' Push all changes.
    .SaveFile()

End With
```

New contents of "MyFile.ini".

```ini
[Section 1]
Key1=This value
Key2=That value-updated
Key3=This and That value


[Section 2]
Key1=Section key
Another key=Here


; This section was created on the fly.
[New Section]

; This key did not previously exist.
New Key 1=Created key 1

; This key didn't exist either.
New Key 2=Created key 2
```