using System;
using PromotionApp.Models;
using PromotionApp.RuleEngine;
using System.Collections.Generic;
using System.Linq;

namespace PromotionApp
{
    public class Program
    {
        public static List<IRuleService> rules;

        public static List<string> defaultCart;
        // available Product
        public static List<Product> products = new List<Product>()
        {
                 new Product()
                 {
                     productName ="A",
                     price = 20
                 },
                   new Product()
                 {
                       productName ="B",
                       price = 30
                 },
                   new Product()
                 {
                       productName ="C",
                       price = 20
                 },
                   new Product()
                 {
                       productName ="D",
                       price = 20
                 }

        };

        static void Main(string[] args)
        {
            SetupScenario();

            var cart = defaultCart;

            Console.WriteLine("--Promotion Rules Applied ---- ");

            //Apply all rules
            foreach (var rule in rules)
            {
                //Apply each rule repeatedly
                while (rule.IsItemApplicable(cart))
                {
                    cart = rule.RunRule(cart);
                    Console.WriteLine(rule.getMessage());
                }
            }

            // Print out the items that didn't belong to any rule
            Console.WriteLine();
            Console.WriteLine("--Produt--");
            foreach (var item in cart)
            {
                Console.WriteLine(item + " for " + products.Where(x => x.productName == item).FirstOrDefault().price);
            }

            Console.ReadKey();
        }

        //setup scenarios
        public static void SetupScenario()
        {
            rules = new List<IRuleService>();
            rules.Add(new PromotionRule1("A", 3, 130));
            rules.Add(new PromotionRule2("C", "D", 30));
            defaultCart = new List<string>();
            defaultCart.Add("A");
            defaultCart.Add("A");
            defaultCart.Add("A");
            defaultCart.Add("A");
            defaultCart.Add("B");
            defaultCart.Add("C");
        }
    }
}
