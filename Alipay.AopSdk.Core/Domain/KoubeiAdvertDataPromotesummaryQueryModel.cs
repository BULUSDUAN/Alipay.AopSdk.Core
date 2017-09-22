using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertDataPromotesummaryQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertDataPromotesummaryQueryModel : AopObject
	{
		/// <summary>
		///     广告id  如果有这个参数默认搜索这个广告的汇总信息并忽略voucher_name参数
		/// </summary>
		[XmlElement("adv_id")]
		public string AdvId { get; set; }

		/// <summary>
		///     结束时间
		/// </summary>
		[XmlElement("end_date")]
		public string EndDate { get; set; }

		/// <summary>
		///     扩展信息
		/// </summary>
		[XmlElement("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     开始时间
		/// </summary>
		[XmlElement("start_date")]
		public string StartDate { get; set; }
	}
}