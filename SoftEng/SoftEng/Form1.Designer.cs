namespace SoftEng
{
    partial class MonsterGen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_ViewMonster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monsterList = new System.Windows.Forms.CheckedListBox();
            this.Button_genMonster = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ListLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picPortait = new System.Windows.Forms.PictureBox();
            this.lblPortrait = new System.Windows.Forms.Label();
            this.lbHealth = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.lblChallengeRating = new System.Windows.Forms.Label();
            this.txtChallengeRating = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblParameters = new System.Windows.Forms.Label();
            this.lblAverageCR = new System.Windows.Forms.Label();
            this.txtAverageCR = new System.Windows.Forms.TextBox();
            this.lblPartyPop = new System.Windows.Forms.Label();
            this.txtPartyPopulation = new System.Windows.Forms.TextBox();
            this.lblNumMonstersWanted = new System.Windows.Forms.Label();
            this.txtDesiredNumMonsters = new System.Windows.Forms.TextBox();
            this.lblTypeWanted = new System.Windows.Forms.Label();
            this.txtDesiredType = new System.Windows.Forms.TextBox();
            this.lblDesiredSize = new System.Windows.Forms.Label();
            this.txtDesiredSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumd4 = new System.Windows.Forms.TextBox();
            this.lblDiceRoller = new System.Windows.Forms.Label();
            this.txtNumd6 = new System.Windows.Forms.TextBox();
            this.txtNumd8 = new System.Windows.Forms.TextBox();
            this.txtNumd20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtD4Result = new System.Windows.Forms.TextBox();
            this.txtD6Result = new System.Windows.Forms.TextBox();
            this.txtD8Result = new System.Windows.Forms.TextBox();
            this.txtD20Result = new System.Windows.Forms.TextBox();
            this.btnD4 = new System.Windows.Forms.Button();
            this.btnD6 = new System.Windows.Forms.Button();
            this.btnD8 = new System.Windows.Forms.Button();
            this.btnD20 = new System.Windows.Forms.Button();
            this.btnD100 = new System.Windows.Forms.Button();
            this.txtD100Result = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumd100 = new System.Windows.Forms.TextBox();
            this.btnDUser = new System.Windows.Forms.Button();
            this.txtDUserNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumdUser = new System.Windows.Forms.TextBox();
            this.txtDUserResult = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPortait)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ViewMonster
            // 
            this.Button_ViewMonster.Location = new System.Drawing.Point(267, 418);
            this.Button_ViewMonster.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ViewMonster.Name = "Button_ViewMonster";
            this.Button_ViewMonster.Size = new System.Drawing.Size(243, 28);
            this.Button_ViewMonster.TabIndex = 0;
            this.Button_ViewMonster.Text = "View Selected Monster(s)";
            this.Button_ViewMonster.UseVisualStyleBackColor = true;
            this.Button_ViewMonster.Click += new System.EventHandler(this.btn_viewSelectedMonster_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monsterList
            // 
            this.monsterList.FormattingEnabled = true;
            this.monsterList.Location = new System.Drawing.Point(267, 30);
            this.monsterList.Margin = new System.Windows.Forms.Padding(4);
            this.monsterList.Name = "monsterList";
            this.monsterList.Size = new System.Drawing.Size(243, 378);
            this.monsterList.TabIndex = 2;
            this.monsterList.Click += new System.EventHandler(this.monsterList_Click);
            // 
            // Button_genMonster
            // 
            this.Button_genMonster.Location = new System.Drawing.Point(13, 173);
            this.Button_genMonster.Margin = new System.Windows.Forms.Padding(4);
            this.Button_genMonster.Name = "Button_genMonster";
            this.Button_genMonster.Size = new System.Drawing.Size(246, 28);
            this.Button_genMonster.TabIndex = 5;
            this.Button_genMonster.Text = "Generate Random Monster";
            this.Button_genMonster.UseVisualStyleBackColor = true;
            this.Button_genMonster.Click += new System.EventHandler(this.Button_genMonster_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(585, 30);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(161, 22);
            this.txtName.TabIndex = 6;
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(309, 9);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(146, 17);
            this.ListLabel.TabIndex = 8;
            this.ListLabel.Text = "All Available Monsters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Basic Monster Data";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(531, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // picPortait
            // 
            this.picPortait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortait.Location = new System.Drawing.Point(533, 75);
            this.picPortait.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPortait.Name = "picPortait";
            this.picPortait.Size = new System.Drawing.Size(214, 214);
            this.picPortait.TabIndex = 11;
            this.picPortait.TabStop = false;
            // 
            // lblPortrait
            // 
            this.lblPortrait.AutoSize = true;
            this.lblPortrait.Location = new System.Drawing.Point(531, 55);
            this.lblPortrait.Name = "lblPortrait";
            this.lblPortrait.Size = new System.Drawing.Size(58, 17);
            this.lblPortrait.TabIndex = 12;
            this.lblPortrait.Text = "Portrait:";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(531, 326);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(85, 17);
            this.lbHealth.TabIndex = 14;
            this.lbHealth.Text = "Health Dice:";
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(621, 322);
            this.txtHealth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.ReadOnly = true;
            this.txtHealth.Size = new System.Drawing.Size(127, 22);
            this.txtHealth.TabIndex = 13;
            // 
            // lblChallengeRating
            // 
            this.lblChallengeRating.AutoSize = true;
            this.lblChallengeRating.Location = new System.Drawing.Point(531, 298);
            this.lblChallengeRating.Name = "lblChallengeRating";
            this.lblChallengeRating.Size = new System.Drawing.Size(120, 17);
            this.lblChallengeRating.TabIndex = 16;
            this.lblChallengeRating.Text = "Challenge Rating:";
            // 
            // txtChallengeRating
            // 
            this.txtChallengeRating.Location = new System.Drawing.Point(656, 295);
            this.txtChallengeRating.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChallengeRating.Name = "txtChallengeRating";
            this.txtChallengeRating.ReadOnly = true;
            this.txtChallengeRating.Size = new System.Drawing.Size(91, 22);
            this.txtChallengeRating.TabIndex = 15;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(531, 354);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(77, 17);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "Size Class:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(613, 351);
            this.txtSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(135, 22);
            this.txtSize.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(531, 382);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(579, 379);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(169, 22);
            this.txtType.TabIndex = 19;
            // 
            // lblParameters
            // 
            this.lblParameters.AutoSize = true;
            this.lblParameters.Location = new System.Drawing.Point(50, 9);
            this.lblParameters.Name = "lblParameters";
            this.lblParameters.Size = new System.Drawing.Size(168, 17);
            this.lblParameters.TabIndex = 21;
            this.lblParameters.Text = "Randomness Parameters";
            // 
            // lblAverageCR
            // 
            this.lblAverageCR.AutoSize = true;
            this.lblAverageCR.Location = new System.Drawing.Point(10, 35);
            this.lblAverageCR.Name = "lblAverageCR";
            this.lblAverageCR.Size = new System.Drawing.Size(177, 17);
            this.lblAverageCR.TabIndex = 22;
            this.lblAverageCR.Text = "Average Challenge Rating:";
            // 
            // txtAverageCR
            // 
            this.txtAverageCR.Location = new System.Drawing.Point(193, 32);
            this.txtAverageCR.Name = "txtAverageCR";
            this.txtAverageCR.Size = new System.Drawing.Size(66, 22);
            this.txtAverageCR.TabIndex = 23;
            // 
            // lblPartyPop
            // 
            this.lblPartyPop.AutoSize = true;
            this.lblPartyPop.Location = new System.Drawing.Point(10, 63);
            this.lblPartyPop.Name = "lblPartyPop";
            this.lblPartyPop.Size = new System.Drawing.Size(116, 17);
            this.lblPartyPop.TabIndex = 24;
            this.lblPartyPop.Text = "Party Population:";
            // 
            // txtPartyPopulation
            // 
            this.txtPartyPopulation.Location = new System.Drawing.Point(133, 60);
            this.txtPartyPopulation.Name = "txtPartyPopulation";
            this.txtPartyPopulation.Size = new System.Drawing.Size(127, 22);
            this.txtPartyPopulation.TabIndex = 25;
            // 
            // lblNumMonstersWanted
            // 
            this.lblNumMonstersWanted.AutoSize = true;
            this.lblNumMonstersWanted.Location = new System.Drawing.Point(10, 91);
            this.lblNumMonstersWanted.Name = "lblNumMonstersWanted";
            this.lblNumMonstersWanted.Size = new System.Drawing.Size(193, 17);
            this.lblNumMonstersWanted.TabIndex = 26;
            this.lblNumMonstersWanted.Text = "Desired Number of Monsters:";
            // 
            // txtDesiredNumMonsters
            // 
            this.txtDesiredNumMonsters.Location = new System.Drawing.Point(209, 88);
            this.txtDesiredNumMonsters.Name = "txtDesiredNumMonsters";
            this.txtDesiredNumMonsters.Size = new System.Drawing.Size(50, 22);
            this.txtDesiredNumMonsters.TabIndex = 27;
            // 
            // lblTypeWanted
            // 
            this.lblTypeWanted.AutoSize = true;
            this.lblTypeWanted.Location = new System.Drawing.Point(10, 119);
            this.lblTypeWanted.Name = "lblTypeWanted";
            this.lblTypeWanted.Size = new System.Drawing.Size(99, 17);
            this.lblTypeWanted.TabIndex = 28;
            this.lblTypeWanted.Text = "Monster Type:";
            // 
            // txtDesiredType
            // 
            this.txtDesiredType.Location = new System.Drawing.Point(116, 116);
            this.txtDesiredType.Name = "txtDesiredType";
            this.txtDesiredType.Size = new System.Drawing.Size(143, 22);
            this.txtDesiredType.TabIndex = 29;
            // 
            // lblDesiredSize
            // 
            this.lblDesiredSize.AutoSize = true;
            this.lblDesiredSize.Location = new System.Drawing.Point(10, 147);
            this.lblDesiredSize.Name = "lblDesiredSize";
            this.lblDesiredSize.Size = new System.Drawing.Size(94, 17);
            this.lblDesiredSize.TabIndex = 30;
            this.lblDesiredSize.Text = "Monster Size:";
            // 
            // txtDesiredSize
            // 
            this.txtDesiredSize.Location = new System.Drawing.Point(110, 144);
            this.txtDesiredSize.Name = "txtDesiredSize";
            this.txtDesiredSize.Size = new System.Drawing.Size(150, 22);
            this.txtDesiredSize.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "-------------------------------------------------";
            // 
            // txtNumd4
            // 
            this.txtNumd4.Location = new System.Drawing.Point(15, 242);
            this.txtNumd4.Name = "txtNumd4";
            this.txtNumd4.Size = new System.Drawing.Size(25, 22);
            this.txtNumd4.TabIndex = 33;
            this.txtNumd4.Text = "1";
            // 
            // lblDiceRoller
            // 
            this.lblDiceRoller.AutoSize = true;
            this.lblDiceRoller.Location = new System.Drawing.Point(12, 222);
            this.lblDiceRoller.Name = "lblDiceRoller";
            this.lblDiceRoller.Size = new System.Drawing.Size(77, 17);
            this.lblDiceRoller.TabIndex = 34;
            this.lblDiceRoller.Text = "Dice Roller";
            // 
            // txtNumd6
            // 
            this.txtNumd6.Location = new System.Drawing.Point(15, 270);
            this.txtNumd6.Name = "txtNumd6";
            this.txtNumd6.Size = new System.Drawing.Size(25, 22);
            this.txtNumd6.TabIndex = 35;
            this.txtNumd6.Text = "1";
            // 
            // txtNumd8
            // 
            this.txtNumd8.Location = new System.Drawing.Point(15, 298);
            this.txtNumd8.Name = "txtNumd8";
            this.txtNumd8.Size = new System.Drawing.Size(25, 22);
            this.txtNumd8.TabIndex = 36;
            this.txtNumd8.Text = "1";
            // 
            // txtNumd20
            // 
            this.txtNumd20.Location = new System.Drawing.Point(15, 326);
            this.txtNumd20.Name = "txtNumd20";
            this.txtNumd20.Size = new System.Drawing.Size(25, 22);
            this.txtNumd20.TabIndex = 37;
            this.txtNumd20.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "D4:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "D6:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "D8:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 41;
            this.label6.Text = "D20:";
            // 
            // txtD4Result
            // 
            this.txtD4Result.Location = new System.Drawing.Point(82, 242);
            this.txtD4Result.Name = "txtD4Result";
            this.txtD4Result.ReadOnly = true;
            this.txtD4Result.Size = new System.Drawing.Size(100, 22);
            this.txtD4Result.TabIndex = 42;
            // 
            // txtD6Result
            // 
            this.txtD6Result.Location = new System.Drawing.Point(82, 270);
            this.txtD6Result.Name = "txtD6Result";
            this.txtD6Result.ReadOnly = true;
            this.txtD6Result.Size = new System.Drawing.Size(100, 22);
            this.txtD6Result.TabIndex = 43;
            // 
            // txtD8Result
            // 
            this.txtD8Result.Location = new System.Drawing.Point(82, 298);
            this.txtD8Result.Name = "txtD8Result";
            this.txtD8Result.ReadOnly = true;
            this.txtD8Result.Size = new System.Drawing.Size(100, 22);
            this.txtD8Result.TabIndex = 44;
            // 
            // txtD20Result
            // 
            this.txtD20Result.Location = new System.Drawing.Point(90, 326);
            this.txtD20Result.Name = "txtD20Result";
            this.txtD20Result.ReadOnly = true;
            this.txtD20Result.Size = new System.Drawing.Size(92, 22);
            this.txtD20Result.TabIndex = 45;
            // 
            // btnD4
            // 
            this.btnD4.Location = new System.Drawing.Point(188, 243);
            this.btnD4.Name = "btnD4";
            this.btnD4.Size = new System.Drawing.Size(75, 23);
            this.btnD4.TabIndex = 46;
            this.btnD4.Text = "Roll";
            this.btnD4.UseVisualStyleBackColor = true;
            this.btnD4.Click += new System.EventHandler(this.btnD4_Click);
            // 
            // btnD6
            // 
            this.btnD6.Location = new System.Drawing.Point(188, 270);
            this.btnD6.Name = "btnD6";
            this.btnD6.Size = new System.Drawing.Size(75, 23);
            this.btnD6.TabIndex = 47;
            this.btnD6.Text = "Roll";
            this.btnD6.UseVisualStyleBackColor = true;
            this.btnD6.Click += new System.EventHandler(this.btnD6_Click);
            // 
            // btnD8
            // 
            this.btnD8.Location = new System.Drawing.Point(188, 298);
            this.btnD8.Name = "btnD8";
            this.btnD8.Size = new System.Drawing.Size(75, 23);
            this.btnD8.TabIndex = 48;
            this.btnD8.Text = "Roll";
            this.btnD8.UseVisualStyleBackColor = true;
            this.btnD8.Click += new System.EventHandler(this.btnD8_Click);
            // 
            // btnD20
            // 
            this.btnD20.Location = new System.Drawing.Point(188, 326);
            this.btnD20.Name = "btnD20";
            this.btnD20.Size = new System.Drawing.Size(75, 23);
            this.btnD20.TabIndex = 49;
            this.btnD20.Text = "Roll";
            this.btnD20.UseVisualStyleBackColor = true;
            this.btnD20.Click += new System.EventHandler(this.btnD20_Click);
            // 
            // btnD100
            // 
            this.btnD100.Location = new System.Drawing.Point(188, 354);
            this.btnD100.Name = "btnD100";
            this.btnD100.Size = new System.Drawing.Size(75, 23);
            this.btnD100.TabIndex = 53;
            this.btnD100.Text = "Roll";
            this.btnD100.UseVisualStyleBackColor = true;
            this.btnD100.Click += new System.EventHandler(this.btnD100_Click);
            // 
            // txtD100Result
            // 
            this.txtD100Result.Location = new System.Drawing.Point(98, 354);
            this.txtD100Result.Name = "txtD100Result";
            this.txtD100Result.ReadOnly = true;
            this.txtD100Result.Size = new System.Drawing.Size(84, 22);
            this.txtD100Result.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "D100:";
            // 
            // txtNumd100
            // 
            this.txtNumd100.Location = new System.Drawing.Point(15, 354);
            this.txtNumd100.Name = "txtNumd100";
            this.txtNumd100.Size = new System.Drawing.Size(25, 22);
            this.txtNumd100.TabIndex = 50;
            this.txtNumd100.Text = "1";
            // 
            // btnDUser
            // 
            this.btnDUser.Location = new System.Drawing.Point(188, 399);
            this.btnDUser.Name = "btnDUser";
            this.btnDUser.Size = new System.Drawing.Size(75, 23);
            this.btnDUser.TabIndex = 57;
            this.btnDUser.Text = "Roll";
            this.btnDUser.UseVisualStyleBackColor = true;
            this.btnDUser.Click += new System.EventHandler(this.btnDUser_Click);
            // 
            // txtDUserNum
            // 
            this.txtDUserNum.Location = new System.Drawing.Point(62, 399);
            this.txtDUserNum.Name = "txtDUserNum";
            this.txtDUserNum.Size = new System.Drawing.Size(22, 22);
            this.txtDUserNum.TabIndex = 56;
            this.txtDUserNum.Text = "20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "D";
            // 
            // txtNumdUser
            // 
            this.txtNumdUser.Location = new System.Drawing.Point(15, 399);
            this.txtNumdUser.Name = "txtNumdUser";
            this.txtNumdUser.Size = new System.Drawing.Size(25, 22);
            this.txtNumdUser.TabIndex = 54;
            this.txtNumdUser.Text = "1";
            // 
            // txtDUserResult
            // 
            this.txtDUserResult.Location = new System.Drawing.Point(98, 399);
            this.txtDUserResult.Name = "txtDUserResult";
            this.txtDUserResult.ReadOnly = true;
            this.txtDUserResult.Size = new System.Drawing.Size(84, 22);
            this.txtDUserResult.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = ":";
            // 
            // MonsterGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDUserResult);
            this.Controls.Add(this.btnDUser);
            this.Controls.Add(this.txtDUserNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumdUser);
            this.Controls.Add(this.btnD100);
            this.Controls.Add(this.txtD100Result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumd100);
            this.Controls.Add(this.btnD20);
            this.Controls.Add(this.btnD8);
            this.Controls.Add(this.btnD6);
            this.Controls.Add(this.btnD4);
            this.Controls.Add(this.txtD20Result);
            this.Controls.Add(this.txtD8Result);
            this.Controls.Add(this.txtD6Result);
            this.Controls.Add(this.txtD4Result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumd20);
            this.Controls.Add(this.txtNumd8);
            this.Controls.Add(this.txtNumd6);
            this.Controls.Add(this.lblDiceRoller);
            this.Controls.Add(this.txtNumd4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesiredSize);
            this.Controls.Add(this.lblDesiredSize);
            this.Controls.Add(this.txtDesiredType);
            this.Controls.Add(this.lblTypeWanted);
            this.Controls.Add(this.txtDesiredNumMonsters);
            this.Controls.Add(this.lblNumMonstersWanted);
            this.Controls.Add(this.txtPartyPopulation);
            this.Controls.Add(this.lblPartyPop);
            this.Controls.Add(this.txtAverageCR);
            this.Controls.Add(this.lblAverageCR);
            this.Controls.Add(this.lblParameters);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblChallengeRating);
            this.Controls.Add(this.txtChallengeRating);
            this.Controls.Add(this.lbHealth);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lblPortrait);
            this.Controls.Add(this.picPortait);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Button_genMonster);
            this.Controls.Add(this.monsterList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_ViewMonster);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MonsterGen";
            this.Text = "Dungeons and Dragons Monster Generator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPortait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_ViewMonster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox monsterList;
        private System.Windows.Forms.Button Button_genMonster;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox picPortait;
        private System.Windows.Forms.Label lblPortrait;
        private System.Windows.Forms.Label lbHealth;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.Label lblChallengeRating;
        private System.Windows.Forms.TextBox txtChallengeRating;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblParameters;
        private System.Windows.Forms.Label lblAverageCR;
        private System.Windows.Forms.TextBox txtAverageCR;
        private System.Windows.Forms.Label lblPartyPop;
        private System.Windows.Forms.TextBox txtPartyPopulation;
        private System.Windows.Forms.Label lblNumMonstersWanted;
        private System.Windows.Forms.TextBox txtDesiredNumMonsters;
        private System.Windows.Forms.Label lblTypeWanted;
        private System.Windows.Forms.TextBox txtDesiredType;
        private System.Windows.Forms.Label lblDesiredSize;
        private System.Windows.Forms.TextBox txtDesiredSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumd4;
        private System.Windows.Forms.Label lblDiceRoller;
        private System.Windows.Forms.TextBox txtNumd6;
        private System.Windows.Forms.TextBox txtNumd8;
        private System.Windows.Forms.TextBox txtNumd20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtD4Result;
        private System.Windows.Forms.TextBox txtD6Result;
        private System.Windows.Forms.TextBox txtD8Result;
        private System.Windows.Forms.TextBox txtD20Result;
        private System.Windows.Forms.Button btnD4;
        private System.Windows.Forms.Button btnD6;
        private System.Windows.Forms.Button btnD8;
        private System.Windows.Forms.Button btnD20;
        private System.Windows.Forms.Button btnD100;
        private System.Windows.Forms.TextBox txtD100Result;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumd100;
        private System.Windows.Forms.Button btnDUser;
        private System.Windows.Forms.TextBox txtDUserNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumdUser;
        private System.Windows.Forms.TextBox txtDUserResult;
        private System.Windows.Forms.Label label9;
    }
}

