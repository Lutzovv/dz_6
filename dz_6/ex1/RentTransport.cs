using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_6.ex1
{
    public class RentTransport<T> where T : ITransport
    {
        public string FIO { get; set; }
        public T TransportType { get; set; }
        public double RentTime { get; set; }
        public double RentCost { get; set; }

        public string Infomation() => $"Транспорт: {TransportType}\nВремя аренды: {RentTime}\nФИО клиента: {FIO}\nСтоимость аренды: {RentTime * RentCost}";
    }
}
