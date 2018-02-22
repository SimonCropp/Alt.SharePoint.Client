
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.TenantCdn
{
    public class TenantCdnUrlMock : TenantCdnUrl
    {


        public override System.String CdnUrl => CdnUrlEx;
        public System.String CdnUrlEx { get; set; }

        public override System.DateTime ExpirationTimeUtc => ExpirationTimeUtcEx;
        public System.DateTime ExpirationTimeUtcEx { get; set; }

        public override System.Boolean IsCdnUrlAvailable => IsCdnUrlAvailableEx;
        public System.Boolean IsCdnUrlAvailableEx { get; set; }

        public override System.String ItemUrl => ItemUrlEx;
        public System.String ItemUrlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

