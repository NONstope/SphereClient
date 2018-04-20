namespace SphereClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.programList = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.feedback = new System.Windows.Forms.TabPage();
            this.bugReport = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.feedback.SuspendLayout();
            this.bugReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // programList
            // 
            this.programList.FormattingEnabled = true;
            this.programList.Location = new System.Drawing.Point(17, 26);
            this.programList.Name = "programList";
            this.programList.Size = new System.Drawing.Size(322, 21);
            this.programList.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.feedback);
            this.tabControl1.Controls.Add(this.bugReport);
            this.tabControl1.Location = new System.Drawing.Point(17, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 275);
            this.tabControl1.TabIndex = 1;
            // 
            // feedback
            // 
            this.feedback.Controls.Add(this.comboBox1);
            this.feedback.Controls.Add(this.button2);
            this.feedback.Controls.Add(this.richTextBox2);
            this.feedback.Controls.Add(this.label2);
            this.feedback.Location = new System.Drawing.Point(4, 22);
            this.feedback.Name = "feedback";
            this.feedback.Padding = new System.Windows.Forms.Padding(3);
            this.feedback.Size = new System.Drawing.Size(314, 249);
            this.feedback.TabIndex = 0;
            this.feedback.Text = "Feedback";
            this.feedback.UseVisualStyleBackColor = true;
            // 
            // bugReport
            // 
            this.bugReport.Controls.Add(this.label1);
            this.bugReport.Controls.Add(this.richTextBox1);
            this.bugReport.Controls.Add(this.button1);
            this.bugReport.Location = new System.Drawing.Point(4, 22);
            this.bugReport.Name = "bugReport";
            this.bugReport.Padding = new System.Windows.Forms.Padding(3);
            this.bugReport.Size = new System.Drawing.Size(314, 249);
            this.bugReport.TabIndex = 1;
            this.bugReport.Text = "Bug report";
            this.bugReport.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 63);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(255, 128);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Write about the bug you get";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Give us some feedback about these program";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(30, 100);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(250, 85);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(30, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Raiting";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Open Sphere";
            this.notifyIcon.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.programList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Sphere";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.tabControl1.ResumeLayout(false);
            this.feedback.ResumeLayout(false);
            this.feedback.PerformLayout();
            this.bugReport.ResumeLayout(false);
            this.bugReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox programList;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage feedback;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage bugReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}