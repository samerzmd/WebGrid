using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebGrid.Models
{
    public class PagedList<T>
    {

        public PagedList(int pageSize=10)
        {
            Items=new List<T>();
            this.PageSize = pageSize;
        }

        public int Count { get; set; }
        public int PageSize { get; set; }
        public List<T> Items { get; set; }
    }
}
