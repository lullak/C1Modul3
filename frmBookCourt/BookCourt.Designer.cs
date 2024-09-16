namespace frmBookCourt
{
    partial class BookCourt
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
            textBoxFirstName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxStreetAddress = new TextBox();
            listBoxCourt = new ListBox();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            buttonCreateBooking = new Button();
            buttonUpdateBooking = new Button();
            buttonDeleteBooking = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(114, 43);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(179, 27);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(114, 85);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(179, 27);
            textBoxSurname.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(114, 128);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(179, 27);
            textBoxPhone.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(114, 173);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(179, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(114, 215);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(179, 27);
            textBoxPostalCode.TabIndex = 4;
            // 
            // textBoxStreetAddress
            // 
            textBoxStreetAddress.Location = new Point(114, 257);
            textBoxStreetAddress.Name = "textBoxStreetAddress";
            textBoxStreetAddress.Size = new Size(179, 27);
            textBoxStreetAddress.TabIndex = 5;
            // 
            // listBoxCourt
            // 
            listBoxCourt.FormattingEnabled = true;
            listBoxCourt.Location = new Point(395, 52);
            listBoxCourt.Name = "listBoxCourt";
            listBoxCourt.Size = new Size(434, 324);
            listBoxCourt.TabIndex = 6;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(114, 314);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(250, 27);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(114, 356);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(250, 27);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // buttonCreateBooking
            // 
            buttonCreateBooking.Location = new Point(499, 382);
            buttonCreateBooking.Name = "buttonCreateBooking";
            buttonCreateBooking.Size = new Size(162, 29);
            buttonCreateBooking.TabIndex = 9;
            buttonCreateBooking.Text = "Skapa Bokning";
            buttonCreateBooking.UseVisualStyleBackColor = true;
            
            // 
            // buttonUpdateBooking
            // 
            buttonUpdateBooking.Location = new Point(667, 382);
            buttonUpdateBooking.Name = "buttonUpdateBooking";
            buttonUpdateBooking.Size = new Size(162, 29);
            buttonUpdateBooking.TabIndex = 10;
            buttonUpdateBooking.Text = "Uppdatera bokning";
            buttonUpdateBooking.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteBooking
            // 
            buttonDeleteBooking.Location = new Point(667, 417);
            buttonDeleteBooking.Name = "buttonDeleteBooking";
            buttonDeleteBooking.Size = new Size(162, 29);
            buttonDeleteBooking.TabIndex = 11;
            buttonDeleteBooking.Text = "Radera bookning";
            buttonDeleteBooking.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 12;
            label1.Text = "Förnamn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 13;
            label2.Text = "Efternamn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 14;
            label3.Text = "Telefon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 15;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 218);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 16;
            label5.Text = "Postnummer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 260);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 17;
            label6.Text = "Adress";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 319);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 18;
            label7.Text = "Start tid";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 361);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 19;
            label8.Text = "Slut tid";
            // 
            // BookCourt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 487);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonDeleteBooking);
            Controls.Add(buttonUpdateBooking);
            Controls.Add(buttonCreateBooking);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(listBoxCourt);
            Controls.Add(textBoxStreetAddress);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxFirstName);
            Name = "BookCourt";
            Text = "BookCourt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxSurname;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxPostalCode;
        private TextBox textBoxStreetAddress;
        private ListBox listBoxCourt;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Button buttonCreateBooking;
        private Button buttonUpdateBooking;
        private Button buttonDeleteBooking;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}