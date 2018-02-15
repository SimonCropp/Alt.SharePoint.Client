
namespace Microsoft.SharePoint.Client
{
    public class CreatableItemInfoMock
    {


        public override System.Int32 DocumentTemplate => DocumentTemplateEx;
        public System.Int32 DocumentTemplateEx { get; set; }

        public override System.String FileExtension => FileExtensionEx;
        public System.String FileExtensionEx { get; set; }

        public override System.String ItemType => ItemTypeEx;
        public System.String ItemTypeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

