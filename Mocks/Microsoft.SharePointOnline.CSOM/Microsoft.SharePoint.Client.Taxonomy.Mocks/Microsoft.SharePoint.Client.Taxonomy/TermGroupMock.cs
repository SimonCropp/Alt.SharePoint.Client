
namespace Microsoft.SharePoint.Client.Taxonomy
{
    public class TermGroupMock
    {


        public override System.Collections.Generic.IEnumerable`1<System.String> ContributorPrincipalNames => ContributorPrincipalNamesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> ContributorPrincipalNamesEx { get; set; }

        public override System.String Description => DescriptionEx;
        public System.String DescriptionEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> GroupManagerPrincipalNames => GroupManagerPrincipalNamesEx;
        public System.Collections.Generic.IEnumerable`1<System.String> GroupManagerPrincipalNamesEx { get; set; }

        public override System.Boolean IsSiteCollectionGroup => IsSiteCollectionGroupEx;
        public System.Boolean IsSiteCollectionGroupEx { get; set; }

        public override System.Boolean IsSystemGroup => IsSystemGroupEx;
        public System.Boolean IsSystemGroupEx { get; set; }

        public override Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSets => TermSetsEx;
        public Microsoft.SharePoint.Client.Taxonomy.TermSetCollection TermSetsEx { get; set; }

    }
}

