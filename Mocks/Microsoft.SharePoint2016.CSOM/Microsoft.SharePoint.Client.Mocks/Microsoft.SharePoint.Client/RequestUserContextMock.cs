
namespace Microsoft.SharePoint.Client
{
    public class RequestUserContextMock
    {


        public override Microsoft.SharePoint.Client.User User => UserEx;
        public Microsoft.SharePoint.Client.User UserEx { get; set; }

    }
}

