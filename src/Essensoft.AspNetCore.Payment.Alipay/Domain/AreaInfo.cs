using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AreaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AreaInfo : AlipayObject
    {
        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        [XmlElement("province")]
        public string Province { get; set; }
    }
}
