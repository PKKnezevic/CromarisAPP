using System;
using System.ComponentModel;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormRIF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.AddUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderBox = new System.Windows.Forms.TextBox();
            this.InvestmentBox = new System.Windows.Forms.TextBox();
            this.DMSBox = new System.Windows.Forms.TextBox();
            this.ReceiptBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddUser
            // 
            this.AddUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddUser.Location = new System.Drawing.Point(0, 298);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(382, 55);
            this.AddUser.TabIndex = 0;
            this.AddUser.Text = "Dodaj";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Narudzbenica:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Racun:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "DMS Broj:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(25, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Investicijski nalog:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderBox
            // 
            this.OrderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderBox.Location = new System.Drawing.Point(200, 30);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Size = new System.Drawing.Size(100, 30);
            this.OrderBox.TabIndex = 5;
            // 
            // InvestmentBox
            // 
            this.InvestmentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InvestmentBox.Location = new System.Drawing.Point(200, 180);
            this.InvestmentBox.Name = "InvestmentBox";
            this.InvestmentBox.Size = new System.Drawing.Size(100, 30);
            this.InvestmentBox.TabIndex = 6;
            // 
            // DMSBox
            // 
            this.DMSBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DMSBox.Location = new System.Drawing.Point(200, 130);
            this.DMSBox.Name = "DMSBox";
            this.DMSBox.Size = new System.Drawing.Size(100, 30);
            this.DMSBox.TabIndex = 7;
            // 
            // ReceiptBox
            // 
            this.ReceiptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceiptBox.Location = new System.Drawing.Point(200, 80);
            this.ReceiptBox.Name = "ReceiptBox";
            this.ReceiptBox.Size = new System.Drawing.Size(100, 30);
            this.ReceiptBox.TabIndex = 8;
            // 
            // TableFormRIF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ReceiptBox);
            this.Controls.Add(this.DMSBox);
            this.Controls.Add(this.InvestmentBox);
            this.Controls.Add(this.OrderBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddUser);
            this.Name = "TableFormRIF";
            this.Text = "RIF";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderBox;
        private System.Windows.Forms.TextBox InvestmentBox;
        private System.Windows.Forms.TextBox DMSBox;
        private System.Windows.Forms.TextBox ReceiptBox;

        #endregion
    }
}