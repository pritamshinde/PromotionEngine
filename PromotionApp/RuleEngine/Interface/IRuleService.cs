using System;
using System.Collections.Generic;

namespace PromotionApp.RuleEngine
{
    public interface IRuleService
    {
        bool IsApplicable(List<string> cart);

        List<string> Apply(List<string> cart);
        string getPrettyMessage();
    }
}