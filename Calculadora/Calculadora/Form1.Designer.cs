﻿
namespace Calculadora
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
            this.n1Tb = new System.Windows.Forms.TextBox();
            this.n2Tb = new System.Windows.Forms.TextBox();
            this.somarBt = new System.Windows.Forms.Button();
            this.saidaLb = new System.Windows.Forms.Label();
            this.subtrairBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // n1Tb
            // 
            this.n1Tb.Location = new System.Drawing.Point(238, 137);
            this.n1Tb.Name = "n1Tb";
            this.n1Tb.Size = new System.Drawing.Size(300, 55);
            this.n1Tb.TabIndex = 0;
            // 
            // n2Tb
            // 
            this.n2Tb.Location = new System.Drawing.Point(238, 243);
            this.n2Tb.Name = "n2Tb";
            this.n2Tb.Size = new System.Drawing.Size(300, 55);
            this.n2Tb.TabIndex = 1;
            // 
            // somarBt
            // 
            this.somarBt.Location = new System.Drawing.Point(238, 403);
            this.somarBt.Name = "somarBt";
            this.somarBt.Size = new System.Drawing.Size(225, 69);
            this.somarBt.TabIndex = 2;
            this.somarBt.Text = "+";
            this.somarBt.UseVisualStyleBackColor = true;
            this.somarBt.Click += new System.EventHandler(this.somarBt_Click);
            // 
            // saidaLb
            // 
            this.saidaLb.AutoSize = true;
            this.saidaLb.Location = new System.Drawing.Point(238, 582);
            this.saidaLb.Name = "saidaLb";
            this.saidaLb.Size = new System.Drawing.Size(39, 48);
            this.saidaLb.TabIndex = 3;
            this.saidaLb.Text = "0";
            // 
            // subtrairBt
            // 
            this.subtrairBt.Location = new System.Drawing.Point(580, 402);
            this.subtrairBt.Name = "subtrairBt";
            this.subtrairBt.Size = new System.Drawing.Size(225, 69);
            this.subtrairBt.TabIndex = 4;
            this.subtrairBt.Text = "-";
            this.subtrairBt.UseVisualStyleBackColor = true;
            this.subtrairBt.Click += new System.EventHandler(this.subtrairBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(626, 137);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(225, 69);
            this.clearBt.TabIndex = 5;
            this.clearBt.Text = "clear";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 969);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.subtrairBt);
            this.Controls.Add(this.saidaLb);
            this.Controls.Add(this.somarBt);
            this.Controls.Add(this.n2Tb);
            this.Controls.Add(this.n1Tb);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox n1Tb;
        private System.Windows.Forms.TextBox n2Tb;
        private System.Windows.Forms.Button somarBt;
        private System.Windows.Forms.Label saidaLb;
        private System.Windows.Forms.Button subtrairBt;
        private System.Windows.Forms.Button clearBt;
    }
}

