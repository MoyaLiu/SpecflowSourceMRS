using MarsQA_1.Helpers;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ExcelPath, "TestData");
            
        }

        [AfterScenario]
        public void TearDown()
        {
           //Screenshot
           string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");

           //Close the browser
           //Close();
           
        }
    }
}
