namespace Server2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btn_answer = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_score = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_nquestions = new System.Windows.Forms.Label();
            this.lb_min = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_sec = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.lb_ans1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_ans2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_ans3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_ans4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Questions Send";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Questions :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Answer :";
            // 
            // tb_answer
            // 
            this.tb_answer.AutoCompleteCustomSource.AddRange(new string[] {
            "Abdo",
            "Egypt",
            "Mit Ghmaer",
            "21",
            "Computer Science"});
            this.tb_answer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_answer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_answer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(316, 320);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(595, 32);
            this.tb_answer.TabIndex = 4;
            // 
            // btn_answer
            // 
            this.btn_answer.BackColor = System.Drawing.Color.Teal;
            this.btn_answer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_answer.ForeColor = System.Drawing.Color.Snow;
            this.btn_answer.Location = new System.Drawing.Point(535, 390);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(175, 52);
            this.btn_answer.TabIndex = 5;
            this.btn_answer.Text = "Answer";
            this.btn_answer.UseVisualStyleBackColor = false;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1054, 563);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 626;
            this.lineShape1.X2 = 624;
            this.lineShape1.Y1 = 78;
            this.lineShape1.Y2 = 260;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(806, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Questions Number : 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(806, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Score :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(977, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "/5";
            // 
            // lb_score
            // 
            this.lb_score.AutoSize = true;
            this.lb_score.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_score.Location = new System.Drawing.Point(946, 193);
            this.lb_score.Name = "lb_score";
            this.lb_score.Size = new System.Drawing.Size(32, 24);
            this.lb_score.TabIndex = 10;
            this.lb_score.Text = "??";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Questions number recive :";
            // 
            // lb_nquestions
            // 
            this.lb_nquestions.AutoSize = true;
            this.lb_nquestions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nquestions.Location = new System.Drawing.Point(358, 150);
            this.lb_nquestions.Name = "lb_nquestions";
            this.lb_nquestions.Size = new System.Drawing.Size(23, 24);
            this.lb_nquestions.TabIndex = 12;
            this.lb_nquestions.Text = "0";
            // 
            // lb_min
            // 
            this.lb_min.AutoSize = true;
            this.lb_min.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_min.Location = new System.Drawing.Point(559, 17);
            this.lb_min.Name = "lb_min";
            this.lb_min.Size = new System.Drawing.Size(70, 48);
            this.lb_min.TabIndex = 13;
            this.lb_min.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(615, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 48);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            // 
            // lb_sec
            // 
            this.lb_sec.AutoSize = true;
            this.lb_sec.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_sec.Location = new System.Drawing.Point(635, 17);
            this.lb_sec.Name = "lb_sec";
            this.lb_sec.Size = new System.Drawing.Size(70, 48);
            this.lb_sec.TabIndex = 15;
            this.lb_sec.Text = "00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 34);
            this.label10.TabIndex = 16;
            this.label10.Text = "Total Time : 1 M";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 487);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "1-";
            // 
            // lb_ans1
            // 
            this.lb_ans1.AutoSize = true;
            this.lb_ans1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ans1.Location = new System.Drawing.Point(66, 487);
            this.lb_ans1.Name = "lb_ans1";
            this.lb_ans1.Size = new System.Drawing.Size(89, 24);
            this.lb_ans1.TabIndex = 18;
            this.lb_ans1.Text = "Waiting";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "2-";
            // 
            // lb_ans2
            // 
            this.lb_ans2.AutoSize = true;
            this.lb_ans2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ans2.Location = new System.Drawing.Point(341, 487);
            this.lb_ans2.Name = "lb_ans2";
            this.lb_ans2.Size = new System.Drawing.Size(89, 24);
            this.lb_ans2.TabIndex = 20;
            this.lb_ans2.Text = "Waiting";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(608, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 24);
            this.label13.TabIndex = 21;
            this.label13.Text = "3-";
            // 
            // lb_ans3
            // 
            this.lb_ans3.AutoSize = true;
            this.lb_ans3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ans3.Location = new System.Drawing.Point(635, 487);
            this.lb_ans3.Name = "lb_ans3";
            this.lb_ans3.Size = new System.Drawing.Size(89, 24);
            this.lb_ans3.TabIndex = 22;
            this.lb_ans3.Text = "Waiting";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(816, 487);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 24);
            this.label14.TabIndex = 23;
            this.label14.Text = "4-";
            // 
            // lb_ans4
            // 
            this.lb_ans4.AutoSize = true;
            this.lb_ans4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ans4.Location = new System.Drawing.Point(841, 487);
            this.lb_ans4.Name = "lb_ans4";
            this.lb_ans4.Size = new System.Drawing.Size(89, 24);
            this.lb_ans4.TabIndex = 24;
            this.lb_ans4.Text = "Waiting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 563);
            this.Controls.Add(this.lb_ans4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lb_ans3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lb_ans2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lb_ans1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lb_sec);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_min);
            this.Controls.Add(this.lb_nquestions);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_score);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_answer);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button btn_answer;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_score;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_nquestions;
        private System.Windows.Forms.Label lb_min;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_sec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_ans1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_ans2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_ans3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_ans4;
    }
}

