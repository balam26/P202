using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202.Data
{
    public class Sell
    {
        #region propiedades
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime SellDate { get; set; }
        public int Folio { get; set;}

        #endregion
    }
}
