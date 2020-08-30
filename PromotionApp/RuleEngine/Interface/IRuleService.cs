using System;
using System.Collections.Generic;

namespace PromotionApp.RuleEngine
{
    public interface IRuleService
    {
        bool IsItemApplicable(List<string> cart);

        List<string> RunRule(List<string> cart);
        string getMessage();
    }
}