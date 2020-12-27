namespace DiscordFlooder.FrontEnd.View
{
    partial class ApplicationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationView));
            this.titleLabel = new System.Windows.Forms.Label();
            this.openFilePathTokenList = new System.Windows.Forms.OpenFileDialog();
            this.messageDelayLabel = new System.Windows.Forms.Label();
            this.inviteLabel = new System.Windows.Forms.Label();
            this.channelIdLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.tokenListButton = new System.Windows.Forms.Button();
            this.proxyListButton = new System.Windows.Forms.Button();
            this.messageDelayTextBox = new System.Windows.Forms.TextBox();
            this.inviteTextBox = new System.Windows.Forms.TextBox();
            this.channelIdTextBox = new System.Windows.Forms.TextBox();
            this.openFilePathProxyList = new System.Windows.Forms.OpenFileDialog();
            this.executeButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.skipJoinCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titleLabel.Location = new System.Drawing.Point(297, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(500, 33);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Discord Flooder - by alexo and edson";
            // 
            // openFilePathTokenList
            // 
            this.openFilePathTokenList.FileName = "TokenList.txt";
            // 
            // messageDelayLabel
            // 
            this.messageDelayLabel.AutoSize = true;
            this.messageDelayLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageDelayLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageDelayLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.messageDelayLabel.Location = new System.Drawing.Point(12, 133);
            this.messageDelayLabel.Name = "messageDelayLabel";
            this.messageDelayLabel.Size = new System.Drawing.Size(198, 25);
            this.messageDelayLabel.TabIndex = 1;
            this.messageDelayLabel.Text = "Messages delay(ms):";
            // 
            // inviteLabel
            // 
            this.inviteLabel.AutoSize = true;
            this.inviteLabel.BackColor = System.Drawing.Color.Transparent;
            this.inviteLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inviteLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.inviteLabel.Location = new System.Drawing.Point(12, 199);
            this.inviteLabel.Name = "inviteLabel";
            this.inviteLabel.Size = new System.Drawing.Size(157, 25);
            this.inviteLabel.TabIndex = 2;
            this.inviteLabel.Text = "Invite to server:";
            // 
            // channelIdLabel
            // 
            this.channelIdLabel.AutoSize = true;
            this.channelIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.channelIdLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelIdLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.channelIdLabel.Location = new System.Drawing.Point(12, 267);
            this.channelIdLabel.Name = "channelIdLabel";
            this.channelIdLabel.Size = new System.Drawing.Size(116, 25);
            this.channelIdLabel.TabIndex = 3;
            this.channelIdLabel.Text = "Channel Id:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Transparent;
            this.messageLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.messageLabel.Location = new System.Drawing.Point(12, 341);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(93, 25);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Message:";
            // 
            // tokenListButton
            // 
            this.tokenListButton.Location = new System.Drawing.Point(683, 560);
            this.tokenListButton.Name = "tokenListButton";
            this.tokenListButton.Size = new System.Drawing.Size(165, 33);
            this.tokenListButton.TabIndex = 5;
            this.tokenListButton.Text = "Token list";
            this.tokenListButton.UseVisualStyleBackColor = true;
            this.tokenListButton.Click += new System.EventHandler(this.FilePathToTokenList_Click);
            // 
            // proxyListButton
            // 
            this.proxyListButton.Location = new System.Drawing.Point(854, 560);
            this.proxyListButton.Name = "proxyListButton";
            this.proxyListButton.Size = new System.Drawing.Size(187, 33);
            this.proxyListButton.TabIndex = 6;
            this.proxyListButton.Text = "Proxy list";
            this.proxyListButton.UseVisualStyleBackColor = true;
            this.proxyListButton.Click += new System.EventHandler(this.FilePathToProxyList_Click);
            // 
            // messageDelayTextBox
            // 
            this.messageDelayTextBox.Location = new System.Drawing.Point(240, 138);
            this.messageDelayTextBox.Name = "messageDelayTextBox";
            this.messageDelayTextBox.Size = new System.Drawing.Size(143, 20);
            this.messageDelayTextBox.TabIndex = 7;
            this.messageDelayTextBox.Text = "500";
            this.messageDelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.messageDelayTextBox.TextChanged += new System.EventHandler(this.Delay_TextChanged);
            // 
            // inviteTextBox
            // 
            this.inviteTextBox.Location = new System.Drawing.Point(215, 205);
            this.inviteTextBox.Name = "inviteTextBox";
            this.inviteTextBox.Size = new System.Drawing.Size(168, 20);
            this.inviteTextBox.TabIndex = 9;
            this.inviteTextBox.TextChanged += new System.EventHandler(this.Invite_TextChanged);
            // 
            // channelIdTextBox
            // 
            this.channelIdTextBox.Location = new System.Drawing.Point(135, 272);
            this.channelIdTextBox.Name = "channelIdTextBox";
            this.channelIdTextBox.Size = new System.Drawing.Size(248, 20);
            this.channelIdTextBox.TabIndex = 10;
            this.channelIdTextBox.TextChanged += new System.EventHandler(this.ChannelId_TextChanged);
            // 
            // openFilePathProxyList
            // 
            this.openFilePathProxyList.FileName = "ProxyList.txt";
            // 
            // executeButton
            // 
            this.executeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.executeButton.Location = new System.Drawing.Point(17, 560);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(366, 31);
            this.executeButton.TabIndex = 12;
            this.executeButton.Text = "Start";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.AcceptsReturn = true;
            this.messageTextBox.AllowDrop = true;
            this.messageTextBox.Location = new System.Drawing.Point(17, 380);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(366, 151);
            this.messageTextBox.TabIndex = 14;
            this.messageTextBox.Text = "https://github.com/edsonphx/Discord-flooder-V2";
            this.messageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.messageTextBox.TextChanged += new System.EventHandler(this.TextMessage_TextChanged);
            // 
            // skipJoinCheckBox
            // 
            this.skipJoinCheckBox.AutoSize = true;
            this.skipJoinCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.skipJoinCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipJoinCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skipJoinCheckBox.Location = new System.Drawing.Point(215, 231);
            this.skipJoinCheckBox.Name = "skipJoinCheckBox";
            this.skipJoinCheckBox.Size = new System.Drawing.Size(84, 21);
            this.skipJoinCheckBox.TabIndex = 15;
            this.skipJoinCheckBox.Text = "Skip Join";
            this.skipJoinCheckBox.UseVisualStyleBackColor = false;
            this.skipJoinCheckBox.CheckedChanged += new System.EventHandler(this.SkipJoin_CheckedChanged);
            // 
            // ApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DiscordBot_FrontEnd.Properties.Resources.boulos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 638);
            this.Controls.Add(this.skipJoinCheckBox);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.channelIdTextBox);
            this.Controls.Add(this.inviteTextBox);
            this.Controls.Add(this.messageDelayTextBox);
            this.Controls.Add(this.proxyListButton);
            this.Controls.Add(this.tokenListButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.channelIdLabel);
            this.Controls.Add(this.inviteLabel);
            this.Controls.Add(this.messageDelayLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApplicationView";
            this.Text = "Discord Flooder";
            this.FormClosing += Form_Close;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.Label messageDelayLabel;
        private System.Windows.Forms.TextBox messageDelayTextBox;

        private System.Windows.Forms.Label inviteLabel;
        private System.Windows.Forms.TextBox inviteTextBox;
        private System.Windows.Forms.CheckBox skipJoinCheckBox;

        private System.Windows.Forms.Label channelIdLabel;
        private System.Windows.Forms.TextBox channelIdTextBox;

        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox messageTextBox;

        private System.Windows.Forms.Button tokenListButton;
        private System.Windows.Forms.OpenFileDialog openFilePathTokenList;
        
        private System.Windows.Forms.Button proxyListButton;
        private System.Windows.Forms.OpenFileDialog openFilePathProxyList;

        private System.Windows.Forms.Button executeButton;
    }
}

