using BL.Report.Enums;
using BL.Reports.Enums;
using BL.Reports.ProductionReports;
using BL.Repositories.Repositories;
using DAL.DTO.Entities;
using System.Data.Common;

namespace EnezcamERP.Forms.Report_Forms
{
    public partial class SpecQuantities : Form
    {
        public SpecQuantities(DateRangedProductionReport report)
        {
            InitializeComponent();
            this.report = report;
            FillDataGridView();
        }

        DateRangedProductionReport report;

        void ClearDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
        }

        void CreateDataGridViewColumns(DataGridView dataGridView)
        {
            dataGridView.Columns.Add(new DataGridViewColumn()
            {
                HeaderText = "Özellik"
            });

            foreach (ProductionType productionType in Enum.GetValues(typeof(ProductionType)))
            {
                dataGridView.Columns.Add(new DataGridViewColumn()
                {
                    HeaderText = ConvertEnumToNames(productionType),
                });
            }
        }
        void CreateDataGridViewRows(DataGridView dataGridView)
        {
            foreach (Spec spec in new SpecRepository().GetAll())
            {
                var row = new DataGridViewRow();

                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = spec.Name
                });

                bool isValid = false;

                foreach (ProductionType productionType in Enum.GetValues(typeof(ProductionType)))
                {
                    if (report.GetSpecQuantity(spec, productionType).Any(x => x.Value > 0))
                        isValid = true;

                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = report.GetSpecQuantity(spec, productionType).Any(x=>x.Value > 0) ? report.GetSpecQuantityString(report.GetSpecQuantity(spec, productionType)) : string.Empty
                    });
                }

                if (isValid)
                    dataGridView.Rows.Add(row);
            }
        }

        string ConvertEnumToNames(ProductionType productionType) =>
            productionType switch
            {
                ProductionType.Produced => "ISICAM",
                ProductionType.Processed => "İŞLEME",
                ProductionType.Stock => "STOK",
                _ => string.Empty
            };

        void FillDataGridView()
        {
            dgSpecQuantities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            ClearDataGridView(dgSpecQuantities);
            CreateDataGridViewColumns(dgSpecQuantities);
            CreateDataGridViewRows(dgSpecQuantities);
        }
    }
}