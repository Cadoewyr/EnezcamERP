using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnezcamERP.Forms.Yearly_Report_Cost_Form
{
    public partial class FormYearlyReportCosts : Form
    {
        public FormYearlyReportCosts()
        {
            InitializeComponent();
        }

        public object ResultObject { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<decimal> outgoings = new();

            outgoings.Add(nudM1.Value);
            outgoings.Add(nudM2.Value);
            outgoings.Add(nudM3.Value);
            outgoings.Add(nudM4.Value);
            outgoings.Add(nudM5.Value);
            outgoings.Add(nudM6.Value);
            outgoings.Add(nudM7.Value);
            outgoings.Add(nudM8.Value);
            outgoings.Add(nudM9.Value);
            outgoings.Add(nudM10.Value);
            outgoings.Add(nudM11.Value);
            outgoings.Add(nudM12.Value);

            this.ResultObject = outgoings.ToArray();
            this.DialogResult = DialogResult.OK;
        }
    }
}
