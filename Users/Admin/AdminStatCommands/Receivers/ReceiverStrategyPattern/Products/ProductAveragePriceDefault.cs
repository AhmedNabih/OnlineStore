﻿using OnlineStore.srcFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Users.Admin.AdminStatCommands.Receivers.ReceiverStrategyPattern.Products
{
    public class ProductAveragePriceDefault : IAverage
    {
        private DataBaseQueries query;

        public ProductAveragePriceDefault()
        {
            query = new DataBaseQueries();
        }

        public String Average()
        {
            double res1 = Convert.ToInt32(query.StorePricesSum());
            int res2 = Convert.ToInt32(query.StorePricesCnt());
            return "Store prices Average: " + ((double)res1 / res2).ToString();
        }
    }
}
