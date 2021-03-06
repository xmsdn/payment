﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosSidedishbatchSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosSidedishbatchSaveModel : AlipayObject
    {
        /// <summary>
        /// 需要添加配菜的菜品ID
        /// </summary>
        [JsonProperty("dish_ids")]
        public List<string> DishIds { get; set; }

        /// <summary>
        /// 批量添加的配菜
        /// </summary>
        [JsonProperty("dish_material_list")]
        public List<PosDishMaterialModel> DishMaterialList { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
