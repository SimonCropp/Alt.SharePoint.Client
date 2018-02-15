
namespace Microsoft.SharePoint.Client
{
    public class WebResponseInfoMock
    {


        public override System.String Body => BodyEx;
        public System.String BodyEx { get; set; }

        public override System.Collections.Generic.IDictionary`2<System.String,System.String> Headers => HeadersEx;
        public System.Collections.Generic.IDictionary`2<System.String,System.String> HeadersEx { get; set; }

        public override System.Int32 StatusCode => StatusCodeEx;
        public System.Int32 StatusCodeEx { get; set; }

        public override System.String TypeId => TypeIdEx;
        public System.String TypeIdEx { get; set; }

    }
}

