<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("c")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("b", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("a", New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.Button = New System.Windows.Forms.Button()
        Me.LabelButton = New System.Windows.Forms.Label()
        Me.LabelButtonValue = New System.Windows.Forms.Label()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.LabelCheckBox = New System.Windows.Forms.Label()
        Me.LabelCheckBoxValue = New System.Windows.Forms.Label()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.LabelCheckedListBox = New System.Windows.Forms.Label()
        Me.LabelCheckedListBoxValue = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelComboBox = New System.Windows.Forms.Label()
        Me.LabelComboBoxValue = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelDateTimePicker = New System.Windows.Forms.Label()
        Me.LabelDateTimePickerValue = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelListBoxValue = New System.Windows.Forms.Label()
        Me.LabelListBox = New System.Windows.Forms.Label()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.LabelMonthCalendar = New System.Windows.Forms.Label()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LabelNumericUpDown = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.LabelRadioButton = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.LabelTextBox = New System.Windows.Forms.Label()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.LabelTreeView = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(166, 35)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(179, 51)
        Me.Button.TabIndex = 0
        Me.Button.Text = "Button"
        Me.Button.UseVisualStyleBackColor = True
        '
        'LabelButton
        '
        Me.LabelButton.AutoSize = True
        Me.LabelButton.Location = New System.Drawing.Point(12, 51)
        Me.LabelButton.Name = "LabelButton"
        Me.LabelButton.Size = New System.Drawing.Size(58, 18)
        Me.LabelButton.TabIndex = 1
        Me.LabelButton.Text = "Button"
        '
        'LabelButtonValue
        '
        Me.LabelButtonValue.AutoSize = True
        Me.LabelButtonValue.Location = New System.Drawing.Point(385, 51)
        Me.LabelButtonValue.Name = "LabelButtonValue"
        Me.LabelButtonValue.Size = New System.Drawing.Size(17, 18)
        Me.LabelButtonValue.TabIndex = 2
        Me.LabelButtonValue.Text = "0"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(166, 131)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(109, 22)
        Me.CheckBox.TabIndex = 3
        Me.CheckBox.Text = "CheckBox"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'LabelCheckBox
        '
        Me.LabelCheckBox.AutoSize = True
        Me.LabelCheckBox.Location = New System.Drawing.Point(12, 132)
        Me.LabelCheckBox.Name = "LabelCheckBox"
        Me.LabelCheckBox.Size = New System.Drawing.Size(83, 18)
        Me.LabelCheckBox.TabIndex = 4
        Me.LabelCheckBox.Text = "CheckBox"
        '
        'LabelCheckBoxValue
        '
        Me.LabelCheckBoxValue.AutoSize = True
        Me.LabelCheckBoxValue.Location = New System.Drawing.Point(385, 135)
        Me.LabelCheckBoxValue.Name = "LabelCheckBoxValue"
        Me.LabelCheckBoxValue.Size = New System.Drawing.Size(48, 18)
        Me.LabelCheckBoxValue.TabIndex = 5
        Me.LabelCheckBoxValue.Text = "False"
        '
        'CheckedListBox
        '
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.CheckedListBox.Location = New System.Drawing.Point(166, 201)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(179, 104)
        Me.CheckedListBox.TabIndex = 6
        '
        'LabelCheckedListBox
        '
        Me.LabelCheckedListBox.AutoSize = True
        Me.LabelCheckedListBox.Location = New System.Drawing.Point(12, 213)
        Me.LabelCheckedListBox.Name = "LabelCheckedListBox"
        Me.LabelCheckedListBox.Size = New System.Drawing.Size(129, 18)
        Me.LabelCheckedListBox.TabIndex = 7
        Me.LabelCheckedListBox.Text = "CheckedListBox"
        '
        'LabelCheckedListBoxValue
        '
        Me.LabelCheckedListBoxValue.AutoSize = True
        Me.LabelCheckedListBoxValue.Location = New System.Drawing.Point(397, 201)
        Me.LabelCheckedListBoxValue.Name = "LabelCheckedListBoxValue"
        Me.LabelCheckedListBoxValue.Size = New System.Drawing.Size(17, 18)
        Me.LabelCheckedListBoxValue.TabIndex = 8
        Me.LabelCheckedListBoxValue.Text = "a"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.ComboBox1.Location = New System.Drawing.Point(166, 339)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 26)
        Me.ComboBox1.TabIndex = 9
        '
        'LabelComboBox
        '
        Me.LabelComboBox.AutoSize = True
        Me.LabelComboBox.Location = New System.Drawing.Point(12, 347)
        Me.LabelComboBox.Name = "LabelComboBox"
        Me.LabelComboBox.Size = New System.Drawing.Size(88, 18)
        Me.LabelComboBox.TabIndex = 10
        Me.LabelComboBox.Text = "ComboBox"
        '
        'LabelComboBoxValue
        '
        Me.LabelComboBoxValue.AutoSize = True
        Me.LabelComboBoxValue.Location = New System.Drawing.Point(397, 342)
        Me.LabelComboBoxValue.Name = "LabelComboBoxValue"
        Me.LabelComboBoxValue.Size = New System.Drawing.Size(17, 18)
        Me.LabelComboBoxValue.TabIndex = 11
        Me.LabelComboBoxValue.Text = "a"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(166, 407)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(179, 25)
        Me.DateTimePicker.TabIndex = 12
        '
        'LabelDateTimePicker
        '
        Me.LabelDateTimePicker.AutoSize = True
        Me.LabelDateTimePicker.Location = New System.Drawing.Point(13, 414)
        Me.LabelDateTimePicker.Name = "LabelDateTimePicker"
        Me.LabelDateTimePicker.Size = New System.Drawing.Size(128, 18)
        Me.LabelDateTimePicker.TabIndex = 13
        Me.LabelDateTimePicker.Text = "DateTimePicker"
        '
        'LabelDateTimePickerValue
        '
        Me.LabelDateTimePickerValue.AutoSize = True
        Me.LabelDateTimePickerValue.Location = New System.Drawing.Point(397, 412)
        Me.LabelDateTimePickerValue.Name = "LabelDateTimePickerValue"
        Me.LabelDateTimePickerValue.Size = New System.Drawing.Size(57, 18)
        Me.LabelDateTimePickerValue.TabIndex = 14
        Me.LabelDateTimePickerValue.Text = "(blank)"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.ListBox1.Location = New System.Drawing.Point(166, 470)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 94)
        Me.ListBox1.TabIndex = 15
        '
        'LabelListBoxValue
        '
        Me.LabelListBoxValue.AutoSize = True
        Me.LabelListBoxValue.Location = New System.Drawing.Point(397, 470)
        Me.LabelListBoxValue.Name = "LabelListBoxValue"
        Me.LabelListBoxValue.Size = New System.Drawing.Size(57, 18)
        Me.LabelListBoxValue.TabIndex = 16
        Me.LabelListBoxValue.Text = "(blank)"
        '
        'LabelListBox
        '
        Me.LabelListBox.AutoSize = True
        Me.LabelListBox.Location = New System.Drawing.Point(12, 479)
        Me.LabelListBox.Name = "LabelListBox"
        Me.LabelListBox.Size = New System.Drawing.Size(64, 18)
        Me.LabelListBox.TabIndex = 17
        Me.LabelListBox.Text = "ListBox"
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(653, 35)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 19
        '
        'LabelMonthCalendar
        '
        Me.LabelMonthCalendar.AutoSize = True
        Me.LabelMonthCalendar.Location = New System.Drawing.Point(513, 51)
        Me.LabelMonthCalendar.Name = "LabelMonthCalendar"
        Me.LabelMonthCalendar.Size = New System.Drawing.Size(121, 18)
        Me.LabelMonthCalendar.TabIndex = 20
        Me.LabelMonthCalendar.Text = "MonthCalendar"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Location = New System.Drawing.Point(653, 321)
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(297, 25)
        Me.NumericUpDown.TabIndex = 21
        '
        'LabelNumericUpDown
        '
        Me.LabelNumericUpDown.AutoSize = True
        Me.LabelNumericUpDown.Location = New System.Drawing.Point(513, 323)
        Me.LabelNumericUpDown.Name = "LabelNumericUpDown"
        Me.LabelNumericUpDown.Size = New System.Drawing.Size(133, 18)
        Me.LabelNumericUpDown.TabIndex = 22
        Me.LabelNumericUpDown.Text = "NumericUpDown"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(653, 377)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(134, 22)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(653, 414)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(134, 22)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(653, 453)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(134, 22)
        Me.RadioButton3.TabIndex = 25
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'LabelRadioButton
        '
        Me.LabelRadioButton.AutoSize = True
        Me.LabelRadioButton.Location = New System.Drawing.Point(513, 377)
        Me.LabelRadioButton.Name = "LabelRadioButton"
        Me.LabelRadioButton.Size = New System.Drawing.Size(100, 18)
        Me.LabelRadioButton.TabIndex = 26
        Me.LabelRadioButton.Text = "RadioButton"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(653, 506)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(297, 25)
        Me.TextBox.TabIndex = 27
        '
        'LabelTextBox
        '
        Me.LabelTextBox.AutoSize = True
        Me.LabelTextBox.Location = New System.Drawing.Point(513, 509)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(70, 18)
        Me.LabelTextBox.TabIndex = 28
        Me.LabelTextBox.Text = "TextBox"
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(653, 564)
        Me.TreeView.Name = "TreeView"
        TreeNode1.Name = "c"
        TreeNode1.Text = "c"
        TreeNode2.Name = "b"
        TreeNode2.Text = "b"
        TreeNode3.Name = "b"
        TreeNode3.Text = "a"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView.Size = New System.Drawing.Size(297, 89)
        Me.TreeView.TabIndex = 29
        '
        'LabelTreeView
        '
        Me.LabelTreeView.AutoSize = True
        Me.LabelTreeView.Location = New System.Drawing.Point(513, 564)
        Me.LabelTreeView.Name = "LabelTreeView"
        Me.LabelTreeView.Size = New System.Drawing.Size(79, 18)
        Me.LabelTreeView.TabIndex = 30
        Me.LabelTreeView.Text = "TreeView"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 665)
        Me.Controls.Add(Me.LabelTreeView)
        Me.Controls.Add(Me.TreeView)
        Me.Controls.Add(Me.LabelTextBox)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.LabelRadioButton)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LabelNumericUpDown)
        Me.Controls.Add(Me.NumericUpDown)
        Me.Controls.Add(Me.LabelMonthCalendar)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.LabelListBox)
        Me.Controls.Add(Me.LabelListBoxValue)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LabelDateTimePickerValue)
        Me.Controls.Add(Me.LabelDateTimePicker)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.LabelComboBoxValue)
        Me.Controls.Add(Me.LabelComboBox)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelCheckedListBoxValue)
        Me.Controls.Add(Me.LabelCheckedListBox)
        Me.Controls.Add(Me.CheckedListBox)
        Me.Controls.Add(Me.LabelCheckBoxValue)
        Me.Controls.Add(Me.LabelCheckBox)
        Me.Controls.Add(Me.CheckBox)
        Me.Controls.Add(Me.LabelButtonValue)
        Me.Controls.Add(Me.LabelButton)
        Me.Controls.Add(Me.Button)
        Me.Name = "Form"
        Me.Text = "Form"
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button As Button
    Friend WithEvents LabelButton As Label
    Friend WithEvents LabelButtonValue As Label
    Friend WithEvents CheckBox As CheckBox
    Friend WithEvents LabelCheckBox As Label
    Friend WithEvents LabelCheckBoxValue As Label
    Friend WithEvents CheckedListBox As CheckedListBox
    Friend WithEvents LabelCheckedListBox As Label
    Friend WithEvents LabelCheckedListBoxValue As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LabelComboBox As Label
    Friend WithEvents LabelComboBoxValue As Label
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents LabelDateTimePicker As Label
    Friend WithEvents LabelDateTimePickerValue As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LabelListBoxValue As Label
    Friend WithEvents LabelListBox As Label
    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents LabelMonthCalendar As Label
    Friend WithEvents NumericUpDown As NumericUpDown
    Friend WithEvents LabelNumericUpDown As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents LabelRadioButton As Label
    Friend WithEvents TextBox As TextBox
    Friend WithEvents LabelTextBox As Label
    Friend WithEvents TreeView As TreeView
    Friend WithEvents LabelTreeView As Label
End Class
