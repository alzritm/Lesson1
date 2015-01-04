using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    public class Sales
    {
        private List<Fields> _columns;
        //public List<Fields> columns {
        //    get { return _columns; }
        //    set
        //    {
        //        _columns = new List<Fields>();
        //        _columns.Add(
        //            new Fields
        //            {
        //                caption = "recid",
        //                field = "ID",
        //                size = "50px",
        //                sortable = true
        //            }
        //            );
        //        _columns.Add(
        //            new Fields
        //            {
        //                caption = "Date",
        //                field = "Дата",
        //                size = "150px",
        //                sortable = true
        //            });
        //        _columns.Add(
        //            new Fields
        //            {
        //                caption = "Name",
        //                field = "Имя",
        //                size = "140px",
        //                sortable = true
        //            });
        //        _columns.Add(
        //            new Fields
        //            {
        //                caption = "Count",
        //                field = "Количество",
        //                size = "140px",
        //                sortable = true
        //            });
        //        _columns.Add(
        //            new Fields
        //            {
        //                caption = "Comment",
        //                field = "Комментарий",
        //                size = "100",
        //                sortable = true
        //            });
                
        //    }
        //}
        public List<SalesList> records { get; set; }
        

    }
    
}
