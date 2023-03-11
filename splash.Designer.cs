namespace The_Food_Taxi
{
    partial class splash
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
            this.progress = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadinglabel = new System.Windows.Forms.Label();
            this.timersplash = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(278, 467);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(448, 23);
            this.progress.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::The_Food_Taxi.Properties.Resources.splashone;
            this.pictureBox1.Location = new System.Drawing.Point(278, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 378);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadinglabel
            // 
            this.loadinglabel.AutoSize = true;
            this.loadinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadinglabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadinglabel.Location = new System.Drawing.Point(273, 429);
            this.loadinglabel.Name = "loadinglabel";
            this.loadinglabel.Size = new System.Drawing.Size(107, 25);
            this.loadinglabel.TabIndex = 3;
            this.loadinglabel.Text = "Loading...";
            // 
            // timersplash
            // 
            this.timersplash.Tick += new System.EventHandler(this.timersplash_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(607, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Developed by Ashik,Ayon and Esham...";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(998, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadinglabel);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.pictureBox1);
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label loadinglabel;
        private System.Windows.Forms.Timer timersplash;
        private System.Windows.Forms.Label label1;
    }
}