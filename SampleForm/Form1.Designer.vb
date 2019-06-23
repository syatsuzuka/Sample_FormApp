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
        Me.LabelHeader = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelRadioButtonValue3 = New System.Windows.Forms.Label()
        Me.LabelRadioButtonValue2 = New System.Windows.Forms.Label()
        Me.LabelRadioButtonValue1 = New System.Windows.Forms.Label()
        Me.LabelMonthCalendarValue = New System.Windows.Forms.Label()
        Me.LabelTreeView = New System.Windows.Forms.Label()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.LabelTextBox = New System.Windows.Forms.Label()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.LabelRadioButton = New System.Windows.Forms.Label()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LabelNumericUpDown = New System.Windows.Forms.Label()
        Me.NumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.LabelMonthCalendar = New System.Windows.Forms.Label()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.LabelListBox = New System.Windows.Forms.Label()
        Me.LabelListBoxValue = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LabelDateTimePickerValue = New System.Windows.Forms.Label()
        Me.LabelDateTimePicker = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LabelComboBoxValue = New System.Windows.Forms.Label()
        Me.LabelComboBox = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelCheckedListBoxValue = New System.Windows.Forms.Label()
        Me.LabelCheckedListBox = New System.Windows.Forms.Label()
        Me.CheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.LabelCheckBoxValue = New System.Windows.Forms.Label()
        Me.LabelCheckBox = New System.Windows.Forms.Label()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.LabelButtonValue = New System.Windows.Forms.Label()
        Me.LabelButton = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.LabelTreeViewValue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelHeader
        '
        Me.LabelHeader.AutoSize = True
        Me.LabelHeader.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelHeader.Location = New System.Drawing.Point(25, 12)
        Me.LabelHeader.Name = "LabelHeader"
        Me.LabelHeader.Size = New System.Drawing.Size(393, 24)
        Me.LabelHeader.TabIndex = 32
        Me.LabelHeader.Text = "GUI Components for Testing ver1.0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTreeViewValue)
        Me.GroupBox1.Controls.Add(Me.LabelRadioButtonValue3)
        Me.GroupBox1.Controls.Add(Me.LabelRadioButtonValue2)
        Me.GroupBox1.Controls.Add(Me.LabelRadioButtonValue1)
        Me.GroupBox1.Controls.Add(Me.LabelMonthCalendarValue)
        Me.GroupBox1.Controls.Add(Me.LabelTreeView)
        Me.GroupBox1.Controls.Add(Me.TreeView)
        Me.GroupBox1.Controls.Add(Me.LabelTextBox)
        Me.GroupBox1.Controls.Add(Me.TextBox)
        Me.GroupBox1.Controls.Add(Me.LabelRadioButton)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.LabelNumericUpDown)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown)
        Me.GroupBox1.Controls.Add(Me.LabelMonthCalendar)
        Me.GroupBox1.Controls.Add(Me.MonthCalendar)
        Me.GroupBox1.Controls.Add(Me.LabelListBox)
        Me.GroupBox1.Controls.Add(Me.LabelListBoxValue)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.LabelDateTimePickerValue)
        Me.GroupBox1.Controls.Add(Me.LabelDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker)
        Me.GroupBox1.Controls.Add(Me.LabelComboBoxValue)
        Me.GroupBox1.Controls.Add(Me.LabelComboBox)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.LabelCheckedListBoxValue)
        Me.GroupBox1.Controls.Add(Me.LabelCheckedListBox)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox)
        Me.GroupBox1.Controls.Add(Me.LabelCheckBoxValue)
        Me.GroupBox1.Controls.Add(Me.LabelCheckBox)
        Me.GroupBox1.Controls.Add(Me.CheckBox)
        Me.GroupBox1.Controls.Add(Me.LabelButtonValue)
        Me.GroupBox1.Controls.Add(Me.LabelButton)
        Me.GroupBox1.Controls.Add(Me.Button)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(762, 479)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Common Control"
        '
        'LabelRadioButtonValue3
        '
        Me.LabelRadioButtonValue3.AutoSize = True
        Me.LabelRadioButtonValue3.Location = New System.Drawing.Point(673, 317)
        Me.LabelRadioButtonValue3.Name = "LabelRadioButtonValue3"
        Me.LabelRadioButtonValue3.Size = New System.Drawing.Size(40, 12)
        Me.LabelRadioButtonValue3.TabIndex = 34
        Me.LabelRadioButtonValue3.Text = "(blank)"
        '
        'LabelRadioButtonValue2
        '
        Me.LabelRadioButtonValue2.AutoSize = True
        Me.LabelRadioButtonValue2.Location = New System.Drawing.Point(675, 294)
        Me.LabelRadioButtonValue2.Name = "LabelRadioButtonValue2"
        Me.LabelRadioButtonValue2.Size = New System.Drawing.Size(40, 12)
        Me.LabelRadioButtonValue2.TabIndex = 33
        Me.LabelRadioButtonValue2.Text = "(blank)"
        '
        'LabelRadioButtonValue1
        '
        Me.LabelRadioButtonValue1.AutoSize = True
        Me.LabelRadioButtonValue1.Location = New System.Drawing.Point(675, 268)
        Me.LabelRadioButtonValue1.Name = "LabelRadioButtonValue1"
        Me.LabelRadioButtonValue1.Size = New System.Drawing.Size(40, 12)
        Me.LabelRadioButtonValue1.TabIndex = 32
        Me.LabelRadioButtonValue1.Text = "(blank)"
        '
        'LabelMonthCalendarValue
        '
        Me.LabelMonthCalendarValue.AutoEllipsis = True
        Me.LabelMonthCalendarValue.Location = New System.Drawing.Point(663, 54)
        Me.LabelMonthCalendarValue.Name = "LabelMonthCalendarValue"
        Me.LabelMonthCalendarValue.Size = New System.Drawing.Size(90, 142)
        Me.LabelMonthCalendarValue.TabIndex = 31
        Me.LabelMonthCalendarValue.Text = "(blank)"
        '
        'LabelTreeView
        '
        Me.LabelTreeView.AutoSize = True
        Me.LabelTreeView.Location = New System.Drawing.Point(339, 396)
        Me.LabelTreeView.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTreeView.Name = "LabelTreeView"
        Me.LabelTreeView.Size = New System.Drawing.Size(53, 12)
        Me.LabelTreeView.TabIndex = 30
        Me.LabelTreeView.Text = "TreeView"
        '
        'TreeView
        '
        Me.TreeView.Location = New System.Drawing.Point(454, 396)
        Me.TreeView.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeView.Name = "TreeView"
        TreeNode1.Name = "c"
        TreeNode1.Text = "c"
        TreeNode2.Name = "b"
        TreeNode2.Text = "b"
        TreeNode3.Name = "b"
        TreeNode3.Text = "a"
        Me.TreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.TreeView.Size = New System.Drawing.Size(180, 61)
        Me.TreeView.TabIndex = 29
        '
        'LabelTextBox
        '
        Me.LabelTextBox.AutoSize = True
        Me.LabelTextBox.Location = New System.Drawing.Point(339, 359)
        Me.LabelTextBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTextBox.Name = "LabelTextBox"
        Me.LabelTextBox.Size = New System.Drawing.Size(48, 12)
        Me.LabelTextBox.TabIndex = 28
        Me.LabelTextBox.Text = "TextBox"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(456, 356)
        Me.TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(180, 19)
        Me.TextBox.TabIndex = 27
        '
        'LabelRadioButton
        '
        Me.LabelRadioButton.AutoSize = True
        Me.LabelRadioButton.Location = New System.Drawing.Point(339, 271)
        Me.LabelRadioButton.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRadioButton.Name = "LabelRadioButton"
        Me.LabelRadioButton.Size = New System.Drawing.Size(68, 12)
        Me.LabelRadioButton.TabIndex = 26
        Me.LabelRadioButton.Text = "RadioButton"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(456, 317)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(92, 16)
        Me.RadioButton3.TabIndex = 25
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(456, 291)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(92, 16)
        Me.RadioButton2.TabIndex = 24
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(456, 266)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(92, 16)
        Me.RadioButton1.TabIndex = 23
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LabelNumericUpDown
        '
        Me.LabelNumericUpDown.AutoSize = True
        Me.LabelNumericUpDown.Location = New System.Drawing.Point(339, 235)
        Me.LabelNumericUpDown.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNumericUpDown.Name = "LabelNumericUpDown"
        Me.LabelNumericUpDown.Size = New System.Drawing.Size(89, 12)
        Me.LabelNumericUpDown.TabIndex = 22
        Me.LabelNumericUpDown.Text = "NumericUpDown"
        '
        'NumericUpDown
        '
        Me.NumericUpDown.Location = New System.Drawing.Point(456, 235)
        Me.NumericUpDown.Margin = New System.Windows.Forms.Padding(2)
        Me.NumericUpDown.Name = "NumericUpDown"
        Me.NumericUpDown.Size = New System.Drawing.Size(178, 19)
        Me.NumericUpDown.TabIndex = 21
        '
        'LabelMonthCalendar
        '
        Me.LabelMonthCalendar.AutoSize = True
        Me.LabelMonthCalendar.Location = New System.Drawing.Point(339, 54)
        Me.LabelMonthCalendar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMonthCalendar.Name = "LabelMonthCalendar"
        Me.LabelMonthCalendar.Size = New System.Drawing.Size(81, 12)
        Me.LabelMonthCalendar.TabIndex = 20
        Me.LabelMonthCalendar.Text = "MonthCalendar"
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(456, 43)
        Me.MonthCalendar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.SelectionRange = New System.Windows.Forms.SelectionRange(New Date(2000, 1, 1, 0, 0, 0, 0), New Date(2000, 1, 7, 0, 0, 0, 0))
        Me.MonthCalendar.ShowToday = False
        Me.MonthCalendar.TabIndex = 19
        '
        'LabelListBox
        '
        Me.LabelListBox.AutoSize = True
        Me.LabelListBox.Location = New System.Drawing.Point(23, 342)
        Me.LabelListBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelListBox.Name = "LabelListBox"
        Me.LabelListBox.Size = New System.Drawing.Size(44, 12)
        Me.LabelListBox.TabIndex = 17
        Me.LabelListBox.Text = "ListBox"
        '
        'LabelListBoxValue
        '
        Me.LabelListBoxValue.AutoSize = True
        Me.LabelListBoxValue.Location = New System.Drawing.Point(265, 337)
        Me.LabelListBoxValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelListBoxValue.Name = "LabelListBoxValue"
        Me.LabelListBoxValue.Size = New System.Drawing.Size(40, 12)
        Me.LabelListBoxValue.TabIndex = 16
        Me.LabelListBoxValue.Text = "(blank)"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.ListBox1.Location = New System.Drawing.Point(127, 337)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(109, 64)
        Me.ListBox1.TabIndex = 15
        '
        'LabelDateTimePickerValue
        '
        Me.LabelDateTimePickerValue.AutoSize = True
        Me.LabelDateTimePickerValue.Location = New System.Drawing.Point(265, 299)
        Me.LabelDateTimePickerValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDateTimePickerValue.Name = "LabelDateTimePickerValue"
        Me.LabelDateTimePickerValue.Size = New System.Drawing.Size(40, 12)
        Me.LabelDateTimePickerValue.TabIndex = 14
        Me.LabelDateTimePickerValue.Text = "(blank)"
        '
        'LabelDateTimePicker
        '
        Me.LabelDateTimePicker.AutoSize = True
        Me.LabelDateTimePicker.Location = New System.Drawing.Point(24, 299)
        Me.LabelDateTimePicker.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDateTimePicker.Name = "LabelDateTimePicker"
        Me.LabelDateTimePicker.Size = New System.Drawing.Size(86, 12)
        Me.LabelDateTimePicker.TabIndex = 13
        Me.LabelDateTimePicker.Text = "DateTimePicker"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(127, 295)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(109, 19)
        Me.DateTimePicker.TabIndex = 12
        '
        'LabelComboBoxValue
        '
        Me.LabelComboBoxValue.AutoSize = True
        Me.LabelComboBoxValue.Location = New System.Drawing.Point(265, 252)
        Me.LabelComboBoxValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelComboBoxValue.Name = "LabelComboBoxValue"
        Me.LabelComboBoxValue.Size = New System.Drawing.Size(11, 12)
        Me.LabelComboBoxValue.TabIndex = 11
        Me.LabelComboBoxValue.Text = "a"
        '
        'LabelComboBox
        '
        Me.LabelComboBox.AutoSize = True
        Me.LabelComboBox.Location = New System.Drawing.Point(23, 254)
        Me.LabelComboBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelComboBox.Name = "LabelComboBox"
        Me.LabelComboBox.Size = New System.Drawing.Size(60, 12)
        Me.LabelComboBox.TabIndex = 10
        Me.LabelComboBox.Text = "ComboBox"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.ComboBox1.Location = New System.Drawing.Point(127, 250)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(109, 20)
        Me.ComboBox1.TabIndex = 9
        '
        'LabelCheckedListBoxValue
        '
        Me.LabelCheckedListBoxValue.AutoSize = True
        Me.LabelCheckedListBoxValue.Location = New System.Drawing.Point(265, 158)
        Me.LabelCheckedListBoxValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCheckedListBoxValue.Name = "LabelCheckedListBoxValue"
        Me.LabelCheckedListBoxValue.Size = New System.Drawing.Size(11, 12)
        Me.LabelCheckedListBoxValue.TabIndex = 8
        Me.LabelCheckedListBoxValue.Text = "a"
        '
        'LabelCheckedListBox
        '
        Me.LabelCheckedListBox.AutoSize = True
        Me.LabelCheckedListBox.Location = New System.Drawing.Point(23, 165)
        Me.LabelCheckedListBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCheckedListBox.Name = "LabelCheckedListBox"
        Me.LabelCheckedListBox.Size = New System.Drawing.Size(88, 12)
        Me.LabelCheckedListBox.TabIndex = 7
        Me.LabelCheckedListBox.Text = "CheckedListBox"
        '
        'CheckedListBox
        '
        Me.CheckedListBox.FormattingEnabled = True
        Me.CheckedListBox.Items.AddRange(New Object() {"a", "b", "c", "d", "e"})
        Me.CheckedListBox.Location = New System.Drawing.Point(127, 158)
        Me.CheckedListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckedListBox.Name = "CheckedListBox"
        Me.CheckedListBox.Size = New System.Drawing.Size(109, 60)
        Me.CheckedListBox.TabIndex = 6
        '
        'LabelCheckBoxValue
        '
        Me.LabelCheckBoxValue.AutoSize = True
        Me.LabelCheckBoxValue.Location = New System.Drawing.Point(258, 114)
        Me.LabelCheckBoxValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCheckBoxValue.Name = "LabelCheckBoxValue"
        Me.LabelCheckBoxValue.Size = New System.Drawing.Size(33, 12)
        Me.LabelCheckBoxValue.TabIndex = 5
        Me.LabelCheckBoxValue.Text = "False"
        '
        'LabelCheckBox
        '
        Me.LabelCheckBox.AutoSize = True
        Me.LabelCheckBox.Location = New System.Drawing.Point(23, 111)
        Me.LabelCheckBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCheckBox.Name = "LabelCheckBox"
        Me.LabelCheckBox.Size = New System.Drawing.Size(57, 12)
        Me.LabelCheckBox.TabIndex = 4
        Me.LabelCheckBox.Text = "CheckBox"
        '
        'CheckBox
        '
        Me.CheckBox.AutoSize = True
        Me.CheckBox.Location = New System.Drawing.Point(127, 111)
        Me.CheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(76, 16)
        Me.CheckBox.TabIndex = 3
        Me.CheckBox.Text = "CheckBox"
        Me.CheckBox.UseVisualStyleBackColor = True
        '
        'LabelButtonValue
        '
        Me.LabelButtonValue.AutoSize = True
        Me.LabelButtonValue.Location = New System.Drawing.Point(258, 58)
        Me.LabelButtonValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelButtonValue.Name = "LabelButtonValue"
        Me.LabelButtonValue.Size = New System.Drawing.Size(11, 12)
        Me.LabelButtonValue.TabIndex = 2
        Me.LabelButtonValue.Text = "0"
        '
        'LabelButton
        '
        Me.LabelButton.AutoSize = True
        Me.LabelButton.Location = New System.Drawing.Point(23, 57)
        Me.LabelButton.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelButton.Name = "LabelButton"
        Me.LabelButton.Size = New System.Drawing.Size(39, 12)
        Me.LabelButton.TabIndex = 1
        Me.LabelButton.Text = "Button"
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(127, 47)
        Me.Button.Margin = New System.Windows.Forms.Padding(2)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(107, 34)
        Me.Button.TabIndex = 0
        Me.Button.Text = "Button"
        Me.Button.UseVisualStyleBackColor = True
        '
        'LabelTreeViewValue
        '
        Me.LabelTreeViewValue.AutoSize = True
        Me.LabelTreeViewValue.Location = New System.Drawing.Point(675, 420)
        Me.LabelTreeViewValue.Name = "LabelTreeViewValue"
        Me.LabelTreeViewValue.Size = New System.Drawing.Size(40, 12)
        Me.LabelTreeViewValue.TabIndex = 35
        Me.LabelTreeViewValue.Text = "(blank)"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 554)
        Me.Controls.Add(Me.LabelHeader)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form"
        Me.Text = "Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelHeader As Label
    Friend WithEvents LabelMonthCalendarValue As Label
    Friend WithEvents LabelRadioButtonValue1 As Label
    Friend WithEvents LabelRadioButtonValue3 As Label
    Friend WithEvents LabelRadioButtonValue2 As Label
    Friend WithEvents LabelTreeViewValue As Label
End Class
