namespace FIleDownloader
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_url = new System.Windows.Forms.Label();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.pg_status = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_downloaded = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.pb_SaveAs = new System.Windows.Forms.PictureBox();
            this.sfd_SaveDownload = new System.Windows.Forms.SaveFileDialog();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_SaveAs)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_url
            // 
            this.lbl_url.AutoSize = true;
            this.lbl_url.Location = new System.Drawing.Point(39, 34);
            this.lbl_url.Name = "lbl_url";
            this.lbl_url.Size = new System.Drawing.Size(43, 25);
            this.lbl_url.TabIndex = 0;
            this.lbl_url.Text = "Url :";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(88, 34);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(606, 31);
            this.txt_url.TabIndex = 1;
            this.txt_url.MouseEnter += new System.EventHandler(this.txt_url_MouseEnter);
            // 
            // pg_status
            // 
            this.pg_status.Location = new System.Drawing.Point(88, 153);
            this.pg_status.Name = "pg_status";
            this.pg_status.Size = new System.Drawing.Size(648, 27);
            this.pg_status.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status :";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(699, 111);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(37, 25);
            this.lbl_percent.TabIndex = 0;
            this.lbl_percent.Text = "0%";
            this.lbl_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_dev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev.ForeColor = System.Drawing.Color.Red;
            this.lbl_dev.Location = new System.Drawing.Point(598, 282);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(164, 20);
            this.lbl_dev.TabIndex = 0;
            this.lbl_dev.Text = "Developed by  : Mxqius";
            this.lbl_dev.Click += new System.EventHandler(this.lbl_dev_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Speed :";
            // 
            // lbl_downloaded
            // 
            this.lbl_downloaded.AutoSize = true;
            this.lbl_downloaded.Location = new System.Drawing.Point(157, 225);
            this.lbl_downloaded.Name = "lbl_downloaded";
            this.lbl_downloaded.Size = new System.Drawing.Size(53, 25);
            this.lbl_downloaded.TabIndex = 0;
            this.lbl_downloaded.Text = "0 MB";
            this.lbl_downloaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Location = new System.Drawing.Point(105, 263);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(68, 25);
            this.lbl_speed.TabIndex = 0;
            this.lbl_speed.Text = "0 MB/s";
            this.lbl_speed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(618, 201);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(118, 33);
            this.btn_resume.TabIndex = 3;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(494, 201);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(118, 33);
            this.btn_pause.TabIndex = 3;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(370, 201);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(118, 33);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pb_SaveAs
            // 
            this.pb_SaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_SaveAs.Image = global::FIleDownloader.Properties.Resources.SaveFolder;
            this.pb_SaveAs.Location = new System.Drawing.Point(700, 34);
            this.pb_SaveAs.Name = "pb_SaveAs";
            this.pb_SaveAs.Size = new System.Drawing.Size(36, 41);
            this.pb_SaveAs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_SaveAs.TabIndex = 4;
            this.pb_SaveAs.TabStop = false;
            this.pb_SaveAs.Click += new System.EventHandler(this.pb_SaveAs_Click);
            // 
            // sfd_SaveDownload
            // 
            this.sfd_SaveDownload.Title = "Save As";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(114, 111);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(28, 25);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "....";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 311);
            this.Controls.Add(this.pb_SaveAs);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.pg_status);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_downloaded);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_dev);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_url);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DownloadForm";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_SaveAs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_url;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.ProgressBar pg_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_downloaded;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pb_SaveAs;
        private System.Windows.Forms.SaveFileDialog sfd_SaveDownload;
        private System.Windows.Forms.Label lbl_status;
    }
}

