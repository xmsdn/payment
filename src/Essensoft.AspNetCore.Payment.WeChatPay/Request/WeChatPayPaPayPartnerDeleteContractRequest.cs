﻿using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using Essensoft.AspNetCore.Payment.WeChatPay.Utility;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 微信代扣 - 乘车码代扣 - 申请解约
    /// </summary>
    public class WeChatPayPaPayPartnerDeleteContractRequest : IWeChatPayRequest<WeChatPayPaPayPartnerDeleteContractResponse>
    {
        /// <summary>
        /// 子商户应用号
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        public string PlanId { get; set; }

        /// <summary>
        /// 签约协议号
        /// </summary>
        public string ContractCode { get; set; }

        /// <summary>
        /// 委托代扣协议id
        /// </summary>
        public string ContractId { get; set; }

        /// <summary>
        /// 解约备注
        /// </summary>
        public string ContractTerminationRemark { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        public string Version { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/papay/partner/deletecontract";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "plan_id", PlanId },
                { "contract_code", ContractCode },
                { "contract_id", ContractId },
                { "contract_termination_remark", ContractTerminationRemark },
                { "version", Version },
            };
            return parameters;
        }

        public WeChatPaySignType GetSignType()
        {
            return WeChatPaySignType.HMAC_SHA256;
        }

        public void PrimaryHandler(WeChatPayOptions options, WeChatPaySignType signType, WeChatPayDictionary sortedTxtParams)
        {
            sortedTxtParams.Add(WeChatPayConsts.nonce_str, WeChatPayUtility.GenerateNonceStr());
            sortedTxtParams.Add(WeChatPayConsts.appid, options.AppId);
            sortedTxtParams.Add(WeChatPayConsts.mch_id, options.MchId);

            if (signType == WeChatPaySignType.HMAC_SHA256)
            {
                sortedTxtParams.Add(WeChatPayConsts.sign_type, WeChatPayConsts.HMAC_SHA256);
            }

            sortedTxtParams.Add(WeChatPayConsts.sign, WeChatPaySignature.SignWithKey(sortedTxtParams, options.Key, signType));
        }

        public bool GetNeedCheckSign()
        {
            return true;
        }

        #endregion
    }
}
