using _0_Framework.Domain;
using projectDetail.Domain.ProjectAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDetail.Domain.InvoiceAgg
{
  public class Invoice:EntityBase
    {
            public string ProductName { get; private set; }
            public string ProductQty { get; private set; }
            public long UnitPrice { get; private set; }
            public long TotalPrice { get; private set; }
            public DateTime DeliveryDate { get; private set; }
            public long ProjectId { get; private set; }


        public Invoice(string productName,string productQty, long unitPrice,long totalPrice, DateTime deliveryDate,long projectId)
        {
                ProductName = productName;
                ProductQty = productQty;
                UnitPrice = unitPrice;
                TotalPrice = totalPrice;
                DeliveryDate = deliveryDate;
                ProjectId = projectId;

        }
        

    }
}
