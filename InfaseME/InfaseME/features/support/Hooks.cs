using TechTalk.SpecFlow;

namespace InfaseME.features.support
{
    [Binding]
    public sealed class Hooks
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void ChromeBrowser()
        {
            Driver.Intitialize();
        }


        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Close();
        }
    }
}