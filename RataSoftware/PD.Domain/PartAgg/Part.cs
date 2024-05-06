using _0_Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectDetail.Domain.PartAgg
{
    public class Part:EntityBase
    {
        public string PartName { get; private set; }
        public int Number { get; private set; }
        public long InvoiceId { get; private set; }
   
        public Part(string partName, int number, long invoiceId)
        {
            PartName = partName;
            Number = number;
            InvoiceId = invoiceId;

        }
    }
}
