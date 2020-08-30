using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionApp.RuleEngine
{
    public class PromotionRule1 : IRuleService
    {

        private string _productName;
        private int _qty;
        private int _price;
        public PromotionRule1(string productName, int qty, int price)

        {
            this._productName = productName;
            this._qty = qty;
            this._price = price;
        }

        public string getMessage()
        {
            return "Rule Applied: " + _qty + _productName + " for " + _price;
        }

        public bool IsItemApplicable(List<string> cart)
        {
            return cart.Where(x => x == _productName).Count() >= _qty;
        }

        public List<string> RunRule(List<string> cart)
        {
            if (!IsItemApplicable(cart))
            {
                throw new Exception("Rule applied not applicable");
            }

            List<string> newcart = new List<string>();
            int i = 0;

            //Delete required number of items consumed by the rule; return the rest;
            foreach (var item in cart)
            {
                if (item == _productName && i < _qty)
                {
                    i++;
                    continue;
                }
                newcart.Add(item);
            }
            return newcart;
        }
    }
}