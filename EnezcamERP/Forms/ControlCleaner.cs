namespace EnezcamERP.Forms
{
    public static class ControlCleaner
    {
        public static void Clear(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;

                else if (control is RichTextBox)
                    ((RichTextBox)control).Clear();

                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();

                //else if (control is ComboBox)
                //    (control as ComboBox).SelectedIndex = 0;

                //else if (control is CheckBox)
                //    (control as CheckBox).Checked = false;

                if (control.Controls.Count > 0)
                {
                    Clear(control.Controls);
                }
            }

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is TextBox | controls[i] is RichTextBox | controls[i] is MaskedTextBox | controls[i] is ComboBox | controls[i] is ListBox)
                    controls[i].Focus();
            }
        }
    }
}
