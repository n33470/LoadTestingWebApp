using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.LoadTesting;

namespace LoadTestProject.Plugins
{
    public class MyLoadTestPlugin : ILoadTestPlugin
    {

        LoadTest myLoadTest;

        public void Initialize(LoadTest loadTest)
        {
            myLoadTest = loadTest;
            myLoadTest.LoadTestFinished += new EventHandler(myLoadTest_LoadTestFinished);
            myLoadTest.TestStarting += myLoadTest_TestStarting;
            myLoadTest.Context["testNumber"] = 0;
        }

        void myLoadTest_TestStarting(object sender, TestStartingEventArgs e)
        {
            myLoadTest.Context["testNumber"] = (int)myLoadTest.Context["testNumber"] + 1;
            e.TestContextProperties["testNumber"] = myLoadTest.Context["testNumber"];
        }

        void myLoadTest_LoadTestFinished(object sender, EventArgs e)
        {
            
        }
        
    }
}
