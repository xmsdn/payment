﻿using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceUserlevelZrankGetResponse.
    /// </summary>
    public class AlipayDataDataserviceUserlevelZrankGetResponse : AlipayResponse
    {
        /// <summary>
        /// 活跃高价值用户返回
        /// </summary>
        [JsonProperty("result")]
        public AlipayHighValueCustomerResult Result { get; set; }
    }
}
