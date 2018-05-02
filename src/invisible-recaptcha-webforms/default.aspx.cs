using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace invisible_recaptcha_webforms
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var recaptchaResponse = Request.Form["g-recaptcha-response"];
            var isRecaptchaValid = Utils.ValidateRecaptcha(recaptchaResponse);
            if (isRecaptchaValid)
            {
                var username = txtUsername.Text;
                var password = txtPassword.Text;
                if (username == "foo" && password == "bar")
                {
                    lblStatus.Text = "Done";
                }
                else
                {
                    lblStatus.Text = "Wrong credentials";
                }
            }
        }
    }
}