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
            Monsters.Show();
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

        private void checkedListBox1_Click(object sender, EventArgs e)
        {
            // Test click code for the box, see if the data source works //
            MYSQLConn test = new MYSQLConn();
            List<MonsterInfo> testList = test.getMonsterData();
            foreach (MonsterInfo testListItem in testList)
            {
                checkedListBox1.Items.Add(testListItem.monsterType);
            }
        }

        
    }
}
