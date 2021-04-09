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
    
    public partial class SimpleCalender : Form
    {
        string [,,]dailylist=new String[100,12,31];
        int year, month, day;
        public SimpleCalender()
        {
            InitializeComponent();
        }

        private void MoreDate_Click(object sender, EventArgs e)
        {
            pickdate pickdate1 = new pickdate();
            //pickdate1.Show();
            if(pickdate1.ShowDialog()==DialogResult.OK)
            {
                year = pickdate1.year;
                month = pickdate1.month;
                day = pickdate1.day;
                //ToDoList.Text = dailylist[year, month, day];
                DateTime DT2 = new DateTime(year+1970,month,day);
                TheDate.Text = DT2.ToString("d");
                //dailylist[0, 0, 0] = "Ok";
                if(dailylist[year,month,day]=="")
                {
                    ToDoList.Text = "今日尚無記事";
                }
                else
                {
                    ToDoList.Text = dailylist[year, month, day];
                }
                

                
            }
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            FontDialog flg = new FontDialog();
            flg.Font = ToDoList.Font;
            if(flg.ShowDialog()==DialogResult.OK)
            {
                ToDoList.Font = flg.Font;
            }
        }

        private void btnfontcolor_Click(object sender, EventArgs e)
        {
            ColorDialog clg = new ColorDialog();
            clg.FullOpen = true;
            clg.Color = ToDoList.ForeColor;
            if(clg.ShowDialog()==DialogResult.OK)
            {
                ToDoList.ForeColor = clg.Color;
            }
        }

        /*private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(month==2)
            day -= 1;
            DateTime DT4 = new DateTime(year+1970,month,day);
            TheDate.Text = DT4.ToString("d");
            ToDoList.Text = dailylist[year, month, day];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            year += 1;
            month += 1;
            day += 1;
            DateTime DT4 = new DateTime(year+1970, month, day);
            TheDate.Text = DT4.ToString("d");
            ToDoList.Text = dailylist[year, month, day];
        }*/

        private void SimpleCalender_Load(object sender, EventArgs e)
        {
            DateTime DT1 = DateTime.Now;
            TheDate.Text = DT1.ToString("d");
            year = DT1.Year-1970;
            month = DT1.Month;
            day = DT1.Day;
            ToDoList.Text = dailylist[DT1.Year-1970, DT1.Month, DT1.Day];
            if(ToDoList.Text=="")
            {
                ToDoList.Text = "今日尚無記事";
            }
        }
        
        private void AddMoreList_Click(object sender, EventArgs e)
        {
            addlist addlist1 = new addlist();
            addlist1.Owner = this;
            DateTime DT3 = DateTime.Now;
            //addlist1.Show();
            if(addlist1.ShowDialog()==DialogResult.OK)
            {
                year = addlist1.year;
                month = addlist1.month;
                day = addlist1.day;
                
                if (dailylist[year, month, day] == "今日尚無記事")
                {
                    dailylist[year, month, day] = addlist1.listcontent[year, month, day]+"\r\n";
                }
                else
                {
                    dailylist[year, month, day] += addlist1.listcontent[year, month, day]+"\r\n";
                }
                if (year+1970 == DT3.Year && month == DT3.Month && day == DT3.Day)
                {
                    ToDoList.Text = dailylist[year, month, day];
                }
                
            }
        }
    }
}
