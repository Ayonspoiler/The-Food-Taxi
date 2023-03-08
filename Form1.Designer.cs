namespace The_Food_Taxi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showpasscheckBox = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.clearloginbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.createacclabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(717, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(694, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // usernametextBox
            // 
            this.usernametextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernametextBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.Location = new System.Drawing.Point(698, 144);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(213, 31);
            this.usernametextBox.TabIndex = 2;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordtextBox.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(698, 212);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(213, 31);
            this.passwordtextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(694, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // showpasscheckBox
            // 
            this.showpasscheckBox.AutoSize = true;
            this.showpasscheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpasscheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showpasscheckBox.ForeColor = System.Drawing.Color.Blue;
            this.showpasscheckBox.Location = new System.Drawing.Point(760, 264);
            this.showpasscheckBox.Name = "showpasscheckBox";
            this.showpasscheckBox.Size = new System.Drawing.Size(151, 27);
            this.showpasscheckBox.TabIndex = 7;
            this.showpasscheckBox.Text = "Show Password";
            this.showpasscheckBox.UseVisualStyleBackColor = true;
            this.showpasscheckBox.CheckedChanged += new System.EventHandler(this.showpasscheckBox_CheckedChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(698, 297);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(213, 44);
            this.loginbutton.TabIndex = 8;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // clearloginbutton
            // 
            this.clearloginbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearloginbutton.ForeColor = System.Drawing.Color.White;
            this.clearloginbutton.Location = new System.Drawing.Point(698, 358);
            this.clearloginbutton.Name = "clearloginbutton";
            this.clearloginbutton.Size = new System.Drawing.Size(213, 44);
            this.clearloginbutton.TabIndex = 9;
            this.clearloginbutton.Text = "Clear";
            this.clearloginbutton.UseVisualStyleBackColor = false;
            this.clearloginbutton.Click += new System.EventHandler(this.clearloginbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(718, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Don\'t You Have An Account";
            // 
            // createacclabel
            // 
            this.createacclabel.AutoSize = true;
            this.createacclabel.ForeColor = System.Drawing.Color.Blue;
            this.createacclabel.Location = new System.Drawing.Point(718, 466);
            this.createacclabel.Name = "createacclabel";
            this.createacclabel.Size = new System.Drawing.Size(132, 23);
            this.createacclabel.TabIndex = 11;
            this.createacclabel.Text = "Create Account";
            this.createacclabel.Click += new System.EventHandler(this.createacclabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 555);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_Food_Taxi.Properties.Resources.Final_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(68, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 431);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(988, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createacclabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearloginbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.showpasscheckBox);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The_Food_Taxi";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showpasscheckBox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button clearloginbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label createacclabel;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

