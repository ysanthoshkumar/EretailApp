using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EretailApp
{
    class ProductModel
    { 
        public String name
    {
        get;
        set;
    }
    public String Dept
    {
        get;
        set;
    }

    public string category { get; set; }

        public string Sku { get; set; }
        public string EANCode { get; set; }
        public string Qty { get; set; }
        public string FreeQty { get; set; }
        public string Rate { get; set; }
        public string Tax { get; set; }
        public string Amount { get; set; }
        public string Variant { get; set; }
        public string Remarks { get; set; }
        public string Icon { get; set; }

}
}