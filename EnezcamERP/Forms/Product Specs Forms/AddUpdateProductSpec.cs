using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Product_Specs_Forms
{
    public partial class AddUpdateProductSpec : Form
    {
        public AddUpdateProductSpec(Spec? spec, Form parentForm)
        {
            InitializeComponent();

            if (spec != null)
            {
                this.spec = spec;
                this.Text = "Ürün Özelliği Güncelle";
                btnAddUpdate.Text = "Güncelle";

                txtSpecName.Text = spec.Name;
            }
            else
            {
                this.Text = "Ürün Özelliği Ekle";
                btnAddUpdate.Text = "Ekle";
            }

            this.parentForm = parentForm as ProductSpecs;
        }

        Spec spec;
        ProductSpecs parentForm;
        SpecRepository specRepository = new();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            (sender as Button).Enabled = false;

            if (this.spec == null) //Add
            {
                try
                {
                    specRepository.Add(new Spec()
                    {
                        Name = txtSpecName.Text.Trim().ToUpper()
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ControlCleaner.Clear(this.Controls);
            }
            else //Update
            {
                try
                {
                    Spec temp = new()
                    {
                        Name = txtSpecName.Text.Trim().ToUpper()
                    };

                    specRepository.Update(temp, spec.ID);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            parentForm.RefreshSpecs();

            (sender as Button).Enabled = true;
        }
    }
}
