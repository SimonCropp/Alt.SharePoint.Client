
namespace Microsoft.SharePoint.Client.UserProfiles
{
    public class PersonPropertiesMock
    {


        public override System.String AccountName => AccountNameEx;
        public System.String AccountNameEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> DirectReports => DirectReportsEx;
        public System.Collections.Generic.IEnumerable`1<System.String> DirectReportsEx { get; set; }

        public override System.String DisplayName => DisplayNameEx;
        public System.String DisplayNameEx { get; set; }

        public override System.String Email => EmailEx;
        public System.String EmailEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> ExtendedManagers => ExtendedManagersEx;
        public System.Collections.Generic.IEnumerable`1<System.String> ExtendedManagersEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> ExtendedReports => ExtendedReportsEx;
        public System.Collections.Generic.IEnumerable`1<System.String> ExtendedReportsEx { get; set; }

        public override System.Boolean IsFollowed => IsFollowedEx;
        public System.Boolean IsFollowedEx { get; set; }

        public override System.String LatestPost => LatestPostEx;
        public System.String LatestPostEx { get; set; }

        public override System.Collections.Generic.IEnumerable`1<System.String> Peers => PeersEx;
        public System.Collections.Generic.IEnumerable`1<System.String> PeersEx { get; set; }

        public override System.String PersonalUrl => PersonalUrlEx;
        public System.String PersonalUrlEx { get; set; }

        public override System.String PictureUrl => PictureUrlEx;
        public System.String PictureUrlEx { get; set; }

        public override System.String Title => TitleEx;
        public System.String TitleEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.String> UserProfileProperties => UserProfilePropertiesEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> UserProfilePropertiesEx { get; set; }

        public override System.String UserUrl => UserUrlEx;
        public System.String UserUrlEx { get; set; }

    }
}

