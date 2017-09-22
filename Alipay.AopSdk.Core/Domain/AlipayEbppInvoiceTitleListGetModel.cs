using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceTitleListGetModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceTitleListGetModel : AopObject
	{
		/// <summary>
		///     支付宝用户id
		/// </summary>
		[XmlElement("user_id")]
		public string UserId { get; set; }
	}
}