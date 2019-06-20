﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransTrusteeshipAccountCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransTrusteeshipAccountCreateModel : AlipayObject
    {
        /// <summary>
        /// 开户产品码，开户的具体业务类型
        /// </summary>
        [JsonProperty("account_product_code")]
        public string AccountProductCode { get; set; }

        /// <summary>
        /// 外部商户系统会员的唯一标识
        /// </summary>
        [JsonProperty("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 用户类型  党组织:PARTY_ORGANIZATION  企业组织:BUSINESS_ORGANIZATION  企业员工:BUSINESS_EMPLOYEE
        /// </summary>
        [JsonProperty("merchant_user_type")]
        public string MerchantUserType { get; set; }
    }
}