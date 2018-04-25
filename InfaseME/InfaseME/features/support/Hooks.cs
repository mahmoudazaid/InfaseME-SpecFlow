using TechTalk.SpecFlow;

namespace InfaseME.features.support
{
    [Binding]
    public sealed class Hooks
    {

        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //Open the browser before excute Feature File
        [BeforeFeature]
        public static void ChromeBrowser()
        {
            Driver.Intitialize();
        }

        //Close the browser after finishing Feature file execuation
        [AfterFeature]
        public static void AfterFeature()
        {
            Driver.Close();
        }
    }
}