namespace The_Food_Taxi
{
    partial class Register
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
            this.showpasscheckBox = new System.Windows.Forms.CheckBox();
            this.confirmtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btloginlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.clearregbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showpasscheckBox
            // 
            this.showpasscheckBox.AutoSize = true;
            this.showpasscheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpasscheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasscheckBox.ForeColor = System.Drawing.Color.Blue;
            this.showpasscheckBox.Location = new System.Drawing.Point(170, 303);
            this.showpasscheckBox.Name = "showpasscheckBox";
            this.showpasscheckBox.Size = new System.Drawing.Size(121, 20);
            this.showpasscheckBox.TabIndex = 14;
            this.showpasscheckBox.Text = "Show Password";
            this.showpasscheckBox.UseVisualStyleBackColor = true;
            this.showpasscheckBox.CheckedChanged += new System.EventHandler(this.showpasscheckBox_CheckedChanged);
            // 
            // confirmtextBox
            // 
            this.confirmtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmtextBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmtextBox.Location = new System.Drawing.Point(84, 251);
            this.confirmtextBox.Name = "confirmtextBox";
            this.confirmtextBox.PasswordChar = '*';
            this.confirmtextBox.Size = new System.Drawing.Size(213, 31);
            this.confirmtextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(80, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm Password";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtextBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(84, 180);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(213, 31);
            this.passwordtextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(80, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // usernametextBox
            // 
            this.usernametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametextBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.Location = new System.Drawing.Point(84, 112);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(213, 31);
            this.usernametextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(80, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "UserName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 41);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Registration";
            // 
            // btloginlabel
            // 
            this.btloginlabel.AutoSize = true;
            this.btloginlabel.ForeColor = System.Drawing.Color.Blue;
            this.btloginlabel.Location = new System.Drawing.Point(100, 483);
            this.btloginlabel.Name = "btloginlabel";
            this.btloginlabel.Size = new System.Drawing.Size(95, 16);
            this.btloginlabel.TabIndex = 20;
            this.btloginlabel.Text = "Back to LOGIN";
            this.btloginlabel.Click += new System.EventHandler(this.btloginlabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(100, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Already Have an Account";
            // 
            // clearregbutton
            // 
            this.clearregbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearregbutton.ForeColor = System.Drawing.Color.White;
            this.clearregbutton.Location = new System.Drawing.Point(84, 397);
            this.clearregbutton.Name = "clearregbutton";
            this.clearregbutton.Size = new System.Drawing.Size(213, 44);
            this.clearregbutton.TabIndex = 18;
            this.clearregbutton.Text = "Clear";
            this.clearregbutton.UseVisualStyleBackColor = false;
            this.clearregbutton.Click += new System.EventHandler(this.clearregbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.registerbutton.ForeColor = System.Drawing.Color.White;
            this.registerbutton.Location = new System.Drawing.Point(84, 347);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(213, 44);
            this.registerbutton.TabIndex = 17;
            this.registerbutton.Text = "Register";
            this.registerbutton.UseVisualStyleBackColor = false;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(572, 594);
            this.Controls.Add(this.btloginlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clearregbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showpasscheckBox);
            this.Controls.Add(this.confirmtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showpasscheckBox;
        private System.Windows.Forms.TextBox confirmtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btloginlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearregbutton;
        private System.Windows.Forms.Button registerbutton;
    }
}