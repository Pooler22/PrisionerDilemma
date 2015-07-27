namespace PrisionerDilemma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDefectPlayer1 = new System.Windows.Forms.Button();
            this.buttonCooperatePlayer1 = new System.Windows.Forms.Button();
            this.comboBoxPlayer2 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTotalScorePlayer1 = new System.Windows.Forms.Label();
            this.labelTotalScorePlayer2 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelLastScorePlayer1 = new System.Windows.Forms.Label();
            this.labelLastScorePlayer2 = new System.Windows.Forms.Label();
            this.buttonStartIteration = new System.Windows.Forms.Button();
            this.labelLastDecisionPlayer1 = new System.Windows.Forms.Label();
            this.labelLastDecisionPlayer2 = new System.Windows.Forms.Label();
            this.textBoxNumberOfIteration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDefectPlayer2 = new System.Windows.Forms.Button();
            this.buttonCooperatePlayer2 = new System.Windows.Forms.Button();
            this.comboBoxPlayer1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Decision:";
            // 
            // buttonDefectPlayer1
            // 
            this.buttonDefectPlayer1.Location = new System.Drawing.Point(186, 82);
            this.buttonDefectPlayer1.Name = "buttonDefectPlayer1";
            this.buttonDefectPlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonDefectPlayer1.TabIndex = 30;
            this.buttonDefectPlayer1.Text = "Defect";
            this.buttonDefectPlayer1.UseVisualStyleBackColor = true;
            this.buttonDefectPlayer1.Visible = false;
            this.buttonDefectPlayer1.Click += new System.EventHandler(this.buttonDefectPlayer1_Click);
            // 
            // buttonCooperatePlayer1
            // 
            this.buttonCooperatePlayer1.Location = new System.Drawing.Point(105, 82);
            this.buttonCooperatePlayer1.Name = "buttonCooperatePlayer1";
            this.buttonCooperatePlayer1.Size = new System.Drawing.Size(75, 23);
            this.buttonCooperatePlayer1.TabIndex = 29;
            this.buttonCooperatePlayer1.Text = "Cooperate";
            this.buttonCooperatePlayer1.UseVisualStyleBackColor = true;
            this.buttonCooperatePlayer1.Visible = false;
            this.buttonCooperatePlayer1.Click += new System.EventHandler(this.buttonCooperatePlayer1_Click);
            // 
            // comboBoxPlayer2
            // 
            this.comboBoxPlayer2.FormattingEnabled = true;
            this.comboBoxPlayer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxPlayer2.Location = new System.Drawing.Point(306, 39);
            this.comboBoxPlayer2.Name = "comboBoxPlayer2";
            this.comboBoxPlayer2.Size = new System.Drawing.Size(158, 21);
            this.comboBoxPlayer2.TabIndex = 28;
            this.comboBoxPlayer2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPlayer2_SelectionChangeCommitted);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(596, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Save as txt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(596, 144);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelTotalScorePlayer1
            // 
            this.labelTotalScorePlayer1.AutoSize = true;
            this.labelTotalScorePlayer1.Location = new System.Drawing.Point(176, 219);
            this.labelTotalScorePlayer1.Name = "labelTotalScorePlayer1";
            this.labelTotalScorePlayer1.Size = new System.Drawing.Size(13, 13);
            this.labelTotalScorePlayer1.TabIndex = 14;
            this.labelTotalScorePlayer1.Text = "0";
            // 
            // labelTotalScorePlayer2
            // 
            this.labelTotalScorePlayer2.AutoSize = true;
            this.labelTotalScorePlayer2.Location = new System.Drawing.Point(368, 220);
            this.labelTotalScorePlayer2.Name = "labelTotalScorePlayer2";
            this.labelTotalScorePlayer2.Size = new System.Drawing.Size(13, 13);
            this.labelTotalScorePlayer2.TabIndex = 13;
            this.labelTotalScorePlayer2.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(490, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Number of iterations:";
            // 
            // labelLastScorePlayer1
            // 
            this.labelLastScorePlayer1.AutoSize = true;
            this.labelLastScorePlayer1.Location = new System.Drawing.Point(176, 172);
            this.labelLastScorePlayer1.Name = "labelLastScorePlayer1";
            this.labelLastScorePlayer1.Size = new System.Drawing.Size(13, 13);
            this.labelLastScorePlayer1.TabIndex = 12;
            this.labelLastScorePlayer1.Text = "0";
            // 
            // labelLastScorePlayer2
            // 
            this.labelLastScorePlayer2.AutoSize = true;
            this.labelLastScorePlayer2.Location = new System.Drawing.Point(368, 173);
            this.labelLastScorePlayer2.Name = "labelLastScorePlayer2";
            this.labelLastScorePlayer2.Size = new System.Drawing.Size(13, 13);
            this.labelLastScorePlayer2.TabIndex = 11;
            this.labelLastScorePlayer2.Text = "0";
            // 
            // buttonStartIteration
            // 
            this.buttonStartIteration.Location = new System.Drawing.Point(596, 82);
            this.buttonStartIteration.Name = "buttonStartIteration";
            this.buttonStartIteration.Size = new System.Drawing.Size(75, 23);
            this.buttonStartIteration.TabIndex = 9;
            this.buttonStartIteration.Text = "Start";
            this.buttonStartIteration.UseVisualStyleBackColor = true;
            this.buttonStartIteration.Click += new System.EventHandler(this.buttonStartIteration_Click);
            // 
            // labelLastDecisionPlayer1
            // 
            this.labelLastDecisionPlayer1.AutoSize = true;
            this.labelLastDecisionPlayer1.Location = new System.Drawing.Point(167, 125);
            this.labelLastDecisionPlayer1.Name = "labelLastDecisionPlayer1";
            this.labelLastDecisionPlayer1.Size = new System.Drawing.Size(31, 13);
            this.labelLastDecisionPlayer1.TabIndex = 10;
            this.labelLastDecisionPlayer1.Text = "none";
            // 
            // labelLastDecisionPlayer2
            // 
            this.labelLastDecisionPlayer2.AutoSize = true;
            this.labelLastDecisionPlayer2.Location = new System.Drawing.Point(359, 125);
            this.labelLastDecisionPlayer2.Name = "labelLastDecisionPlayer2";
            this.labelLastDecisionPlayer2.Size = new System.Drawing.Size(31, 13);
            this.labelLastDecisionPlayer2.TabIndex = 9;
            this.labelLastDecisionPlayer2.Text = "none";
            // 
            // textBoxNumberOfIteration
            // 
            this.textBoxNumberOfIteration.Location = new System.Drawing.Point(596, 39);
            this.textBoxNumberOfIteration.Name = "textBoxNumberOfIteration";
            this.textBoxNumberOfIteration.Size = new System.Drawing.Size(75, 20);
            this.textBoxNumberOfIteration.TabIndex = 8;
            this.textBoxNumberOfIteration.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Last score:";
            // 
            // buttonDefectPlayer2
            // 
            this.buttonDefectPlayer2.Location = new System.Drawing.Point(387, 82);
            this.buttonDefectPlayer2.Name = "buttonDefectPlayer2";
            this.buttonDefectPlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonDefectPlayer2.TabIndex = 7;
            this.buttonDefectPlayer2.Text = "Defect";
            this.buttonDefectPlayer2.UseVisualStyleBackColor = true;
            this.buttonDefectPlayer2.Visible = false;
            this.buttonDefectPlayer2.Click += new System.EventHandler(this.buttonDefectPlayer2_Click);
            // 
            // buttonCooperatePlayer2
            // 
            this.buttonCooperatePlayer2.Location = new System.Drawing.Point(306, 82);
            this.buttonCooperatePlayer2.Name = "buttonCooperatePlayer2";
            this.buttonCooperatePlayer2.Size = new System.Drawing.Size(75, 23);
            this.buttonCooperatePlayer2.TabIndex = 6;
            this.buttonCooperatePlayer2.Text = "Cooperate";
            this.buttonCooperatePlayer2.UseVisualStyleBackColor = true;
            this.buttonCooperatePlayer2.Visible = false;
            this.buttonCooperatePlayer2.Click += new System.EventHandler(this.buttonCooperatePlayer2_Click);
            // 
            // comboBoxPlayer1
            // 
            this.comboBoxPlayer1.FormattingEnabled = true;
            this.comboBoxPlayer1.Location = new System.Drawing.Point(105, 39);
            this.comboBoxPlayer1.Name = "comboBoxPlayer1";
            this.comboBoxPlayer1.Size = new System.Drawing.Size(158, 21);
            this.comboBoxPlayer1.TabIndex = 5;
            this.comboBoxPlayer1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxPlayer1_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Strategy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total score:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last decision:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player 1";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(596, 223);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 32;
            this.buttonHelp.Text = "Help!";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "All vs All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDefectPlayer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCooperatePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPlayer2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelTotalScorePlayer1);
            this.Controls.Add(this.comboBoxPlayer1);
            this.Controls.Add(this.labelTotalScorePlayer2);
            this.Controls.Add(this.buttonCooperatePlayer2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.buttonDefectPlayer2);
            this.Controls.Add(this.labelLastScorePlayer1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelLastScorePlayer2);
            this.Controls.Add(this.textBoxNumberOfIteration);
            this.Controls.Add(this.buttonStartIteration);
            this.Controls.Add(this.labelLastDecisionPlayer2);
            this.Controls.Add(this.labelLastDecisionPlayer1);
            this.Name = "Form1";
            this.Text = "Prisioner";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelTotalScorePlayer1;
		private System.Windows.Forms.Label labelTotalScorePlayer2;
		private System.Windows.Forms.Label labelLastScorePlayer1;
		private System.Windows.Forms.Label labelLastScorePlayer2;
		private System.Windows.Forms.Label labelLastDecisionPlayer1;
		private System.Windows.Forms.Label labelLastDecisionPlayer2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button buttonDefectPlayer2;
		private System.Windows.Forms.Button buttonCooperatePlayer2;
		private System.Windows.Forms.ComboBox comboBoxPlayer1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonStartIteration;
		private System.Windows.Forms.TextBox textBoxNumberOfIteration;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonDefectPlayer1;
		private System.Windows.Forms.Button buttonCooperatePlayer1;
		private System.Windows.Forms.ComboBox comboBoxPlayer2;
		private System.Windows.Forms.Button buttonHelp;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

