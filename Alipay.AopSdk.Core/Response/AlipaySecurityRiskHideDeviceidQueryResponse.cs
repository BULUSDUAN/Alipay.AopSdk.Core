using System.Xml.Serialization;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityRiskHideDeviceidQueryResponse.
	/// </summary>
	public class AlipaySecurityRiskHideDeviceidQueryResponse : AopResponse
	{
		/// <summary>
		///     设备指纹的apdid
		/// </summary>
		[XmlElement("deviceid")]
		public string Deviceid { get; set; }
	}
}