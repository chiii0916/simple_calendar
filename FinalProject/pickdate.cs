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
    public partial class pickdate : Form
    {
        public int year, month, day;
        public pickdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            year = dateTimePicker1.Value.Year-1970;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;
            this.Close();
        }
    }
}
