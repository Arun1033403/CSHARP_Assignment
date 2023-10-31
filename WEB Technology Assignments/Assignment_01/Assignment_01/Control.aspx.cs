using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_01
{
    public partial class Control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Drag and Drop some Mobile Images
                ddlItems.Items.Add(new ListItem("IKALL K10", "IKALL K10.png"));
                ddlItems.Items.Add(new ListItem("One Plus 11", "One Plus 11.png"));
                ddlItems.Items.Add(new ListItem("Redmi 12", "Redmi 12.png"));
                ddlItems.Items.Add(new ListItem("TECHNO Spark 10", "TECHNO Spark 10.png"));
                ddlItems.Items.Add(new ListItem("Xiaomi 11", "Xiaomi 11.png"));
            }
        }
        protected void ddlItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedImageUrl = ddlItems.SelectedItem.Value;
            imgItem.ImageUrl = $"Images/{selectedImageUrl}";
        }

        protected void btnShowCost_Click(object sender, EventArgs e)
        {
            string TheSelectedItem = ddlItems.SelectedItem.Text;
            string cost = GetItemCost(TheSelectedItem);

            lblCost.Text = $"Price of the {TheSelectedItem}: {cost}";
        }


        private string GetItemCost(string item)
        {

            switch (item)
            {
                case "IKALL K10":
                    return "Rs 9,999";
                case "One Plus 11":
                    return "Rs 49,999";
                case "Redmi 12":
                    return "Rs 12,999";
                case "TECHNO Spark 10":
                    return "6,499";
                case "Xiaomi 11":
                    return "19,999";
                default:
                    return "Select Item";
            }
        }

    }
}