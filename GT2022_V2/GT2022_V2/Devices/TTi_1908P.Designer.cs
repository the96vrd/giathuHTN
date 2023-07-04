namespace GT2022_V2.Devices
{
    partial class TTi_1908P
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
            this.comboBox_command = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_SET = new System.Windows.Forms.Button();
            this.textBox_Feedback = new System.Windows.Forms.TextBox();
            this.button_GET = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Notes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_command
            // 
            this.comboBox_command.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_command.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_command.FormattingEnabled = true;
            this.comboBox_command.Items.AddRange(new object[] {
            "VDC 10V",
            "VAC 100V",
            "OHMS",
            "READ?"});
            this.comboBox_command.Location = new System.Drawing.Point(133, 50);
            this.comboBox_command.Name = "comboBox_command";
            this.comboBox_command.Size = new System.Drawing.Size(314, 26);
            this.comboBox_command.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEST MULTIMETER TTi 1908P";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feedback:";
            // 
            // button_SET
            // 
            this.button_SET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_SET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SET.Location = new System.Drawing.Point(453, 49);
            this.button_SET.Name = "button_SET";
            this.button_SET.Size = new System.Drawing.Size(90, 28);
            this.button_SET.TabIndex = 5;
            this.button_SET.Text = "SET";
            this.button_SET.UseVisualStyleBackColor = true;
            this.button_SET.Click += new System.EventHandler(this.button_SET_Click);
            // 
            // textBox_Feedback
            // 
            this.textBox_Feedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Feedback.Location = new System.Drawing.Point(133, 88);
            this.textBox_Feedback.Name = "textBox_Feedback";
            this.textBox_Feedback.Size = new System.Drawing.Size(314, 24);
            this.textBox_Feedback.TabIndex = 6;
            // 
            // button_GET
            // 
            this.button_GET.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_GET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GET.Location = new System.Drawing.Point(453, 86);
            this.button_GET.Name = "button_GET";
            this.button_GET.Size = new System.Drawing.Size(90, 28);
            this.button_GET.TabIndex = 7;
            this.button_GET.Text = "GET";
            this.button_GET.UseVisualStyleBackColor = true;
            this.button_GET.Click += new System.EventHandler(this.button_GET_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Notes);
            this.panel1.Location = new System.Drawing.Point(53, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 189);
            this.panel1.TabIndex = 8;
            // 
            // label_Notes
            // 
            this.label_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Notes.Location = new System.Drawing.Point(0, 0);
            this.label_Notes.Name = "label_Notes";
            this.label_Notes.Size = new System.Drawing.Size(490, 189);
            this.label_Notes.TabIndex = 0;
            this.label_Notes.Text = "             ";
            // 
            // TTi_1908P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_GET);
            this.Controls.Add(this.textBox_Feedback);
            this.Controls.Add(this.button_SET);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_command);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TTi_1908P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multimeter TTi 1908P";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTi_1908P_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TTi_1908P_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_command;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_SET;
        private System.Windows.Forms.TextBox textBox_Feedback;
        private System.Windows.Forms.Button button_GET;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Notes;
    }
}