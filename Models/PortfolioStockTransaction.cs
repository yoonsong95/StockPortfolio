﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockPortfolio.Models
{
    public enum TransactionType
    {
        Buy,
        Sell
    }

    public class PortfolioStockTransaction
    {
        public int ID { get; set; }
        public int PortfolioStockID { get; set; }        // foreign key
        public DateTime TransactionDateTime { get; set; }
        public TransactionType TransactionType { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public PortfolioStock PortfolioStock { get; set; }        // navigation property
    }
}