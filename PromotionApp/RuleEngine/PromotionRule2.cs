using System;
using System.Collections.Generic;
using PromotionApp.Models;
using System.Linq;


namespace PromotionApp.RuleEngine
{
    public class PromotionRule2 : IRuleService
    {

        private string _productType1;
        private string _productType2;

        private int _price;

        // when SKUtype1 and SKU type2 are bought together it is at the offer price
        public PromotionRule2(string productType1, string productType2, int price)
        {
            this._productType1 = productType1;
            this._productType2 = productType2;
            this._price = price;
        }

        public List<string> RunRule(List<string> cart)
        {

            if (!IsItemApplicable(cart))
            {
                throw new Exception("Rule applied  not applicable");
            }

            List<string> newcart = new List<string>();
            bool found1 = false, found2 = false;

            //Delete required number of items consumed by the rule; return the rest;
            foreach (var item in cart)
            {
                if (item == _productType1 && !found1)
                {
                    found1 = true;
                    continue;
                }
                if (item == _productType2 && !found2)
                {
                    found2 = true;
                    continue;
                }
                newcart.Add(item);
            }
            return newcart;
        }

        public string getMessage()
        {
            return "Rule Applied: (" + _productType1 + " + " + _productType2 + ") for " + _price;
        }

        public bool IsItemApplicable(List<string> cart)
        {

            return cart.Any(x => x == _productType1) && cart.Any(x => x == _productType2);
        }
    }

}