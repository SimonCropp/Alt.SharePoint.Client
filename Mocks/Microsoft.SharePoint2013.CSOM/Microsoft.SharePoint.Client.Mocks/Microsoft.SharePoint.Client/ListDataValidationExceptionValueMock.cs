
namespace Microsoft.SharePoint.Client
{
    public class ListDataValidationExceptionValueMock
    {


        public override System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.ListDataValidationFailure> FieldFailures => FieldFailuresEx;
        public System.Collections.Generic.IList`1<Microsoft.SharePoint.Client.ListDataValidationFailure> FieldFailuresEx { get; set; }

        public override Microsoft.SharePoint.Client.ListDataValidationFailure ItemFailure => ItemFailureEx;
        public Microsoft.SharePoint.Client.ListDataValidationFailure ItemFailureEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

