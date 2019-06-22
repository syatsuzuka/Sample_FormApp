Public Class Form
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        LabelButtonValue.Text = CInt(LabelButtonValue.Text) + 1

    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox.CheckedChanged
        LabelCheckBoxValue.Text = CStr(CheckBox.Checked)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox.SelectedIndexChanged
        LabelCheckedListBoxValue.Text = CheckedListBox.SelectedIndex
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        LabelComboBoxValue.Text = ComboBox1.Text
    End Sub

    Private Sub DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker.ValueChanged
        LabelDateTimePickerValue.Text = DateTimePicker.Value
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        LabelListBoxValue.Text = ListBox1.SelectedItem.ToString
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LabelTreeView.Click

    End Sub
End Class
