using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex3
{
    public class LuxuryItems :ITax, IOutput
    {
        public string ClassName => _type;
        private static readonly string _type = "Предметы роскоши";

        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public string AddTax() => $"Цена на товар: {ItemName} (с учетом налога) будет составлять: {ItemPrice + (ItemPrice * 20 / 100)}";

        public string PrintInfomation() => $"{_type}\nНазвание товара: {ItemName}\nЦена без налога: {ItemPrice}\nЦена с налогом: {ItemPrice + (ItemPrice * 20 / 100)}";
    }
}
