namespace OOP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxCourse = new TextBox();
            textBoxPoints = new TextBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            textBoxShow = new Button();
            buttonCalculatePoints = new Button();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Kursnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 83);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Antal poäng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 121);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Startdatum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 159);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Slutdatum";
            // 
            // textBoxCourse
            // 
            textBoxCourse.Location = new Point(126, 44);
            textBoxCourse.Name = "textBoxCourse";
            textBoxCourse.Size = new Size(237, 27);
            textBoxCourse.TabIndex = 4;
            // 
            // textBoxPoints
            // 
            textBoxPoints.Location = new Point(126, 80);
            textBoxPoints.Name = "textBoxPoints";
            textBoxPoints.Size = new Size(126, 27);
            textBoxPoints.TabIndex = 5;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(126, 116);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 6;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(126, 154);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 7;
            // 
            // textBoxShow
            // 
            textBoxShow.Location = new Point(12, 221);
            textBoxShow.Name = "textBoxShow";
            textBoxShow.Size = new Size(154, 29);
            textBoxShow.TabIndex = 8;
            textBoxShow.Text = "Visa";
            textBoxShow.UseVisualStyleBackColor = true;
            textBoxShow.Click += textBoxShow_Click;
            // 
            // buttonCalculatePoints
            // 
            buttonCalculatePoints.Location = new Point(176, 221);
            buttonCalculatePoints.Name = "buttonCalculatePoints";
            buttonCalculatePoints.Size = new Size(154, 29);
            buttonCalculatePoints.TabIndex = 9;
            buttonCalculatePoints.Text = "Beräkna poäng";
            buttonCalculatePoints.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(336, 221);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(154, 29);
            buttonCalculate.TabIndex = 10;
            buttonCalculate.Text = "Beräkna";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 326);
            Controls.Add(buttonCalculate);
            Controls.Add(buttonCalculatePoints);
            Controls.Add(textBoxShow);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(textBoxPoints);
            Controls.Add(textBoxCourse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxCourse;
        private TextBox textBoxPoints;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button textBoxShow;
        private Button buttonCalculatePoints;
        private Button buttonCalculate;
    }
}
