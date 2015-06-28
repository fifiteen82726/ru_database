using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;                  // Dataset
using System.Data.SqlClient;        // SqlDataAdapter
 
public partial class _Default : System.Web.UI.Page
{
    public string youtubeLink ="http://www.youtube.com/embed/qrO4YZeyl0I";
    public string SingerName = "Lady Gaga";
    public string SongName = "Bad Romance";
    static int value = 0;
    string conn = "Server=140.138.154.29; Database=s1021704; User ID=sy; Password=1234; Trusted_Connection=False;";
    //宣告 資料庫命令 字串
    int dropSingerValue=0;
    int dropVideoValue = 0;
    int videoId = 0;
   
    protected void Page_Load(object sender, EventArgs e)
    {
        //Response.Write("s" + value);
        if (DropDownList1.SelectedValue != "")
        {
            dropSingerValue = Convert.ToInt32(DropDownList1.SelectedValue);
           // Response.Write(Convert.ToInt32(DropDownList1.SelectedValue).ToString());
           
        }
       // string strQuery = "SELECT course_id, course_name FROM tbl_course";
        if (!Page.IsPostBack)
        {
            string strQuery = "SELECT singer_id,singer_name,gender FROM singer;";
            SqlDataAdapter da = new SqlDataAdapter(strQuery, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count > 0)
            {

                ds.Dispose();
                DropDownList1.Items.Clear();
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "singer_name";
                DropDownList1.DataValueField = "singer_id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("-- Select Singer --", "0"));
            }
            else
            {
                Response.Write("no data");

                Response.End();
            }

        }
        /*
        if (DropDownList2.SelectedValue != "")
        {
            dropVideoValue = Convert.ToInt32(DropDownList2.SelectedValue);
            // Response.Write(Convert.ToInt32(DropDownList1.SelectedValue).ToString());

        }

        if (dropVideoValue != 0)
        {
            


        }
         */

        if (DropDownList2.SelectedValue != "")
        {
            dropVideoValue = Convert.ToInt32(DropDownList2.SelectedValue);
            // Response.Write(Convert.ToInt32(DropDownList1.SelectedValue).ToString());

        }

       
       

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //get song name and value
        DropDownList2.Visible = true;
        string videoQuery = "SELECT video_id,video_name FROM video where singer_id =" + dropSingerValue.ToString() + ";";

        SqlDataAdapter da2 = new SqlDataAdapter(videoQuery, conn);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        if (ds2.Tables[0].Rows.Count > 0)
        {
            SingerName = DropDownList1.SelectedItem.Text;
            SongName = "";
            ds2.Dispose(); DropDownList2.Items.Clear();
            DropDownList2.DataSource = ds2;
            DropDownList2.DataTextField = "video_name";
            DropDownList2.DataValueField = "video_id";
            DropDownList2.DataBind();
            DropDownList2.Items.Insert(0, new ListItem("-- Select Video --", "0"));
        }
        else
        {
            Response.Write("no data");
            // Response.End();

        }

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        //get link
        dropVideoValue = Convert.ToInt32(DropDownList2.SelectedValue);
       // Response.Write("hello" + dropVideoValue.ToString());
        string LinkQuery = "SELECT video_link FROM video where video_id =" + dropVideoValue.ToString() + ";";

        SqlDataAdapter da3 = new SqlDataAdapter(LinkQuery, conn);
        DataSet ds3 = new DataSet();
        da3.Fill(ds3);
        if (ds3.Tables[0].Rows.Count > 0)
        {
            SingerName = DropDownList1.SelectedItem.Text;
            youtubeLink = " http://www.youtube.com/embed/" + ds3.Tables[0].Rows[0][0].ToString();
 
            SongName = DropDownList2.SelectedItem.Text;
          //  Response.Write(ds3.Tables[0].Rows[0][0]);
            //Response.End();

        }
        else
        {
            Response.Write("no data");
            Response.End();

        }
       
    }
}