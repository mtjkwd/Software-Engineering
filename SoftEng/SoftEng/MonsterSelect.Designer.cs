namespace SoftEng
{
    partial class MonsterSelect
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
            this.MonsterSelect_Cancel = new System.Windows.Forms.Button();
            this.MonsterSelect_BABLabel = new System.Windows.Forms.Label();
            this.MonsterSelect_InitModLabel = new System.Windows.Forms.Label();
            this.MonsterSelect_DamageDiceLabel = new System.Windows.Forms.Label();
            this.MonsterSelect_NumHDLabel = new System.Windows.Forms.Label();
            this.MonsterSelect_HealthDiceLabel = new System.Windows.Forms.Label();
            this.MonsterSelect_BABText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_InitModText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_DamageDiceText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_NumHDText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_HealthDiceText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_Name = new System.Windows.Forms.Label();
            this.MonsterSelect_NameText = new System.Windows.Forms.TextBox();
            this.MonsterSelect_Edit = new System.Windows.Forms.Button();
            this.MonsterSelect_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSelect_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MonsterSelect_Cancel
            // 
            this.MonsterSelect_Cancel.Location = new System.Drawing.Point(138, 229);
            this.MonsterSelect_Cancel.Name = "MonsterSelect_Cancel";
            this.MonsterSelect_Cancel.Size = new System.Drawing.Size(117, 23);
            this.MonsterSelect_Cancel.TabIndex = 1;
            this.MonsterSelect_Cancel.Text = "Discard Monster";
            this.MonsterSelect_Cancel.UseVisualStyleBackColor = true;
            this.MonsterSelect_Cancel.Click += new System.EventHandler(this.MonsterSelect_Cancel_Click);
            // 
            // MonsterSelect_BABLabel
            // 
            this.MonsterSelect_BABLabel.AutoSize = true;
            this.MonsterSelect_BABLabel.Location = new System.Drawing.Point(12, 47);
            this.MonsterSelect_BABLabel.Name = "MonsterSelect_BABLabel";
            this.MonsterSelect_BABLabel.Size = new System.Drawing.Size(98, 13);
            this.MonsterSelect_BABLabel.TabIndex = 3;
            this.MonsterSelect_BABLabel.Text = "Base Attack Bonus";
            // 
            // MonsterSelect_InitModLabel
            // 
            this.MonsterSelect_InitModLabel.AutoSize = true;
            this.MonsterSelect_InitModLabel.Location = new System.Drawing.Point(12, 82);
            this.MonsterSelect_InitModLabel.Name = "MonsterSelect_InitModLabel";
            this.MonsterSelect_InitModLabel.Size = new System.Drawing.Size(86, 13);
            this.MonsterSelect_InitModLabel.TabIndex = 4;
            this.MonsterSelect_InitModLabel.Text = "Initiative Modifier";
            this.MonsterSelect_InitModLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // MonsterSelect_DamageDiceLabel
            // 
            this.MonsterSelect_DamageDiceLabel.AutoSize = true;
            this.MonsterSelect_DamageDiceLabel.Location = new System.Drawing.Point(12, 117);
            this.MonsterSelect_DamageDiceLabel.Name = "MonsterSelect_DamageDiceLabel";
            this.MonsterSelect_DamageDiceLabel.Size = new System.Drawing.Size(72, 13);
            this.MonsterSelect_DamageDiceLabel.TabIndex = 5;
            this.MonsterSelect_DamageDiceLabel.Text = "Damage Dice";
            // 
            // MonsterSelect_NumHDLabel
            // 
            this.MonsterSelect_NumHDLabel.AutoSize = true;
            this.MonsterSelect_NumHDLabel.Location = new System.Drawing.Point(12, 154);
            this.MonsterSelect_NumHDLabel.Name = "MonsterSelect_NumHDLabel";
            this.MonsterSelect_NumHDLabel.Size = new System.Drawing.Size(97, 13);
            this.MonsterSelect_NumHDLabel.TabIndex = 6;
            this.MonsterSelect_NumHDLabel.Text = "Number of Hit Dice";
            // 
            // MonsterSelect_HealthDiceLabel
            // 
            this.MonsterSelect_HealthDiceLabel.AutoSize = true;
            this.MonsterSelect_HealthDiceLabel.Location = new System.Drawing.Point(12, 190);
            this.MonsterSelect_HealthDiceLabel.Name = "MonsterSelect_HealthDiceLabel";
            this.MonsterSelect_HealthDiceLabel.Size = new System.Drawing.Size(57, 13);
            this.MonsterSelect_HealthDiceLabel.TabIndex = 7;
            this.MonsterSelect_HealthDiceLabel.Text = "Health Die";
            // 
            // MonsterSelect_BABText
            // 
            this.MonsterSelect_BABText.Location = new System.Drawing.Point(135, 44);
            this.MonsterSelect_BABText.Name = "MonsterSelect_BABText";
            this.MonsterSelect_BABText.ReadOnly = true;
            this.MonsterSelect_BABText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_BABText.TabIndex = 8;
            // 
            // MonsterSelect_InitModText
            // 
            this.MonsterSelect_InitModText.Location = new System.Drawing.Point(135, 79);
            this.MonsterSelect_InitModText.Name = "MonsterSelect_InitModText";
            this.MonsterSelect_InitModText.ReadOnly = true;
            this.MonsterSelect_InitModText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_InitModText.TabIndex = 9;
            // 
            // MonsterSelect_DamageDiceText
            // 
            this.MonsterSelect_DamageDiceText.Location = new System.Drawing.Point(135, 114);
            this.MonsterSelect_DamageDiceText.Name = "MonsterSelect_DamageDiceText";
            this.MonsterSelect_DamageDiceText.ReadOnly = true;
            this.MonsterSelect_DamageDiceText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_DamageDiceText.TabIndex = 10;
            // 
            // MonsterSelect_NumHDText
            // 
            this.MonsterSelect_NumHDText.Location = new System.Drawing.Point(135, 151);
            this.MonsterSelect_NumHDText.Name = "MonsterSelect_NumHDText";
            this.MonsterSelect_NumHDText.ReadOnly = true;
            this.MonsterSelect_NumHDText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_NumHDText.TabIndex = 11;
            // 
            // MonsterSelect_HealthDiceText
            // 
            this.MonsterSelect_HealthDiceText.Location = new System.Drawing.Point(135, 187);
            this.MonsterSelect_HealthDiceText.Name = "MonsterSelect_HealthDiceText";
            this.MonsterSelect_HealthDiceText.ReadOnly = true;
            this.MonsterSelect_HealthDiceText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_HealthDiceText.TabIndex = 12;
            // 
            // MonsterSelect_Name
            // 
            this.MonsterSelect_Name.AutoSize = true;
            this.MonsterSelect_Name.Location = new System.Drawing.Point(12, 15);
            this.MonsterSelect_Name.Name = "MonsterSelect_Name";
            this.MonsterSelect_Name.Size = new System.Drawing.Size(76, 13);
            this.MonsterSelect_Name.TabIndex = 13;
            this.MonsterSelect_Name.Text = "Monster Name";
            // 
            // MonsterSelect_NameText
            // 
            this.MonsterSelect_NameText.Location = new System.Drawing.Point(135, 12);
            this.MonsterSelect_NameText.Name = "MonsterSelect_NameText";
            this.MonsterSelect_NameText.ReadOnly = true;
            this.MonsterSelect_NameText.Size = new System.Drawing.Size(100, 20);
            this.MonsterSelect_NameText.TabIndex = 14;
            // 
            // MonsterSelect_Edit
            // 
            this.MonsterSelect_Edit.Location = new System.Drawing.Point(15, 229);
            this.MonsterSelect_Edit.Name = "MonsterSelect_Edit";
            this.MonsterSelect_Edit.Size = new System.Drawing.Size(117, 23);
            this.MonsterSelect_Edit.TabIndex = 15;
            this.MonsterSelect_Edit.Text = "Edit Monster";
            this.MonsterSelect_Edit.UseVisualStyleBackColor = true;
            this.MonsterSelect_Edit.Click += new System.EventHandler(this.MonsterSelect_Edit_Click);
            // 
            // MonsterSelect_PictureBox
            // 
            this.MonsterSelect_PictureBox.Location = new System.Drawing.Point(255, 33);
            this.MonsterSelect_PictureBox.Name = "MonsterSelect_PictureBox";
            this.MonsterSelect_PictureBox.Size = new System.Drawing.Size(161, 174);
            this.MonsterSelect_PictureBox.TabIndex = 16;
            this.MonsterSelect_PictureBox.TabStop = false;
            // 
            // MonsterSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 266);
            this.Controls.Add(this.MonsterSelect_PictureBox);
            this.Controls.Add(this.MonsterSelect_Edit);
            this.Controls.Add(this.MonsterSelect_NameText);
            this.Controls.Add(this.MonsterSelect_Name);
            this.Controls.Add(this.MonsterSelect_HealthDiceText);
            this.Controls.Add(this.MonsterSelect_NumHDText);
            this.Controls.Add(this.MonsterSelect_DamageDiceText);
            this.Controls.Add(this.MonsterSelect_InitModText);
            this.Controls.Add(this.MonsterSelect_BABText);
            this.Controls.Add(this.MonsterSelect_HealthDiceLabel);
            this.Controls.Add(this.MonsterSelect_NumHDLabel);
            this.Controls.Add(this.MonsterSelect_DamageDiceLabel);
            this.Controls.Add(this.MonsterSelect_InitModLabel);
            this.Controls.Add(this.MonsterSelect_BABLabel);
            this.Controls.Add(this.MonsterSelect_Cancel);
            this.Name = "MonsterSelect";
            this.Text = "MonsterSelect";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MonsterSelect_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MonsterSelect_Cancel;
        private System.Windows.Forms.Label MonsterSelect_BABLabel;
        private System.Windows.Forms.Label MonsterSelect_InitModLabel;
        private System.Windows.Forms.Label MonsterSelect_DamageDiceLabel;
        private System.Windows.Forms.Label MonsterSelect_NumHDLabel;
        private System.Windows.Forms.Label MonsterSelect_HealthDiceLabel;
        private System.Windows.Forms.TextBox MonsterSelect_BABText;
        private System.Windows.Forms.TextBox MonsterSelect_InitModText;
        private System.Windows.Forms.TextBox MonsterSelect_DamageDiceText;
        private System.Windows.Forms.TextBox MonsterSelect_NumHDText;
        private System.Windows.Forms.TextBox MonsterSelect_HealthDiceText;
        private System.Windows.Forms.Label MonsterSelect_Name;
        private System.Windows.Forms.TextBox MonsterSelect_NameText;
        private System.Windows.Forms.Button MonsterSelect_Edit;
        private System.Windows.Forms.PictureBox MonsterSelect_PictureBox;

    }
}