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
                else if (control is ComboBox)
                    (control as ComboBox).SelectedIndex = 0;
                else if (control is ListBox)
                    (control as ListBox).Items.Clear();
                else if (control is ListView)
                    (control as ListView).Items.Clear();

                if (control.Controls.Count > 0)
                {
                    Clear(control.Controls);
                }
            }
        }
    }
}
