using BL.Repositories.Repositories;
using DAL.DTO.Entities;

namespace EnezcamERP.Forms.Yearly_Report_Cost_Form
{
    public partial class FormYearlyReportCosts : Form
    {
        public FormYearlyReportCosts(int year)
        {
            _year = year;
            InitializeComponent();
        }

        int _year;

        private void FormYearlyReportCosts_Load(object sender, EventArgs e)
        {
            FillNumericUpDownControls();
        }

        MonthlyOutgoingsRepository moRepository = new();

        void FillNumericUpDownControls()
        {
            var res = moRepository.GetAll();

            nudM1.Value = res.Where(x => x.Month == 1 & x.Year == _year).Any() ? res.Where(x => x.Month == 1 & x.Year == _year).First().Outgoing : 0;
            nudM2.Value = res.Where(x => x.Month == 2 & x.Year == _year).Any() ? res.Where(x => x.Month == 2 & x.Year == _year).First().Outgoing : 0;
            nudM3.Value = res.Where(x => x.Month == 3 & x.Year == _year).Any() ? res.Where(x => x.Month == 3 & x.Year == _year).First().Outgoing : 0;
            nudM4.Value = res.Where(x => x.Month == 4 & x.Year == _year).Any() ? res.Where(x => x.Month == 4 & x.Year == _year).First().Outgoing : 0;
            nudM5.Value = res.Where(x => x.Month == 5 & x.Year == _year).Any() ? res.Where(x => x.Month == 5 & x.Year == _year).First().Outgoing : 0;
            nudM6.Value = res.Where(x => x.Month == 6 & x.Year == _year).Any() ? res.Where(x => x.Month == 6 & x.Year == _year).First().Outgoing : 0;
            nudM7.Value = res.Where(x => x.Month == 7 & x.Year == _year).Any() ? res.Where(x => x.Month == 7 & x.Year == _year).First().Outgoing : 0;
            nudM8.Value = res.Where(x => x.Month == 8 & x.Year == _year).Any() ? res.Where(x => x.Month == 8 & x.Year == _year).First().Outgoing : 0;
            nudM9.Value = res.Where(x => x.Month == 9 & x.Year == _year).Any() ? res.Where(x => x.Month == 9 & x.Year == _year).First().Outgoing : 0;
            nudM10.Value = res.Where(x => x.Month == 10 & x.Year == _year).Any() ? res.Where(x => x.Month == 10 & x.Year == _year).First().Outgoing : 0;
            nudM11.Value = res.Where(x => x.Month == 11 & x.Year == _year).Any() ? res.Where(x => x.Month == 11 & x.Year == _year).First().Outgoing : 0;
            nudM12.Value = res.Where(x => x.Month == 12 & x.Year == _year).Any() ? res.Where(x => x.Month == 12 & x.Year == _year).First().Outgoing : 0;
        }

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

            for (int i = 0; i < outgoings.Count; i++)
            {
                var res = moRepository.GetByDate(_year, i + 1);

                if (res != null)
                {
                    moRepository.Update(new MonthlyOutgoing()
                    {
                        Month = res.Month,
                        Year = res.Year,
                        Outgoing = outgoings[i]
                    }, res.ID);
                }
                else
                {
                    moRepository.Add(new()
                    {
                        Outgoing = outgoings[i],
                        Month = i + 1,
                        Year = _year
                    });
                }
            }

            this.Close();
        }
    }
}
