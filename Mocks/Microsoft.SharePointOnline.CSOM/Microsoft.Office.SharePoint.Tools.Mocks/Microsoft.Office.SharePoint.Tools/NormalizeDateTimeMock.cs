
namespace Microsoft.Office.SharePoint.Tools
{
    public class NormalizeDateTimeMock : NormalizeDateTime
    {


        public override Microsoft.Office.SharePoint.Tools.LobDateTimeMode LobDateTimeMode => LobDateTimeModeEx;
        public Microsoft.Office.SharePoint.Tools.LobDateTimeMode LobDateTimeModeEx { get; set; }

    }
}
