using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms
{
    public static class ColumnSettingsManager
    {
        static ColumnSettingsRepository columnSettingsDB = new();

        public static void SetColumns(Form form, ListView listView)
        {
            foreach (ColumnHeader col in listView.Columns)
            {
                var colSet = columnSettingsDB.GetAll(x => x.FormName == form.Name & x.ColumnName == col.Text).FirstOrDefault();

                if (colSet == null)
                    columnSettingsDB.Add(new ColumnSetting()
                    {
                        FormName = form.Name,
                        ColumnName = col.Text,
                        DisplayIndex = col.DisplayIndex
                    });

                if (colSet != null && !colSet.IsActive)
                    col.Width = 0;
                else if (colSet != null && colSet.IsActive)
                    col.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
    }
}
