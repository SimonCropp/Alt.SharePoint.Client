
// ReSharper disable IdentifierTypo
namespace Microsoft.SharePoint.Client
{
    public class ChangeListMock : ChangeList
    {


        public override System.Guid ListId => ListIdEx;
        public System.Guid ListIdEx { get; set; }

        public override System.Guid WebId => WebIdEx;
        public System.Guid WebIdEx { get; set; }

    }
}

