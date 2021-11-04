
namespace RadioJavanTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxProxy = new System.Windows.Forms.ComboBox();
            this.btnProxy = new System.Windows.Forms.Button();
            this.textBoxAPI = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxSync = new System.Windows.Forms.CheckBox();
            this.checkBoxPlay = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.checkBoxSave = new System.Windows.Forms.CheckBox();
            this.checkBoxLike = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblPersent = new System.Windows.Forms.Label();
            this.lblRetry = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.lblRemain = new System.Windows.Forms.Label();
            this.lblComplet = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxProxy);
            this.groupBox1.Controls.Add(this.btnProxy);
            this.groupBox1.Controls.Add(this.textBoxAPI);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBoxSync);
            this.groupBox1.Controls.Add(this.checkBoxPlay);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBoxList);
            this.groupBox1.Controls.Add(this.textBoxTrack);
            this.groupBox1.Controls.Add(this.checkBoxSave);
            this.groupBox1.Controls.Add(this.checkBoxLike);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnCombo);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 428);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Thread:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxProxy
            // 
            this.comboBoxProxy.FormattingEnabled = true;
            this.comboBoxProxy.Items.AddRange(new object[] {
            "Without",
            "Http/Https",
            "Socks4",
            "Socks5"});
            this.comboBoxProxy.Location = new System.Drawing.Point(25, 258);
            this.comboBoxProxy.Name = "comboBoxProxy";
            this.comboBoxProxy.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProxy.TabIndex = 17;
            this.comboBoxProxy.SelectedIndexChanged += new System.EventHandler(this.comboBoxProxy_SelectedIndexChanged);
            // 
            // btnProxy
            // 
            this.btnProxy.BackColor = System.Drawing.Color.Gray;
            this.btnProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxy.ForeColor = System.Drawing.Color.Black;
            this.btnProxy.Location = new System.Drawing.Point(176, 30);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(132, 56);
            this.btnProxy.TabIndex = 16;
            this.btnProxy.Text = "Load Proxy";
            this.btnProxy.UseVisualStyleBackColor = false;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // textBoxAPI
            // 
            this.textBoxAPI.Location = new System.Drawing.Point(25, 306);
            this.textBoxAPI.Name = "textBoxAPI";
            this.textBoxAPI.Size = new System.Drawing.Size(283, 22);
            this.textBoxAPI.TabIndex = 15;
            this.textBoxAPI.Text = "Proxy API:";
            this.textBoxAPI.TextChanged += new System.EventHandler(this.textBoxAPI_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MP3",
            "Video"});
            this.comboBox1.Location = new System.Drawing.Point(187, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxSync
            // 
            this.checkBoxSync.Location = new System.Drawing.Point(190, 212);
            this.checkBoxSync.Name = "checkBoxSync";
            this.checkBoxSync.Size = new System.Drawing.Size(118, 28);
            this.checkBoxSync.TabIndex = 13;
            this.checkBoxSync.Text = "Sync Track";
            this.checkBoxSync.UseVisualStyleBackColor = true;
            this.checkBoxSync.CheckedChanged += new System.EventHandler(this.checkBoxSync_CheckedChanged);
            // 
            // checkBoxPlay
            // 
            this.checkBoxPlay.Location = new System.Drawing.Point(25, 212);
            this.checkBoxPlay.Name = "checkBoxPlay";
            this.checkBoxPlay.Size = new System.Drawing.Size(118, 28);
            this.checkBoxPlay.TabIndex = 12;
            this.checkBoxPlay.Text = "Play Track";
            this.checkBoxPlay.UseVisualStyleBackColor = true;
            this.checkBoxPlay.CheckedChanged += new System.EventHandler(this.checkBoxPlay_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 137);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(74, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // textBoxList
            // 
            this.textBoxList.Enabled = false;
            this.textBoxList.Location = new System.Drawing.Point(25, 346);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(283, 22);
            this.textBoxList.TabIndex = 6;
            this.textBoxList.Text = "SaveList Name";
            // 
            // textBoxTrack
            // 
            this.textBoxTrack.Location = new System.Drawing.Point(25, 387);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(283, 22);
            this.textBoxTrack.TabIndex = 5;
            this.textBoxTrack.Text = "Track Name";
            // 
            // checkBoxSave
            // 
            this.checkBoxSave.Location = new System.Drawing.Point(25, 178);
            this.checkBoxSave.Name = "checkBoxSave";
            this.checkBoxSave.Size = new System.Drawing.Size(118, 28);
            this.checkBoxSave.TabIndex = 4;
            this.checkBoxSave.Text = "Save Track";
            this.checkBoxSave.UseVisualStyleBackColor = true;
            this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
            // 
            // checkBoxLike
            // 
            this.checkBoxLike.Location = new System.Drawing.Point(190, 178);
            this.checkBoxLike.Name = "checkBoxLike";
            this.checkBoxLike.Size = new System.Drawing.Size(118, 28);
            this.checkBoxLike.TabIndex = 3;
            this.checkBoxLike.Text = "Like Track";
            this.checkBoxLike.UseVisualStyleBackColor = true;
            this.checkBoxLike.CheckedChanged += new System.EventHandler(this.checkBoxLike_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(176, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(132, 56);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.Gray;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.ForeColor = System.Drawing.Color.Black;
            this.btnCombo.Location = new System.Drawing.Point(25, 30);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(132, 56);
            this.btnCombo.TabIndex = 0;
            this.btnCombo.Text = "Load Combo";
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.lblTimer);
            this.groupBox2.Controls.Add(this.lblPersent);
            this.groupBox2.Controls.Add(this.lblRetry);
            this.groupBox2.Controls.Add(this.lblFail);
            this.groupBox2.Controls.Add(this.lblSuccess);
            this.groupBox2.Controls.Add(this.lblRemain);
            this.groupBox2.Controls.Add(this.lblComplet);
            this.groupBox2.Location = new System.Drawing.Point(379, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 428);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTimer.Location = new System.Drawing.Point(6, 405);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(329, 23);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "00:00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPersent
            // 
            this.lblPersent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPersent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPersent.Location = new System.Drawing.Point(6, 357);
            this.lblPersent.Name = "lblPersent";
            this.lblPersent.Size = new System.Drawing.Size(329, 23);
            this.lblPersent.TabIndex = 5;
            this.lblPersent.Text = "Total: 0% || CPM: 0";
            this.lblPersent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRetry
            // 
            this.lblRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRetry.ForeColor = System.Drawing.Color.Olive;
            this.lblRetry.Location = new System.Drawing.Point(6, 294);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(329, 23);
            this.lblRetry.TabIndex = 4;
            this.lblRetry.Text = "Retry: 0";
            // 
            // lblFail
            // 
            this.lblFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFail.Location = new System.Drawing.Point(6, 225);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(329, 23);
            this.lblFail.TabIndex = 3;
            this.lblFail.Text = "Failure: 0";
            // 
            // lblSuccess
            // 
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSuccess.Location = new System.Drawing.Point(6, 160);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(329, 23);
            this.lblSuccess.TabIndex = 2;
            this.lblSuccess.Text = "Success: 0";
            // 
            // lblRemain
            // 
            this.lblRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblRemain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemain.Location = new System.Drawing.Point(6, 89);
            this.lblRemain.Name = "lblRemain";
            this.lblRemain.Size = new System.Drawing.Size(329, 23);
            this.lblRemain.TabIndex = 1;
            this.lblRemain.Text = "Remaining: 0";
            // 
            // lblComplet
            // 
            this.lblComplet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblComplet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblComplet.Location = new System.Drawing.Point(6, 29);
            this.lblComplet.Name = "lblComplet";
            this.lblComplet.Size = new System.Drawing.Size(329, 23);
            this.lblComplet.TabIndex = 0;
            this.lblComplet.Text = "Completed: 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RJ Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.CheckBox checkBoxSave;
        private System.Windows.Forms.CheckBox checkBoxLike;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.TextBox textBoxTrack;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblPersent;
        private System.Windows.Forms.Label lblRetry;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Label lblRemain;
        private System.Windows.Forms.Label lblComplet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxPlay;
        private System.Windows.Forms.CheckBox checkBoxSync;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxAPI;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.ComboBox comboBoxProxy;
        private System.Windows.Forms.Label label1;
    }
}

