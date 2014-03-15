using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace LoadTestProject.Plugins
{
    [DisplayName("URL Manager Plugin")]
    [Description("Adds a context parameter for the base URL to use for testing.")]
    public class UrlManagerPlugin : WebTestPlugin
    {
        public UrlManagerPlugin()
        {
            ContextParameterName = "BaseUrl";
        }

        [DisplayName("Context Parameter Name")]
        [Description("The name of the context parameter to store the base URL.")]
        [DefaultValue("BaseUrl")]
        public string ContextParameterName { get; set; }

        public override void PreWebTest(object sender, PreWebTestEventArgs e)
        {
            base.PreWebTest(sender, e);

            e.WebTest.Context[ContextParameterName] = "http://localhost/LoadTestWebApp/";
        }
        
        public override void PrePage(object sender, PrePageEventArgs e)
        {
            base.PrePage(sender, e);
        }
    }
}
