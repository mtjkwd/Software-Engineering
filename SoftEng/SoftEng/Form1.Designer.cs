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
            this.button3 = new System.Windows.Forms.Button();
            this.Button_genMonster = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.picPortait)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ViewMonster
            // 
            this.Button_ViewMonster.Location = new System.Drawing.Point(267, 365);
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
            this.button2.Location = new System.Drawing.Point(16, 166);
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
            this.monsterList.CheckOnClick = true;
            this.monsterList.FormattingEnabled = true;
            this.monsterList.Location = new System.Drawing.Point(267, 30);
            this.monsterList.Margin = new System.Windows.Forms.Padding(4);
            this.monsterList.Name = "monsterList";
            this.monsterList.Size = new System.Drawing.Size(243, 327);
            this.monsterList.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 105);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Get Monster Picture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button_genMonster
            // 
            this.Button_genMonster.Location = new System.Drawing.Point(267, 418);
            this.Button_genMonster.Margin = new System.Windows.Forms.Padding(4);
            this.Button_genMonster.Name = "Button_genMonster";
            this.Button_genMonster.Size = new System.Drawing.Size(243, 28);
            this.Button_genMonster.TabIndex = 5;
            this.Button_genMonster.Text = "Generate Random Monster";
            this.Button_genMonster.UseVisualStyleBackColor = true;
            this.Button_genMonster.Click += new System.EventHandler(this.Button_genMonster_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(585, 30);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(162, 22);
            this.txtName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "-----------------------------------------------";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(310, 9);
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
            this.lblName.Location = new System.Drawing.Point(530, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name:";
            // 
            // picPortait
            // 
            this.picPortait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortait.Location = new System.Drawing.Point(533, 75);
            this.picPortait.Name = "picPortait";
            this.picPortait.Size = new System.Drawing.Size(214, 214);
            this.picPortait.TabIndex = 11;
            this.picPortait.TabStop = false;
            // 
            // lblPortrait
            // 
            this.lblPortrait.AutoSize = true;
            this.lblPortrait.Location = new System.Drawing.Point(530, 55);
            this.lblPortrait.Name = "lblPortrait";
            this.lblPortrait.Size = new System.Drawing.Size(58, 17);
            this.lblPortrait.TabIndex = 12;
            this.lblPortrait.Text = "Portrait:";
            // 
            // lbHealth
            // 
            this.lbHealth.AutoSize = true;
            this.lbHealth.Location = new System.Drawing.Point(530, 326);
            this.lbHealth.Name = "lbHealth";
            this.lbHealth.Size = new System.Drawing.Size(85, 17);
            this.lbHealth.TabIndex = 14;
            this.lbHealth.Text = "Health Dice:";
            // 
            // txtHealth
            // 
            this.txtHealth.Location = new System.Drawing.Point(621, 323);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.ReadOnly = true;
            this.txtHealth.Size = new System.Drawing.Size(126, 22);
            this.txtHealth.TabIndex = 13;
            // 
            // lblChallengeRating
            // 
            this.lblChallengeRating.AutoSize = true;
            this.lblChallengeRating.Location = new System.Drawing.Point(530, 298);
            this.lblChallengeRating.Name = "lblChallengeRating";
            this.lblChallengeRating.Size = new System.Drawing.Size(120, 17);
            this.lblChallengeRating.TabIndex = 16;
            this.lblChallengeRating.Text = "Challenge Rating:";
            // 
            // txtChallengeRating
            // 
            this.txtChallengeRating.Location = new System.Drawing.Point(656, 295);
            this.txtChallengeRating.Name = "txtChallengeRating";
            this.txtChallengeRating.ReadOnly = true;
            this.txtChallengeRating.Size = new System.Drawing.Size(91, 22);
            this.txtChallengeRating.TabIndex = 15;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(530, 354);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(77, 17);
            this.lblSize.TabIndex = 18;
            this.lblSize.Text = "Size Class:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(613, 351);
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = true;
            this.txtSize.Size = new System.Drawing.Size(134, 22);
            this.txtSize.TabIndex = 17;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(530, 382);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(578, 379);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(169, 22);
            this.txtType.TabIndex = 19;
            // 
            // MonsterGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Button_genMonster);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Button_genMonster;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
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
    }
}

