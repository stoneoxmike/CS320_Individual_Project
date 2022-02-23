using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS320_Individual_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            ArrayList allClasses = new ArrayList();
            allClasses.Add(new Classes(textBoxName.Text, dateTimePickerFrom.Value.Hour, dateTimePickerTo.Value.Hour, dateTimePickerFrom.Value.Minute, dateTimePickerTo.Value.Minute, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked));
            textBoxName.Clear();
        }

        private void buttonMeetingTime_Click(object sender, EventArgs e)
        {
           
        }
    }
}
