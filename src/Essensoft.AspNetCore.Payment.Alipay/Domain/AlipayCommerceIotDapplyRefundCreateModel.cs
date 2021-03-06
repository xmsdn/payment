﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotDapplyRefundCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDapplyRefundCreateModel : AlipayObject
    {
        /// <summary>
        /// 物料申请单号
        /// </summary>
        [JsonProperty("asset_apply_order_id")]
        public string AssetApplyOrderId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }
    }
}
