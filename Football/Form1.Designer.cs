namespace Football
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
            this.textBox1nameTeam = new System.Windows.Forms.TextBox();
            this.textBox2Country = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3Player = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4Number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5Position = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6MatchDate = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1nameTeam
            // 
            this.textBox1nameTeam.Location = new System.Drawing.Point(12, 32);
            this.textBox1nameTeam.Name = "textBox1nameTeam";
            this.textBox1nameTeam.Size = new System.Drawing.Size(346, 26);
            this.textBox1nameTeam.TabIndex = 0;
            this.textBox1nameTeam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2Country
            // 
            this.textBox2Country.Location = new System.Drawing.Point(12, 104);
            this.textBox2Country.Name = "textBox2Country";
            this.textBox2Country.Size = new System.Drawing.Size(346, 26);
            this.textBox2Country.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter TEAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Team\'s country";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter PLAYER";
            // 
            // textBox3Player
            // 
            this.textBox3Player.Location = new System.Drawing.Point(397, 32);
            this.textBox3Player.Name = "textBox3Player";
            this.textBox3Player.Size = new System.Drawing.Size(370, 26);
            this.textBox3Player.TabIndex = 0;
            this.textBox3Player.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Player\'s number";
            // 
            // textBox4Number
            // 
            this.textBox4Number.Location = new System.Drawing.Point(397, 104);
            this.textBox4Number.Name = "textBox4Number";
            this.textBox4Number.Size = new System.Drawing.Size(171, 26);
            this.textBox4Number.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Player\'s position";
            // 
            // textBox5Position
            // 
            this.textBox5Position.Location = new System.Drawing.Point(579, 104);
            this.textBox5Position.Name = "textBox5Position";
            this.textBox5Position.Size = new System.Drawing.Size(188, 26);
            this.textBox5Position.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 204);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(397, 201);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(370, 204);
            this.listBox2.TabIndex = 12;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "ADD Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(635, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 38);
            this.button2.TabIndex = 14;
            this.button2.Text = "ADD Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(397, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox6MatchDate
            // 
            this.textBox6MatchDate.Location = new System.Drawing.Point(12, 571);
            this.textBox6MatchDate.Name = "textBox6MatchDate";
            this.textBox6MatchDate.Size = new System.Drawing.Size(213, 26);
            this.textBox6MatchDate.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 512);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 26);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(397, 512);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 26);
            this.textBox2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "TEAM1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(705, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "TEAM2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Goals1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 474);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Goals2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(316, 430);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "MATCH RESULTS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 541);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Date";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 571);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(507, 32);
            this.button3.TabIndex = 26;
            this.button3.Text = "LOAD RESULTS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 510);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(201, 28);
            this.comboBox2.TabIndex = 27;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(566, 512);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(201, 28);
            this.comboBox3.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox6MatchDate);
            this.Controls.Add(this.textBox5Position);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4Number);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2Country);
            this.Controls.Add(this.textBox3Player);
            this.Controls.Add(this.textBox1nameTeam);
            this.Name = "Form1";
            this.Text = "FOOTBALL CHAMP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1nameTeam;
        private System.Windows.Forms.TextBox textBox2Country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3Player;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5Position;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6MatchDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}

