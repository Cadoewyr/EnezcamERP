using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace EnezcamERP.Forms.DataGridColumnHeaderTemplates
{
    public class Template
    {
        public static Dictionary<string, string> DailyProduction
        {
            get
            {
                Dictionary<string, string> temp = new();
                temp.Add("clmDate", "Tarih");
                temp.Add("clmCustomerName", "Cari Adı");
                temp.Add("clmJobNo", "Sipariş No");
                temp.Add("clmProductName", "Ürün Adı");
                temp.Add("clmProcessType", "Tür");
                temp.Add("clmQuantity", "Miktar");
                temp.Add("clmUnitCode", "Birim");
                temp.Add("clmUnitPrice", "Birim Fiyat");
                temp.Add("clmPrice", "Fiyat");
                temp.Add("clmCustomerTotal", "Cari Toplam Tutarı");
                temp.Add("clmUnitCost", "Birim Maliyet");
                temp.Add("clmCost", "Maliyet");
                temp.Add("clmProfit", "Kar");
                temp.Add("clmProfitRatio", "Kar Oranı");

                return temp;
            }
        }
        public static Dictionary<string, string> DateRangedProduction
        {
            get
            {
                Dictionary<string, string> temp = new();
                temp.Add("clmDate", "Tarih");
                temp.Add("clmPrice", "Satış Tutarı");
                temp.Add("clmCost", "Malzeme Maliyeti");
                temp.Add("clmProfit", "Malzeme Karı");
                temp.Add("clmProfitRatio", "Malzeme Kar Oranı");
                temp.Add("clmOutgoing", "Sabit Gider");
                temp.Add("clmCostWithOutgoing", "Sabit Gider Dahil Maliyet");
                temp.Add("clmProfitWithoutOutgoing", "Sabit Gider Düşüldükten Sonra Kar");
                temp.Add("clmProfitRatioWithoutOutgoing", "Sabit Gider Sonrası Kar");

                return temp;
            }
        }
    }
}
