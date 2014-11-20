using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{

    public interface ISalesService
    {
         List<SalesList> GetList();
        int GetNuberSales();
    }
    public class SalesService : ISalesService
    {
        /// <summary>
        /// Список данных для таблицы
        /// </summary>
        /// <returns></returns>
        public List<SalesList> GetList()
        {
            return new List<SalesList>
            {
                new SalesList
                {
                    Date = DateTime.Now,
                    Name = "Первая",
                    Count = 1,
                    Comment = ""
                },
                 new SalesList
                {
                    Date = DateTime.Now,
                    Name = "Вторая",
                    Count = 3,
                    Comment = ""
                }
            };
        }

        public int GetNuberSales()
        {
            return 3;
        }
    }
}
