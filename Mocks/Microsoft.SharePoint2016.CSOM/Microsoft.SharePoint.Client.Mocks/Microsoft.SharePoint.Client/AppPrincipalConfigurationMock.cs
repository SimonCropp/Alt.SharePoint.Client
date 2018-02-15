
namespace Microsoft.SharePoint.Client
{
    public class AppPrincipalConfigurationMock : AppPrincipalConfiguration
    {


        public override System.Collections.Generic.IList`1<System.String> ApplicationEndpointAuthorities => ApplicationEndpointAuthoritiesEx;
        public System.Collections.Generic.IList`1<System.String> ApplicationEndpointAuthoritiesEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> ApplicationPrincipalNames => ApplicationPrincipalNamesEx;
        public System.Collections.Generic.IList`1<System.String> ApplicationPrincipalNamesEx { get; set; }

        public override System.String NameIdentifier => NameIdentifierEx;
        public System.String NameIdentifierEx { get; set; }

        public override System.Collections.Generic.IList`1<System.String> RedirectAddresses => RedirectAddressesEx;
        public System.Collections.Generic.IList`1<System.String> RedirectAddressesEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}
