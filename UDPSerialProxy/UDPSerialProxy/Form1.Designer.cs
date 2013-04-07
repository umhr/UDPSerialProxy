namespace UDPSerialProxy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.S2UButton = new System.Windows.Forms.Button();
            this.covertLabel = new System.Windows.Forms.Label();
            this.U2SButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.bauRateComboBox = new System.Windows.Forms.ComboBox();
            this.openButton = new System.Windows.Forms.Button();
            this.portselectComboBox = new System.Windows.Forms.ComboBox();
            this.messageTextBoxSerial = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.logTextBoxSerial = new System.Windows.Forms.TextBox();
            this.recivePortTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.targetIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetPortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "BaudRate:";
            // 
            // S2UButton
            // 
            this.S2UButton.Location = new System.Drawing.Point(275, 164);
            this.S2UButton.Name = "S2UButton";
            this.S2UButton.Size = new System.Drawing.Size(75, 23);
            this.S2UButton.TabIndex = 35;
            this.S2UButton.Text = "Serial2UDP";
            this.S2UButton.UseVisualStyleBackColor = true;
            this.S2UButton.Click += new System.EventHandler(this.S2UButton_Click);
            // 
            // covertLabel
            // 
            this.covertLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.covertLabel.Location = new System.Drawing.Point(291, 133);
            this.covertLabel.Name = "covertLabel";
            this.covertLabel.Size = new System.Drawing.Size(40, 12);
            this.covertLabel.TabIndex = 34;
            this.covertLabel.Text = "|";
            this.covertLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // U2SButton
            // 
            this.U2SButton.Location = new System.Drawing.Point(275, 94);
            this.U2SButton.Name = "U2SButton";
            this.U2SButton.Size = new System.Drawing.Size(75, 23);
            this.U2SButton.TabIndex = 33;
            this.U2SButton.Text = "UDP2Serial";
            this.U2SButton.UseVisualStyleBackColor = true;
            this.U2SButton.Click += new System.EventHandler(this.U2SButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // bauRateComboBox
            // 
            this.bauRateComboBox.FormattingEnabled = true;
            this.bauRateComboBox.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.bauRateComboBox.Location = new System.Drawing.Point(61, 50);
            this.bauRateComboBox.Name = "bauRateComboBox";
            this.bauRateComboBox.Size = new System.Drawing.Size(121, 20);
            this.bauRateComboBox.TabIndex = 26;
            this.bauRateComboBox.Text = "9600";
            // 
            // openButton
            // 
            this.openButton.Enabled = false;
            this.openButton.Location = new System.Drawing.Point(188, 21);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 24;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // portselectComboBox
            // 
            this.portselectComboBox.FormattingEnabled = true;
            this.portselectComboBox.Location = new System.Drawing.Point(61, 23);
            this.portselectComboBox.Name = "portselectComboBox";
            this.portselectComboBox.Size = new System.Drawing.Size(121, 20);
            this.portselectComboBox.TabIndex = 23;
            // 
            // messageTextBoxSerial
            // 
            this.messageTextBoxSerial.Location = new System.Drawing.Point(357, 256);
            this.messageTextBoxSerial.Name = "messageTextBoxSerial";
            this.messageTextBoxSerial.Size = new System.Drawing.Size(180, 19);
            this.messageTextBoxSerial.TabIndex = 32;
            // 
            // writeButton
            // 
            this.writeButton.Enabled = false;
            this.writeButton.Location = new System.Drawing.Point(543, 253);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(75, 23);
            this.writeButton.TabIndex = 31;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(2, 106);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(260, 161);
            this.logTextBox.TabIndex = 11;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(187, 75);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 10;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // logTextBoxSerial
            // 
            this.logTextBoxSerial.Location = new System.Drawing.Point(357, 82);
            this.logTextBoxSerial.Multiline = true;
            this.logTextBoxSerial.Name = "logTextBoxSerial";
            this.logTextBoxSerial.ReadOnly = true;
            this.logTextBoxSerial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextBoxSerial.Size = new System.Drawing.Size(260, 166);
            this.logTextBoxSerial.TabIndex = 30;
            // 
            // recivePortTextBox
            // 
            this.recivePortTextBox.Location = new System.Drawing.Point(131, 25);
            this.recivePortTextBox.Name = "recivePortTextBox";
            this.recivePortTextBox.Size = new System.Drawing.Size(50, 19);
            this.recivePortTextBox.TabIndex = 12;
            this.recivePortTextBox.Text = "8989";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(187, 23);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 13;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "IPAddress";
            // 
            // targetIPTextBox
            // 
            this.targetIPTextBox.Location = new System.Drawing.Point(59, 52);
            this.targetIPTextBox.Name = "targetIPTextBox";
            this.targetIPTextBox.Size = new System.Drawing.Size(85, 19);
            this.targetIPTextBox.TabIndex = 15;
            this.targetIPTextBox.Text = "192.168.0.255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "送信先";
            // 
            // targetPortTextBox
            // 
            this.targetPortTextBox.Location = new System.Drawing.Point(150, 52);
            this.targetPortTextBox.Name = "targetPortTextBox";
            this.targetPortTextBox.Size = new System.Drawing.Size(50, 19);
            this.targetPortTextBox.TabIndex = 17;
            this.targetPortTextBox.Text = "7777";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logTextBox);
            this.groupBox1.Controls.Add(this.SendButton);
            this.groupBox1.Controls.Add(this.recivePortTextBox);
            this.groupBox1.Controls.Add(this.connectButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.targetIPTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.targetPortTextBox);
            this.groupBox1.Controls.Add(this.messageTextBox);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 278);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UDP";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(5, 77);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(174, 19);
            this.messageTextBox.TabIndex = 18;
            this.messageTextBox.Text = "Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bauRateComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.openButton);
            this.groupBox2.Controls.Add(this.portselectComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(355, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 278);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 22;
            this.label2.Text = "Serial Port:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 287);
            this.Controls.Add(this.S2UButton);
            this.Controls.Add(this.covertLabel);
            this.Controls.Add(this.U2SButton);
            this.Controls.Add(this.messageTextBoxSerial);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.logTextBoxSerial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "UDPSerialProxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button S2UButton;
        private System.Windows.Forms.Label covertLabel;
        private System.Windows.Forms.Button U2SButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox bauRateComboBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ComboBox portselectComboBox;
        private System.Windows.Forms.TextBox messageTextBoxSerial;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox logTextBoxSerial;
        private System.Windows.Forms.TextBox recivePortTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetPortTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;

    }
}

