
namespace Microsoft.SharePoint.Client.Microfeed
{
    public class MicrofeedDataCollectionMock
    {


        public override System.DateTime LastItemDeletedDate => LastItemDeletedDateEx;
        public System.DateTime LastItemDeletedDateEx { get; set; }

    }
}

