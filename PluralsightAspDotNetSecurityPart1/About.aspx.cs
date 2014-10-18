using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PluralsightAspDotNetSecurityPart1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Creating an unhandled exception
            var i = Convert.ToInt16("x");

            //Causes alot of 
            //info about the server shown to the end user

            //to fix we need to add to web.config
            //a custom entry into system.web
            //<customErrors mode="RemoteOnly"></customErrors>

            //Remote only is great for development
            //it will allow debug messages be show when working in a local mode (development)
            //and it wont display an debug messages in remote mode (production)

            //now the internal server code and path and framework version
            //is not shown anymore when an exception occurs

        }
    }
}