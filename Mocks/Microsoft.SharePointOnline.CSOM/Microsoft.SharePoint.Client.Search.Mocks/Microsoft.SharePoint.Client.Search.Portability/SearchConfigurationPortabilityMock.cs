
namespace Microsoft.SharePoint.Client.Search.Portability
{
    public class SearchConfigurationPortabilityMock : SearchConfigurationPortability
    {


        public override System.String ImportWarnings => ImportWarningsEx;
        public System.String ImportWarningsEx { get; set; }

    }
}
