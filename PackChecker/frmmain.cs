using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Data.OleDb;
using System.Configuration;
using System.IO;

namespace PackChecker
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        

        private void frmmain_Load(object sender, EventArgs e)
        {
            
            string defaulthome = Properties.Settings.Default.defaulthome;
            switch (defaulthome)
            {

                case "Pack":
                    tabmain.SelectTab(tabpack);
                    
                    //this.ActiveControl = cmbpatient;
                    break;

                case "Check":
                    tabmain.SelectTab(tabcheck);
                    //this.ActiveControl = cmbpatient;
                    break;
                    
                case "Collect":
                    tabmain.SelectTab(tabcollect);
                    this.ActiveControl = cmbpatient;
                    break;
            }

                       
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            
            OleDbDataAdapter adapt = new OleDbDataAdapter();

            DataSet ds = new DataSet();

            
            string sql = "SELECT tblpatient.patientid, tblpatient.pxlastname & ', ' & tblpatient.pxfirstname AS pxname FROM tblpatient WHERE active = true ORDER BY pxlastname ASC, pxfirstname ASC";
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);

                adapt.SelectCommand = cmd;
                adapt.Fill(ds);
                adapt.Dispose();
                con.Close();
                cmbpatient.DataSource = ds.Tables[0];
                cmbpatient.ValueMember = "patientid";
                cmbpatient.DisplayMember = "pxname";

            }catch(Exception ex)
            {
                MessageBox.Show("Couldnt open connection");
                string filePath = @"C:\error\Error.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                }
            }




        }

        private void btnopencollect_Click(object sender, EventArgs e)
        {
            var pxid = cmbpatient.SelectedValue.ToString();

            int pass = Utility.userreq("collect");
            if (pass == 0)
            {
                return;
            }

            frmcollecting frmcollecting = new frmcollecting(pxid);
            frmcollecting.ShowDialog();
        }

        private void btninitpacks_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("repack");
            if (pass == 0)
            {
                return;
            }


            inputbox inputbox = new inputbox("What date would you like your first packing cycle to start with. (dd/mm/yy)", "Cycle Initialisation", "");
            string answer = null;
            if (inputbox.ShowDialog() == DialogResult.OK)
            {

                answer = inputbox.answer;
            }
            inputbox.Close();
            inputbox.Dispose();
            DateTime cycleweekdate;
            while (!DateTime.TryParse(answer, out cycleweekdate))
            {
                MessageBox.Show("That wasn't a date, please try again");
                inputbox inputbox2 = new inputbox("What date would you like your first packing cycle to start with. (dd/mm/yy)", "Cycle Initialisation", "");
                if (inputbox2.ShowDialog() == DialogResult.OK)
                {

                    answer = inputbox2.answer;
                }
                else
                {
                    //exit if cancel pressed
                    return;
                }
            }

            string strdateins = "INSERT INTO tblweek (weekdate) VALUES (?)";
            string getid = "Select @@Identity";

            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

            OleDbDataAdapter adapt = new OleDbDataAdapter();

            OleDbCommand cmd = new OleDbCommand(strdateins, con);

            cmd.Parameters.Add("?", OleDbType.Date, 10).Value = answer;

            adapt.SelectCommand = cmd;
            int weekdateid = new int();
            weekdateid = 0;
            using (cmd)
            {
                con.Open();

                cmd.ExecuteNonQuery();
                cmd.CommandText = getid;
                weekdateid = (int)cmd.ExecuteScalar();
                con.Close();

            }

            string strupdate = "UPDATE tblsettings SET settingdate = ? WHERE settingid = 6";

            OleDbCommand cmdup = new OleDbCommand(strupdate, con);

            cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = answer;
            adapt.SelectCommand = cmdup;

            con.Open();
            cmdup.ExecuteNonQuery();
            con.Close();

            //Get list of patients needing packs
            string strpkpx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpatient.active
FROM tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid
WHERE(((tblpatient.active) = True));";

            OleDbCommand cmdpx = new OleDbCommand(strpkpx, con);
            DataTable dt = new DataTable();
            con.Open();
            OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx);

            adaptpx.Fill(dt);


            DateTime origpackdate = new DateTime();
            origpackdate = Convert.ToDateTime(answer);

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid) VALUES (?,?,?)";
            OleDbCommand cmdp = new OleDbCommand(strpackins, con);
            OleDbDataAdapter adaptp = new OleDbDataAdapter();


            foreach (DataRow row in dt.Rows)
            {
                var pxid = row["patientid"].ToString();
                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());

                int i = 0;

                // MessageBox.Show(pxid);
                nextpackdate = origpackdate;

                while (i < cpacks)
                {

                    cmdp.Parameters.Clear();
                    cmdp.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate;
                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;




                    adaptp.SelectCommand = cmdp;



                    cmdp.ExecuteNonQuery();


                    nextpackdate = nextpackdate.AddDays(+7);
                    i++;


                }

            }
            con.Close();
        }

        private void btnopenfrmpack_Click(object sender, EventArgs e)
        {
            //string input = Interaction.InputBox("Enter User Login", "User Check", "", -1, -1);

            int pass = Utility.userreq("pack");
            if (pass == 0)
            {
                return;
            }
            //User.curuserlogin, User.curuserid, User.curusername
            frmpacking frmpacking = new frmpacking();
            frmpacking.ShowDialog();
        }
        
       
        private void btnopenfrmpack_Click_1(object sender, EventArgs e)
        {
            int pass = Utility.userreq("pack");
            if (pass == 0)
            {
                return;
            }
            frmpacking frmpacking = new frmpacking();
            frmpacking.ShowDialog();
        }

        private void btncheck_Click_1(object sender, EventArgs e)
        {

            int pass = Utility.userreq("check");
            if (pass == 0)
            {
                return;
            }

            frmchecking frmchecking = new frmchecking();
            frmchecking.ShowDialog();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {

        }
        

        private void btnforcecycle_Click(object sender, EventArgs e)
        {
            int pass = Utility.userreq("repack");
            if (pass == 0)
            {
                return;
            }
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            yesnobox yn = new yesnobox("Are you sure you want to force a new cycle?", "Check Force");
            if (yn.ShowDialog() == DialogResult.No)
            {
                return;
            }
            DateTime curdate = new DateTime();
            DateTime newdate = new DateTime();
            int defweeks = 0;
            //Get last cycle date
            string strpackdate = "SELECT * FROM tblsettings WHERE settingid = 6";
            OleDbCommand cmd = new OleDbCommand(strpackdate, con);
            con.Open();
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                curdate = Convert.ToDateTime(reader["settingdate"]);

            }

            reader.Close();
            con.Close();

            strpackdate = "SELECT * FROM tblsettings WHERE settingid = 8";
            cmd = new OleDbCommand(strpackdate, con);
            con.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                defweeks = Convert.ToInt32(reader["settingactive"]);

            }
            reader.Close();

            con.Close();

            newdate = curdate.AddDays(7 * defweeks);

            //yesnobox yn = new yesnobox("Would you like to create a new packing cycle starting" + Environment.NewLine + Environment.NewLine + newdate.ToShortDateString() , "Date Confirmation");
            //if (yn.ShowDialog() == DialogResult.No)
            //{
            //    return;
            //}
            //yn.Close();
            //yn.Dispose();

            //insert new WEEK into the pack schedule
            string strdateins = "INSERT INTO tblweek (weekdate) VALUES (?)";
            string getid = "Select @@Identity";


            OleDbDataAdapter adapt = new OleDbDataAdapter();

            OleDbCommand cmdp = new OleDbCommand(strdateins, con);

            cmdp.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;

            adapt.SelectCommand = cmdp;
            int weekdateid = new int();
            weekdateid = 0;
            using (cmdp)
            {
                con.Open();

                cmdp.ExecuteNonQuery();
                cmdp.CommandText = getid;
                weekdateid = (int)cmdp.ExecuteScalar();
                con.Close();

            }

            string strupdate = "UPDATE tblsettings SET settingdate = ? WHERE settingid = 6";

            OleDbCommand cmdup = new OleDbCommand(strupdate, con);

            cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = newdate;
            adapt.SelectCommand = cmdup;

            con.Open();
            cmdup.ExecuteNonQuery();
            con.Close();

            //Get list of patients needing packs
            string strpkpx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, Max(tblweek.weekdate) AS MaxOfweekdate, Max([weekdate]+(7*[cycleweeks])) AS nextpack
            FROM tblweek RIGHT JOIN ((tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid) LEFT JOIN tblpack ON tblpatient.patientid = tblpack.patientid) ON tblweek.weekid = tblpack.origcycledateid
            WHERE (((tblpatient.active)=True))
            GROUP BY tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks
            HAVING (((Max([weekdate]+(7*[cycleweeks]))) = ?))";


            OleDbCommand cmdpx = new OleDbCommand(strpkpx, con);
            cmdpx.Parameters.Add("?", OleDbType.Date, 8).Value = newdate.ToShortDateString();



            DataTable dt = new DataTable();
            con.Open();
            OleDbDataAdapter adaptpx = new OleDbDataAdapter(cmdpx);
            adaptpx.SelectCommand = cmdpx;
            adaptpx.Fill(dt);


            DateTime origpackdate = new DateTime();
            origpackdate = newdate;

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid) VALUES (?,?,?)";
            OleDbCommand cmdadd = new OleDbCommand(strpackins, con);
            OleDbDataAdapter adaptp = new OleDbDataAdapter();


            foreach (DataRow row in dt.Rows)
            {
                var pxid = row["patientid"].ToString();
                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());

                int i = 0;

                // MessageBox.Show(pxid);
                nextpackdate = origpackdate;

                while (i < cpacks)
                {

                    cmdadd.Parameters.Clear();
                    cmdadd.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate;
                    cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                    cmdadd.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;




                    adaptp.SelectCommand = cmdadd;



                    cmdadd.ExecuteNonQuery();


                    nextpackdate = nextpackdate.AddDays(+7);
                    i++;


                }

            }
            con.Close();


            
        }

        private void btnpxlist_Click(object sender, EventArgs e)
        {
            frmpatientlist pxlist = new frmpatientlist();
            pxlist.ShowDialog();
        }

        private void btncycle_Click(object sender, EventArgs e)
        {
            frmcyclelist fc = new frmcyclelist();
            fc.ShowDialog();
        }

        private void btnlocations_Click(object sender, EventArgs e)
        {
            frmlocationlist ll = new frmlocationlist();
            ll.ShowDialog();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            frmuserlist ul = new frmuserlist();
            ul.ShowDialog();
        }

        private void btnjobs_Click(object sender, EventArgs e)
        {
            frmjoblist jl = new frmjoblist();
            jl.ShowDialog();
        }

        private void btntraysizes_Click(object sender, EventArgs e)
        {
            frmtraysizelist ts = new frmtraysizelist();
            ts.ShowDialog();
        }
    }
}
