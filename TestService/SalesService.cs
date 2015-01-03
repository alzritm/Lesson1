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
        private List<SalesList> _sales;
        /// <summary>
        /// Список данных для таблицы
        /// </summary>
        /// <returns></returns>
        public List<SalesList> GetList()
        {
            var sales =new List<SalesList>
            {
                new SalesList
                {
                    recid = 1,
                    Date = DateTime.Now.ToShortDateString().Replace(".","/"),
                    Name = "Первая",
                    Count = 1,
                    Comment = ""
                },
                 new SalesList
                {
                    recid = 2,
                    Date = DateTime.Now.ToShortDateString().Replace(".","/"),
                    Name = "Вторая",
                    Count = 3,
                    Comment = ""
                }
            };
            var i = 2;
            while (i < 100)
            {
                i++;
                sales.Add(new SalesList
                {
                    recid = i,
                    Date = DateTime.Now.ToShortDateString().Replace(".", "/"),
                    Name = String.Format("Запись номер {0}", i),
                    Count = 1+i,
                    Comment = "generated"
                });

            }
            
            _sales = new List<SalesList>(sales);
            return sales;
        }

        public int GetNuberSales()
        {
            return _sales.Count;
        }
    }
}
