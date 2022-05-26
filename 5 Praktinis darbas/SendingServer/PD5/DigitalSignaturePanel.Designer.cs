namespace PD5
{
    partial class DigitalSignaturePanel
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HashButton = new System.Windows.Forms.Button();
            this.ConnectionState = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENT SERVER";
            // 
            // MessageField
            // 
            this.MessageField.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MessageField.Location = new System.Drawing.Point(12, 155);
            this.MessageField.Multiline = true;
            this.MessageField.Name = "MessageField";
            this.MessageField.PlaceholderText = "Message To Hash";
            this.MessageField.Size = new System.Drawing.Size(523, 75);
            this.MessageField.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input Message";
            // 
            // HashButton
            // 
            this.HashButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.HashButton.FlatAppearance.BorderSize = 0;
            this.HashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HashButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HashButton.ForeColor = System.Drawing.Color.White;
            this.HashButton.Location = new System.Drawing.Point(12, 253);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(523, 58);
            this.HashButton.TabIndex = 3;
            this.HashButton.Text = "Hash Message";
            this.HashButton.UseVisualStyleBackColor = false;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // ConnectionState
            // 
            this.ConnectionState.BackColor = System.Drawing.Color.Silver;
            this.ConnectionState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionState.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectionState.Location = new System.Drawing.Point(12, 560);
            this.ConnectionState.Multiline = true;
            this.ConnectionState.Name = "ConnectionState";
            this.ConnectionState.PlaceholderText = "No Connection Established";
            this.ConnectionState.Size = new System.Drawing.Size(523, 86);
            this.ConnectionState.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(12, 461);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(523, 58);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect To Server And Send Data";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 532);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Connection State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 327);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hash State";
            // 
            // OutputField
            // 
            this.OutputField.BackColor = System.Drawing.Color.Silver;
            this.OutputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputField.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputField.Location = new System.Drawing.Point(12, 355);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.PlaceholderText = "No Data Available";
            this.OutputField.Size = new System.Drawing.Size(523, 71);
            this.OutputField.TabIndex = 8;
            // 
            // DigitalSignaturePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 664);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ConnectionState);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessageField);
            this.Controls.Add(this.panel1);
            this.Name = "DigitalSignaturePanel";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox MessageField;
        private Label label2;
        private Button HashButton;
        private TextBox ConnectionState;
        private Button ConnectButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private Label label4;
        private TextBox OutputField;
    }
}