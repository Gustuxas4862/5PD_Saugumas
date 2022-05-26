namespace ReceiverServer
{
    partial class ServerPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerState = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceivedText = new System.Windows.Forms.TextBox();
            this.VerifyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MessageField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER INTERFACE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 99);
            this.panel1.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(12, 125);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(536, 58);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start Server";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Server State";
            // 
            // ServerState
            // 
            this.ServerState.BackColor = System.Drawing.Color.Silver;
            this.ServerState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServerState.Location = new System.Drawing.Point(12, 227);
            this.ServerState.Multiline = true;
            this.ServerState.Name = "ServerState";
            this.ServerState.PlaceholderText = "No Data Available";
            this.ServerState.Size = new System.Drawing.Size(536, 56);
            this.ServerState.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 521);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Received";
            // 
            // ReceivedText
            // 
            this.ReceivedText.BackColor = System.Drawing.Color.Silver;
            this.ReceivedText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceivedText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReceivedText.Location = new System.Drawing.Point(12, 549);
            this.ReceivedText.Multiline = true;
            this.ReceivedText.Name = "ReceivedText";
            this.ReceivedText.PlaceholderText = "No Data Available";
            this.ReceivedText.Size = new System.Drawing.Size(536, 166);
            this.ReceivedText.TabIndex = 12;
            // 
            // VerifyButton
            // 
            this.VerifyButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.VerifyButton.FlatAppearance.BorderSize = 0;
            this.VerifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VerifyButton.ForeColor = System.Drawing.Color.White;
            this.VerifyButton.Location = new System.Drawing.Point(12, 443);
            this.VerifyButton.Name = "VerifyButton";
            this.VerifyButton.Size = new System.Drawing.Size(536, 58);
            this.VerifyButton.TabIndex = 14;
            this.VerifyButton.Text = "Verify Signature";
            this.VerifyButton.UseVisualStyleBackColor = false;
            this.VerifyButton.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 315);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Input Message";
            // 
            // MessageField
            // 
            this.MessageField.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageField.Location = new System.Drawing.Point(12, 343);
            this.MessageField.Multiline = true;
            this.MessageField.Name = "MessageField";
            this.MessageField.PlaceholderText = "Message";
            this.MessageField.Size = new System.Drawing.Size(536, 75);
            this.MessageField.TabIndex = 15;
            // 
            // ServerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 740);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.VerifyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReceivedText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServerState);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.panel1);
            this.Name = "ServerPanel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button StartButton;
        private Label label4;
        private TextBox ServerState;
        private Label label2;
        private TextBox ReceivedText;
        private Button VerifyButton;
        private Label label3;
        private TextBox MessageField;
    }
}