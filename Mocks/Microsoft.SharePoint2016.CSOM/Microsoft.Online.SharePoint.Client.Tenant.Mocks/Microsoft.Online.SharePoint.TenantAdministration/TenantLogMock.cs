
namespace Microsoft.Online.SharePoint.TenantAdministration
{
    public class TenantLogMock : TenantLog
    {


        public override System.DateTime LastAvailableTimeInUtc => LastAvailableTimeInUtcEx;
        public System.DateTime LastAvailableTimeInUtcEx { get; set; }

    }
}
