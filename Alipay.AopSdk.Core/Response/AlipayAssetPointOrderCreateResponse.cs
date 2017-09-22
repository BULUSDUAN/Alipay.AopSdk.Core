using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayAssetPointOrderCreateResponse.
	/// </summary>
	public class AlipayAssetPointOrderCreateResponse : AopResponse
	{
		/// <summary>
		///     支付宝集分宝发放流水号
		/// </summary>
		[XmlElement("alipay_order_no")]
		public string AlipayOrderNo { get; set; }
	}
}