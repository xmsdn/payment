﻿using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneCouponSendResponse.
    /// </summary>
    public class AlipayInsSceneCouponSendResponse : AlipayResponse
    {
        /// <summary>
        /// 发奖凭证
        /// </summary>
        [JsonProperty("certificate")]
        public InsCertificate Certificate { get; set; }

        /// <summary>
        /// 活动ID
        /// </summary>
        [JsonProperty("compaign_id")]
        public string CompaignId { get; set; }

        /// <summary>
        /// 发奖流水ID
        /// </summary>
        [JsonProperty("flow_id")]
        public string FlowId { get; set; }

        /// <summary>
        /// 保险产品
        /// </summary>
        [JsonProperty("product")]
        public InsProduct Product { get; set; }
    }
}
