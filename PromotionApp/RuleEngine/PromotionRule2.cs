using System;
using System.Collections.Generic;
using PromotionApp.Models;
using System.Linq;


namespace PromotionApp.RuleEngine
{
    public class PromotionRule2 : IRuleService
    {
      
   string _productType1;
        string _productType2;

        int _price;

        // when SKUtype1 and SKU type2 are bought together it is at the offer price
        public PromotionRule2(string productType1, string productType2,int price)
        {
            this._productType1=productType1;
            this._productType2=productType2;
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