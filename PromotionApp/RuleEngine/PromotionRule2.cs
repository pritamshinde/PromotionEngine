using System;
using System.Collections.Generic;
using PromotionApp.Models;
using System.Linq;


namespace PromotionApp.RuleEngine
{
    public class promotionRule2 : IRuleService
    {
        private string _productName;
        private int _qty;
        private int _price;
        public promotionRule2(string productName, int qty, int price)

        {
            this._productName = productName;
            this._qty = qty;
            this._price = price;
        }



        public List<string> RunRule(List<string> cart)
        {
            throw new NotImplementedException();
        }

        public string getMessage()
        {
            throw new NotImplementedException();
        }

        public bool IsItemApplicable(List<string> cart)
        {
            throw new NotImplementedException();
        }
    }

}