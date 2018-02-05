using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Runtime.InteropServices;


namespace PackChecker
{
    public partial class frmreports : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        public frmreports()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        
        private void patientlistcreate()
                {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strrpt = @"SELECT StrConv(tblpatient.pxlastname,3) AS pxlastname, StrConv(tblpatient.pxfirstname,3) AS pxfirstname, IIf(IsNull([tblpatient].[repatnumber]) Or [repatnumber]='','','X') AS Repat, tblpatient.repatnumber, tblpatient.active, tblcycle.cyclecode, tblpatient.comment, tblpacksize.sizelongname, IIf(tblpatient.delivery=-1,'X','') AS Delivery, IIf(tblpatient.signingsheet=-1,'X','') AS SignSheet, IIf(IsNull(tblpatient.secondarypacklocation),tblpacklocation.locationname,tblpacklocation.locationname+' + '+tblpacklocation_1.locationname) AS location
FROM tblpacksize INNER JOIN (tblpacklocation INNER JOIN (tblcycle INNER JOIN (tblpatient LEFT JOIN tblpacklocation AS tblpacklocation_1 ON tblpatient.secondarypacklocation = tblpacklocation_1.locationid) ON tblcycle.cycleid = tblpatient.cycleid) ON tblpacklocation.locationid = tblpatient.packlocation) ON tblpacksize.packsizeid = tblpatient.traysize
WHERE (((tblpatient.active)=True))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";
                
                OleDbDataAdapter adapt = new OleDbDataAdapter(strrpt, con);
                
                webbitdbdataset webd = new webbitdbdataset();
                
                con.Open();
                adapt.Fill(webd,webd.Tables[0].TableName);
                con.Close();
                

                reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptpatientlist.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("rptpatient", webd.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(source);
                System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                ps.Landscape = true;
                reportViewer1.SetPageSettings(ps);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }


        }

        private void deactivatedpacks()
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbDataAdapter adapt;
                string strrpt;
                 

                if(cmbpatient.SelectedIndex == -1)
                {
                    strrpt = @"SELECT tblpatient.pxlastname+', '+tblpatient.pxfirstname AS pxname, tblpatient.pxfirstname, tblpatient.pxlastname, tbluser.userfirstname AS packuser, tbluser_1.userfirstname AS checkuser, tbluser_2.userfirstname AS deactuser, tblpack.active, tblpack.cycledate, tblpack.packeddate, tblpack.checkeddate, tblpack.deactivecomment, tblpatient.patientid
FROM tblpatient INNER JOIN (tbluser AS tbluser_1 RIGHT JOIN (tbluser RIGHT JOIN (tbluser AS tbluser_2 INNER JOIN tblpack ON tbluser_2.userid = tblpack.repackuser) ON tbluser.userid = tblpack.packeduser) ON tbluser_1.userid = tblpack.checkeduser) ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.active)=False))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname";

                    adapt = new OleDbDataAdapter(strrpt, con);
                    

                }
                else
                {
                    strrpt = @"SELECT tblpatient.pxlastname+', '+tblpatient.pxfirstname AS pxname, tblpatient.pxfirstname, tblpatient.pxlastname, tbluser.userfirstname AS packuser, tbluser_1.userfirstname AS checkuser, tbluser_2.userfirstname AS deactuser, tblpack.active, tblpack.cycledate, tblpack.packeddate, tblpack.checkeddate, tblpack.deactivecomment, tblpatient.patientid
FROM tblpatient INNER JOIN (tbluser AS tbluser_1 RIGHT JOIN (tbluser RIGHT JOIN (tbluser AS tbluser_2 INNER JOIN tblpack ON tbluser_2.userid = tblpack.repackuser) ON tbluser.userid = tblpack.packeduser) ON tbluser_1.userid = tblpack.checkeduser) ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.active)=False) AND ((tblpatient.patientid)=?))
ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";

                    OleDbCommand cmd = new OleDbCommand(strrpt, con);

                    cmd.Parameters.Add("?", OleDbType.Integer).Value = cmbpatient.SelectedValue;
                    adapt = new OleDbDataAdapter();
                    adapt.SelectCommand = cmd;
                    //MessageBox.Show(cmbpatient.SelectedValue.ToString());
                }
                 

                 

               // adapt = new OleDbDataAdapter(strrpt, con);

                webbitdbdataset webd = new webbitdbdataset();

                con.Open();
                adapt.Fill(webd, webd.Tables[0].TableName);
                con.Close();
                if(webd.Tables[0].Rows.Count == 0)
                {
                    using (msgbox mb = new msgbox("This patient has no Deactivated packs.", "no packs"))
                    {
                        mb.ShowDialog();
                        return;
                    }
                }
                

                reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptdeactivated.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("rptdeactivated", webd.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(source);
                System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                ps.Landscape = true;
                reportViewer1.SetPageSettings(ps);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }


        }
        private void cyclecheck()
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbCommand cmd = new OleDbCommand();
                DateTime sdate = Convert.ToDateTime(datestart.Value.ToString("dd/MM/yyyy"));
                DateTime edate = Convert.ToDateTime(dateend.Value.ToString("dd/MM/yyyy"));
                string strrpt = @"SELECT StrConv(tblpatient.pxlastname,3)+', '+StrConv(tblpatient.pxfirstname,3) AS pxname, tblpatient.pxlastname, 
tblpatient.pxfirstname, tblpack.cycledate, tbluser.userfirstname AS packeduser, tblpack.packeddate, tbluser_1.userfirstname AS checkeduser, tblpack.checkeddate,
tbluser_2.userfirstname AS collectuser, tblpack.errorcomment, tblpack.active, tblpack.packerrors, tbluser_3.userfirstname AS Repackuser
FROM tbluser AS tbluser_3 INNER JOIN (tblpatient INNER JOIN (((tbluser RIGHT JOIN tblpack ON tbluser.userid = tblpack.packeduser) LEFT JOIN tbluser AS tbluser_2 ON 
tblpack.collectuser = tbluser_2.userid) LEFT JOIN tbluser AS tbluser_1 ON tblpack.checkeduser = tbluser_1.userid) ON tblpatient.patientid = tblpack.patientid) ON tbluser_3.userid = 
tblpack.repackuser WHERE tblpack.cycledate Between ? And ? AND tblpack.active=False AND tblpack.packerrors>0 ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname";

                cmd = new OleDbCommand(strrpt, con);

                cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                
                OleDbDataAdapter adapt = new OleDbDataAdapter();
                
                adapt.SelectCommand = cmd;
                webbitdbdataset webd = new webbitdbdataset();

                con.Open();
                adapt.Fill(webd, webd.Tables[0].TableName);
                con.Close();
                
                reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptcyclechecker.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("cyclecheck", webd.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(source);

                OleDbCommand cmd2 = new OleDbCommand();
                string rpttbl = @"SELECT tbluser.userfirstname, Count(tblpack.packid) AS CountOfpackid, Sum(tblpack.packerrors) AS SumOfpackerrors FROM tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.packeduser
WHERE  tblpack.cycledate Between ? And ? AND tblpack.active=False AND tblpack.packerrors>0
GROUP BY tbluser.userfirstname";

                cmd2 = new OleDbCommand(rpttbl, con);

                cmd2.Parameters.Add("?", OleDbType.Date).Value = sdate;
                cmd2.Parameters.Add("?", OleDbType.Date).Value = edate;

                OleDbDataAdapter adapt2 = new OleDbDataAdapter();

                adapt2 = new OleDbDataAdapter(strrpt, con);

                adapt2.SelectCommand = cmd2;

                con.Open();
                adapt2.Fill(webd, webd.Tables[1].TableName);
                con.Close();
                source = new ReportDataSource("tblerrors", webd.Tables[1]);
                reportViewer1.LocalReport.DataSources.Add(source);

                string rptchanges = @"SELECT StrConv(tblpatient.pxlastname,3)+', '+StrConv(tblpatient.pxfirstname,3) AS pxname, tblpatient.pxlastname, tblpatient.pxfirstname, 
                tblpack.cycledate, tbluser.userfirstname AS packeduser, tblpack.packeddate, tbluser_1.userfirstname AS checkeduser, tblpack.checkeddate, tbluser_2.userfirstname AS collectuser, 
                tblpack.active, tbluser_3.userfirstname AS Repackuser, tblpack.repackcomment, tblpatient.patientid FROM tblpatient INNER JOIN (tbluser AS tbluser_3 INNER JOIN 
                (((tbluser RIGHT JOIN tblpack ON tbluser.userid = tblpack.packeduser) LEFT JOIN tbluser AS tbluser_2 ON tblpack.collectuser = tbluser_2.userid) LEFT JOIN tbluser AS 
                tbluser_1 ON tblpack.checkeduser = tbluser_1.userid) ON tbluser_3.userid = tblpack.repackuser) ON tblpatient.patientid = tblpack.patientid
                WHERE tblpack.cycledate Between ? And ? AND tblpack.active=False AND tblpack.repackcomment Is Not Null
                ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname";

                OleDbCommand cmd3 = new OleDbCommand();
                cmd3 = new OleDbCommand(rptchanges, con);

                cmd3.Parameters.Add("?", OleDbType.Date).Value = sdate;
                cmd3.Parameters.Add("?", OleDbType.Date).Value = edate;

                OleDbDataAdapter adapt3 = new OleDbDataAdapter();

                adapt3.SelectCommand = cmd3;
                

                con.Open();
                adapt3.Fill(webd, webd.Tables[2].TableName);
                con.Close();

               
                //reportViewer1.LocalReport.DataSources.Clear();
                source = new ReportDataSource("changecheck", webd.Tables[2]);
                reportViewer1.LocalReport.DataSources.Add(source);


                reportViewer1.LocalReport.Refresh();
                System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                ps.Landscape = true;
                reportViewer1.SetPageSettings(ps);
                this.reportViewer1.RefreshReport();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("DateRange", sdate.ToShortDateString() + " to " + edate.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

            }

        }

        private void packsperpxcreat()
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                OleDbCommand cmd = new OleDbCommand();
                DateTime sdate = Convert.ToDateTime(datestart.Value.ToString("dd/MM/yyyy"));
                DateTime edate = Convert.ToDateTime(dateend.Value.ToString("dd/MM/yyyy"));
                string strrpt = @"SELECT StrConv(tblpatient.pxlastname,3)+', '+StrConv(tblpatient.pxfirstname,3) AS pxname, tblpatient.patientid, tblpatient.pxlastname, 
                    tblpatient.pxfirstname, tblpack.cycledate, tbluser.userfirstname AS packeduser, tblpack.packeddate, tbluser_1.userfirstname AS checkeduser, tblpack.checkeddate,
                    tbluser_2.userfirstname AS collectuser, tblpack.collectdate, tblpack.receivedby, tblpack.packcomment, tblpack.iscommunity, tblpack.isover5med, tblpack.isrepat,
                    tblpack.isconcession, tblpack.weeksinpack FROM tblpatient INNER JOIN (((tbluser RIGHT JOIN tblpack ON tbluser.userid = tblpack.packeduser) LEFT JOIN tbluser AS tbluser_2 ON tblpack.collectuser 
                    = tbluser_2.userid) LEFT JOIN tbluser AS tbluser_1 ON tblpack.checkeduser = tbluser_1.userid) ON tblpatient.patientid = tblpack.patientid";

                if (cmbpatient.SelectedIndex == -1 )
                {
                    if(cmbclaimable.SelectedIndex == 0)
                    {
                        strrpt = strrpt + @" WHERE (((tblpack.cycledate) Between ? And ?) AND ((tblpack.active)=True) AND ((tblpack.packeduser) Is Not Null))
                                            ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";
                        cmd = new OleDbCommand(strrpt, con);

                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                    }

                    if (cmbclaimable.SelectedIndex == 1)
                    {
                        strrpt = strrpt + @" WHERE (((tblpack.cycledate) Between ? And ?) AND ((tblpack.iscommunity)=True) AND ((tblpack.isover5med)=True) AND 
                        ((tblpack.active)=True) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.isrepat)=True)) OR (((tblpack.cycledate) Between ? And ?) AND ((tblpack.iscommunity)=True) AND 
                        ((tblpack.active)=True) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.isconcession)=True))
                        ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";
                        cmd = new OleDbCommand(strrpt, con);

                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                    }

                    if (cmbclaimable.SelectedIndex == 2)
                    {
                        strrpt = strrpt + @" WHERE (((tblpack.cycledate) Between ? AND ?) AND ((tblpack.packeduser) Is Not Null) 
                        AND ((tblpack.active)=True) AND ((tblpack.iscommunity)=False)) OR (((tblpack.cycledate) Between ? And ?) AND ((tblpack.packeduser) Is Not Null) AND 
                        ((tblpack.active)=True) AND ((tblpack.isover5med)=False)) OR (((tblpack.cycledate) Between ? And ?) AND ((tblpack.packeduser) Is Not Null) AND 
                        ((tblpack.active)=True) AND ((tblpack.isrepat)=False) AND ((tblpack.isconcession)=False))
                        ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";

                        cmd = new OleDbCommand(strrpt, con);

                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                    }



                    

                }
                else
                {
                    strrpt = strrpt + @" WHERE (tblpack.cycledate BETWEEN ? AND ?) AND (tblpack.active = -1) AND tblpatient.patientid = ?
                                            ORDER BY tblpatient.pxlastname, tblpatient.pxfirstname;";
                 
                    cmd = new OleDbCommand(strrpt, con);
                   
                    cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = cmbpatient.SelectedValue;
                    //MessageBox.Show(cmbpatient.SelectedValue.ToString());
                }
                
                OleDbDataAdapter adapt = new OleDbDataAdapter();

                 

                

                adapt.SelectCommand = cmd;
                webbitdbdataset webd = new webbitdbdataset();

                con.Open();
                adapt.Fill(webd, webd.Tables[0].TableName);
                con.Close();


                reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptpacksperpx.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("rptpacks", webd.Tables[0]);
                reportViewer1.LocalReport.DataSources.Add(source);
                reportViewer1.LocalReport.Refresh();
                System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                ps.Landscape = true;
                reportViewer1.SetPageSettings(ps);
                this.reportViewer1.RefreshReport();
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("DateRange", sdate.ToShortDateString() + " to " + edate.ToShortDateString()));
                this.reportViewer1.LocalReport.SetParameters(reportParameters);

            }
            
        }
        private void rptcountscreate()
        {

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strrpt = @"SELECT '0' AS Order1, 'Packed' AS Category, tblpack.cycledate, tblpack.packid, tbluser.userfirstname AS [user], tblpack.packeduser
FROM tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.packeduser
WHERE Cycledate between ? AND ?
UNION
SELECT '1' AS Order1, 'Checked' AS Category, tblpack.cycledate, tblpack.packid, tbluser.userfirstname AS Expr1, tblpack.checkeduser
FROM tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.checkeduser
WHERE Cycledate between ? AND ?
UNION
SELECT '2' AS Order1, 'Given Out' AS Category, tblpack.cycledate, tblpack.packid, tbluser.userfirstname AS xpr1, tblpack.collectuser
FROM tbluser INNER JOIN tblpack ON tbluser.userid = tblpack.collectuser
WHERE Cycledate between ? AND ?";
                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {


                    using (OleDbCommand cmd = new OleDbCommand(strrpt, con))
                    {

                        DateTime sdate = Convert.ToDateTime(datestart.Value.ToString("dd/MM/yyyy"));
                        DateTime edate = Convert.ToDateTime(dateend.Value.ToString("dd/MM/yyyy"));
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        

                        adapt.SelectCommand = cmd;
                        using (webbitdbdataset webd = new webbitdbdataset())
                        {
                            con.Open();
                            adapt.Fill(webd, webd.Tables[0].TableName);
                            con.Close();


                            reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptcounts.rdlc";
                            reportViewer1.ProcessingMode = ProcessingMode.Local;
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource source = new ReportDataSource("rptcounts", webd.Tables[0]);
                            reportViewer1.LocalReport.DataSources.Add(source);
                            System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                            ps.Landscape = false;
                            reportViewer1.SetPageSettings(ps);
                            reportViewer1.LocalReport.Refresh();
                            this.reportViewer1.RefreshReport();
                            ReportParameterCollection reportParameters = new ReportParameterCollection();
                            reportParameters.Add(new ReportParameter("DateRange", sdate.ToShortDateString() + " to " + edate.ToShortDateString()));
                            this.reportViewer1.LocalReport.SetParameters(reportParameters);

                        }
                    }
                }
            }
        }
        
        private void rptqcppcreate()
                {

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strrpt = @"SELECT Format(tblpack.cycledate, 'MMMM') AS MonthDate,
       Year(tblpack.cycledate) AS YearDate, Sum(tblpack.weeksinpack) AS SumOfweeksinpack, 
       Month(tblpack.cycledate) AS MonthOrder
FROM tblpatient 
INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.iscommunity)=True) 
      AND ((tblpatient.over5med)=True) 
      AND ((tblpack.active)=True)
      AND ((tblpack.isrepat)=True) 
      AND ((tblpack.cycledate) Between ? And ?) 
      AND ((tblpack.packeduser) Is Not Null)) 
      OR (((tblpack.iscommunity)=True) 
      AND ((tblpatient.over5med)=True) 
      AND ((tblpack.active)=True)
      AND ((tblpack.isconcession)=True) 
      AND ((tblpack.cycledate) Between ? And ?) 
      AND ((tblpack.packeduser) Is Not Null))
GROUP BY Format(tblpack.cycledate, 'MMMM'), Year(tblpack.cycledate), Month(tblpack.cycledate)
ORDER BY Format(tblpack.cycledate, 'MMMM'), Year(tblpack.cycledate)";       
                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {


                using (OleDbCommand cmd = new OleDbCommand(strrpt, con))
                {

                    DateTime sdate = Convert.ToDateTime(datestart.Value.ToString("dd/MM/yyyy"));
                    DateTime edate = Convert.ToDateTime(dateend.Value.ToString("dd/MM/yyyy"));
                    cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                    cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;

                        adapt.SelectCommand = cmd;
                    using (webbitdbdataset webd = new webbitdbdataset())
                    {
                        con.Open();
                        adapt.Fill(webd, webd.Tables[0].TableName);
                        con.Close();


                        reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptqcpp.rdlc";
                        
                        reportViewer1.ProcessingMode = ProcessingMode.Local;
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource source = new ReportDataSource("rptqccp", webd.Tables[0]);
                        reportViewer1.LocalReport.DataSources.Add(source);
                            System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                            ps.Landscape = false;
                            reportViewer1.SetPageSettings(ps);
                            reportViewer1.LocalReport.Refresh();
                        this.reportViewer1.RefreshReport();
                            ReportParameterCollection reportParameters = new ReportParameterCollection();
                            reportParameters.Add(new ReportParameter("DateRange", sdate.ToShortDateString() + " to " + edate.ToShortDateString()));
                            this.reportViewer1.LocalReport.SetParameters(reportParameters);

                            
                            

                        }
                    }
                }
            }
        }
        private void rptgraphcountscreate()
        {

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strrpt = @"SELECT        ' Packed' AS Category, Format(packeddate,'dd / MM / yy') AS Dateof, packid
                                FROM tblpack
                                WHERE Cycledate between? AND ? AND packeddate is not null
                                UNION
                                SELECT        'Checked' AS Category2, Format(checkeddate,'dd/MM/yy') AS Dateof2, packid
                                FROM tblpack tblpack_1
                                WHERE Cycledate between ? AND? AND checkeddate is not null
                                UNION
                                SELECT        'Collected' AS Category2, Format(collectdate,'dd/MM/yy') AS Dateof2, packid
                                FROM tblpack tblpack_1
                                WHERE Cycledate between ? AND? AND collectdate is not null; ";

                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {


                    using (OleDbCommand cmd = new OleDbCommand(strrpt, con))
                    {

                        DateTime sdate = Convert.ToDateTime(datestart.Value.ToString("dd/MM/yyyy"));
                        DateTime edate = Convert.ToDateTime(dateend.Value.ToString("dd/MM/yyyy"));
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = sdate;
                        cmd.Parameters.Add("?", OleDbType.Date).Value = edate;

                        adapt.SelectCommand = cmd;
                        using (webbitdbdataset webd = new webbitdbdataset())
                        {
                            con.Open();
                            adapt.Fill(webd, webd.Tables[0].TableName);
                            con.Close();


                            reportViewer1.LocalReport.ReportEmbeddedResource = "PackChecker.rptgraphcounts.rdlc";
                            reportViewer1.ProcessingMode = ProcessingMode.Local;
                            reportViewer1.LocalReport.DataSources.Clear();
                            ReportDataSource source = new ReportDataSource("rptgraphcounts", webd.Tables[0]);
                            reportViewer1.LocalReport.DataSources.Add(source);
                            System.Drawing.Printing.PageSettings ps = reportViewer1.GetPageSettings();
                            ps.Landscape = true;
                            reportViewer1.SetPageSettings(ps);
                            reportViewer1.LocalReport.Refresh();
                            this.reportViewer1.RefreshReport();

                        }
                    }
                }
            }
        }
        private void btngeneratereport_Click(object sender, EventArgs e)
        {
            //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            RadioButton radioBtn = radioreportgroup.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (radioBtn != null)
            {
                startplash("Loading...");
                try
                { 
                switch (radioBtn.Name)
                {
                    case "radiopxlist":
                        
                        patientlistcreate();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 100;
                            //reportViewer1.SetDisplayMode(DisplayMode.Normal);
                            break;

                    case "radiopklist":
                        
                        packsperpxcreat();
                        reportViewer1.ZoomMode = ZoomMode.PageWidth;
                        //reportViewer1.ZoomPercent = 200;
                       // reportViewer1.SetDisplayMode(DisplayMode.Normal);
                        break;

                    case "radiocounts":
                        
                        rptcountscreate();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 150;
                           // reportViewer1.SetDisplayMode(DisplayMode.Normal); ;
                        break;
                        
                    case "radiographcounts":
                        
                        rptgraphcountscreate();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 150;
                            //reportViewer1.SetDisplayMode(DisplayMode.Normal);
                            break;

                    case "radioqcpp":
                        
                        rptqcppcreate();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 200;
                            //reportViewer1.SetDisplayMode(DisplayMode.Normal);
                            
                            break;
                            

                                case "radiocyclecheck":
                            cyclecheck();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 100;
                            //reportViewer1.SetDisplayMode(DisplayMode.Normal);

                            break;

                        case "radiodeactivated":
                            deactivatedpacks();
                            reportViewer1.ZoomMode = ZoomMode.PageWidth;
                            //reportViewer1.ZoomPercent = 100;
                            //reportViewer1.SetDisplayMode(DisplayMode.Normal);

                            break;
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }


                this.reportViewer1.RefreshReport();
                stopsplash();
            }
        }

        
        
        private void frmreports_Load(object sender, EventArgs e)
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            datestart.Value = firstDayOfMonth;
            var nextmonth = DateTime.Now.Month + 1;
            if (nextmonth == 13)
            {
                nextmonth = 1;
            }
            
            var lastDayofMonth = new DateTime(DateTime.Now.Year, nextmonth, 1).AddDays(-1);


            dateend.Value = lastDayofMonth;

            string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname + ', ' + tblpatient.pxfirstname AS pxname FROM tblpatient WHERE active = true ORDER BY pxlastname ASC, pxfirstname ASC";
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    DataSet ds = new DataSet();
                    con.Open();
                    OleDbDataAdapter adapt = new OleDbDataAdapter();
                    OleDbCommand cmd = new OleDbCommand(sql, con);

                    adapt.SelectCommand = cmd;
                    adapt.Fill(ds);
                    adapt.Dispose();
                    con.Close();


                    cmbpatient.ValueMember = "patientid";
                    cmbpatient.DisplayMember = "pxname";
                    cmbpatient.DataSource = ds.Tables[0];
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

            string sqlcycles = @"SELECT tblweek.weekid, tblweek.weekdate, tblweek.holidaycycle
                                    FROM tblweek
                                    WHERE(((tblweek.holidaycycle) = False))
                                    ORDER BY tblweek.weekdate DESC";
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    DataSet ds2 = new DataSet();
                    con.Open();
                    OleDbDataAdapter adapt = new OleDbDataAdapter();
                    OleDbCommand cmd = new OleDbCommand(sqlcycles, con);

                    adapt.SelectCommand = cmd;
                    adapt.Fill(ds2);
                    adapt.Dispose();
                    con.Close();


                    cmbcycles.ValueMember = "weekid";
                    cmbcycles.DisplayMember = "weekdate";
                    cmbcycles.DataSource = ds2.Tables[0];
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }


            radiopxlist.Checked = true;
            cmbpatient.SelectedIndex = -1;

        }

        private void radioreportgroup_Enter(object sender, EventArgs e)
        {

        }

        private void radiopxlist_CheckedChanged(object sender, EventArgs e)
        {
            if(radiopxlist.Checked == true)
            {
                changeoptvis(false, false, false);
            }
        }

        private void radiopklist_CheckedChanged(object sender, EventArgs e)
        {
            if (radiopklist.Checked == true)
            {
                changeoptvis(true, true, true);
                cmbclaimable.SelectedText = "All";
                cmbclaimable.SelectedIndex = 0;
            }
        }

        private void radioqcpp_CheckedChanged(object sender, EventArgs e)
        {
            if (radioqcpp.Checked == true)
            {
                changeoptvis(false, true, false);
                var firstDayOfYear = new DateTime(DateTime.Now.Year, 1, 1);
                datestart.Value = firstDayOfYear;
                var lastDayOfYear = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1);
                dateend.Value = lastDayOfYear;

                
            }
        }

        private void changeoptvis(bool vispx, bool visdate , bool visclaim)
        {
            vispatients(vispx);
            visdates(visdate);
            visclaimable(visclaim);

            if (vispx == false && visdate == false)
            {
                groupoptions.Visible = false;
            }
            else
            {
                groupoptions.Visible = true;
            }
        }

        private void vispatients(bool vis)
        {
            cmbpatient.Visible = vis;
            lblpx.Visible = vis;
            chkactive.Visible = vis;
            btnclear.Visible = vis;
            
            
        }
   

        private void visdates(bool vis)
        {
            datestart.Visible = vis;
            dateend.Visible = vis;
            lblstartdate.Visible = vis;
            lblenddate.Visible = vis;
            btnthismonth.Visible = vis;
            btnthisyear.Visible = vis;

        }

        private void visclaimable(bool vis)
        {
            lblpacktype.Visible = vis;
            cmbclaimable.Visible = vis;
        }
        

        private void radiocounts_CheckedChanged(object sender, EventArgs e)
        {
            if (radiocounts.Checked == true)
            {
                changeoptvis(false, true, false);
            }
        }

        private void radiographcounts_CheckedChanged(object sender, EventArgs e)
        {
            changeoptvis(false, true, false);
        }

        private void radiocyclecheck_CheckedChanged(object sender, EventArgs e)
        {
            changeoptvis(false, true, false);
        }

        private void radiodeactivated_CheckedChanged(object sender, EventArgs e)
        {
            changeoptvis(true, false, false);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cmbpatient.SelectedIndex = -1;
        }

        private void btnthismonth_Click(object sender, EventArgs e)
        {
            var firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var nextmonth = DateTime.Now.Month + 1;
            if (nextmonth == 13)
            {
                nextmonth = 1;
            }
            var lastDayofMonth = new DateTime(DateTime.Now.Year, nextmonth, 1).AddDays(-1); ;
            datestart.Value = firstDayOfMonth;
            dateend.Value = lastDayofMonth;
        }

        private void btnthisyear_Click(object sender, EventArgs e)
        {
            var firstDayOfYear = new DateTime(DateTime.Now.Year, 1, 1);
            datestart.Value = firstDayOfYear;
            var lastDayOfYear = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1);
            dateend.Value = lastDayOfYear;
        }

        private void chkactive_CheckedChanged(object sender, EventArgs e)
        {
            if(chkactive.Checked == true)
            {
                string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname + ', ' + tblpatient.pxfirstname AS pxname FROM tblpatient WHERE active = true ORDER BY pxlastname ASC, pxfirstname ASC";
                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        DataSet ds = new DataSet();
                        con.Open();
                        OleDbDataAdapter adapt = new OleDbDataAdapter();
                        OleDbCommand cmd = new OleDbCommand(sql, con);

                        adapt.SelectCommand = cmd;
                        adapt.Fill(ds);
                        adapt.Dispose();
                        con.Close();


                        cmbpatient.ValueMember = "patientid";
                        cmbpatient.DisplayMember = "pxname";
                        cmbpatient.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }

                
                cmbpatient.SelectedIndex = -1;
            }else
            {
                string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname + ', ' + tblpatient.pxfirstname AS pxname FROM tblpatient ORDER BY pxlastname ASC, pxfirstname ASC";
                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        DataSet ds = new DataSet();
                        con.Open();
                        OleDbDataAdapter adapt = new OleDbDataAdapter();
                        OleDbCommand cmd = new OleDbCommand(sql, con);

                        adapt.SelectCommand = cmd;
                        adapt.Fill(ds);
                        adapt.Dispose();
                        con.Close();


                        cmbpatient.ValueMember = "patientid";
                        cmbpatient.DisplayMember = "pxname";
                        cmbpatient.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
                }


                cmbpatient.SelectedIndex = -1;
            }
        }
        string splashtext;
        FrmSplash splashy;
        private void startplash(string starttext)
        {
            if (!backgroundWorker1.IsBusy)
            {
                splashtext = starttext;
                backgroundWorker1.RunWorkerAsync();

            }

        }
        private void updatesplash(string updatetext)
        {
            splashy.InvokeBy(() =>
            {
                splashy.SetStatus(updatetext);
            }
                        );
        }
        private void stopsplash()
        {
            splashy.InvokeBy(() =>
            {
                splashy.Close();
            }
                        );

            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            splashy = new FrmSplash();
            splashy.SetStatus(splashtext);
            splashy.ShowDialog();
        }

        private void cmbclaimable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

