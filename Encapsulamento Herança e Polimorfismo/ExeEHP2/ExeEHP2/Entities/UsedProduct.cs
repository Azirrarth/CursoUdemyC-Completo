﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ExeEHP2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }



        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufactured date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + " )";
        }
    }
}
