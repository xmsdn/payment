﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishRuleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringDishRuleCreateModel : AlipayObject
    {
        /// <summary>
        /// 菜品规则通用模型
        /// </summary>
        [JsonProperty("kb_dish_rule_info")]
        public KbdishRuleInfo KbDishRuleInfo { get; set; }
    }
}
