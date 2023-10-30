using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Code_Test_07
{
    public partial class Validator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string familyName = txtFamilyName.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string zipCode = txtZipCode.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;


            string resultMessage = $@"Name: {name}<br />
                                     Family_Name: {familyName}<br />
                                     Address: {address}<br />
                                     City: {city}<br />
                                     Zip_Code: {zipCode}<br />
                                     Phone: {phone}<br />
                                     Email: {email}<br />";

            resultLabel.Text = resultMessage;
        }
    }
}