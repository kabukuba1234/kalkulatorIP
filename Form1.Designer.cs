﻿
namespace KalkulatorIP2
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
            this.IPAdressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.networkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IPAdressTextBox
            // 
            this.IPAdressTextBox.Location = new System.Drawing.Point(214, 12);
            this.IPAdressTextBox.Mask = "###\\.###\\.###\\.###";
            this.IPAdressTextBox.Name = "IPAdressTextBox";
            this.IPAdressTextBox.Size = new System.Drawing.Size(89, 23);
            this.IPAdressTextBox.TabIndex = 0;
            this.IPAdressTextBox.Text = "255255255255";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adres IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Maska:";
            // 
            // maskTextBox
            // 
            this.maskTextBox.Location = new System.Drawing.Point(214, 41);
            this.maskTextBox.Mask = "###\\.###\\.###\\.###";
            this.maskTextBox.Name = "maskTextBox";
            this.maskTextBox.Size = new System.Drawing.Size(89, 23);
            this.maskTextBox.TabIndex = 2;
            this.maskTextBox.Text = "255255255255";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(309, 18);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(94, 45);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Policz";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres sieci:";
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(214, 67);
            this.networkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(89, 23);
            this.networkAddressTextBox.TabIndex = 5;
            this.networkAddressTextBox.Text = "055055055055";
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(214, 96);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(89, 23);
            this.BroadcastTextBox.TabIndex = 7;
            this.BroadcastTextBox.Text = "055055055055";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres rozgłoszeniowy:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAdressTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IPAdressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox networkAddressTextBox;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label4;
    }
}

