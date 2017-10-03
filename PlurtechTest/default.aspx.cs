using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Security;

namespace PlurtechTest
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                ctlDays.Items.Add(i.ToString());
            }
            var allFiles = GetFileNames();
            ctlAllFiles.DataSource = allFiles;
            ctlAllFiles.DataBind();
        }

        List<FileInfo> GetFileNames()
        {
            string imgPath = Server.MapPath("~/App_Data/");
            List<FileInfo> images = new List<FileInfo>();

            DirectoryInfo directoryInfo = new DirectoryInfo(imgPath);
            FileInfo[] fileInfo = directoryInfo.GetFiles();

            foreach (FileInfo file in fileInfo)
            {
                images.Add(file);
            }
            return images;
        }


        protected void btnGetDate_Click(object sender, EventArgs e)
        {
            ctlYears.SelectedValue = DateTime.Now.Year.ToString();
            ctlMonths.SelectedValue = DateTime.Now.Month.ToString();
            ctlDays.SelectedValue = DateTime.Now.Day.ToString();
        }

        protected void ctlDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(ctlYears.SelectedValue);
            int month = int.Parse(ctlMonths.SelectedValue);
            int day = int.Parse(ctlDays.SelectedValue);
            int daysAvailable = DateTime.DaysInMonth(year, month);
            if (day < daysAvailable)
                lblDate.Text = new DateTime(year, month, day).DayOfWeek.ToString();
            else
                lblDate.Text = "?";

        }
    }
}