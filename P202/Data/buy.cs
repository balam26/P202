using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202.Data
{
    public class buy
    {
        #region propiedades
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public DateTime BuyDate { get; set; }
        public int Folio { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
