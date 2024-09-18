using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using System.Data;

namespace EnezcamERP.Forms.Product_Specs_Forms
{
    public partial class ProductSpecs : Form
    {
        public ProductSpecs()
        {
            InitializeComponent();
        }

        SpecRepository specRepository = new();

        public void RefreshSpecs()
        {
            lvProductSpecs.Items.Clear();

            foreach (Spec spec in specRepository.GetAll().OrderBy(x => x.Name))
            {
                lvProductSpecs.Items.Add(new ListViewItem()
                {
                    Text = spec.Name,
                    Tag = spec
                });
            }

            lvProductSpecs.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void DeleteSpec(Spec spec)
        {
            try
            {
                specRepository.Delete(spec);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductSpecs_Load(object sender, EventArgs e)
        {
            RefreshSpecs();
        }

        private void btnUpdateSpec_Click(object sender, EventArgs e)
        {
            if (lvProductSpecs.SelectedItems.Count > 0)
            {
                AddUpdateProductSpec form = new(lvProductSpecs.SelectedItems[0].Tag as Spec, this);
                form.ShowDialog();

                RefreshSpecs();
            }
        }

        private void btnDeleteSpec_Click(object sender, EventArgs e)
        {
            if (lvProductSpecs.SelectedItems.Count > 0)
            {
                DeleteSpec(lvProductSpecs.SelectedItems[0].Tag as Spec);

                RefreshSpecs();
            }
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            AddUpdateProductSpec form = new(null, this);
            form.ShowDialog();

            RefreshSpecs();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvProductSpecs_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvProductSpecs.SelectedItems.Count > 0)
            {
                Spec selectedSpec = lvProductSpecs.SelectedItems[0].Tag as Spec;

                DeleteSpec(selectedSpec);
                RefreshSpecs();
            }
        }
    }
}
