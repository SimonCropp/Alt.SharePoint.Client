
namespace Microsoft.SharePoint.Client
{
    public class WebRequestEventArgsMock : WebRequestEventArgs
    {


        public override Microsoft.SharePoint.Client.WebRequestExecutor WebRequestExecutor => WebRequestExecutorEx;
        public Microsoft.SharePoint.Client.WebRequestExecutor WebRequestExecutorEx { get; set; }

    }
}
