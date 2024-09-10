namespace WinFormsDemo1
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(89, 55);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(270, 27);
            textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(89, 118);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 27);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(89, 177);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(265, 226);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 32);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 95);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 154);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 330);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "Form1";
            Text = "Create new user";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Button buttonSave;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
