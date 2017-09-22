using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiMarketingCampaignDetailInfoQueryResponse.
	/// </summary>
	public class KoubeiMarketingCampaignDetailInfoQueryResponse : AopResponse
	{
		/// <summary>
		///     适用门店:门店与门店之间用“,”隔开
		/// </summary>
		[XmlElement("limit_shops")]
		public string LimitShops { get; set; }
	}
}