﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMenuDataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMenuDataBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 开始日期
        /// </summary>
        [JsonProperty("begin_date")]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期，开始日期/结束日期时间跨度最大30天
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }
}
