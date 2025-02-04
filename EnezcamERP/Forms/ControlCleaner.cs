namespace EnezcamERP.Forms
{
    public static class ControlCleaner
    {
        public static void Clear(Control.ControlCollection controls, Control? exception = null)
        {
            foreach (Control control in controls)
            {
                if (exception != null && exception == control)
                    continue;

                if (control is TextBox)
                    control.Text = string.Empty;

                else if (control is RichTextBox)
                    ((RichTextBox)control).Clear();

                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();

                else if (control is NumericUpDown)
                    (control as NumericUpDown).Value = (control as NumericUpDown).Minimum;

                if (control.Controls.Count > 0)
                    Clear(control.Controls, exception);
            }

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is TextBox | controls[i] is RichTextBox | controls[i] is MaskedTextBox | controls[i] is ComboBox | controls[i] is ListBox)
                    controls[i].Focus();
            }
        }
        public static void Clear(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                    control.Text = string.Empty;

                else if (control is RichTextBox)
                    ((RichTextBox)control).Clear();

                else if (control is MaskedTextBox)
                    ((MaskedTextBox)control).Clear();

                else if (control is NumericUpDown)
                    (control as NumericUpDown).Value = (control as NumericUpDown).Minimum;

                if (control.Controls.Count > 0)
                    Clear(control.Controls);
            }

            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i] is TextBox | controls[i] is RichTextBox | controls[i] is MaskedTextBox | controls[i] is ComboBox | controls[i] is ListBox)
                    controls[i].Focus();
            }
        }
    }
}
