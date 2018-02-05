using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackChecker
{
    public partial class datepicker : Form
    {
        
        string warn;
        public datepicker(string question, string title,string monwarning,DateTime currentdate)
        {
            InitializeComponent();
            lblquestion.Text = question;
            Text = title;
            warn = monwarning;
            dateTimePicker.Value = currentdate;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
        public DateTime ourdate;
        public DateTime theirdate;
        private void btnok_Click(object sender, EventArgs e)
        {

            //check if they want a monday
            if (warn == "1")
            {
               // var dtp = sender as DateTimePicker;
                var selectedDate = dateTimePicker.Value;
                theirdate = selectedDate;
                ourdate = dateTimePicker.Value;
                if (selectedDate.DayOfWeek != DayOfWeek.Monday)
                {
                    var offset = (int)(selectedDate.DayOfWeek + 6)%7 *-1;
                    var monday = selectedDate + TimeSpan.FromDays(offset);
                    dateTimePicker.Value = monday;
                    ourdate = dateTimePicker.Value;
                    using (yesnobox mb = new yesnobox("That isn't a Monday, Would you like to start from " + monday.ToShortDateString() + " instead?", "Date Check"))
                    {
                        if (mb.ShowDialog() == DialogResult.Yes)
                        {
                            theirdate = ourdate;
                        }

                    }


                }

            }

            if (warn == "2")
            {
                //Force Monday to be used
                var selectedDate = dateTimePicker.Value;
                theirdate = selectedDate;
                ourdate = dateTimePicker.Value;
                if (selectedDate.DayOfWeek != DayOfWeek.Monday)
                {
                    var offset = (int)(selectedDate.DayOfWeek + 6) % 7 * -1;
                    var monday = selectedDate + TimeSpan.FromDays(offset);
                    dateTimePicker.Value = monday;
                    ourdate = dateTimePicker.Value;
                    
                   theirdate = ourdate;
                    


                }
            }
            
            //Let them use non monday
            if(warn != "1" && warn != "2")
            {
                ourdate = dateTimePicker.Value;
                theirdate = ourdate;
            }
            
        }

        private void lblquestion_Click(object sender, EventArgs e)
        {

        }

        private void datepicker_Paint(object sender, PaintEventArgs e)
        {
            var borderColor = Color.FromArgb(0, 59, 76);
            var borderStyle = ButtonBorderStyle.Solid;
            var borderWidth = 3;
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle,
                    borderColor,
                    borderWidth,
                    borderStyle);
        }
    }
}
