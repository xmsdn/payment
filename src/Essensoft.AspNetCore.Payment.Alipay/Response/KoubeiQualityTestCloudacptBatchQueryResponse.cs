﻿using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptBatchQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptBatchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 批次列表
        /// </summary>
        [JsonProperty("batch_list")]
        public List<OpenBatch> BatchList { get; set; }

        /// <summary>
        /// 单品批次数
        /// </summary>
        [JsonProperty("batch_num")]
        public string BatchNum { get; set; }
    }
}
