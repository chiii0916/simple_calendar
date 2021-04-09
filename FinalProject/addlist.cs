using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    
    public partial class addlist : Form
    {
        public string[,,]listcontent = new String[100,12,31];
        public int year, month, day;
        public addlist()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            year = dateTimePicker1.Value.Year-1970;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
            listcontent[year, month, day] += rtblist.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
