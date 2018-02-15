
namespace Microsoft.SharePoint.Client
{
    public class ObjectSharingInformationMock
    {


        public override System.String AnonymousEditLink => AnonymousEditLinkEx;
        public System.String AnonymousEditLinkEx { get; set; }

        public override System.String AnonymousViewLink => AnonymousViewLinkEx;
        public System.String AnonymousViewLinkEx { get; set; }

        public override System.Boolean CanManagePermissions => CanManagePermissionsEx;
        public System.Boolean CanManagePermissionsEx { get; set; }

        public override System.Boolean HasPendingAccessRequests => HasPendingAccessRequestsEx;
        public System.Boolean HasPendingAccessRequestsEx { get; set; }

        public override System.Boolean HasPermissionLevels => HasPermissionLevelsEx;
        public System.Boolean HasPermissionLevelsEx { get; set; }

        public override System.Boolean IsSharedWithCurrentUser => IsSharedWithCurrentUserEx;
        public System.Boolean IsSharedWithCurrentUserEx { get; set; }

        public override System.Boolean IsSharedWithGuest => IsSharedWithGuestEx;
        public System.Boolean IsSharedWithGuestEx { get; set; }

        public override System.Boolean IsSharedWithMany => IsSharedWithManyEx;
        public System.Boolean IsSharedWithManyEx { get; set; }

        public override System.Boolean IsSharedWithSecurityGroup => IsSharedWithSecurityGroupEx;
        public System.Boolean IsSharedWithSecurityGroupEx { get; set; }

        public override System.String PendingAccessRequestsLink => PendingAccessRequestsLinkEx;
        public System.String PendingAccessRequestsLinkEx { get; set; }

    }
}

