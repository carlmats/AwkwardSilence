﻿namespace NoAwkwardSilence
{
    partial class MainForm
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
            this.updateBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sourceListBox = new System.Windows.Forms.CheckedListBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delayTrackBar = new System.Windows.Forms.TrackBar();
            this.toleranceTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playRadio = new System.Windows.Forms.RadioButton();
            this.muteRadio = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(32, 209);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(69, 23);
            this.updateBtn.TabIndex = 0;
            this.updateBtn.Text = "Refresh";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(100, 209);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sourceListBox
            // 
            this.sourceListBox.FormattingEnabled = true;
            this.sourceListBox.Location = new System.Drawing.Point(12, 34);
            this.sourceListBox.Name = "sourceListBox";
            this.sourceListBox.Size = new System.Drawing.Size(120, 169);
            this.sourceListBox.TabIndex = 3;
            this.sourceListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.sourceListBox_ItemCheck);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(186, 209);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 4;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Enabled = false;
            this.logTextBox.Location = new System.Drawing.Point(100, 109);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(161, 81);
            this.logTextBox.TabIndex = 5;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 46);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.sourceListBox);
            this.splitContainer.Panel1.Controls.Add(this.updateBtn);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.label4);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.label2);
            this.splitContainer.Panel2.Controls.Add(this.delayTrackBar);
            this.splitContainer.Panel2.Controls.Add(this.toleranceTrackBar);
            this.splitContainer.Panel2.Controls.Add(this.startBtn);
            this.splitContainer.Panel2.Controls.Add(this.logTextBox);
            this.splitContainer.Panel2.Controls.Add(this.stopBtn);
            this.splitContainer.Panel2.Enabled = false;
            this.splitContainer.Size = new System.Drawing.Size(414, 251);
            this.splitContainer.SplitterDistance = 137;
            this.splitContainer.TabIndex = 6;
            this.splitContainer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sound sources";
            this.toolTip1.SetToolTip(this.label1, "Mute/Unmute this sound source. If it does not show up in the list, try playing so" +
        "me sound from the source and press refresh");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Delay until unmute (s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sound tolerance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Debug log";
            // 
            // delayTrackBar
            // 
            this.delayTrackBar.Location = new System.Drawing.Point(110, 7);
            this.delayTrackBar.Name = "delayTrackBar";
            this.delayTrackBar.Size = new System.Drawing.Size(160, 45);
            this.delayTrackBar.TabIndex = 7;
            this.delayTrackBar.Tag = "";
            this.toolTip1.SetToolTip(this.delayTrackBar, "The delay between the sound going quiet and unmuting the sound source");
            this.delayTrackBar.Value = 3;
            // 
            // toleranceTrackBar
            // 
            this.toleranceTrackBar.Location = new System.Drawing.Point(110, 58);
            this.toleranceTrackBar.Name = "toleranceTrackBar";
            this.toleranceTrackBar.Size = new System.Drawing.Size(160, 45);
            this.toleranceTrackBar.TabIndex = 6;
            this.toleranceTrackBar.TickFrequency = 2;
            this.toolTip1.SetToolTip(this.toleranceTrackBar, "Tweak this slider to make the program tolerate more ambient noise (i.e. higher vo" +
        "lume is required to trigger the sound source)");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playRadio);
            this.groupBox1.Controls.Add(this.muteRadio);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 46);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // playRadio
            // 
            this.playRadio.AutoSize = true;
            this.playRadio.Location = new System.Drawing.Point(221, 19);
            this.playRadio.Name = "playRadio";
            this.playRadio.Size = new System.Drawing.Size(86, 17);
            this.playRadio.TabIndex = 1;
            this.playRadio.TabStop = true;
            this.playRadio.Text = "Play / Pause";
            this.playRadio.UseVisualStyleBackColor = true;
            // 
            // muteRadio
            // 
            this.muteRadio.AutoSize = true;
            this.muteRadio.Location = new System.Drawing.Point(89, 19);
            this.muteRadio.Name = "muteRadio";
            this.muteRadio.Size = new System.Drawing.Size(97, 17);
            this.muteRadio.TabIndex = 0;
            this.muteRadio.TabStop = true;
            this.muteRadio.Text = "Mute / Unmute";
            this.muteRadio.UseVisualStyleBackColor = true;
            this.muteRadio.CheckedChanged += new System.EventHandler(this.muteRadio_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 297);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "AwkwardSilence - BETA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.delayTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckedListBox sourceListBox;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton playRadio;
        private System.Windows.Forms.RadioButton muteRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar delayTrackBar;
        private System.Windows.Forms.TrackBar toleranceTrackBar;
    }
}
