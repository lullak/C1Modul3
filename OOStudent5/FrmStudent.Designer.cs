namespace OOStudent5
{
    partial class FrmStudent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            listBoxCourses = new ListBox();
            buttonShow = new Button();
            buttonClear = new Button();
            buttonGetGrades = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Förnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Efternamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 115);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Personnummer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 157);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 194);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 112);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 191);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 27);
            textBox5.TabIndex = 9;
            // 
            // listBoxCourses
            // 
            listBoxCourses.FormattingEnabled = true;
            listBoxCourses.Location = new Point(467, 28);
            listBoxCourses.Name = "listBoxCourses";
            listBoxCourses.Size = new Size(294, 204);
            listBoxCourses.TabIndex = 10;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(138, 261);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(135, 29);
            buttonShow.TabIndex = 11;
            buttonShow.Text = "Visa";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(281, 261);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(135, 29);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Rensa";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonGetGrades
            // 
            buttonGetGrades.Location = new Point(626, 261);
            buttonGetGrades.Name = "buttonGetGrades";
            buttonGetGrades.Size = new Size(135, 29);
            buttonGetGrades.TabIndex = 13;
            buttonGetGrades.Text = "Hämta betyg";
            buttonGetGrades.UseVisualStyleBackColor = true;
            buttonGetGrades.Click += buttonGetGrades_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 352);
            Controls.Add(buttonGetGrades);
            Controls.Add(buttonClear);
            Controls.Add(buttonShow);
            Controls.Add(listBoxCourses);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmStudent";
            Text = "FrmStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private ListBox listBoxCourses;
        private Button buttonShow;
        private Button buttonClear;
        private Button buttonGetGrades;
    }
}