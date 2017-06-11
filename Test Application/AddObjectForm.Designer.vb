<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddObjectForm
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
        Me.CommentsLabel = New System.Windows.Forms.Label()
        Me.OrderLabel = New System.Windows.Forms.Label()
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.ValueTextBox = New System.Windows.Forms.TextBox()
        Me.OrderTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.SectionNameLabel = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.KeyNameLabel = New System.Windows.Forms.Label()
        Me.SectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.KeyNameComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CreateIfNotExistCheckBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CommentsLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.OrderLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ValueLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.ValueTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.OrderTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CommentsTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SectionNameLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SubmitButton, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.KeyNameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SectionNameComboBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.KeyNameComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CreateIfNotExistCheckBox, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 267)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'CommentsLabel
        '
        Me.CommentsLabel.AutoSize = True
        Me.CommentsLabel.Location = New System.Drawing.Point(3, 105)
        Me.CommentsLabel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.CommentsLabel.Name = "CommentsLabel"
        Me.CommentsLabel.Size = New System.Drawing.Size(56, 13)
        Me.CommentsLabel.TabIndex = 7
        Me.CommentsLabel.Text = "Comments"
        '
        'OrderLabel
        '
        Me.OrderLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OrderLabel.AutoSize = True
        Me.OrderLabel.Location = New System.Drawing.Point(3, 81)
        Me.OrderLabel.Name = "OrderLabel"
        Me.OrderLabel.Size = New System.Drawing.Size(77, 13)
        Me.OrderLabel.TabIndex = 6
        Me.OrderLabel.Text = "Order (number)"
        '
        'ValueLabel
        '
        Me.ValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Location = New System.Drawing.Point(3, 56)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(34, 13)
        Me.ValueLabel.TabIndex = 5
        Me.ValueLabel.Text = "Value"
        '
        'ValueTextBox
        '
        Me.ValueTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ValueTextBox.Location = New System.Drawing.Point(109, 53)
        Me.ValueTextBox.Name = "ValueTextBox"
        Me.ValueTextBox.Size = New System.Drawing.Size(284, 20)
        Me.ValueTextBox.TabIndex = 2
        '
        'OrderTextBox
        '
        Me.OrderTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.OrderTextBox.Location = New System.Drawing.Point(109, 78)
        Me.OrderTextBox.Name = "OrderTextBox"
        Me.OrderTextBox.Size = New System.Drawing.Size(284, 20)
        Me.OrderTextBox.TabIndex = 3
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommentsTextBox.Location = New System.Drawing.Point(109, 103)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.Size = New System.Drawing.Size(284, 79)
        Me.CommentsTextBox.TabIndex = 4
        '
        'SectionNameLabel
        '
        Me.SectionNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SectionNameLabel.AutoSize = True
        Me.SectionNameLabel.Location = New System.Drawing.Point(3, 6)
        Me.SectionNameLabel.Name = "SectionNameLabel"
        Me.SectionNameLabel.Size = New System.Drawing.Size(74, 13)
        Me.SectionNameLabel.TabIndex = 4
        Me.SectionNameLabel.Text = "Section Name"
        '
        'SubmitButton
        '
        Me.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.SubmitButton.Location = New System.Drawing.Point(109, 213)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 6
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'KeyNameLabel
        '
        Me.KeyNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.KeyNameLabel.AutoSize = True
        Me.KeyNameLabel.Location = New System.Drawing.Point(3, 31)
        Me.KeyNameLabel.Name = "KeyNameLabel"
        Me.KeyNameLabel.Size = New System.Drawing.Size(56, 13)
        Me.KeyNameLabel.TabIndex = 9
        Me.KeyNameLabel.Text = "Key Name"
        '
        'SectionNameComboBox
        '
        Me.SectionNameComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.SectionNameComboBox.FormattingEnabled = True
        Me.SectionNameComboBox.Location = New System.Drawing.Point(109, 3)
        Me.SectionNameComboBox.Name = "SectionNameComboBox"
        Me.SectionNameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.SectionNameComboBox.TabIndex = 0
        '
        'KeyNameComboBox
        '
        Me.KeyNameComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.KeyNameComboBox.FormattingEnabled = True
        Me.KeyNameComboBox.Location = New System.Drawing.Point(109, 28)
        Me.KeyNameComboBox.Name = "KeyNameComboBox"
        Me.KeyNameComboBox.Size = New System.Drawing.Size(284, 21)
        Me.KeyNameComboBox.TabIndex = 1
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(10, 255)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(396, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(381, 17)
        Me.ToolStripStatusLabel.Spring = True
        Me.ToolStripStatusLabel.Text = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CreateIfNotExistCheckBox
        '
        Me.CreateIfNotExistCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CreateIfNotExistCheckBox.AutoSize = True
        Me.CreateIfNotExistCheckBox.Checked = True
        Me.CreateIfNotExistCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CreateIfNotExistCheckBox.Location = New System.Drawing.Point(109, 189)
        Me.CreateIfNotExistCheckBox.Name = "CreateIfNotExistCheckBox"
        Me.CreateIfNotExistCheckBox.Size = New System.Drawing.Size(107, 17)
        Me.CreateIfNotExistCheckBox.TabIndex = 5
        Me.CreateIfNotExistCheckBox.Text = "Create if not exist"
        Me.CreateIfNotExistCheckBox.UseVisualStyleBackColor = True
        '
        'AddObjectForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 287)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AddObjectForm"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddObjectForm"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ValueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionNameLabel As System.Windows.Forms.Label
    Friend WithEvents CommentsLabel As System.Windows.Forms.Label
    Friend WithEvents OrderLabel As System.Windows.Forms.Label
    Friend WithEvents ValueLabel As System.Windows.Forms.Label
    Friend WithEvents KeyNameLabel As System.Windows.Forms.Label
    Friend WithEvents SectionNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KeyNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CreateIfNotExistCheckBox As System.Windows.Forms.CheckBox
End Class
