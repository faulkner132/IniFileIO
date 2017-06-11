Imports IniFileIO

Public Class AddObjectForm

    Private iniTest As IniFile


    Public Sub New(iniFile As IniFile, formTitle As String)
        InitializeComponent()

        Me.Text = formTitle
        iniTest = iniFile

        For Each section As IniFile.Section In iniTest.GetAllSections
            SectionNameComboBox.Items.Add(section.Name)
        Next

        UpdateInfoStatus()

    End Sub

    Private Sub SectionNameComboBox_Changed() Handles SectionNameComboBox.SelectedIndexChanged, SectionNameComboBox.TextChanged

        KeyNameComboBox.Items.Clear()
        OrderTextBox.Text = ""
        CommentsTextBox.Text = ""

        Dim sectionName As String = SectionNameComboBox.Text

        If iniTest.SectionNameExists(sectionName) Then

            If KeyNameComboBox.Visible Then
                For Each key As IniFile.Key In iniTest.GetSectionKeys(sectionName)
                    KeyNameComboBox.Items.Add(key.Name)
                Next

            Else
                OrderTextBox.Text = iniTest.GetSectionOrder(sectionName)
                CommentsTextBox.Text = iniTest.GetSectionComments(sectionName)
            End If

        End If

        UpdateInfoStatus()

    End Sub

    Private Sub KeyNameComboBox_Changed() Handles KeyNameComboBox.SelectedIndexChanged, KeyNameComboBox.TextChanged

        ValueTextBox.Text = ""
        OrderTextBox.Text = ""
        CommentsTextBox.Text = ""

        Dim sectionName As String = SectionNameComboBox.Text
        Dim keyName As String = KeyNameComboBox.Text

        If iniTest.KeyNameExists(sectionName, keyName) Then
            ValueTextBox.Text = iniTest.GetKeyValue(sectionName, keyName)
            OrderTextBox.Text = iniTest.GetKeyOrder(sectionName, keyName)
            CommentsTextBox.Text = iniTest.GetKeyComments(sectionName, keyName)
        End If

        UpdateInfoStatus()

    End Sub


    Private Sub UpdateInfoStatus()

        Dim infoText As New List(Of String)

        If SectionNameComboBox.Visible AndAlso SectionNameComboBox.Text <> "" Then
            infoText.Add("Sections: " & iniTest.SectionNameCount(SectionNameComboBox.Text))
        End If

        If KeyNameComboBox.Visible AndAlso KeyNameComboBox.Text <> "" Then
            infoText.Add("Keys: " & iniTest.KeyNameCount(SectionNameComboBox.Text,
                                                         KeyNameComboBox.Text))
        End If

        If infoText.Count > 0 Then
            infoText.Insert(0, "Count by Name")
        End If

        ToolStripStatusLabel.Text = String.Join(" / ", infoText.ToArray)

    End Sub

End Class