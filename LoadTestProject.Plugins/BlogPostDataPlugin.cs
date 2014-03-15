using System;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace LoadTestProject.Plugins
{
    [DisplayName("Blog Post Data Plugin")]
    [Description("Adds a context parameters for Title and Content.")]
    public class BlogPostDataPlugin : WebTestPlugin
    {

        [DisplayName("Title Parameter Name")]
        [Description("The name of the context parameter for Blog title.")]
        [DefaultValue("TitleField")]
        public string TitleParameterName { get; set; }

        [DisplayName("Content Parameter Name")]
        [Description("The name of the context parameter to store the Blog content.")]
        [DefaultValue("ContentField")]
        public string ContentParameterName { get; set; }

        public override void PreWebTest(object sender, PreWebTestEventArgs e)
        {
            base.PreWebTest(sender, e);
        }

        public override void PrePage(object sender, PrePageEventArgs e)
        {
            base.PrePage(sender, e);
        }

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            base.PreRequest(sender, e);

            // the TestNumber parameter comes from the MyTestPlugin which is connected to the CreatePost.loadtest
            var testNumber = -1;
            if(e.WebTest.Context.ContainsKey("testNumber"))
                testNumber = (int)e.WebTest.Context["testNumber"];

            // the PostId parameter comes from the extraction rule contained in the EditPost.webtest
            string postId = "";
            if (e.WebTest.Context.ContainsKey("PostId"))
                postId = e.WebTest.Context["PostId"].ToString();


            // Content field will have TestNumber, PostId, timestamp, and new GUID
            e.WebTest.Context[this.ContentParameterName] = string.Format("TestNumber: {0} postId: {1} at: {2} id: {3}", testNumber, postId, DateTime.Now, Guid.NewGuid());

            // Title field will be random number between 0-100
            var rand = new Random();
            e.WebTest.Context[this.TitleParameterName] = string.Format("Random Number: {0}", rand.Next(101));
        }
    }
}
