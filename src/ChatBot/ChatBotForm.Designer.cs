namespace ChatBot
{
    partial class ChatBotForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatBotForm));
            this.txtReply = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetReply = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonSpeech = new System.Windows.Forms.RadioButton();
            this.radioButtonHand = new System.Windows.Forms.RadioButton();
            this.btnSpeech = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReply
            // 
            this.txtReply.Location = new System.Drawing.Point(12, 96);
            this.txtReply.Multiline = true;
            this.txtReply.Name = "txtReply";
            this.txtReply.ReadOnly = true;
            this.txtReply.Size = new System.Drawing.Size(274, 124);
            this.txtReply.TabIndex = 1;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 43);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(274, 21);
            this.txtSend.TabIndex = 0;
            this.txtSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSend_KeyPress);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(424, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(209, 22);
            this.loadMenuItem.Text = "Choose KnowledgeBase...";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(209, 22);
            this.exitMenuItem.Text = "Quit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // btnGetReply
            // 
            this.btnGetReply.Location = new System.Drawing.Point(305, 43);
            this.btnGetReply.Name = "btnGetReply";
            this.btnGetReply.Size = new System.Drawing.Size(99, 21);
            this.btnGetReply.TabIndex = 3;
            this.btnGetReply.Text = "Get Reply";
            this.btnGetReply.UseVisualStyleBackColor = true;
            this.btnGetReply.Click += new System.EventHandler(this.btnGetReply_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.radioButtonSpeech);
            this.panel1.Controls.Add(this.radioButtonHand);
            this.panel1.Location = new System.Drawing.Point(305, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 88);
            this.panel1.TabIndex = 4;
            // 
            // radioButtonSpeech
            // 
            this.radioButtonSpeech.AutoSize = true;
            this.radioButtonSpeech.Location = new System.Drawing.Point(18, 18);
            this.radioButtonSpeech.Name = "radioButtonSpeech";
            this.radioButtonSpeech.Size = new System.Drawing.Size(59, 16);
            this.radioButtonSpeech.TabIndex = 1;
            this.radioButtonSpeech.Text = "Speech";
            this.radioButtonSpeech.UseVisualStyleBackColor = true;
            this.radioButtonSpeech.CheckedChanged += new System.EventHandler(this.radioButtonSpeech_CheckedChanged);
            // 
            // radioButtonHand
            // 
            this.radioButtonHand.AutoSize = true;
            this.radioButtonHand.Checked = true;
            this.radioButtonHand.Location = new System.Drawing.Point(18, 52);
            this.radioButtonHand.Name = "radioButtonHand";
            this.radioButtonHand.Size = new System.Drawing.Size(47, 16);
            this.radioButtonHand.TabIndex = 0;
            this.radioButtonHand.TabStop = true;
            this.radioButtonHand.Text = "Text";
            this.radioButtonHand.UseVisualStyleBackColor = true;
            this.radioButtonHand.CheckedChanged += new System.EventHandler(this.radioButtonHand_CheckedChanged);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Enabled = false;
            this.btnSpeech.Location = new System.Drawing.Point(305, 199);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(99, 21);
            this.btnSpeech.TabIndex = 5;
            this.btnSpeech.Text = "Start";
            this.btnSpeech.UseVisualStyleBackColor = true;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            // 
            // ChatBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 245);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetReply);
            this.Controls.Add(this.txtReply);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "ChatBotForm";
            this.Text = "ChatBot";
            this.Load += new System.EventHandler(this.ChatBotForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReply;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Button btnGetReply;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonSpeech;
        private System.Windows.Forms.RadioButton radioButtonHand;
        private System.Windows.Forms.Button btnSpeech;
    }
}

