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

namespace PackChecker
{
    public partial class frmsettingsmenu : UserControl
    {
        public frmsettingsmenu()
        {
            InitializeComponent();
        }

        private void frmsettings_Load(object sender, EventArgs e)
        {

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
            int pass = Utility.userreq("webadmin");
            if (pass == 0)
            {
                return;
            }
            frmjoblist jl = new frmjoblist();
            jl.ShowDialog();
        }

        private void btntraysizes_Click(object sender, EventArgs e)
        {
            frmtraysizelist ts = new frmtraysizelist();
            ts.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int pass = Utility.userreq("webadmin");
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
            int weekdateid = 0;
            string strdateins = "INSERT INTO tblweek (weekdate) VALUES (?)";
            string getid = "Select @@Identity";
            try
            {
                OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString());

                OleDbDataAdapter adapt = new OleDbDataAdapter();

                OleDbCommand cmd = new OleDbCommand(strdateins, con);

                cmd.Parameters.Add("?", OleDbType.Date, 10).Value = answer;

                adapt.SelectCommand = cmd;


                using (cmd)
                {
                    con.Open();

                    cmd.ExecuteNonQuery();
                    cmd.CommandText = getid;
                    weekdateid = (int)cmd.ExecuteScalar();
                    con.Close();

                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

            string strupdate = "UPDATE tblsettings SET settingdate = ? WHERE settingid = 6";

            try
            {
                using (OleDbConnection con = new OleDbConnection(PackChecker.Properties.Settings.Default["WebbitConnectionString"].ToString()))
                {


                    using (OleDbCommand cmdup = new OleDbCommand(strupdate, con))
                    {
                        using (OleDbDataAdapter adapt = new OleDbDataAdapter())
                        {
                            cmdup.Parameters.Add("?", OleDbType.Date, 10).Value = answer;
                            adapt.SelectCommand = cmdup;

                            con.Open();
                            cmdup.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }

            //Get list of patients needing packs
            string strpkpx = @"SELECT tblpatient.patientid, tblcycle.cycleweeks, tblcycle.cyclepacks, tblpatient.active
FROM tblcycle INNER JOIN tblpatient ON tblcycle.cycleid = tblpatient.cycleid
WHERE(((tblpatient.active) = -1));";
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
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }



            DateTime origpackdate = new DateTime();
            origpackdate = Convert.ToDateTime(answer);

            DateTime nextpackdate = new DateTime();
            string strpackins = "INSERT INTO tblpack (cycledate,patientid,origcycledateid,weeksinpack) VALUES (?,?,?,?)";

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
                                var pxid = row["patientid"].ToString();
                                var cweeks = Convert.ToInt32(row["cycleweeks"].ToString());
                                var cpacks = Convert.ToInt32(row["cyclepacks"].ToString());
                                int weeksinpack = cweeks / cpacks;

                                int i = 0;

                                // MessageBox.Show(pxid);
                                nextpackdate = origpackdate;
                                
                                while (i < cpacks)
                                {

                                    cmdp.Parameters.Clear();
                                    cmdp.Parameters.Add("?", OleDbType.Date, 32).Value = nextpackdate;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = pxid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer, 9).Value = weekdateid;
                                    cmdp.Parameters.Add("?", OleDbType.Integer).Value = weeksinpack;




                                    adaptp.SelectCommand = cmdp;



                                    cmdp.ExecuteNonQuery();


                                    nextpackdate = nextpackdate.AddDays(+7);
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
                Utility.LogFile(exe.Message, e.ToString(), ((Control)sender).Name, exe.LineNumber(), this.FindForm().Name);
            }
        }
    }
    }

