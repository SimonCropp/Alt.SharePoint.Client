
namespace Microsoft.SharePoint.Client
{
    public class RemoteWebMock
    {


        public override System.Boolean CanSendEmail => CanSendEmailEx;
        public System.Boolean CanSendEmailEx { get; set; }

        public override System.Boolean ShareByEmailEnabled => ShareByEmailEnabledEx;
        public System.Boolean ShareByEmailEnabledEx { get; set; }

        public override System.Boolean ShareByLinkEnabled => ShareByLinkEnabledEx;
        public System.Boolean ShareByLinkEnabledEx { get; set; }

        public override Microsoft.SharePoint.Client.Web Web => WebEx;
        public Microsoft.SharePoint.Client.Web WebEx { get; set; }

    }
}

