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

            MYSQLConn test = new MYSQLConn();
            List<MonsterInfo> testList = test.getMonsterData();
            foreach (MonsterInfo testListItem in testList)
            {
                monsterList.Items.Add(testListItem.monsterName);
            }
        }

        private void btn_viewSelectedMonster_Click(object sender, EventArgs e)
        {
            foreach (object currentMonster in monsterList.CheckedItems)
            {
                makeNewDetailedWindow(monsterList.GetItemText(currentMonster));
            }
        }

        private void Button_genMonster_Click(object sender, EventArgs e)
        {
            MYSQLConn sql = new MYSQLConn();
            List<MonsterAttributes> theMonsters = sql.getConditionalMonsterAttributes(txtAverageCR.Text, txtPartyPopulation.Text, txtDesiredNumMonsters.Text, txtDesiredType.Text, txtDesiredSize.Text);
            if (theMonsters.Count == 0)
            {
                MessageBox.Show("Your generation parameters provided no results. Please revise your search parameters and try again!");
            }
            else
            {
                int counter = 0;
                Random randlekins = new Random();
                if (txtDesiredNumMonsters.Text != "")
                {
                    while (counter < Convert.ToInt32(txtDesiredNumMonsters.Text))
                    {
                        int nextOne = randlekins.Next() % theMonsters.Count;
                        makeNewDetailedWindow(theMonsters[nextOne].monsterName);
                        counter++;
                    }
                }
                else
                {
                    makeNewDetailedWindow(theMonsters[0].monsterName);
                }
            }
        }

        private void makeNewDetailedWindow(string monsterName)
        {
            Form Monsters = new MonsterSelect();
            Control[] Name = Monsters.Controls.Find("MonsterSelect_NameText", true);
            Control[] BAB = Monsters.Controls.Find("MonsterSelect_BABText", true);
            Control[] InitMod = Monsters.Controls.Find("MonsterSelect_InitModText", true);
            Control[] DamageDice = Monsters.Controls.Find("MonsterSelect_DamageDiceText", true);
            Control[] NumHD = Monsters.Controls.Find("MonsterSelect_NumHDText", true);
            Control[] HealthDice = Monsters.Controls.Find("MonsterSelect_HealthDiceText", true);
            Control[] pictureBox = Monsters.Controls.Find("MonsterSelect_PictureBox", true);

            TextBox NameText = (TextBox)Name[0];
            TextBox BABText = (TextBox)BAB[0];
            TextBox InitModText = (TextBox)InitMod[0];
            TextBox DamageDiceText = (TextBox)DamageDice[0];
            TextBox NumHDText = (TextBox)NumHD[0];
            TextBox HealthDiceText = (TextBox)HealthDice[0];
            PictureBox pictureBoxItem = (PictureBox)pictureBox[0];

            //Get the info for each monster and load it into a new popup
            MYSQLConn sqlConnection = new MYSQLConn();
            List<MonsterAttributes> attributes = sqlConnection.getMonsterAttributes(monsterName);

            NameText.Text = attributes[0].monsterName.ToString();
            Monsters.Text = attributes[0].monsterName.ToString(); // change window  title //
            BABText.Text = attributes[0].BAB.ToString();
            InitModText.Text = attributes[0].InitMod.ToString();
            DamageDiceText.Text = attributes[0].DamageDice.ToString();
            NumHDText.Text = attributes[0].NumHD.ToString();
            HealthDiceText.Text = attributes[0].HealthDice.ToString();
            pictureBoxItem.ImageLocation = attributes[0].pictureLoc.ToString();

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
            if (MessageBox.Show("Are you sure that you want to close the monster generator?", "Close Application?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
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
            picPortait.ImageLocation = sql.getMonsterImage(selectedMonster.monsterName.ToString());
        }

        private int rollDice(int numDice, int diceNum)
        {
            int result = 0;

            Random randy = new Random();
            for (int i = 0; i < numDice; i++)
            {
                int mod = (randy.Next() % diceNum) +1;
                result += mod;
            }

            return result;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumd4.Text), 4);
                txtD4Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumd6.Text), 6);
                txtD6Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumd8.Text), 8);
                txtD8Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumd20.Text), 20);
                txtD20Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }

        private void btnD100_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumd100.Text), 100);
                txtD100Result.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }

        private void btnDUser_Click(object sender, EventArgs e)
        {
            try
            {
                int result = rollDice(Convert.ToInt32(txtNumdUser.Text), Convert.ToInt32(txtDUserNum.Text));
                txtDUserResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a number of dice to roll!");
            }
        }
    }
}
