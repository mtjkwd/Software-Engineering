﻿namespace SoftEng
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Button_populateMonsters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_ViewMonster
            // 
            this.Button_ViewMonster.Location = new System.Drawing.Point(278, 164);
            this.Button_ViewMonster.Name = "Button_ViewMonster";
            this.Button_ViewMonster.Size = new System.Drawing.Size(148, 23);
            this.Button_ViewMonster.TabIndex = 0;
            this.Button_ViewMonster.Text = "View Selected Monster";
            this.Button_ViewMonster.UseVisualStyleBackColor = true;
            this.Button_ViewMonster.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(214, 64);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Get Monster Picture";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button_populateMonsters
            // 
            this.Button_populateMonsters.Location = new System.Drawing.Point(149, 164);
            this.Button_populateMonsters.Name = "Button_populateMonsters";
            this.Button_populateMonsters.Size = new System.Drawing.Size(123, 23);
            this.Button_populateMonsters.TabIndex = 5;
            this.Button_populateMonsters.Text = "Populate Monsters";
            this.Button_populateMonsters.UseVisualStyleBackColor = true;
            this.Button_populateMonsters.Click += new System.EventHandler(this.Button_populateMonsters_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 320);
            this.Controls.Add(this.Button_populateMonsters);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button_ViewMonster);
            this.Name = "Form1";
            this.Text = "DnD Monsters App";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ViewMonster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Button_populateMonsters;
    }
}

