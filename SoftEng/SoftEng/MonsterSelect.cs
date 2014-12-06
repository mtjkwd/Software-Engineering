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
    public partial class MonsterSelect : Form
    {
        public MonsterSelect()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MonsterSelect_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonsterSelect_Edit_Click(object sender, EventArgs e)
        {
            // When the user clicks the Edit Monster button, this code fires to unhide stuff //
            if (MonsterSelect_Edit.Text == "Edit Monster")
            {
                MonsterSelect_NameText.ReadOnly = false;
                MonsterSelect_BABText.ReadOnly = false;
                MonsterSelect_InitModText.ReadOnly = false;
                MonsterSelect_DamageDiceText.ReadOnly = false;
                MonsterSelect_NumHDText.ReadOnly = false;
                MonsterSelect_HealthDiceText.ReadOnly = false;
                MonsterSelect_Edit.Text = "Save Changes";
            }
            else if (MonsterSelect_Edit.Text == "Save Changes")
            {
                MonsterSelect_NameText.ReadOnly = true;
                MonsterSelect_BABText.ReadOnly = true;
                MonsterSelect_InitModText.ReadOnly = true;
                MonsterSelect_DamageDiceText.ReadOnly = true;
                MonsterSelect_NumHDText.ReadOnly = true;
                MonsterSelect_HealthDiceText.ReadOnly = true;
                MonsterSelect_Edit.Text = "Edit Monster";
            }
        }

    }
}
