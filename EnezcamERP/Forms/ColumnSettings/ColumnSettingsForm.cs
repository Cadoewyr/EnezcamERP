using BL.Repositories.Repositories;

namespace EnezcamERP.Forms.ColumnSettings
{
    public partial class ColumnSettingsForm : Form
    {
        public ColumnSettingsForm(Form form, ListView listView)
        {
            InitializeComponent();

            this.form = form;
            this.listView = listView;

            RefreshList();
        }

        Form form;
        ListView listView;
        bool isSaved = false;

        void RefreshList()
        {
            cbColumnSettings.Items.Clear();

            foreach (var col in new ColumnSettingsRepository().GetAll().Where(x => x.FormName == form.Name))
            {
                cbColumnSettings.Items.Add(col.ColumnName, col.IsActive);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cbColumnSettings.Items.Count; i++)
            {
                var colSetting = new ColumnSettingsRepository().GetAll(x => x.ColumnName == cbColumnSettings.Items[i].ToString() & x.FormName == form.Name).First();

                new ColumnSettingsRepository().Update(colSetting with
                {
                    IsActive = cbColumnSettings.GetItemChecked(i),
                    UpdatedAt = DateTime.Now
                }, colSetting.ID);
            }

            isSaved = true;

            (sender as Button).Enabled = !isSaved;
        }

        private void cbColumnSettings_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            isSaved = false;
        }

        private void cbCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0;i < cbColumnSettings.Items.Count;i++)
            {
                cbColumnSettings.SetItemChecked(i, (sender as CheckBox).Checked);
            }

            isSaved = false;
            btnSave.Enabled = !isSaved;
        }
    }
}
