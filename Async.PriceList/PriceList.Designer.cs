namespace Async.PriceList
{
    partial class PriceList
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
            this.label_Username = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Logs = new System.Windows.Forms.TextBox();
            this.splitContainer_PriceList = new System.Windows.Forms.SplitContainer();
            this.listBox_PriceList = new System.Windows.Forms.ListBox();
            this.label_UsernameNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_PriceList)).BeginInit();
            this.splitContainer_PriceList.Panel1.SuspendLayout();
            this.splitContainer_PriceList.Panel2.SuspendLayout();
            this.splitContainer_PriceList.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(12, 15);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(141, 34);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Username";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(82, 12);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(153, 41);
            this.textBox_Username.TabIndex = 1;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(12, 59);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(132, 34);
            this.label_Password.TabIndex = 2;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(82, 56);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(153, 41);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(82, 83);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 4;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Logs
            // 
            this.textBox_Logs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Logs.Location = new System.Drawing.Point(0, 0);
            this.textBox_Logs.Multiline = true;
            this.textBox_Logs.Name = "textBox_Logs";
            this.textBox_Logs.Size = new System.Drawing.Size(748, 714);
            this.textBox_Logs.TabIndex = 5;
            // 
            // splitContainer_PriceList
            // 
            this.splitContainer_PriceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer_PriceList.Location = new System.Drawing.Point(15, 112);
            this.splitContainer_PriceList.Name = "splitContainer_PriceList";
            // 
            // splitContainer_PriceList.Panel1
            // 
            this.splitContainer_PriceList.Panel1.Controls.Add(this.listBox_PriceList);
            // 
            // splitContainer_PriceList.Panel2
            // 
            this.splitContainer_PriceList.Panel2.Controls.Add(this.textBox_Logs);
            this.splitContainer_PriceList.Size = new System.Drawing.Size(1420, 714);
            this.splitContainer_PriceList.SplitterDistance = 668;
            this.splitContainer_PriceList.TabIndex = 6;
            // 
            // listBox_PriceList
            // 
            this.listBox_PriceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_PriceList.FormattingEnabled = true;
            this.listBox_PriceList.ItemHeight = 33;
            this.listBox_PriceList.Location = new System.Drawing.Point(0, 0);
            this.listBox_PriceList.Name = "listBox_PriceList";
            this.listBox_PriceList.Size = new System.Drawing.Size(668, 714);
            this.listBox_PriceList.TabIndex = 0;
            // 
            // label_UsernameNote
            // 
            this.label_UsernameNote.AutoSize = true;
            this.label_UsernameNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_UsernameNote.Location = new System.Drawing.Point(79, 36);
            this.label_UsernameNote.Name = "label_UsernameNote";
            this.label_UsernameNote.Size = new System.Drawing.Size(654, 34);
            this.label_UsernameNote.TabIndex = 7;
            this.label_UsernameNote.Text = "A Username that starts with a \"j\" returns a success";
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 838);
            this.Controls.Add(this.label_UsernameNote);
            this.Controls.Add(this.splitContainer_PriceList);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Username);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "PriceList";
            this.Text = "Pricelist";
            this.Load += new System.EventHandler(this.PriceList_Load);
            this.splitContainer_PriceList.Panel1.ResumeLayout(false);
            this.splitContainer_PriceList.Panel2.ResumeLayout(false);
            this.splitContainer_PriceList.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_PriceList)).EndInit();
            this.splitContainer_PriceList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Logs;
        private System.Windows.Forms.SplitContainer splitContainer_PriceList;
        private System.Windows.Forms.ListBox listBox_PriceList;
        private System.Windows.Forms.Label label_UsernameNote;
    }
}

