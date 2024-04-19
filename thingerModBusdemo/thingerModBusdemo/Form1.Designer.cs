
namespace thingerModBusdemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cmb_Port = new ComboBox();
            btn_Connect = new Button();
            btn_CloseConnect = new Button();
            btn_Read1 = new Button();
            txt_Humidity1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_Temp1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 94);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "串口号：";
            label1.Click += label1_Click;
            // 
            // cmb_Port
            // 
            cmb_Port.FormattingEnabled = true;
            cmb_Port.Location = new Point(193, 86);
            cmb_Port.Name = "cmb_Port";
            cmb_Port.Size = new Size(151, 28);
            cmb_Port.TabIndex = 1;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(389, 85);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(94, 29);
            btn_Connect.TabIndex = 2;
            btn_Connect.Text = "建立连接";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_CloseConnect
            // 
            btn_CloseConnect.Location = new Point(531, 85);
            btn_CloseConnect.Name = "btn_CloseConnect";
            btn_CloseConnect.Size = new Size(94, 29);
            btn_CloseConnect.TabIndex = 3;
            btn_CloseConnect.Text = "断开连接";
            btn_CloseConnect.UseVisualStyleBackColor = true;
            btn_CloseConnect.Click += btn_CloseConnect_Click;
            // 
            // btn_Read1
            // 
            btn_Read1.Location = new Point(103, 173);
            btn_Read1.Name = "btn_Read1";
            btn_Read1.Size = new Size(116, 55);
            btn_Read1.TabIndex = 4;
            btn_Read1.Text = "读取1号温湿度";
            btn_Read1.UseVisualStyleBackColor = true;
            // 
            // txt_Humidity1
            // 
            txt_Humidity1.BackColor = SystemColors.InfoText;
            txt_Humidity1.ForeColor = Color.Lime;
            txt_Humidity1.Location = new Point(332, 148);
            txt_Humidity1.Name = "txt_Humidity1";
            txt_Humidity1.Size = new Size(250, 27);
            txt_Humidity1.TabIndex = 5;
            txt_Humidity1.Text = "0";
            txt_Humidity1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 155);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "温度：";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(239, 201);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "湿度：";
            // 
            // txt_Temp1
            // 
            txt_Temp1.BackColor = SystemColors.InfoText;
            txt_Temp1.ForeColor = Color.Lime;
            txt_Temp1.Location = new Point(332, 201);
            txt_Temp1.Name = "txt_Temp1";
            txt_Temp1.Size = new Size(250, 27);
            txt_Temp1.TabIndex = 8;
            txt_Temp1.Text = "0";
            txt_Temp1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Temp1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Humidity1);
            Controls.Add(btn_Read1);
            Controls.Add(btn_CloseConnect);
            Controls.Add(btn_Connect);
            Controls.Add(cmb_Port);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private ComboBox cmb_Port;
        private Button btn_Connect;
        private Button btn_CloseConnect;
        private Button btn_Read1;
        private TextBox txt_Humidity1;
        private Label label2;
        private Label label3;
        private TextBox txt_Temp1;
    }
}
