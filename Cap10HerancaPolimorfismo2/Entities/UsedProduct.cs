using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cap10HerancaPolimorfismo2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + "(Used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " ( Manufacture date: " + ManufactureDate + ")";
        }
    }
}
