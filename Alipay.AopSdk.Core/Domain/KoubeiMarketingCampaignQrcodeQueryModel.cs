using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignQrcodeQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignQrcodeQueryModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[XmlElement("camp_id")]
		public string CampId { get; set; }
	}
}