using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;





namespace PackChecker
{

    public partial class frmpatientlist : Form
    {

        OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);

        public frmpatientlist()
        {

            InitializeComponent();


        }

        private void frmpatientlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpacklocation' table. You can move, or remove it, as needed.
            this.tblpacklocationTableAdapter.Fill(this.websterdbDataSet.tblpacklocation);
            // TODO: This line of code loads data into the 'websterdbDataSet.tblpacksize' table. You can move, or remove it, as needed.
            this.tblpacksizeTableAdapter.Fill(this.websterdbDataSet.tblpacksize);
            // TODO: This line of code loads data into the 'websterdbDataSet.tblcycle' table. You can move, or remove it, as needed.
            this.tblcycleTableAdapter.Fill(this.websterdbDataSet.tblcycle);

            string strpx = @"SELECT * FROM tblpatient";

            OleDbDataAdapter dataadapter = new OleDbDataAdapter(strpx, con);

            con.Open();

            DataSet ds = new DataSet();
            //con.Open();
            dataadapter.Fill(ds, "tableData");
            con.Close();
            dataGridpatients.AutoGenerateColumns = false;




            //ALLOCATE COLUMNS TO DATA
            clnpxid.DataPropertyName = "patientid";

            clnlastname.DataPropertyName = "pxlastname";

            clnfirstname.DataPropertyName = "pxfirstname";

            clnpacksize.DataPropertyName = "traysize";

            clncycletype.DataPropertyName = "cycleid";

            clnlocation1.DataPropertyName = "packlocation";

            clnlocation2.DataPropertyName = "secondarypacklocation";

            clnpxcomment.DataPropertyName = "comment";

            clndelivery.DataPropertyName = "delivery";

            clnactive.DataPropertyName = "active";

            clnsigningsheet.DataPropertyName = "signingsheet";

            dataGridpatients.DataSource = ds;
            dataGridpatients.DataMember = "tableData";

            //foreach (DataGridViewRow row in dataGridPacked.Rows)
            //{
            //    if (row.Cells["clnPackComment"].Value.ToString() != "")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.LightBlue;
            //    }
            //}
            foreach (DataGridViewRow row in dataGridpatients.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells["clnlocation2"].Value.ToString()))
                {
                    
                    row.Cells["clnclear"].Style.Padding = new Padding(100, 0, 0, 0);
                }
                else
                {
                    row.Cells["clnclear"].Style.Padding = new Padding(0, 0, 0, 0);

                }
            }


        }




        private void dataGridPacked_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            {

                DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                MessageBox.Show(row.Cells["clnlocation1"].Value.ToString());

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here

                    if (e.RowIndex >= 0)
                    {
                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

                        //IF we are in the Column PACKCOMMENT, do this
                        if (col.Name.Equals("clnPackComment"))
                        {


                            //DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                            string packid = row.Cells["packid"].Value.ToString();
                            string cellvalue = row.Cells["clnPackComment"].Value.ToString();
                            //string input = Interaction.InputBox("Enter new message here", "Pack Comment", cellvalue, -1, -1);
                            inputbox inputbox = new inputbox("Enter new message here", "Pack Comment", cellvalue);
                            string answer = null;
                            if (inputbox.ShowDialog() == DialogResult.OK)
                            {
                                //MessageBox.Show(inputbox.answer);
                                answer = inputbox.answer;

                            }
                            else
                            {
                                return;
                            }


                            string strpcom = "UPDATE tblpack SET packcomment = ? WHERE packid= ?";

                            OleDbCommand sqlcom = new OleDbCommand(strpcom, con);

                            OleDbDataAdapter dadapter = new OleDbDataAdapter();

                            string userbrack = null;

                            if (!string.IsNullOrWhiteSpace(answer))
                            {
                                userbrack = " (" + User.curuserlogin + ")";
                            }

                            sqlcom.Parameters.Add("?", OleDbType.VarWChar, 30).Value = answer + userbrack;
                            sqlcom.Parameters.Add("?", OleDbType.Integer, 5).Value = packid;

                            dadapter.SelectCommand = sqlcom;

                            con.Open();

                            sqlcom.ExecuteNonQuery();
                            row.Cells["clnPackComment"].Value = answer;
                            con.Close();

                        }



                    }
                }
            }

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //
            //
            string strup = @"UPDATE tblpatient SET tblpatient.pxfirstname = ?, tblpatient.pxlastname = ?,tblpatient.cycleid = ?,
                                tblpatient.comment = ?, tblpatient.traysize = ?,tblpatient.packlocation = ?, tblpatient.secondarypacklocation = ?,
                                tblpatient.active = ?, tblpatient.delivery = ?, tblpatient.signingsheet = ? WHERE patientid = ?";





            OleDbDataAdapter dataadapter = new OleDbDataAdapter();
            OleDbCommand sqlcom2 = new OleDbCommand(strup, con);

            con.Open();
            foreach (DataGridViewRow row in dataGridpatients.Rows)
            {

                //int n;
                //var loc2 = 0;
                //var result = int.TryParse(row.Cells["clnlocation2"].Value.ToString(), out n);
                //    if (result)
                //{
                //    return;
                //}
                //else
                //{
                //    loc2 = DBNull.Value;
                //}
                
                
               
                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnfirstname"].Value.ToString();
                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnlastname"].Value.ToString();
                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clncycletype"].Value;
                sqlcom2.Parameters.Add("?", OleDbType.VarWChar).Value = row.Cells["clnpxcomment"].Value.ToString();
                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnpacksize"].Value;
                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnlocation1"].Value;
                if (string.IsNullOrWhiteSpace(row.Cells["clnlocation2"].Value.ToString()))
                {
                    sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = DBNull.Value;
                }
                else
                {
                    sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnlocation2"].Value;
                }
                
                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["clnactive"].Value;
                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["clndelivery"].Value;
                sqlcom2.Parameters.Add("?", OleDbType.Boolean).Value = row.Cells["clnsigningsheet"].Value;
                sqlcom2.Parameters.Add("?", OleDbType.Integer).Value = row.Cells["clnpxid"].Value;
                dataadapter.SelectCommand = sqlcom2;



                sqlcom2.ExecuteNonQuery();
                sqlcom2.Parameters.Clear();
            }
            con.Close();
            

            this.Dispose();
        }



        private void dataGridpatients_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            {
                bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
                var datagridview = sender as DataGridView;

                // Check to make sure the cell clicked is the cell containing the combobox 
                if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
                {
                    datagridview.BeginEdit(true);
                    ((ComboBox)datagridview.EditingControl).DroppedDown = true;
                }
            }
        }

        private void tblcycleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tblcycleTableAdapter.FillBy(this.websterdbDataSet.tblcycle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridpatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (e.RowIndex >= 0)
                    {

                        //Figure out which button we jsut pressed
                        DataGridViewColumn col = this.dataGridpatients.Columns[e.ColumnIndex];

                        //IF we are in the Column pack, do this
                        if (col.Name.Equals("clnclear"))
                        {
                            DataGridViewRow row = this.dataGridpatients.Rows[e.RowIndex];
                            
                            row.Cells["clnlocation2"].Value = DBNull.Value;
                            row.Cells["clnclear"].Style.Padding = new Padding(100, 0, 0, 0);
                            
                        
                        }
                    }
                
            }
            }
       

    }
}
