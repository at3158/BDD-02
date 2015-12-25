using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BDD_02.WEBDATA;

namespace BDD_02.WEBFORM
{
    public partial class CalWebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton1_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            firstNumber = int.Parse(TextBox1.Text.ToString());
            secondNumber = int.Parse(TextBox2.Text.ToString());
            Label2.Text = new BDD_02.WEBDATA.Calculation().Add(firstNumber, secondNumber).ToString();
        }
    }
}