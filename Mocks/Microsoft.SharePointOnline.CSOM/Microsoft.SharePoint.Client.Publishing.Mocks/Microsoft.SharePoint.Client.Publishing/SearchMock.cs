
namespace Microsoft.SharePoint.Client.Publishing
{
    public class SearchMock : Search
    {


        public override System.Int32[] QueryLanguages => QueryLanguagesEx;
        public System.Int32[] QueryLanguagesEx { get; set; }

    }
}

