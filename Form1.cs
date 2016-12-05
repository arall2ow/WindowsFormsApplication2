using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void kum_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();                                            //ปุ่มสั่งให้ปิดโปรแกรม 
        }

        private void tun_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void pon_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Button1kilo.Checked)                          //วิ่งเข้าเงื่อนไขแรกเมื่อติ๊กที่ กิโลกรัม 
            {
                double i = double.Parse(num.Text);            //รับค่าและแปลงเป็น double

                dataGridView1.ColumnCount = 3;                //จำนวนแถวใน dataGridView
                dataGridView1.Columns[0].Name = "กรัม";        //ชื่อแถวแรก
                dataGridView1.Columns[1].Name = "ตัน";         //ชื่อแถวสอง
                dataGridView1.Columns[2].Name = "ปอนด์";       //ชื่อแถวสาม

                string[] row = new string[] { (i * 1000).ToString(), (i / 1000).ToString(), (i * 2.2046).ToString() };  //แสดงผลลงใน dataGridView แต่ละช่อง
                dataGridView1.Rows.Add(row);                  //คำสั่งเขียนข้อมูลลงใน dataGridView
            }
            if (radioButton2.Checked)                           //วิ่งเข้าเงื่อนไขเมื่อติ๊กที่ กรัม 
            {
                double i = double.Parse(num.Text);              //รับค่าและแปลงเป็น double

                dataGridView1.ColumnCount = 3;                //จำนวนแถวใน dataGridView
                dataGridView1.Columns[0].Name = "กิโลกรัม";       //ชื่อแถวแรก
                dataGridView1.Columns[1].Name = "ตัน";           //ชื่อแถวสอง
                dataGridView1.Columns[2].Name = "ปอนด์";         //ชื่อแถวสาม

                string[] row = new string[] { (i / 1000).ToString(), (i / 1000000).ToString(), (i * 0.0022046).ToString() }; //แสดงผลลงใน dataGridView แต่ละช่อง
                dataGridView1.Rows.Add(row);                    //คำสั่งเขียนข้อมูลลงใน dataGridView
            }
            if (radioButton3.Checked)                           //วิ่งเข้าเงื่อนไขเมื่อติ๊กที่ ตัน
            {
                double i = double.Parse(num.Text);              //รับค่าและแปลงเป็น double

                dataGridView1.ColumnCount = 3;                  //จำนวนแถวใน dataGridView
                dataGridView1.Columns[0].Name = "กิโลกรัม";       //ชื่อแถวแรก
                dataGridView1.Columns[1].Name = "กรัม";          //ชื่อแถวสอง
                dataGridView1.Columns[2].Name = "ปอนด์";         //ชื่อแถวสาม

                string[] row = new string[] { (i * 1000).ToString(), (i * 1000000).ToString(), (i * 2204.6).ToString() }; //แสดงผลลงใน dataGridView แต่ละช่อง
                dataGridView1.Rows.Add(row);                    //คำสั่งเขียนข้อมูลลงใน dataGridView
            }
            if (radioButton4.Checked)                           //วิ่งเข้าเงื่อนไขเมื่อติ๊กที่ ปอนด์
            {
                double i = double.Parse(num.Text);              //รับค่าและแปลงเป็น double

                dataGridView1.ColumnCount = 3;                  //จำนวนแถวใน dataGridView
                dataGridView1.Columns[0].Name = "กิโลกรัม";        //ชื่อแถวแรก
                dataGridView1.Columns[1].Name = "กรัม";          //ชื่อแถวสอง
                dataGridView1.Columns[2].Name = "ตัน";           //ชื่อแถวสาม


                string[] row = new string[] { (i * 0.453592).ToString(), (i * 453.59237).ToString(), (i * 0.000454).ToString() }; //แสดงผลลงใน dataGridView แต่ละช่อง
                dataGridView1.Rows.Add(row);                    //คำสั่งเขียนข้อมูลลงใน dataGridView
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)   //ดักการใส่ตัวอักษรลงในช่องรับค่า 
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')                     //เงื่อนไข สามารถใส่ได้แค่เลข 0-9
            {
                if (e.KeyChar != (char)1)
                {
                    MessageBox.Show("กรุณากรอกเฉพาะตัวเลข");                //ผิดเงื่อนไขจะแสดง MessageBox
                    e.KeyChar = (char)0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();                                 //ล้างข้อมูลใน dataGridView1
        }
    }
}
