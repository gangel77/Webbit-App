using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;


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
            OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
             //TODO: This line of code loads data into the 'websterdbDataSet.tblpack' table. You can move, or remove it, as needed.


            string struser = @"SELECT tbluser.userid, tbluser.userfirstname, tbluser.userlastname, tbluser.userlogin, tbljob.cancheck, tbljob.cancollect,tbljob.admin, tbljob.canpack, tbljob.canrequestrepack
FROM tbljob INNER JOIN tbluser ON tbljob.jobid = tbluser.userjobid WHERE userlogin = ?";



            OleDbDataAdapter adapt = new OleDbDataAdapter();

            OleDbCommand cmd = new OleDbCommand(struser, con);
            cmd.Parameters.Add("?", OleDbType.VarWChar, 3).Value = answer;


            con.Open();
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string ans = null;
                ans = reader["canpack"].ToString();
                switch (job)
                {

                    case "pack":
                        {
                            if (reader["canpack"].ToString() == "False")
                            {
                                msgbox mb = new msgbox(reader["userfirstname"].ToString() + " is not registered to Pack." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                con.Close();
                                return 0;
                            }
                            break;
                        }

                    case "check":
                        {
                            if (reader["cancheck"].ToString() == "False")
                            {
                                msgbox mb = new msgbox(reader["userfirstname"].ToString() + " is not registered to Check." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                con.Close();
                                return 0;
                            }
                            break;
                        }

                    case "collect":
                        {
                            if (reader["cancollect"].ToString() == "False")
                            {
                                msgbox mb = new msgbox(reader["userfirstname"].ToString() + " is not registered to give out packs." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                con.Close();
                                return 0;
                            }
                            break;
                        }

                    case "admin":
                        {
                            if (reader["admin"].ToString() == "False")
                            {
                                msgbox mb = new msgbox(reader["userfirstname"].ToString() + " is not registered as an Administrator." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                con.Close();
                                return 0;
                            }
                            break;
                        }

                    case "repack":
                        {
                            if (reader["canrequestrepack"].ToString() == "False")
                            {
                                msgbox mb = new msgbox(reader["userfirstname"].ToString() + " is not registered to authorised to do this." + Environment.NewLine + Environment.NewLine + "Check job allocation", "Need Permission");
                                mb.ShowDialog();
                                con.Close();
                                return 0;

                            }

                            break;
                        }
                    default:
                        con.Close();
                        return 0;

                }

                User.curuserid = reader["userid"].ToString();
                User.curuserlogin = reader["userlogin"].ToString();
                User.curusername = reader["userfirstname"].ToString();
                reader.Close();
                return 1;

            }
            else
            {
                msgbox msgbox = new msgbox("That is not a valid user", "No user");
                msgbox.ShowDialog();
                con.Close();
                return 0;
            }



        }

       
    }
}
