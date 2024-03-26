using DAL.DTO.Entities;

namespace BL.Reports.ProductReports
{
    public class YearlyProductStatistic
    {
        public YearlyProductStatistic(Product product, int year)
        {
            _product = product;
            _year = year;

            CreateStatisticReport();
        }

        void CreateStatisticReport()
        {
            for (int i = 1; i <= 12; i++)
            {
                _monthlyStatisticsReports.Add(new MontlyProductStatistic(_product, _year, i));
            }
        }

        int _year;
        Product _product;

        List<MontlyProductStatistic> _monthlyStatisticsReports = [];

        public List<MontlyProductStatistic> MontlyProductStatistics => _monthlyStatisticsReports;

        public int Year => _year;
        public Product Product => _product;

        public decimal TotalQuantity => _monthlyStatisticsReports.Sum(x => x.Quantity);
        public decimal TotalArea => _monthlyStatisticsReports.Sum(x => x.Area);
        public decimal AverageQuantity => _monthlyStatisticsReports.Average(x => x.Quantity);
        public decimal AverageArea => _monthlyStatisticsReports.Average(x => x.Area);

        public decimal TotalCost => _monthlyStatisticsReports.Sum(x => x.Cost);
        public decimal TotalPrice => _monthlyStatisticsReports.Sum(x => x.Price);
        public decimal AverageCost => _monthlyStatisticsReports.Average(x => x.Cost);
        public decimal AveragePrice => _monthlyStatisticsReports.Average(x => x.Price);
    }
}
