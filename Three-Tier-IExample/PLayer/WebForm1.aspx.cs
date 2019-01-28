using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Three_Tier_IExample.ReferenceCallMethod;

namespace Three_Tier_IExample.PLayer
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //Constructor dependancy injection 

        private IMethodBLL objBLL;

        public WebForm1()
        {
            objBLL = new BLLMethods(new ClsBussLayer(new ClsDataLayer()));
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            objBLL.InsertData(txtname.Text,txtgender.Text,txtdob.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            objBLL.UpdateData(txtname.Text, txtgender.Text, txtdob.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            objBLL.DeleteData(txtname.Text);

            GridView1.DataSource = objBLL.SelectData();
            GridView1.DataBind();
        }
    }
}