using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sisNota
{
    public partial class home : System.Web.UI.Page
    {

        funcoes funcoes = new funcoes();

        public void MsgBox(String ex)
        {

            //string message = "Hello! Mudassar.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(ex);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());
        
        }	

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if ((TextBox1.Text.Equals("Bruno")) && (funcoes.md5(TextBox2.Text).Equals("123")))
            {
                Server.Transfer("WebForm1.aspx");
            }
            else
            {
                MsgBox("Usuário ou Senha inválidos");
            }

        }

    }
}