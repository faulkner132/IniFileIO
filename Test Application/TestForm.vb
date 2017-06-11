Imports IniFileIO

Public Class TestForm

    Private iniTest As IniFile


    Private Sub TestForm_Load() Handles MyBase.Load
        Me.Text = My.Application.Info.Title
        FileNameTextBox.Text = My.Application.Info.DirectoryPath & "\Test.ini"
        LoadFromFileButton_Click()
    End Sub


    Private Sub LoadFromFileButton_Click() Handles LoadFromFileButton.Click
        iniTest = New IniFile(FileNameTextBox.Text,
                              keyNameWhitespaceLiteral:=KeyNameWhitespaceLiteralCheckBox.Checked,
                              keyValueWhitespaceLiteral:=KeyValueWhitespaceLiteralCheckBox.Checked)

        If My.Computer.FileSystem.FileExists(FileNameTextBox.Text) Then
            ContentsTextBox.Text = My.Computer.FileSystem.ReadAllText(FileNameTextBox.Text)
        Else
            ContentsTextBox.Text = "< File Does Not Exist >"
        End If
    End Sub


    Private Sub LoadFromTextButton_Click(sender As Object, e As EventArgs) Handles LoadFromTextButton.Click
        iniTest = IniFile.CreateFromString(ContentsTextBox.Text)
        NewFileTextBox.Text = iniTest.FileName
    End Sub

    Private Sub SaveButton_Click() Handles SaveButton.Click
        My.Computer.FileSystem.WriteAllText(FileNameTextBox.Text, ContentsTextBox.Text, False)
        LoadFromFileButton_Click()
    End Sub


    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles _
        AddSectionButton.Click, AddKeyButton.Click,
        EditSectionButton.Click, EditKeyButton.Click,
        DeleteSectionButton.Click, DeleteKeyButton.Click

        Using objectData As New AddObjectForm(iniTest, sender.Text)
            With objectData

                Dim hideControls As New List(Of Control)

                ' Hide any unneeded controls.
                Select Case sender.Name

                    Case AddSectionButton.Name, EditSectionButton.Name
                        hideControls.AddRange({.KeyNameLabel, .KeyNameComboBox,
                                               .ValueLabel, .ValueTextBox})

                        If sender.Name = AddSectionButton.Name Then
                            hideControls.Add(.CreateIfNotExistCheckBox)
                        End If

                    Case AddKeyButton.Name
                        hideControls.AddRange({.CreateIfNotExistCheckBox})

                    Case DeleteSectionButton.Name
                        hideControls.AddRange({.KeyNameLabel, .KeyNameComboBox,
                                               .ValueLabel, .ValueTextBox,
                                               .OrderLabel, .OrderTextBox,
                                               .CommentsLabel, .CommentsTextBox,
                                               .CreateIfNotExistCheckBox})

                    Case DeleteKeyButton.Name
                        hideControls.AddRange({.ValueLabel, .ValueTextBox,
                                               .OrderLabel, .OrderTextBox,
                                               .CommentsLabel, .CommentsTextBox,
                                               .CreateIfNotExistCheckBox})

                End Select


                For Each hideControl As Control In hideControls
                    hideControl.Visible = False
                Next



                If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

                    Dim sectionName As String = .SectionNameComboBox.Text
                    Dim keyName As String = .KeyNameComboBox.Text
                    Dim value As String = .ValueTextBox.Text
                    Dim comments As String = .CommentsTextBox.Text
                    Dim order As Integer = If(.OrderTextBox.Text = "",
                                              Integer.MaxValue, .OrderTextBox.Text)
                    Dim createIfNotExist As Boolean = .CreateIfNotExistCheckBox.Checked

                    ' Perform action.
                    Select Case sender.Name

                        Case AddSectionButton.Name
                            iniTest.AddSection(sectionName, comments:=comments, order:=order)

                        Case AddKeyButton.Name
                            iniTest.AddKey(sectionName, keyName, value,
                                           comments:=comments, order:=order)

                        Case EditSectionButton.Name
                            iniTest.SetSectionData(sectionName,
                                                   order:=order, comments:=comments,
                                                   createIfNotExist:=createIfNotExist)

                        Case EditKeyButton.Name
                            iniTest.SetKeyData(sectionName, keyName,
                                               value:=value, comments:=comments, order:=order,
                                               createIfNotExist:=createIfNotExist)

                        Case DeleteSectionButton.Name
                            iniTest.DeleteSection(sectionName)

                        Case DeleteKeyButton.Name
                            iniTest.DeleteKey(sectionName, keyName)

                    End Select

                    ' Push changes to the ini file object.
                    iniTest.SaveFile(preserveOrders:=True, reloadAfterSave:=False)
                    LoadFromFileButton_Click()
                End If

            End With
        End Using

    End Sub

End Class
