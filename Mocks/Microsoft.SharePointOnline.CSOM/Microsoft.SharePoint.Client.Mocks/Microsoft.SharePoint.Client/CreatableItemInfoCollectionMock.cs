
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class CreatableItemInfoCollectionMock : CreatableItemInfoCollection
    {


        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

        public override void WriteToXml(System.Xml.XmlWriter @writer, Microsoft.SharePoint.Client.SerializationContext @serializationContext)
        {
        }

    }
}

