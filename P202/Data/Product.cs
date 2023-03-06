using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P202.Data
{
    public class Product
    {
        #region Propiedades
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public string SerialNumber { get; set; }
        #endregion
    }
}
