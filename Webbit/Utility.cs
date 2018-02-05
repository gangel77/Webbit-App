using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.ComponentModel;

namespace PackChecker
{
    
    public static class Utility
    {
        
        public static int userreq(string job)
        {
            inputbox inputbox = new inputbox("Enter User Login", "User Check", "");
            string answer = null;
           
            
            if (inputbox.ShowDialog() == DialogResult.OK)
            {
                
                answer = inputbox.answer;
                if (string.IsNullOrWhiteSpace(answer))
                {
                    msgbox msgbox = new msgbox("Please input a User Login Code", "No user");
                    msgbox.ShowDialog();
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            string ufirstname = "No name";
            string canpack = "False";
            string cancheck = "False";
            string cancollect = "False";
            string canadmin = "False";
            string canwebadmin = "False";
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                //TODO: This line of code loads data into the 'webbitdbdataset.tblpack' table. You can move, or remove it, as needed.


                string struser = @"SELECT tbluser.userid, tbluser.userfirstname, tbluser.userlastname, tbluser.userlogin, tbljob.cancheck, tbljob.cancollect,tbljob.admin, tbljob.canpack, tbljob.webadmin
FROM tbljob INNER JOIN tbluser ON tbljob.jobid = tbluser.userjobid WHERE userlogin = ?";



                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmd = new OleDbCommand(struser, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = answer;


                        con.Open();
                        OleDbDataReader reader;
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            
                            string ans = null;
                            ans = reader["canpack"].ToString();
                            ufirstname = reader["userfirstname"].ToString();
                            canpack = reader["canpack"].ToString();
                            cancheck = reader["cancheck"].ToString();
                            cancollect = reader["cancollect"].ToString();
                            canadmin = reader["admin"].ToString();
                            canwebadmin = reader["webadmin"].ToString();
                            User.curuserid = Convert.ToInt32(reader["userid"]);
                            User.curuserlogin = reader["userlogin"].ToString();
                            User.curusername = reader["userfirstname"].ToString();
                            }
                        else
                        {
                            reader.Close();
                            msgbox msgbox = new msgbox("That is not a valid user", "No user");
                            msgbox.ShowDialog();
                            con.Close();
                            return 0;
                        }
                        reader.Close();
                       con.Close();
                    }
                }
                
            }

                switch (job)
                {

                    case "pack":
                        {
                            if (canpack == "False")
                            {
                                msgbox mb = new msgbox(ufirstname + " is not registered to Pack." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                               
                                return 0;
                            }
                            break;
                        }

                    case "check":
                        {
                            if (cancheck == "False")
                            {
                                msgbox mb = new msgbox(ufirstname + " is not registered to Check." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                
                                return 0;
                            }
                            break;
                        }

                    case "collect":
                        {
                            if (cancollect == "False")
                            {
                                msgbox mb = new msgbox(ufirstname + " is not registered to give out packs." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                
                                return 0;
                            }
                            break;
                        }

                    case "admin":
                        {
                            if (canadmin == "False")
                            {
                                msgbox mb = new msgbox(ufirstname + " is not registered as an Administrator." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                
                                return 0;
                            }
                            break;
                        }

                    case "webadmin":
                        {
                            if (canwebadmin == "False")
                            {
                                msgbox mb = new msgbox(ufirstname + " is not registered to authorised to do this." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                
                                return 0;

                            }

                            break;
                        }
                    default:
                        
                        return 0;
                    }
            return 1;

        }

        public static void addcycle()
        {
            
            DateTime curdate = new DateTime();
            DateTime newdate = new DateTime();
            bool iscommunity = new bool();
            int defweeks = 0;
            string isoldmonthly = "0";
            string isnewmonthly;
            //Get last cycle date
            string strpackdate = "SELECT * FROM tblsettings WHERE settingid = 6";
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {

                using (OleDbCommand cmd = new OleDbCommand(strpackdate, con))
                {


                    con.Open();
                    OleDbDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        curdate = Convert.ToDateTime(reader["settingdate"]);
                        isoldmonthly = reader["settingactive"].ToString();

                    }

                    reader.Close();
                    con.Close();
                }
            }

            if (isoldmonthly == "0")
            {
                isnewmonthly = "-1";
            }
            else
            {
                isnewmonthly = "0";
            }

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {


                strpackdate = "SELECT * FROM tblsettings WHERE settingid = 8";
                using (OleDbCommand cmd = new OleDbCommand(strpackdate, con))
                {


                    con.Open();
                    OleDbDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        defweeks = Convert.ToInt32(reader["settingactive"]);

                    }
                    reader.Close();

                    con.Close();

                }
            }
            newdate = curdate.AddDays(7 * defweeks);


            //insert new WEEK into the pack schedule
            string strdateins = "INSERT INTO tblweek (weekdate,monthlycycle) VALUES (?,?)";
            string getid = "Select @@Identity";
            int weekdateid = new int();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {


                    using (OleDbCommand cmdp = new OleDbCommand(strdateins, con))
                    {



                        cmdp.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;
                        cmdp.Parameters.Add("?", OleDbType.VarWChar).Value = isnewmonthly;
                        adapt.SelectCommand = cmdp;
                        
                        

                        con.Open();
                        cmdp.ExecuteNonQuery();
                        cmdp.CommandText = getid;
                        weekdateid = (int)cmdp.ExecuteScalar();
                        con.Close();


                    }
                }
            }
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {

                    using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                    {
                        string strupdate = "UPDATE tblsettings SET settingdate = ?, settingactive = ?, settingextra = ? WHERE settingid = 6";

                        OleDbCommand cmdup = new OleDbCommand(strupdate, con);


                        cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;
                        cmdup.Parameters.Add("?", OleDbType.VarWChar).Value = isnewmonthly;
                    cmdup.Parameters.Add("?", OleDbType.VarWChar).Value = weekdateid;
                    adapt.SelectCommand = cmdup;

                        con.Open();
                        cmdup.ExecuteNonQuery();
                        con.Close();
                    }
                }


            Utility.initnewpacks(weekdateid, newdate, isnewmonthly);

                //Get list of patients needing packs
                string strpkpx = @"SELECT bigquery.patientid, bigquery.cycleweeks, bigquery.cyclepacks, bigquery.MaxOfweekdate, bigquery.nextpack, bigquery.iscommunity, bigquery.over5med, bigquery.concessionnumber, bigquery.repatnumber
FROM (SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, Max(tblweek.weekdate) AS MaxOfweekdate, Max([tblweek].[weekdate]+(7*[cycleweeks])) AS nextpack, tblpack.earlyrequest, tblinstitution.iscommunity, tblpatient.over5med, tblpatient.concessionnumber, tblpatient.repatnumber, tblpatient.ForceOnNext
FROM tblweek RIGHT JOIN ((tblcycle RIGHT JOIN (tblpatient INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid) ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tblweek.weekid = tblpack.origcycledateid
WHERE (((tblpatient.active)=True) AND ((tblweek.holidaycycle)=False))
GROUP BY tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpack.earlyrequest, tblinstitution.iscommunity, tblpatient.over5med, tblpatient.concessionnumber, tblpatient.repatnumber, tblpatient.ForceOnNext)  AS bigquery LEFT JOIN (SELECT tblpatient.patientid, tblpack.earlyrequest, tblweek.weekdate
FROM tblweek INNER JOIN (tblpatient INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tblweek.weekid = tblpack.origcycledateid
GROUP BY tblpatient.patientid, tblpack.earlyrequest, tblweek.weekdate
HAVING (((tblpack.earlyrequest)=-1))
)  AS Bigquery_holiday ON (bigquery.patientid = Bigquery_holiday.patientid) AND (bigquery.nextpack = Bigquery_holiday.weekdate)
WHERE (((bigquery.nextpack)<=?) AND ((Bigquery_holiday.patientid) Is Null)) OR (((bigquery.ForceOnNext)=True));";

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {

                using (OleDbCommand cmdpx = new OleDbCommand(strpkpx, con))
                {


                    cmdpx.Parameters.Add("?", OleDbType.Date).Value = newdate.ToShortDateString();



                    DataTable dt = new DataTable();
                    con.Open();
                    using (OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx))
                    {


                        adaptpx.SelectCommand = cmdpx;
                        adaptpx.Fill(dt);

                        //MessageBox.Show(dt.Rows.Count.ToString());
                        DateTime origpackdate = new DateTime();
                        origpackdate = newdate;

                        DateTime nextpackdate = new DateTime();
                        string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid,weeksinpack,iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,?,?,?,?,?,?)";
                        using (OleDbCommand cmdadd = new OleDbCommand(strpackins, con))
                        {
                            using (OleDbDataAdapter adaptp = new OleDbDataAdapter())
                            {


                                foreach (DataRow row in dt.Rows)
                                {
                                    bool isrepat = new bool();
                                    if (string.IsNullOrEmpty(row["repatnumber"].ToString()))
                                    {
                                        isrepat = false;
                                    }
                                    else
                                    {
                                        isrepat = true;
                                    }

                                    bool isconcession = new bool();
                                    if (string.IsNullOrEmpty(row["concessionnumber"].ToString()))
                                    {
                                        isconcession = false;
                                    }
                                    else
                                    {
                                        isconcession = true;
                                    }

                                    bool isover5med = Convert.ToBoolean(row["over5med"]);

                                    var pxid = row["patientid"].ToString();
                                    var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                                    var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());
                                    int weeksinpack = cweeks / cpacks;
                                    int daysadv = weeksinpack * 7;
                                    iscommunity = Convert.ToBoolean(row["iscommunity"]);
                                    int i = 0;

                                    // MessageBox.Show(pxid);
                                    nextpackdate = origpackdate;

                                    while (i < cpacks)
                                    {

                                        cmdadd.Parameters.Clear();
                                        cmdadd.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate.ToShortDateString();
                                        cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                                        cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;
                                        cmdadd.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                        cmdadd.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                        cmdadd.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                        cmdadd.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                        cmdadd.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;


                                        adaptp.SelectCommand = cmdadd;



                                        cmdadd.ExecuteNonQuery();


                                        nextpackdate = nextpackdate.AddDays(+daysadv);
                                        i++;


                                    }

                                }
                                con.Close();
                            }
                        }
                    }
                }
            }
            try
            {

                
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string strupdateuser = "UPDATE tblpatient SET ForceOnNext = False where ForceOnNext = true";

                    using (OleDbCommand cmd = new OleDbCommand(strupdateuser, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, "Failed to Falsify ForceOnNext", "Add New Cycle", exe.LineNumber(), "Failed to Falsify ForceOnNext");
            }
        }

        public static void checktopack(out double counttopack, out int weekid)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
               

                string strcurcycle = "Select Settingextra FROM tblsettings WHERE settingid = 6";


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdp = new OleDbCommand(strcurcycle, con))
                    {

                        adapt.SelectCommand = cmdp;

                        con.Open();
                        weekid = Convert.ToInt32(cmdp.ExecuteScalar());
                        con.Close();
                    }
                }




                counttopack = new int();

                string strcount = @"SELECT Count(*) AS pcked
                                FROM tblpack
                                WHERE (((tblpack.active)=True) AND ((tblpack.packeduser) Is Null) AND ((tblpack.origcycledateid)=?))";



                using (OleDbCommand cmd = new OleDbCommand(strcount, con))
                {
                    cmd.Parameters.Add("?", OleDbType.Integer).Value = weekid;
                    
                    OleDbDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        counttopack = Convert.ToDouble(reader["pcked"]);
                        
                    }

                }


            }
        }

        public static void checkfuturetopack(out double counttopackfuture)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                DateTime curcycle;

                string strcurcycle = "Select settingdate FROM tblsettings WHERE settingid = 6";


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdp = new OleDbCommand(strcurcycle, con))
                    {

                        adapt.SelectCommand = cmdp;

                        con.Open();
                        curcycle = (DateTime)cmdp.ExecuteScalar();
                        con.Close();
                    }
                }




                counttopackfuture = new int();

                string strcount = @"SELECT Count(*) AS pcked
                                    FROM tblweek INNER JOIN tblpack ON tblweek.weekid = tblpack.origcycledateid
                                    WHERE (((tblpack.active)=True) AND ((tblpack.packeduser) Is Null) AND ((tblweek.weekdate) > ?";



                using (OleDbCommand cmd = new OleDbCommand(strcount, con))
                {
                    cmd.Parameters.Add("?", OleDbType.Date).Value = curcycle;

                    OleDbDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        counttopackfuture = Convert.ToDouble(reader["pcked"]);

                    }

                }


            }
        }

        public static void checktocheck(out double countocheck)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                DateTime curcycle;

                string strcurcycle = "Select settingdate FROM tblsettings WHERE settingid = 6";


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdp = new OleDbCommand(strcurcycle, con))
                    {

                        adapt.SelectCommand = cmdp;

                        con.Open();
                        curcycle = (DateTime)cmdp.ExecuteScalar();
                        con.Close();
                    }
                }
                
                countocheck = 0;
               
                string strcount = @"SELECT COUNT(*) as countcheck FROM tblpack WHERE 
                                    active = true AND packeduser IS NOT NULL AND checkeduser IS NULL";


                using (OleDbCommand cmd = new OleDbCommand(strcount, con))
                {
                    
                    OleDbDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        countocheck = Convert.ToDouble(reader["countcheck"]);

                    }

                }


            }
        }

        public static void checktotalpacks(out double totalpacks)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                DateTime curcycle;

                string strcurcycle = "Select settingdate FROM tblsettings WHERE settingid = 6";


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdp = new OleDbCommand(strcurcycle, con))
                    {

                        adapt.SelectCommand = cmdp;

                        con.Open();
                        curcycle = (DateTime)cmdp.ExecuteScalar();
                        con.Close();
                    }
                }
                
                totalpacks = 0;
                
                string strcount = @"SELECT Count(*) AS counttotal
                        FROM tblweek INNER JOIN tblpack ON tblweek.weekid = tblpack.origcycledateid
                        WHERE (((tblpack.[active])=True) AND ((tblweek.weekdate)=?))";


                using (OleDbCommand cmd = new OleDbCommand(strcount, con))
                {
                    cmd.Parameters.Add("?", OleDbType.Date).Value = curcycle;


                    OleDbDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalpacks = Convert.ToDouble(reader["counttotal"]);
                        
                    }

                }


            }
        }

        public static void checkdeliver(out double countdeliv)
        {
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                DateTime curcycle;

                string strcurcycle = "Select settingdate FROM tblsettings WHERE settingid = 6";


                using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                {

                    using (OleDbCommand cmdp = new OleDbCommand(strcurcycle, con))
                    {

                        adapt.SelectCommand = cmdp;

                        con.Open();
                        curcycle = (DateTime)cmdp.ExecuteScalar();
                        con.Close();
                    }
                }
                
                countdeliv = 0;
                string strcount = @"SELECT Count(*) AS CountDeliv
                            FROM (SELECT tblpack.patientid AS todeliv
                            FROM tblpatient INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid
                            WHERE (((tblpack.packeduser) Is Not Null) AND ((tblpack.checkeduser) Is Not Null) AND ((tblpack.collectuser) Is Null) AND ((tblpatient.delivery)=True) AND ((tblpack.active)=True))
                            GROUP BY tblpack.patientid)  AS x";


                using (OleDbCommand cmd = new OleDbCommand(strcount, con))
                {
                    OleDbDataReader reader;

                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        countdeliv = Convert.ToDouble(reader["CountDeliv"]);
                    }

                }


            }
        }

        public static int LineNumber(this Exception e)

            {

                int linenum = 0;

                try

                {

                    linenum = Convert.ToInt32(e.StackTrace.Substring(e.StackTrace.LastIndexOf(":line") + 5));

                }

                catch

                {

                    //Stack trace is not available!

                }

                return linenum;

            }
        
        public static void LogFile(string sExceptionName, string sEventName, string sControlName, int nErrorLineNo, string sFormName)
        {
            MessageBox.Show("You have encountered an error; Make note of what you were doing and if this happens again please contact support.");

            //string filePath = @"C:\error\Error.txt";

            //using (StreamWriter writer = new StreamWriter(filePath, true))
            //{
            //    writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
            //       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
            //    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
            //}
            

                StreamWriter log;
                var fileName = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApp‌​licationData), "PackChecker\\ErrorLog.txt");

            //MessageBox.Show(fileName.ToString());
            if (!File.Exists(fileName))

                {

                    log = new StreamWriter(fileName);
                

                }

                else

                {

                    log = File.AppendText(fileName);

                }

                // Write to the file:

                log.WriteLine("Data Time:" + DateTime.Now);

                log.WriteLine("Exception Name:" + sExceptionName);

                log.WriteLine("Event Name:" + sEventName);

                log.WriteLine("Control Name:" + sControlName);

                log.WriteLine("Error Line No.:" + nErrorLineNo);

                log.WriteLine("Form Name:" + sFormName);

                log.WriteLine("");

                // Close the stream:

                log.Close();
            Environment.Exit(1);

            }
        
        public static void checkwebbitconnection(out int pass)
        {
            

            try
            {

                
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {

                    con.Open();
                    

                }
               
            }
            catch
            {

               //MessageBox.Show("Webbit Connection Failed - Check ", "failed connection");
                pass = 0;
                return;

            }
            //MessageBox.Show("Webbit Database Connected!");
            
            pass = 1;

            
            
        }

        public static void checkdispenseconnection(out int pass, string dispname)
        {
            
            try
            {


                using (SqlConnection con = new SqlConnection(PackChecker.Properties.Settings.Default["LotsConnectionString"].ToString() + ";Connection Timeout=1"))
                {

                    con.Open();


                }


            }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(dispname + " Connection Failed", "failed connection");
            //    MessageBox.Show(ex.ToString(), "failed connection");
            //    pass = 0;
            //    return;



            //}
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, "Failed to check patient count", "Main Page Open", exe.LineNumber(), "Checking LOTS");
            }

            pass = 1;



        }

        public static void initpacks(object sender, EventArgs e,string formname, frmimportinstitutions owner)
        {
            //int pass = Utility.userreq("webadmin");
            //if (pass == 0)
            //{
            //    return;
            //}

            int ismonthly = new int();

            using (yesnobox mb = new yesnobox("Are you about to start packing a Monthly cycle (eg. you have patients getting FOUR weeks this cycle)","Pick Date Warning"))
            {
                if(mb.ShowDialog() == DialogResult.Yes)
                {
                    ismonthly = -1;

                }else
                {
                    ismonthly = 0;
                }
            }


                datepicker datebox = new datepicker("What MONDAY would you like your first packing cycle to start with", "Cycle Initialisation", "1", DateTime.Now);
            DateTime answer = new DateTime();
            if (datebox.ShowDialog() == DialogResult.OK)
            {

                answer = datebox.theirdate;
                
            }
            else
            {
                //exit if cancel pressed
                Environment.Exit(0);
            }
            owner.startplash("Building Packs");
            int weekdateid = 0;
            string strdateins = "INSERT INTO tblweek (weekdate, monthlycycle) VALUES (?,?)";
            string getid = "Select @@Identity";
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    OleDbCommand cmd = new OleDbCommand(strdateins, con);

                    cmd.Parameters.Add("?", OleDbType.Date, 10).Value = answer.ToShortDateString();
                    cmd.Parameters.Add("?", OleDbType.VarWChar).Value = ismonthly;


                    using (cmd)
                    {
                        con.Open();

                        cmd.ExecuteNonQuery();
                        cmd.CommandText = getid;
                        weekdateid = (int)cmd.ExecuteScalar();
                        con.Close();

                    }

                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), formname);
            }

            owner.updatesplash("Still creating packs...");

            //Get list of patients needing packs
            string strpkpx;
            if (ismonthly == 0)
            {
                strpkpx = @"SELECT tblpatient.*, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpack.packid, tblinstitution.iscommunity
FROM (tblcycle INNER JOIN (tblpatient INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid) ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid
WHERE (((tblpack.packid) Is Null) AND ((tblpatient.active)=True) AND ((tblcycle.cycleweeks)=2));";
            }else
            {
                strpkpx = @"SELECT tblpatient.*, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpack.packid, tblinstitution.iscommunity
FROM ((tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid) INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid
WHERE (((tblpatient.active)=True) AND ((tblpack.packid) Is Null));";
            }
            
            DataTable dt = new DataTable();
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdpx = new OleDbCommand(strpkpx, con))
                    {

                        con.Open();
                        using (OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx))
                        {

                            adaptpx.Fill(dt);
                        }
                    }

                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), formname);
            }


            owner.updatesplash("Rebbit...");
            DateTime origpackdate = new DateTime();
            origpackdate = answer;

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid,weeksinpack,iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,?,?,?,?,?,?)";

            int countcreated = new int();
            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdp = new OleDbCommand(strpackins, con))
                    {
                        using (OleDbDataAdapter adaptp = new OleDbDataAdapter())
                        {

                            con.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                bool isrepat = new bool();
                                if (string.IsNullOrEmpty(row["repatnumber"].ToString()))
                                {
                                    isrepat = false;
                                }
                                else
                                {
                                    isrepat = true;
                                }

                                bool isconcession = new bool();
                                if (string.IsNullOrEmpty(row["concessionnumber"].ToString()))
                                {
                                    isconcession = false;
                                }
                                else
                                {
                                    isconcession = true;
                                }

                                bool isover5med = Convert.ToBoolean(row["over5med"]);
                                var pxid = row["patientid"].ToString();
                                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());
                                int weeksinpack = cweeks / cpacks;
                                bool iscommunity = Convert.ToBoolean(row["iscommunity"]);
                                int daysadv = weeksinpack * 7;
                                int i = 0;

                                // MessageBox.Show(pxid);
                                nextpackdate = origpackdate;

                                while (i < cpacks)
                                {

                                    
                                    cmdp.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate.ToShortDateString();
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;



                                    adaptp.SelectCommand = cmdp;



                                    cmdp.ExecuteNonQuery();

                                    cmdp.Parameters.Clear();
                                    nextpackdate = nextpackdate.AddDays(+daysadv);
                                    i++;


                                }
                                countcreated++;
                                owner.updatesplash("Rebbit...Packs Created: " + countcreated);
                            }
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), formname);
            }

            string strupdate = "UPDATE tblsettings SET settingdate = ?, settingactive = ?, settingextra = ? WHERE settingid = 6";

            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {


                    using (OleDbCommand cmdup = new OleDbCommand(strupdate, con))
                    {
                        cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = answer.ToShortDateString();
                        cmdup.Parameters.Add("?", OleDbType.VarWChar).Value = ismonthly;
                        cmdup.Parameters.Add("?", OleDbType.Integer).Value = weekdateid;
                        con.Open();
                        cmdup.ExecuteNonQuery();
                        con.Close();

                    }
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), formname);
            }
            owner.stopsplash();
        }

        public static void initnewpacks(int weekdateid, DateTime newdate, string ismonthly)
        {
            int prevweekdateid = new int();

            //Get list of patients needing packs
            string strpkpx = @"SELECT tblpatient.*, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpack.packid, tblinstitution.iscommunity
FROM ((tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid) INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid
WHERE (((tblpatient.active)=True) AND ((tblpack.packid) Is Null));";
            DataTable dt = new DataTable();
            
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdpx = new OleDbCommand(strpkpx, con))
                    {

                        con.Open();
                        using (OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx))
                        {

                            adaptpx.Fill(dt);
                        }
                    }

                }

            string sqlprevweekdateid = "SELECT *  FROM tblweek WHERE weekdate = ?";

               using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    OleDbCommand cmd = new OleDbCommand(sqlprevweekdateid, con);

                    cmd.Parameters.Add("?", OleDbType.Date, 10).Value = newdate.AddDays(-14);


                    using (cmd)
                    {
                        con.Open();

                        cmd.ExecuteScalar();
                        prevweekdateid = (int)cmd.ExecuteScalar();
                        con.Close();

                    }

                }
            



            DateTime origpackdate = new DateTime();
            origpackdate = newdate;

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid,weeksinpack,iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,?,?,?,?,?,?)";

            int countcreated = new int();
            
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdp = new OleDbCommand(strpackins, con))
                    {
                        using (OleDbDataAdapter adaptp = new OleDbDataAdapter())
                        {

                            con.Open();
                            foreach (DataRow row in dt.Rows)
                            {
                                bool isrepat = new bool();
                                if (string.IsNullOrEmpty(row["repatnumber"].ToString()))
                                {
                                    isrepat = false;
                                }
                                else
                                {
                                    isrepat = true;
                                }

                                bool isconcession = new bool();
                                if (string.IsNullOrEmpty(row["concessionnumber"].ToString()))
                                {
                                    isconcession = false;
                                }
                                else
                                {
                                    isconcession = true;
                                }

                                bool isover5med = Convert.ToBoolean(row["over5med"]);
                                var pxid = row["patientid"].ToString();
                                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());
                                int weeksinpack = cweeks / cpacks;
                                bool iscommunity = Convert.ToBoolean(row["iscommunity"]);


                            nextpackdate = origpackdate;
                            if (ismonthly != "-1" && cpacks == 4 && cweeks == 4)
                            {
                                cpacks = 2;
                                cweeks = 2;
                                weekdateid = prevweekdateid;
                            }

                            if (ismonthly != "-1" && cpacks == 1 && cweeks == 4)
                            {
                                //cpacks = 1;
                                //cweeks = 2;
                                weekdateid = prevweekdateid;
                                nextpackdate = origpackdate.AddDays(-14);
                            }

                            if (ismonthly != "-1" && cpacks == 2 && cweeks == 4)
                            {
                                cpacks = 1;
                                cweeks = 2;
                                weekdateid = prevweekdateid;
                                //nextpackdate = origpackdate.AddDays(-14);
                            }

                            int daysadv = weeksinpack * 7;
                            int i = 0;

                                // MessageBox.Show(pxid);
                                

                                while (i < cpacks)
                                {


                                    cmdp.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate.ToShortDateString();
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;



                                    adaptp.SelectCommand = cmdp;



                                    cmdp.ExecuteNonQuery();

                                    cmdp.Parameters.Clear();
                                    nextpackdate = nextpackdate.AddDays(+daysadv);
                                    i++;


                                }
                                countcreated++;
                                
                            }
                            con.Close();
                        }
                    }
                }
            

            //string strupdate = "UPDATE tblsettings SET settingdate = ?, settingactive = -1, settingextra = ? WHERE settingid = 6";

           
            //    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            //    {


            //        using (OleDbCommand cmdup = new OleDbCommand(strupdate, con))
            //        {
            //            cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = newdate.ToShortDateString();
            //            cmdup.Parameters.Add("?", OleDbType.Integer).Value = weekdateid;
            //            con.Open();
            //            cmdup.ExecuteNonQuery();
            //            con.Close();

            //        }
            //    }
            
        }
        public static void import_institutions(out int count)
        {

            DataTable dtLotsInst = new DataTable();
            using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
            {
                using (SqlDataAdapter instadapt = new SqlDataAdapter(@"SELECT InstitutionNew.institutionid, InstitutionNew.institutionname FROM InstitutionNew;", lotscon))
                {
                    lotscon.Open();

                    instadapt.Fill(dtLotsInst);

                    lotscon.Close();
                }

            }




            DataTable dtWebbitInst = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter(@"SELECT tblinstitution.dispenseinstid AS institutionid, tblinstitution.institutionname FROM tblinstitution;", con))
                {
                    con.Open();

                    instadaptweb.Fill(dtWebbitInst);

                    con.Close();
                }

            }


            var idsNotInB = dtLotsInst.AsEnumerable().Select(r => r.Field<int>("institutionid"))
        .Except(dtWebbitInst.AsEnumerable().Select(r => r.Field<int>("institutionid")));

             count = idsNotInB.Count();

            if (count != 0)
            {
                DataTable dtOnlyLots = (from row in dtLotsInst.AsEnumerable()
                                        join id in idsNotInB
                                        on row.Field<int>("institutionid") equals id
                                        select row).CopyToDataTable();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    string strgetloc = @"INSERT INTO tblinstitution ( dispenseinstid, institutionname ) VALUES (?,?)";

                    using (OleDbCommand cmd = new OleDbCommand(strgetloc, con))
                    {

                        con.Open();
                        foreach (DataRow dr in dtOnlyLots.Rows)
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(dr["institutionid"]);
                            cmd.Parameters.Add("?", OleDbType.VarWChar).Value = dr["institutionname"].ToString();

                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();


                        }
                        con.Close();
                    }


                }
            }
        }

        public static void addnewpx(out DataTable dtallnewpx)
        {
            DataTable dtwebbitinsts = new DataTable();
            dtallnewpx = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strinst = "SELECT * FROM tblinstitution WHERE iswebster = -1";
                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(strinst, con))
                {
                    using (DataSet ds = new DataSet())
                    {
                        con.Open();
                        dataadapter.Fill(dtwebbitinsts);
                        con.Close();
                    }
                }
            }
            int lotsinstid;
            int webbitinstid;
            string instname;
            bool iscommunity;
            int totaladdedpx = 0;

            foreach (DataRow row in dtwebbitinsts.Rows)
            {
                lotsinstid = Convert.ToInt32(row["dispenseinstid"]);
                instname = row["institutionname"].ToString();
                iscommunity = Convert.ToBoolean(row["iscommunity"]);
                webbitinstid = Convert.ToInt32(row["institutionid"]);

                //Get list of all patients in that institution on dispense
                DataTable dtLotspx = new DataTable();
                        using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
                        {
                            using (SqlCommand cmdinst = new SqlCommand(@"SELECT Person.*
                                                    FROM Person
                                                    WHERE (((Person.LastName) Not Like '%Control%') AND ((Person.InstitutionID)=@instid)) ORDER BY LastName, FirstName;", lotscon))
                            {
                                cmdinst.Parameters.Add("@instid", SqlDbType.Int).Value = lotsinstid;
                                using (SqlDataAdapter instadapt = new SqlDataAdapter())
                                {
                                    instadapt.SelectCommand = cmdinst;

                                    lotscon.Open();

                                    instadapt.Fill(dtLotspx);

                                    lotscon.Close();
                                }
                            }

                        }



                        //Get list of all patients in that institution on webbit
                        DataTable dtWebbitPx = new DataTable();
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter(@"SELECT dispenseid as patientid FROM tblpatient WHERE casual = false;", con))
                            {
                                con.Open();

                                instadaptweb.Fill(dtWebbitPx);

                                con.Close();
                            }

                        }


                        var idsNotInPx = dtLotspx.AsEnumerable().Select(r => r.Field<int>("personid"))
                    .Except(dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("patientid")));
                        int count = idsNotInPx.Count();
                        
                        if (count == 0)
                        {
                            
                            //msgbox mb = new PackChecker.msgbox("No patients to import - " + instname, "No new patients");
                            //mb.ShowDialog();
                        }
                        else
                        {
                            //Find all new patients.
                            DataTable dtOnlyLotspx = (from row2 in dtLotspx.AsEnumerable()
                                                      join id in idsNotInPx
                                                      on row2.Field<int>("personid") equals id
                                                      where (row2.Field<int>("institutionid") == lotsinstid)
                                                      select row2).CopyToDataTable();


                    dtallnewpx.Merge(dtOnlyLotspx);


                            totaladdedpx = totaladdedpx + count;

                            using (frmpatientlistadd newpx = new frmpatientlistadd(dtOnlyLotspx, iscommunity, webbitinstid, instname))
                            {
                                newpx.ShowDialog();
                            }
                        }


                        

                    }
                }
        
        public static void remove_patient()
        {
            //Create a list of all Webbit institutions to iterate through
            DataTable dtwebbitinsts = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strinst = "SELECT * FROM tblinstitution";
                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(strinst, con))
                {
                    using (DataSet ds = new DataSet())
                    {
                        con.Open();
                        dataadapter.Fill(dtwebbitinsts);
                        con.Close();
                    }
                }
            }
            int lotsinstid;
            int webbitinstid;
            string instname;
            bool iscommunity;
            int totalremovedpx = 0;

            DataTable dtAllRemoved = new DataTable();
            foreach (DataRow row in dtwebbitinsts.Rows)
            {
                lotsinstid = Convert.ToInt32(row["dispenseinstid"]);
                instname = row["institutionname"].ToString();
                iscommunity = Convert.ToBoolean(row["iscommunity"]);
                webbitinstid = Convert.ToInt32(row["institutionid"]);

                //Get list of all patients in that institution on dispense
                DataTable dtLotspx = new DataTable();
                using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
                {
                    using (SqlCommand cmdinst = new SqlCommand(@"SELECT Person.*, *
                                                    FROM Person
                                                    WHERE (((Person.LastName) Not Like '%Control%') AND ((Person.InstitutionID)=@instid))", lotscon))
                    {
                        cmdinst.Parameters.Add("@instid", SqlDbType.Int).Value = lotsinstid;
                        using (SqlDataAdapter instadapt = new SqlDataAdapter())
                        {
                            instadapt.SelectCommand = cmdinst;

                            lotscon.Open();

                            instadapt.Fill(dtLotspx);

                            lotscon.Close();
                        }
                    }

                }



                //Get list of all patients in that institution on webbit
                DataTable dtWebbitPx = new DataTable();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT * FROM tblpatient WHERE institutionid = ?;", con))
                    {
                        cmdwebistpx.Parameters.Add("?", OleDbType.Integer).Value = webbitinstid;
                        using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                        {
                            instadaptweb.SelectCommand = cmdwebistpx;

                            con.Open();

                            instadaptweb.Fill(dtWebbitPx);

                            con.Close();
                        }
                    }

                }



                var idsNotInLots = dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("dispenseid"))
            .Except(dtLotspx.AsEnumerable().Select(r => r.Field<int>("personid")));

                int countpxremoved = idsNotInLots.Count();

                if (countpxremoved != 0)
                {
                    //Find all new patients.
                    DataTable dtOnlyWebbitpx = (from row2 in dtWebbitPx.AsEnumerable()
                                                join id in idsNotInLots
                                                on row2.Field<int>("dispenseid") equals id
                                                where (row2.Field<int>("institutionid") == webbitinstid)
                                                select row2).CopyToDataTable();
                    //Deactivate patients removed from Dispense

                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        using (OleDbCommand cmdwebistpxremove = new OleDbCommand(@"UPDATE tblpatient SET active = 0, institutionid = NULL WHERE patientid = ?;", con))
                        {
                            foreach (DataRow dr in dtOnlyWebbitpx.Rows)
                            {
                                int webpxid = Convert.ToInt32(dr["patientid"]);
                                cmdwebistpxremove.Parameters.Add("?", OleDbType.Integer).Value = webpxid;

                                con.Open();
                                cmdwebistpxremove.ExecuteNonQuery();
                                con.Close();

                                cmdwebistpxremove.Parameters.Clear();

                            }

                        }
                        dtAllRemoved.Merge(dtOnlyWebbitpx);
                        totalremovedpx = totalremovedpx + countpxremoved;
                        
                    }
                }
            }

           

            if (totalremovedpx > 0)
            {
                

                msgbox mb = new PackChecker.msgbox(totalremovedpx + " Patients Removed", "Patients Removed");
                mb.ShowDialog();

                //StringBuilder sBuilder = new StringBuilder();
                //sBuilder.Append(drname["pxfirstname"].ToString() + " " + drname["pxlastname"].ToString());
                //sBuilder.Append(totalremovedpx.ToString() + " patients removed from Webbit:" + Environment.NewLine);

                foreach (DataRow drname in dtAllRemoved.Rows)
                {
                    using (msgbox mbname = new PackChecker.msgbox(drname["pxfirstname"].ToString() + " " + drname["pxlastname"].ToString(), "Name"))
                    {
                        mbname.ShowDialog();
                    }

                        //MessageBox.Show(sBuilder.ToString());

                    using (yesnobox yn = new yesnobox("Would you also like to deactivate any unpacked packs for this patient(s)?", "Packs to deact"))
                    {
                        if (yn.ShowDialog() == DialogResult.Yes)
                        {
                            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                            {
                                using (OleDbCommand cmddeactpacks = new OleDbCommand(@"UPDATE tblpack SET tblpack.active = 0, tblpack.deactivecomment = 'Deactivated as removed from Dispense institution', repackuser = ?
                                        WHERE (((tblpack.patientid)=?) AND ((tblpack.packeduser) Is Null) AND ((tblpack.active)=True));", con))
                                {
                                    foreach (DataRow dr in dtAllRemoved.Rows)
                                    {
                                        int webpxid = Convert.ToInt32(dr["patientid"]);
                                        cmddeactpacks.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                                        cmddeactpacks.Parameters.Add("?", OleDbType.Integer).Value = webpxid;

                                        con.Open();
                                        cmddeactpacks.ExecuteNonQuery();
                                        con.Close();

                                        cmddeactpacks.Parameters.Clear();

                                    }

                                }
                            }
                        }

                        using (yesnobox yn2 = new yesnobox("Would you also like to deactivate all UNCOLLECTED packs for this patient(s)?", "Packs to deact"))
                        {
                            if (yn2.ShowDialog() == DialogResult.Yes)
                            {
                                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                                {
                                    using (OleDbCommand cmddeactpacks = new OleDbCommand(@"UPDATE tblpack SET tblpack.active = 0, tblpack.deactivecomment = 'Deactivated as removed from Dispense institution'
                                WHERE (((tblpack.active)=True) AND ((tblpack.patientid)=?) AND ((tblpack.packeduser) Is Not Null) AND ((tblpack.checkeduser) Is Not Null) AND ((tblpack.collectuser) Is Null));", con))
                                    {
                                        foreach (DataRow dr2 in dtAllRemoved.Rows)
                                        {
                                            int webpxid = Convert.ToInt32(dr2["patientid"]);
                                            cmddeactpacks.Parameters.Add("?", OleDbType.Integer).Value = webpxid;

                                            con.Open();
                                            cmddeactpacks.ExecuteNonQuery();
                                            con.Close();

                                            cmddeactpacks.Parameters.Clear();

                                        }

                                    }
                                }
                            }

                        }
                    }
                    

                }
            }
            
        }
        
        public static void reactivate_patient(out DataTable dtallreact)
        {
            DataTable dtwebbitinsts = new DataTable();
            dtallreact = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strinst = "SELECT * FROM tblinstitution WHERE iswebster = -1";
                using (OleDbDataAdapter dataadapter = new OleDbDataAdapter(strinst, con))
                {
                    using (DataSet ds = new DataSet())
                    {
                        con.Open();
                        dataadapter.Fill(dtwebbitinsts);
                        con.Close();
                    }
                }
            }
            int lotsinstid;
            int webbitinstid;
            string instname;
            bool iscommunity;
            int totalreactpx = 0;
            foreach (DataRow row in dtwebbitinsts.Rows)
            {
                lotsinstid = Convert.ToInt32(row["dispenseinstid"]);
                instname = row["institutionname"].ToString();
                iscommunity = Convert.ToBoolean(row["iscommunity"]);
                webbitinstid = Convert.ToInt32(row["institutionid"]);

                //Get list of all patients in that institution on dispense
                DataTable dtLotspx = new DataTable();
                using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
                {
                    using (SqlCommand cmdinst = new SqlCommand(@"SELECT Person.*, *
                                                    FROM Person
                                                    WHERE(((Person.LastName)Not Like '%Control%') AND((Person.InstitutionID) = @instid))", lotscon))
                    {
                        cmdinst.Parameters.Add("@instid", SqlDbType.Int).Value = lotsinstid;
                        using (SqlDataAdapter instadapt = new SqlDataAdapter())
                        {
                            instadapt.SelectCommand = cmdinst;

                            lotscon.Open();

                            instadapt.Fill(dtLotspx);

                            lotscon.Close();
                        }
                    }

                }



                //Get list of all patients in that institution on webbit
                DataTable dtWebbitPx = new DataTable();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT tblpatient.dispenseid AS patientid, tblpatient.institutionid
                                                                        FROM tblpatient
                                                                        WHERE (((tblpatient.institutionid) Is Null)) AND casual = false;", con))
                    {
                        
                        using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                        {
                            instadaptweb.SelectCommand = cmdwebistpx;

                            con.Open();

                            instadaptweb.Fill(dtWebbitPx);

                            con.Close();
                        }
                    }

                }



                var idsNotInLots = dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("patientid"))
            .Intersect(dtLotspx.AsEnumerable().Select(r => r.Field<int>("personid")));

                int countpxreact = idsNotInLots.Count();

                if (countpxreact != 0)
                {
                    //Find all new patients.
                    DataTable dtOnlyWebbitpx = (from row2 in dtLotspx.AsEnumerable()
                                                join id in idsNotInLots
                                                on row2.Field<int>("personid") equals id
                                                where (row2.Field<int>("institutionid") == lotsinstid)
                                                select row2).CopyToDataTable();
                    //Deactivate patients removed from Dispense
                    dtallreact.Merge(dtOnlyWebbitpx);
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        msgbox mb = new PackChecker.msgbox(countpxreact.ToString() + " patients reactivated in " + instname.ToString() + ".", "Patients Reactivated");
                        mb.ShowDialog();

                        using (OleDbCommand cmdwebistpxreact = new OleDbCommand(@"UPDATE tblpatient SET active = -1, institutionid = ? WHERE dispenseid = ?;", con))
                        {
                            foreach (DataRow drname in dtOnlyWebbitpx.Rows)
                            {
                                using (msgbox mbname = new PackChecker.msgbox(drname["firstname"].ToString() + " " + drname["lastname"].ToString(), "Name"))
                                {
                                    mbname.ShowDialog();
                                }

                                int lotspxid = Convert.ToInt32(drname["personid"]);
                                cmdwebistpxreact.Parameters.Add("?", OleDbType.Integer).Value = webbitinstid;
                                cmdwebistpxreact.Parameters.Add("?", OleDbType.Integer).Value = lotspxid;

                                con.Open();
                                cmdwebistpxreact.ExecuteNonQuery();
                                con.Close();

                                cmdwebistpxreact.Parameters.Clear();

                            }

                        }

                        
                    }
                }
                else
                {

                }
               
                totalreactpx = totalreactpx + countpxreact;

            }
            
        }
        
        public static void recopy_dispense()
        {
            DataTable dtLotspx = new DataTable();
            using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
            {
                using (SqlCommand cmdinst = new SqlCommand(@"SELECT * FROM Person WHERE InstitutionID is not null;", lotscon))
                {
                    
                    using (SqlDataAdapter instadapt = new SqlDataAdapter())
                    {
                        instadapt.SelectCommand = cmdinst;

                        lotscon.Open();

                        instadapt.Fill(dtLotspx);

                        lotscon.Close();
                    }
                }

            }



            //Get list of all patients in that institution on webbit
            DataTable dtWebbitPx = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT tblpatient.dispenseid AS webbitdispid
                                                                    FROM tblpatient WHERE casual = false;", con))
                {

                    using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                    {
                        instadaptweb.SelectCommand = cmdwebistpx;

                        con.Open();

                        instadaptweb.Fill(dtWebbitPx);

                        con.Close();
                    }
                }

            }



            var idsInBoth = dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("webbitdispid"))
        .Intersect(dtLotspx.AsEnumerable().Select(r => r.Field<int>("personid")));

            int countpxreact = idsInBoth.Count();

            if (countpxreact != 0)
            {
                //Find all new patients.
                DataTable dtOnlyWebbitpx = (from row2 in dtLotspx.AsEnumerable()
                                            join id in idsInBoth
                                            on row2.Field<int>("personid") equals id
                                            select row2).CopyToDataTable();


                string strins = @"UPDATE tblpatient SET pxfirstname = StrConv(?,3), pxlastname = StrConv(?,3), address = ?, suburb = ?, phonenumber = ?, repatnumber = ?, medicarenumber = ?, concessionnumber = ? 
                                WHERE dispenseid = ?";

                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                    {
                        using (OleDbCommand sqlcom2 = new OleDbCommand(strins, con))
                        {
                            
                            con.Open();
                            foreach (DataRow row in dtOnlyWebbitpx.Rows)
                            {
                                

                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["FirstName"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["LastName"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["Address"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["Suburb"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["PhoneNumber"].ToString();
                                if (string.IsNullOrEmpty(row["VACardID"].ToString()) || Convert.ToInt32(row["VACardID"].ToString()) == 0)
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = DBNull.Value;
                                }
                                else
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["VACardID"].ToString();
                                }

                                

                                //if (string.IsNullOrEmpty(row.Cells["clnrepatid"].FormattedValue.ToString()))
                                //{
                                //    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = "";
                                //}
                                //else
                                //{
                                //    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnrepatid"].Value;
                                //}

                                
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["MedicareNo"].ToString();

                                if (string.IsNullOrEmpty(row["EntitlementC"].ToString()))
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = DBNull.Value;
                                }
                                else
                                {
                                    sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["EntitlementC"].ToString();
                                }
                                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = Convert.ToInt32(row["PersonID"]);
                                dataadapter.SelectCommand = sqlcom2;



                                sqlcom2.ExecuteNonQuery();
                                sqlcom2.Parameters.Clear();
                            }
                            con.Close();
                        }
                    }
                }
            }
            }

        public static void addnewusers()
        {
                //Get list of all patients in that institution on dispense
               
                DataTable dtlotsusers = new DataTable();
               
            using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
            {
                using (SqlCommand cmdinst = new SqlCommand(@"SELECT * FROM Staff;", lotscon))
                {

                    using (SqlDataAdapter instadapt = new SqlDataAdapter())
                    {
                        instadapt.SelectCommand = cmdinst;

                        lotscon.Open();

                        instadapt.Fill(dtlotsusers);

                        lotscon.Close();
                    }
                }

            }

            //Get list of all patients in that institution on webbit
            DataTable dtWebbitPx = new DataTable();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter(@"SELECT dispenseuserid FROM tbluser;", con))
                    {
                        con.Open();

                        instadaptweb.Fill(dtWebbitPx);

                        con.Close();
                    }

                }


                var idsNotInPx = dtlotsusers.AsEnumerable().Select(r => r.Field<int>("StaffID"))
            .Except(dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("dispenseuserid")));
                int count = idsNotInPx.Count();

                if (count == 0)
                {
                //no new users
                }
                else
                {
                    //Find all new patients.
                    DataTable dtOnlyLotsUsers = (from row2 in dtlotsusers.AsEnumerable()
                                              join id in idsNotInPx
                                              on row2.Field<int>("StaffID") equals id
                                              select row2).CopyToDataTable();
                
                string strins = @"INSERT INTO tbluser (userfirstname, userlogin, dispenseuserid, userjobid) VALUES (?,?,?,2)";

                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                    {
                        using (OleDbCommand sqlcom2 = new OleDbCommand(strins, con))
                        {

                            con.Open();
                            foreach (DataRow row in dtOnlyLotsUsers.Rows)
                            {

                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffName"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffInitial"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffID"].ToString();
                                
                                dataadapter.SelectCommand = sqlcom2;
                                
                                sqlcom2.ExecuteNonQuery();
                                sqlcom2.Parameters.Clear();
                            }
                            con.Close();
                        }
                    }
                }
                using (msgbox mb = new msgbox("New Users Added", "updated users"))
                {
                    mb.ShowDialog();
                }

            }




            }

        public static void recopy_dispenseusers()
        {
            DataTable dtlotsusers = new DataTable();

            using (SqlConnection lotscon = new SqlConnection(PackChecker.Properties.Settings.Default["LOTSConnectionString"].ToString()))
            {
                using (SqlCommand cmdinst = new SqlCommand(@"SELECT * FROM Staff;", lotscon))
                {

                    using (SqlDataAdapter instadapt = new SqlDataAdapter())
                    {
                        instadapt.SelectCommand = cmdinst;

                        lotscon.Open();

                        instadapt.Fill(dtlotsusers);

                        lotscon.Close();
                    }
                }

            }

            //Get list of all patients in that institution on webbit
            DataTable dtWebbitPx = new DataTable();
            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter(@"SELECT dispenseuserid FROM tbluser;", con))
                {
                    con.Open();

                    instadaptweb.Fill(dtWebbitPx);

                    con.Close();
                }

            }


            var idsNotInPx = dtlotsusers.AsEnumerable().Select(r => r.Field<int>("StaffID"))
        .Intersect(dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("dispenseuserid")));
            int count = idsNotInPx.Count();

           if(count != 0)
            {
                //Find all new patients.
                DataTable dtOnlyLotsUsers = (from row2 in dtlotsusers.AsEnumerable()
                                             join id in idsNotInPx
                                             on row2.Field<int>("StaffID") equals id
                                             select row2).CopyToDataTable();

                string strins = @"UPDATE tbluser SET userfirstname = ?, userlogin = ? WHERE dispenseuserid = ?";

                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbDataAdapter dataadapter = new OleDbDataAdapter())
                    {
                        using (OleDbCommand sqlcom2 = new OleDbCommand(strins, con))
                        {

                            con.Open();
                            foreach (DataRow row in dtOnlyLotsUsers.Rows)
                            {

                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffName"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffInitial"].ToString();
                                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row["StaffID"].ToString();

                                dataadapter.SelectCommand = sqlcom2;

                                sqlcom2.ExecuteNonQuery();
                                sqlcom2.Parameters.Clear();
                            }
                            con.Close();
                        }
                    }
                }
                //using (msgbox mb = new msgbox("Users Updated", "updated users"))
                //{
                //    mb.ShowDialog();
                //}

            }



            
               
            
        }

        public static void updateallpx(object sender, EventArgs e, string fromloc)
        {
            DataTable dtreact;
            DataTable dtnew;
            DataTable dtPacksToMakedispid = new DataTable();
            int countnewinst;
            //Find new Inst and Import
            
            Utility.import_institutions(out countnewinst);

            //If new inst is detected, 
            if (countnewinst != 0)
            {
                using (msgbox mb = new msgbox("New Institution Detected, please check if packing is required for it.", "New Inst"))
                {
                    mb.ShowDialog();
                }

                using (frmimportinstitutions impinst = new frmimportinstitutions("update"))
                {
                    impinst.ShowDialog();
                }
            }

            
            Utility.remove_patient();

            Utility.reactivate_patient(out dtreact);

            Utility.addnewpx(out dtnew);

            Utility.recopy_dispense();

            dtPacksToMakedispid = dtreact.Copy();
            dtPacksToMakedispid.Merge(dtnew);

            int countpxpacktomake = dtPacksToMakedispid.Rows.Count;

            if(fromloc == "force")
            {
                DateTime curdate = new DateTime();

                string ismonthly = null;
                int weekdateid = new int();
                int prevweekdateid = new int();
                bool isover5med = new bool();
                bool iscommunity = new bool();
                bool isrepat = new bool();
                bool isconcession = new bool();

                DateTime nextpackdate = new DateTime();
                int origweekdateid = new int();
                DateTime origpackdate = new DateTime();
                int countpxpacktoforce;
                DataTable dtmissingpacks = new DataTable();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT tblpatient.*, tblinstitution.iscommunity, tblcycle.cycleweeks, 
                        tblcycle.cyclepacks, tblpatient.active FROM (tblcycle INNER JOIN (tblpatient INNER JOIN tblinstitution ON 
                        tblpatient.institutionid = tblinstitution.institutionid) ON tblcycle.cycleid = tblpatient.cycleid) LEFT 
                        JOIN tblpack ON tblpatient.patientid = tblpack.patientid WHERE (((tblpack.packid) Is Null) AND ((tblpatient.active)=True));", con))
                    {

                        using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                        {
                            instadaptweb.SelectCommand = cmdwebistpx;

                            con.Open();

                            instadaptweb.Fill(dtmissingpacks);

                            con.Close();
                        }
                    }

                }
                countpxpacktoforce = dtmissingpacks.Rows.Count;
                

                //Find dates for packs if we need them
                if (countpxpacktomake != 0 || countpxpacktoforce != 0)
                {

                    

                    //Get current cycle date
                    string strpackdate = "SELECT * FROM tblsettings WHERE settingid = 6";
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {

                        using (OleDbCommand cmd = new OleDbCommand(strpackdate, con))
                        {


                            con.Open();
                            OleDbDataReader reader;
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                curdate = Convert.ToDateTime(reader["settingdate"]);
                                ismonthly = reader["settingactive"].ToString();

                            }

                            reader.Close();
                            con.Close();
                        }
                    }

                    //get the weekid from tblweeks
                    
                    string strdateins = "SELECT *  FROM tblweek WHERE weekdate = ?";

                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            OleDbCommand cmd = new OleDbCommand(strdateins, con);

                            cmd.Parameters.Add("?", OleDbType.Date, 10).Value = curdate;


                            using (cmd)
                            {
                                con.Open();

                                cmd.ExecuteScalar();
                                weekdateid = (int)cmd.ExecuteScalar();
                                con.Close();

                            }

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Utility update all px");
                    }
                    int countweeks = new int();
                    string sqlprevweekdateid = "SELECT *  FROM tblweek WHERE weekdate = ?";
                    string sqlcountweeks = "Select Count (*) as countrows  FROM tblweek WHERE weekdate = ?";
                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            OleDbCommand cmd = new OleDbCommand(sqlcountweeks, con);

                            cmd.Parameters.Add("?", OleDbType.Date, 10).Value = curdate.AddDays(-14);


                            using (cmd)
                            {
                                con.Open();

                                cmd.ExecuteScalar();
                                countweeks = (int)cmd.ExecuteScalar();

                                if (countweeks == 0)
                                {
                                    prevweekdateid = weekdateid;
                                }else
                                {
                                    cmd.CommandText = sqlprevweekdateid;
                                    prevweekdateid = (int)cmd.ExecuteScalar();

                                }

                               
                                con.Close();

                            }

                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Utility update all px");
                    }



                }

                


                if (countpxpacktomake != 0)
                {

                    using (msgbox mb = new msgbox(countpxpacktomake.ToString() + " Patients added, packs will now be created for them.", "New patients"))
                    {
                        mb.ShowDialog();
                    }




                    //foreach (DataRow dr in dtPacksToMakedispid.Rows)
                    //{
                    //    using (msgbox mb = new msgbox(dr["FirstName"].ToString() + " " + dr["LastName"].ToString(), "New patients"))
                    //    {
                    //        mb.ShowDialog();
                    //    }

                    //}


                    //Start Creating packs for patients in new list
                    

                    DataTable dtPacksToMakewebbitid = new DataTable();

                    //Get list of all patients in webbit
                    DataTable dtWebbitPx = new DataTable();
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT tblpatient.*, tblinstitution.iscommunity, tblcycle.cycleweeks, tblcycle.cyclepacks
                                                                        FROM tblcycle INNER JOIN (tblpatient INNER JOIN tblinstitution ON tblpatient.institutionid = 
                                                                            tblinstitution.institutionid) ON tblcycle.cycleid = tblpatient.cycleid;", con))
                        {

                            using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                            {
                                instadaptweb.SelectCommand = cmdwebistpx;

                                con.Open();

                                instadaptweb.Fill(dtWebbitPx);

                                con.Close();
                            }
                        }

                    }
                    //MessageBox.Show(dtWebbitPx.Rows.Count.ToString());
                    //MessageBox.Show(dtPacksToMakedispid.Rows.Count.ToString());


                    var idsinboth = dtWebbitPx.AsEnumerable().Select(r => r.Field<int>("dispenseid"))
                .Intersect(dtPacksToMakedispid.AsEnumerable().Select(r => r.Field<int>("personid")));
                    //MessageBox.Show(idsinboth.Count().ToString());

                    //Find all new patients.
                    dtPacksToMakewebbitid = (from row2 in dtWebbitPx.AsEnumerable()
                                             join id in idsinboth
                                             on row2.Field<int>("dispenseid") equals id
                                             select row2).CopyToDataTable();

                    
                    origpackdate = curdate;
                    
                    origweekdateid = weekdateid;
                    

                    createpacks(sender, e, ismonthly, ref weekdateid, prevweekdateid, dtPacksToMakewebbitid, ref isover5med, ref iscommunity, ref isrepat, ref isconcession, origpackdate, origweekdateid, ref nextpackdate);


                    



                }
                dtmissingpacks.Clear();
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdwebistpx = new OleDbCommand(@"SELECT tblpatient.*, tblinstitution.iscommunity, tblcycle.cycleweeks, 
                        tblcycle.cyclepacks, tblpatient.active FROM (tblcycle INNER JOIN (tblpatient INNER JOIN tblinstitution ON 
                        tblpatient.institutionid = tblinstitution.institutionid) ON tblcycle.cycleid = tblpatient.cycleid) LEFT 
                        JOIN tblpack ON tblpatient.patientid = tblpack.patientid WHERE (((tblpack.packid) Is Null) AND ((tblpatient.active)=True));", con))
                    {

                        using (OleDbDataAdapter instadaptweb = new OleDbDataAdapter())
                        {
                            instadaptweb.SelectCommand = cmdwebistpx;

                            con.Open();

                            instadaptweb.Fill(dtmissingpacks);

                            con.Close();
                        }
                    }

                }
                countpxpacktoforce = dtmissingpacks.Rows.Count;

                if (countpxpacktoforce != 0)
                {
                    origpackdate = curdate;

                    origweekdateid = weekdateid;
                    createpacks(sender, e, ismonthly, ref weekdateid, prevweekdateid, dtmissingpacks, ref isover5med, ref iscommunity, ref isrepat, ref isconcession, origpackdate, origweekdateid, ref nextpackdate);

                }

            }
            Utility.addnewusers();
            Utility.recopy_dispenseusers();
            
        }

        private static void createpacks(object sender, EventArgs e, string ismonthly, ref int weekdateid, int prevweekdateid, DataTable dtPacksToMakewebbitid, ref bool isover5med, ref bool iscommunity, ref bool isrepat, ref bool isconcession, DateTime origpackdate, int origweekdateid, ref DateTime nextpackdate)
        {
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,?,?,?,?,?,?)";

            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {
                    using (OleDbCommand cmdp = new OleDbCommand(strpackins, con))
                    {
                        using (OleDbDataAdapter adaptp = new OleDbDataAdapter())
                        {

                            con.Open();
                            foreach (DataRow row in dtPacksToMakewebbitid.Rows)
                            {
                                weekdateid = origweekdateid;
                                var pxid = row["patientid"].ToString();
                                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());

                                if (string.IsNullOrEmpty(row["repatnumber"].ToString()) || Convert.ToInt32(row["repatnumber"].ToString()) == 0)
                                {
                                    isrepat = false;
                                }
                                else
                                {
                                    isrepat = true;
                                }

                                if (string.IsNullOrEmpty(row["concessionnumber"].ToString()))
                                {
                                    isconcession = false;
                                }
                                else
                                {
                                    isconcession = true;
                                }

                                isover5med = Convert.ToBoolean(row["over5med"]);

                                iscommunity = Convert.ToBoolean(row["iscommunity"]);
                                nextpackdate = origpackdate;

                                int i = 0;
                                if (ismonthly != "-1" && cpacks == 4 && cweeks == 4)
                                {
                                    cpacks = 2;
                                    cweeks = 2;
                                    weekdateid = prevweekdateid;
                                }

                                if (ismonthly != "-1" && cpacks == 1 && cweeks == 4)
                                {
                                    //cpacks = 1;
                                    //cweeks = 2;
                                    weekdateid = prevweekdateid;
                                    nextpackdate = origpackdate.AddDays(-14);
                                }

                                if (ismonthly != "-1" && cpacks == 2 && cweeks == 4)
                                {
                                    cpacks = 1;
                                    cweeks = 2;
                                    weekdateid = prevweekdateid;
                                    //nextpackdate = origpackdate.AddDays(-14);
                                }
                                int weeksinpack = cweeks / cpacks;
                                int daysadv = weeksinpack * 7;
                                // MessageBox.Show(pxid);


                                while (i < cpacks)
                                {


                                    cmdp.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                                    cmdp.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;




                                    adaptp.SelectCommand = cmdp;



                                    cmdp.ExecuteNonQuery();

                                    cmdp.Parameters.Clear();
                                    nextpackdate = nextpackdate.AddDays(+daysadv);
                                    i++;


                                }

                            }
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Utility update all px");
            }
        }

        public static void futurepacks<T>(object sender, EventArgs e, int pxid) where T : IWorker
        {
            DateTime theirstartdate = new DateTime();
            DateTime enddate = new DateTime();
            DateTime ourstartdate = new DateTime();
            bool casual;
            string com;
            //get reason for packs
            using (inputbox inputcom = new inputbox("What are the extra packs for?", "Add Comment", "Holiday"))
            {
                //if press cancel, stop method
                if (inputcom.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                com = inputcom.answer + " - " + User.curusername;


            }

            

            bool nonmonday = false;
            //ask for date
            using (datepicker getfirstdate = new datepicker("What date should the packs start?", "Starting Date", "2", DateTime.Now))
            {
                //if press cancel, stop method
                if (getfirstdate.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                theirstartdate = getfirstdate.theirdate;
                ourstartdate = getfirstdate.ourdate;
                if (theirstartdate.Date != ourstartdate.Date)
                {
                    nonmonday = true;
                }
            }
            using (msgbox mb = new PackChecker.msgbox("Starting date accepted", "leaving accepted"))
            {
                mb.ShowDialog();
            }

            //ask for date
            using (datepicker getenddate = new datepicker("What date should the packs end?", "Ending Date", "0", theirstartdate))
            {
                //if press cancel, stop method
                if (getenddate.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }
                //check if date. if NOT, ask again for date
                enddate = getenddate.ourdate;
            }

            using (msgbox mb = new PackChecker.msgbox("Returning date accepted", "leaving accepted"))
            {
                mb.ShowDialog();
            }

            bool isrepat = new bool();
            bool isconcession = new bool();
            bool isover5med = new bool();
            bool iscommunity = new bool();
            decimal cycleweeks = 0;
            int cyclepacks = 0;
            DateTime lastcycle = new DateTime();

            var target = (T)Application.OpenForms.OfType<T>().FirstOrDefault();
            target?.startplash("Creating future packs");
            //owner.startplash("Creating Packs...");


            //Get weeks and packs for that patients cycle
            DateTime newstartdate = new DateTime();

            using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
            {
                string strupdateuser = "SELECT tblpatient.casual FROM tblpatient WHERE patientid = ?";

                OleDbCommand cmd = new OleDbCommand(strupdateuser, con);
                cmd.Parameters.Add("?", OleDbType.Integer).Value = pxid;

                con.Open();
                casual = (bool)cmd.ExecuteScalar();
                con.Close();

            }


            if (casual == false)
            {


                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string cyclepx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, Max(tblweek.weekdate) AS MaxOfweekdate, tblinstitution.iscommunity, 
                        tblpatient.over5med, tblpatient.repatnumber, tblpatient.concessionnumber
                    FROM (tblweek INNER JOIN ((tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) INNER JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON 
                        tblweek.weekid = tblpack.origcycledateid) INNER JOIN tblinstitution ON tblpatient.institutionid = tblinstitution.institutionid
                    GROUP BY tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblinstitution.iscommunity, tblpatient.over5med, tblpatient.repatnumber, 
                    tblpatient.concessionnumber HAVING tblpatient.patientid = ?;";

                        OleDbCommand cmd = new OleDbCommand(cyclepx, con);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = pxid;

                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cyclepacks = Convert.ToInt32(reader["cyclepacks"].ToString());
                            cycleweeks = Convert.ToInt32(reader["cycleweeks"].ToString());
                            lastcycle = DateTime.Parse(reader["Maxofweekdate"].ToString());
                            if (string.IsNullOrEmpty(reader["repatnumber"].ToString()))
                            {
                                isrepat = false;
                            }
                            else
                            {
                                isrepat = true;
                            }

                            if (string.IsNullOrEmpty(reader["concessionnumber"].ToString()))
                            {
                                isconcession = false;
                            }
                            else
                            {
                                isconcession = true;
                            }

                            isover5med = Convert.ToBoolean(reader["over5med"]);
                            iscommunity = Convert.ToBoolean(reader["iscommunity"]);

                        }
                        con.Close();
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Future Packs Until");
                }
            }
            else
            {
                newstartdate = ourstartdate;
                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string cyclepx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpatient.over5med, tblpatient.repatnumber, tblpatient.concessionnumber, tblpatient.casualcommunity
FROM tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid
GROUP BY tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpatient.over5med, tblpatient.repatnumber, tblpatient.concessionnumber, tblpatient.casualcommunity
HAVING (((tblpatient.patientid)=?));";

                        OleDbCommand cmd = new OleDbCommand(cyclepx, con);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = pxid;

                        con.Open();
                        OleDbDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            cyclepacks = Convert.ToInt32(reader["cyclepacks"].ToString());
                            cycleweeks = Convert.ToInt32(reader["cycleweeks"].ToString());
                            if (string.IsNullOrEmpty(reader["repatnumber"].ToString()))
                            {
                                isrepat = false;
                            }
                            else
                            {
                                isrepat = true;
                            }

                            if (string.IsNullOrEmpty(reader["concessionnumber"].ToString()))
                            {
                                isconcession = false;
                            }
                            else
                            {
                                isconcession = true;
                            }

                            isover5med = Convert.ToBoolean(reader["over5med"]);
                            iscommunity = Convert.ToBoolean(reader["casualcommunity"]);

                        }
                        con.Close();
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Future Packs Util");
                }
            }

            int weeksinpacks = Convert.ToInt32(cycleweeks / cyclepacks);
            int dayadd = Convert.ToInt32(cycleweeks * 7);
            // Need to check if this date IS a cycle date.

            if (casual == false)
            {
                DateTime checkdate = lastcycle;

                // Find the next pack cycle prior to patient needing packs.
                while (checkdate.Date < ourstartdate.Date)
                {
                    checkdate = checkdate.AddDays(+dayadd);

                }


                if (ourstartdate.Date != checkdate.Date)
                {
                    newstartdate = checkdate.AddDays(-dayadd);
                }
                else
                {
                    newstartdate = checkdate;
                }

                if (newstartdate.Date == lastcycle.Date)
                {
                    using (msgbox alreadydate = new msgbox("This cycle or pack has already been made for the patient!", "Already made"))
                    {
                        target?.stopsplash();
                        alreadydate.ShowDialog();
                        return;
                    }
                }
            }


            if (nonmonday == false)
            {
                //if the monday is off-cycle, change it to correct cycle and warn, otherwise keep going
                if (newstartdate.Date < ourstartdate.Date)
                {
                    //ourstartdate = newstartdate;
                    using (msgbox baddate = new msgbox("The packing start date has been changed to " + newstartdate.ToShortDateString() + "." + Environment.NewLine + "to fit in with cycles", "Changed Date"))
                    {
                        baddate.ShowDialog();

                    }
                }
            }
            else
            {
                if ((theirstartdate.AddDays(-dayadd)).Date > (newstartdate.AddDays(-(dayadd - 7))).Date)
                {
                    using (msgbox baddate = new msgbox("The packing start date has been changed to " + newstartdate.ToShortDateString() + "." + Environment.NewLine + "to fit in with cycles" + ".  Date requested will be covered in these packs", "Changed Date"))
                    {
                        baddate.ShowDialog();
                    }
                    //theirstartdate = newstartdate;
                    nonmonday = false;
                }
            }





            //Divide total weeks needed by weeks in that patients cycle
            decimal totalweeks = Convert.ToInt32(enddate.Subtract(newstartdate).TotalDays) / 7 + 1;
            decimal doublegroup = totalweeks / cycleweeks;

            //Round up for thie figure
            int group = Convert.ToInt32(Math.Ceiling(doublegroup));

            //Find records needed for this patient by multiplying packs that get with packs they need
            int records = group * cyclepacks;
            int cycleweeksint = Convert.ToInt32(cycleweeks);
            //create a record for each pack until records created = records needed

            DateTime curdate = newstartdate;
            DateTime cycledate = newstartdate;
            int weekdateid = new int();
            int daypackadd = cycleweeksint / cyclepacks * 7;

            int countcycle = 0;

            while (countcycle < group)
            {
                try
                {
                    using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                    {
                        string strdateins = "INSERT INTO tblweek (weekdate, holidaycycle) VALUES (?,-1)";
                        string getid = "Select @@Identity";


                        OleDbDataAdapter adapt = new OleDbDataAdapter();

                        OleDbCommand cmdp = new OleDbCommand(strdateins, con);

                        cmdp.Parameters.Add("?", OleDbType.Date, 10).Value = cycledate;

                        adapt.SelectCommand = cmdp;

                        weekdateid = 0;
                        using (cmdp)
                        {
                            con.Open();

                            cmdp.ExecuteNonQuery();
                            cmdp.CommandText = getid;
                            weekdateid = (int)cmdp.ExecuteScalar();
                            con.Close();

                        }
                    }
                }
                catch (Exception exe)
                {
                    Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Future Packs Util");
                }
                bool nonmon;

                if (nonmonday == true)
                {
                    curdate = theirstartdate;
                    nonmon = true;
                }
                else
                {
                    nonmon = false;
                }

                string earlycom = "Packs Prior to *extra packs*";

                int countrecs = 0;
                while (countrecs < cyclepacks)
                {
                    try
                    {
                        using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                        {
                            string strupdate = @"INSERT INTO tblpack (cycledate,patientid,origcycledateid,earlyrequest,repackuser,packcomment,isnonmondaypack,weeksinpack, iscommunity, isrepat, isconcession, isover5med) VALUES (?,?,?,-1,?,?,?,?,?,?,?,?)";
                            string newcom;
                            if (curdate.Date < ourstartdate.Date)
                            {
                                newcom = earlycom;
                            }
                            else
                            {
                                newcom = com;
                            }


                            OleDbDataAdapter adap = new OleDbDataAdapter();
                            OleDbCommand cmd = new OleDbCommand(strupdate, con);
                            cmd.Parameters.Add("?", OleDbType.Date).Value = curdate.ToShortDateString();
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = pxid;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = weekdateid;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = User.curuserid;
                            cmd.Parameters.Add("?", OleDbType.VarChar).Value = newcom;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = nonmon;
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = weeksinpacks;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = iscommunity;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = isrepat;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = isconcession;
                            cmd.Parameters.Add("?", OleDbType.Boolean).Value = isover5med;


                            adap.SelectCommand = cmd;

                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    catch (Exception exe)
                    {
                        Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), "Future Packs Until");
                    }
                    countrecs++;
                    if (nonmonday == true)
                    {
                        curdate = newstartdate;
                    }

                    curdate = curdate.AddDays(+daypackadd);
                    nonmon = false;
                    nonmonday = false;

                }
                countcycle++;
                cycledate = cycledate.AddDays(+(cyclepacks * 7));
            }
            target?.stopsplash();
            using (msgbox mbdobe = new msgbox("New packs have been created for patient", "Packs Created"))
            {
                mbdobe.ShowDialog();
                return;
            }
        }
    }
    }


    


