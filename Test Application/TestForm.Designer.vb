<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContentsTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewFileTextBox = New System.Windows.Forms.TextBox()
        Me.LoadFromTextButton = New System.Windows.Forms.Button()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.LoadFromFileButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteKeyButton = New System.Windows.Forms.Button()
        Me.DeleteSectionButton = New System.Windows.Forms.Button()
        Me.EditKeyButton = New System.Windows.Forms.Button()
        Me.EditSectionButton = New System.Windows.Forms.Button()
        Me.AddKeyButton = New System.Windows.Forms.Button()
        Me.AddSectionButton = New System.Windows.Forms.Button()
        Me.KeyNameWhitespaceLiteralCheckBox = New System.Windows.Forms.CheckBox()
        Me.KeyValueWhitespaceLiteralCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ContentsTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(596, 442)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'ContentsTextBox
        '
        Me.ContentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentsTextBox.Location = New System.Drawing.Point(3, 162)
        Me.ContentsTextBox.MaxLength = 1000000
        Me.ContentsTextBox.Multiline = True
        Me.ContentsTextBox.Name = "ContentsTextBox"
        Me.ContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.ContentsTextBox.Size = New System.Drawing.Size(590, 277)
        Me.ContentsTextBox.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.KeyValueWhitespaceLiteralCheckBox)
        Me.Panel1.Controls.Add(Me.KeyNameWhitespaceLiteralCheckBox)
        Me.Panel1.Controls.Add(Me.NewFileTextBox)
        Me.Panel1.Controls.Add(Me.LoadFromTextButton)
        Me.Panel1.Controls.Add(Me.FileNameTextBox)
        Me.Panel1.Controls.Add(Me.LoadFromFileButton)
        Me.Panel1.Controls.Add(Me.SaveButton)
        Me.Panel1.Controls.Add(Me.DeleteKeyButton)
        Me.Panel1.Controls.Add(Me.DeleteSectionButton)
        Me.Panel1.Controls.Add(Me.EditKeyButton)
        Me.Panel1.Controls.Add(Me.EditSectionButton)
        Me.Panel1.Controls.Add(Me.AddKeyButton)
        Me.Panel1.Controls.Add(Me.AddSectionButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 153)
        Me.Panel1.TabIndex = 1
        '
        'NewFileTextBox
        '
        Me.NewFileTextBox.Location = New System.Drawing.Point(222, 129)
        Me.NewFileTextBox.Name = "NewFileTextBox"
        Me.NewFileTextBox.ReadOnly = True
        Me.NewFileTextBox.Size = New System.Drawing.Size(359, 20)
        Me.NewFileTextBox.TabIndex = 10
        '
        'LoadFromTextButton
        '
        Me.LoadFromTextButton.Location = New System.Drawing.Point(116, 127)
        Me.LoadFromTextButton.Name = "LoadFromTextButton"
        Me.LoadFromTextButton.Size = New System.Drawing.Size(100, 23)
        Me.LoadFromTextButton.TabIndex = 9
        Me.LoadFromTextButton.Text = "Load from Text"
        Me.LoadFromTextButton.UseVisualStyleBackColor = True
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Location = New System.Drawing.Point(222, 98)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(359, 20)
        Me.FileNameTextBox.TabIndex = 8
        '
        'LoadFromFileButton
        '
        Me.LoadFromFileButton.Location = New System.Drawing.Point(116, 98)
        Me.LoadFromFileButton.Name = "LoadFromFileButton"
        Me.LoadFromFileButton.Size = New System.Drawing.Size(100, 23)
        Me.LoadFromFileButton.TabIndex = 7
        Me.LoadFromFileButton.Text = "Load from File"
        Me.LoadFromFileButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(10, 98)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteKeyButton
        '
        Me.DeleteKeyButton.Location = New System.Drawing.Point(222, 40)
        Me.DeleteKeyButton.Name = "DeleteKeyButton"
        Me.DeleteKeyButton.Size = New System.Drawing.Size(100, 23)
        Me.DeleteKeyButton.TabIndex = 5
        Me.DeleteKeyButton.Text = "Delete Key"
        Me.DeleteKeyButton.UseVisualStyleBackColor = True
        '
        'DeleteSectionButton
        '
        Me.DeleteSectionButton.Location = New System.Drawing.Point(222, 10)
        Me.DeleteSectionButton.Name = "DeleteSectionButton"
        Me.DeleteSectionButton.Size = New System.Drawing.Size(100, 23)
        Me.DeleteSectionButton.TabIndex = 4
        Me.DeleteSectionButton.Text = "Delete Section"
        Me.DeleteSectionButton.UseVisualStyleBackColor = True
        '
        'EditKeyButton
        '
        Me.EditKeyButton.Location = New System.Drawing.Point(116, 40)
        Me.EditKeyButton.Name = "EditKeyButton"
        Me.EditKeyButton.Size = New System.Drawing.Size(100, 23)
        Me.EditKeyButton.TabIndex = 3
        Me.EditKeyButton.Text = "Edit Key"
        Me.EditKeyButton.UseVisualStyleBackColor = True
        '
        'EditSectionButton
        '
        Me.EditSectionButton.Location = New System.Drawing.Point(116, 10)
        Me.EditSectionButton.Name = "EditSectionButton"
        Me.EditSectionButton.Size = New System.Drawing.Size(100, 23)
        Me.EditSectionButton.TabIndex = 2
        Me.EditSectionButton.Text = "Edit Section"
        Me.EditSectionButton.UseVisualStyleBackColor = True
        '
        'AddKeyButton
        '
        Me.AddKeyButton.Location = New System.Drawing.Point(10, 40)
        Me.AddKeyButton.Name = "AddKeyButton"
        Me.AddKeyButton.Size = New System.Drawing.Size(100, 23)
        Me.AddKeyButton.TabIndex = 1
        Me.AddKeyButton.Text = "Add Key"
        Me.AddKeyButton.UseVisualStyleBackColor = True
        '
        'AddSectionButton
        '
        Me.AddSectionButton.Location = New System.Drawing.Point(10, 10)
        Me.AddSectionButton.Name = "AddSectionButton"
        Me.AddSectionButton.Size = New System.Drawing.Size(100, 23)
        Me.AddSectionButton.TabIndex = 0
        Me.AddSectionButton.Text = "Add Section"
        Me.AddSectionButton.UseVisualStyleBackColor = True
        '
        'KeyNameWhitespaceLiteralCheckBox
        '
        Me.KeyNameWhitespaceLiteralCheckBox.AutoSize = True
        Me.KeyNameWhitespaceLiteralCheckBox.Location = New System.Drawing.Point(222, 75)
        Me.KeyNameWhitespaceLiteralCheckBox.Name = "KeyNameWhitespaceLiteralCheckBox"
        Me.KeyNameWhitespaceLiteralCheckBox.Size = New System.Drawing.Size(169, 17)
        Me.KeyNameWhitespaceLiteralCheckBox.TabIndex = 11
        Me.KeyNameWhitespaceLiteralCheckBox.Text = "Key Name is whitespace literal"
        Me.KeyNameWhitespaceLiteralCheckBox.UseVisualStyleBackColor = True
        '
        'KeyValueWhitespaceLiteralCheckBox
        '
        Me.KeyValueWhitespaceLiteralCheckBox.AutoSize = True
        Me.KeyValueWhitespaceLiteralCheckBox.Location = New System.Drawing.Point(397, 75)
        Me.KeyValueWhitespaceLiteralCheckBox.Name = "KeyValueWhitespaceLiteralCheckBox"
        Me.KeyValueWhitespaceLiteralCheckBox.Size = New System.Drawing.Size(168, 17)
        Me.KeyValueWhitespaceLiteralCheckBox.TabIndex = 12
        Me.KeyValueWhitespaceLiteralCheckBox.Text = "Key Value is whitespace literal"
        Me.KeyValueWhitespaceLiteralCheckBox.UseVisualStyleBackColor = True
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 442)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ContentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DeleteKeyButton As System.Windows.Forms.Button
    Friend WithEvents DeleteSectionButton As System.Windows.Forms.Button
    Friend WithEvents EditKeyButton As System.Windows.Forms.Button
    Friend WithEvents EditSectionButton As System.Windows.Forms.Button
    Friend WithEvents AddKeyButton As System.Windows.Forms.Button
    Friend WithEvents AddSectionButton As System.Windows.Forms.Button
    Friend WithEvents LoadFromFileButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents FileNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoadFromTextButton As System.Windows.Forms.Button
    Friend WithEvents KeyValueWhitespaceLiteralCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents KeyNameWhitespaceLiteralCheckBox As System.Windows.Forms.CheckBox

End Class
