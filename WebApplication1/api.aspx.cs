using System;
using maytinhdongian;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json; charset=utf-8";
        string aS = Request["a"];
        string bS = Request["b"];
        string op = Request["op"];

        double a, b;
        if (!double.TryParse(aS, out a) || !double.TryParse(bS, out b))
        {
            Response.Write("{\"error\":\"Số không hợp lệ\"}");
            return;
        }

        maytinh calc = new maytinh();
        calc.A = a;
        calc.B = b;
        calc.Operation = op;

        try
        {
            double kq = calc.Compute();
            Response.Write("{\"result\":" + kq + "}");
        }
        catch (Exception ex)
        {
            Response.Write("{\"error\":\"" + ex.Message.Replace("\"", "\\\"") + "\"}");
        }
    }
}
