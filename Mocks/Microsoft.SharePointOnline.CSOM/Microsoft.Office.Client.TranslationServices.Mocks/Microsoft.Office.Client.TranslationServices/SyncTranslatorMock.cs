
namespace Microsoft.Office.Client.TranslationServices
{
    public class SyncTranslatorMock : SyncTranslator
    {


        public override Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehavior => OutputSaveBehaviorEx;
        public Microsoft.Office.Client.TranslationServices.SaveBehavior OutputSaveBehaviorEx { get; set; }

    }
}
