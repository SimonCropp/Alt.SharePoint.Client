
namespace Microsoft.SharePoint.Client
{
    public class RequestForwarderMock
    {


        public override System.String Url => UrlEx;
        public System.String UrlEx { get; set; }

        public override Microsoft.SharePoint.Client.ExternalApplicationRequestToken RequestToken => RequestTokenEx;
        public Microsoft.SharePoint.Client.ExternalApplicationRequestToken RequestTokenEx { get; set; }

        public override System.Net.HttpWebRequest WebRequest => WebRequestEx;
        public System.Net.HttpWebRequest WebRequestEx { get; set; }

    }
}

