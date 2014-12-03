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
    public partial class MonsterGen : Form
    {
        public MonsterGen()
        {
            InitializeComponent();
        }

        private void btn_viewSelectedMonster_Click(object sender, EventArgs e)
        {
            //this.Close();
            Form Monsters = new MonsterSelect();
            Control[] Name = Monsters.Controls.Find("MonsterSelect_NameText", true);
            Control[] BAB = Monsters.Controls.Find("MonsterSelect_BABText", true);
            Control[] InitMod = Monsters.Controls.Find("MonsterSelect_InitModText", true);
            Control[] DamageDice = Monsters.Controls.Find("MonsterSelect_DamageDiceText", true);
            Control[] NumHD = Monsters.Controls.Find("MonsterSelect_NumHDText", true);
            Control[] HealthDice = Monsters.Controls.Find("MonsterSelect_HealthDiceText", true);

            TextBox NameText = (TextBox)Name[0];
            TextBox BABText = (TextBox)BAB[0];
            TextBox InitModText = (TextBox)InitMod[0];
            TextBox DamageDiceText = (TextBox)DamageDice[0];
            TextBox NumHDText = (TextBox)NumHD[0];
            TextBox HealthDiceText = (TextBox)HealthDice[0];

            // Test code for one monster, in future get value from check boxes control in form1 //
            MYSQLConn sqlConnection = new MYSQLConn();
            List<MonsterAttributes> attributes = sqlConnection.getMonsterAttributes("Barghest");

            NameText.Text = attributes[0].monsterName.ToString();
            BABText.Text = attributes[0].BAB.ToString();
            InitModText.Text = attributes[0].InitMod.ToString();
            DamageDiceText.Text = attributes[0].DamageDice.ToString();
            NumHDText.Text = attributes[0].NumHD.ToString();
            HealthDiceText.Text = attributes[0].HealthDice.ToString();

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

        private void Button_genMonster_Click(object sender, EventArgs e)
        {
            MYSQLConn test = new MYSQLConn();
            List<MonsterInfo> testList = test.getMonsterData();
            foreach (MonsterInfo testListItem in testList)
            {
                monsterList.Items.Add(testListItem.monsterName);
            }
        }

        private void monsterList_Click(object sender, EventArgs e)
        {
            // Populate the 'preview' box with the picture, monster data, etc for the preview //
            MYSQLConn sql = new MYSQLConn();
            CheckedListBox CheckBoxList = (CheckedListBox)sender;
            List<MonsterInfo> selectedMonsters = sql.getMonsterData(CheckBoxList.SelectedItems[0].ToString());
            MonsterInfo selectedMonster = selectedMonsters[0];

            txtName.Text = selectedMonster.monsterName.ToString();
            txtChallengeRating.Text = selectedMonster.challengeRating.ToString();
            txtHealth.Text = selectedMonster.monsterHealth.ToString();
            txtSize.Text = selectedMonster.monsterSize.ToString();
            txtType.Text = selectedMonster.monsterType.ToString();
        }

        
    }
}
