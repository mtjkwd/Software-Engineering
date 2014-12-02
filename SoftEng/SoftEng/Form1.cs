using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftEng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form Monsters = new MonsterSelect();
            Control[] BAB = Monsters.Controls.Find("MonsterSelect_BABText", true);
            Control[] InitMod = Monsters.Controls.Find("MonsterSelect_InitModText", true);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Occurs when the user wants to close the form, but not done yet //
            // Show dialog asking the user if they are sure //
            if (MessageBox.Show("Are you sure that you want to close?  All data will be lost.", "Close Application?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Gets the monster's picture -- TEST CODE MJ 12.1.14 //
            //MYSQLConn test = new MYSQLConn();
            //List<MonsterAttributes> testList = test.getMonsterAttributes("Assassin Vine");
            //foreach (MonsterAttributes testListItem in testList)
            //{
            //    pictureBox1.Image = testListItem.image;
            //}
            //pictureBox1.Image = System.Drawing.Image.FromFile("./IMG_1110.JPG");
        }

        private void Button_populateMonsters_Click(object sender, EventArgs e)
        {
            // For populating monster name dropdown checkbox list //
            // Test click code for the box, see if the data source works //
            MYSQLConn test = new MYSQLConn();
            List<MonsterInfo> testList = test.getMonsterData();
            foreach (MonsterInfo testListItem in testList)
            {
                checkedListBox1.Items.Add(testListItem.monsterName);
            }
        }

        
    }
}
