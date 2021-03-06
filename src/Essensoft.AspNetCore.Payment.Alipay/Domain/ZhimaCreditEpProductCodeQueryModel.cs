﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpProductCodeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpProductCodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 二维码唯一标识id
        /// </summary>
        [JsonProperty("code_id")]
        public string CodeId { get; set; }

        /// <summary>
        /// 查询结束日期，与开始日期为左闭右闭
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 页码序号，默认从1开始，每页默认为最多300条记录
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 查询开始日期，与结束日期为左闭右闭
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }
    }
}
