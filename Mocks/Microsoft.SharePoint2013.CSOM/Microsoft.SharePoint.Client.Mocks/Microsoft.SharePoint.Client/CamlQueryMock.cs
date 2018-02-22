
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class CamlQueryMock : CamlQuery
    {


        public override System.Boolean DatesInUtc => DatesInUtcEx;
        public System.Boolean DatesInUtcEx { get; set; }

        public override System.String FolderServerRelativeUrl => FolderServerRelativeUrlEx;
        public System.String FolderServerRelativeUrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPosition => ListItemCollectionPositionEx;
        public Microsoft.SharePoint.Client.ListItemCollectionPosition ListItemCollectionPositionEx { get; set; }

        public override System.String ViewXml => ViewXmlEx;
        public System.String ViewXmlEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

