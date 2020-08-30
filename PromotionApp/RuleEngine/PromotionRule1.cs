using System.Collections.Generic;

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
            throw new System.NotImplementedException();
        }

        public bool IsItemApplicable(List<string> cart)
        {
            throw new System.NotImplementedException();
        }

        public List<string> RunRule(List<string> cart)
        {
            throw new System.NotImplementedException();
        }
    }
}