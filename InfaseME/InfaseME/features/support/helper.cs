using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace InfaseME.features.support
{
    [Binding]
    public sealed class helper
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        [When(@"I wait (.*) seconds")]
        public void WhenIWaitSeconds(int number)
        {
            Thread.Sleep(number*1000);
        }

    }
}
