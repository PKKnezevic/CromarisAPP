using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormZaduzenjec
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
            this.KadrovskiBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brojOpremeBox = new System.Windows.Forms.Label();
            this.addZaduzenje = new System.Windows.Forms.Button();
            this.datZaduzenjaDTP = new System.Windows.Forms.DateTimePicker();
            this.datRazduzenjaDTP = new System.Windows.Forms.DateTimePicker();
            this.cadrovskiBox = new System.Windows.Forms.TextBox();
            this.internalBox = new System.Windows.Forms.TextBox();
            this.flokBox = new System.Windows.Forms.TextBox();
            this.imtBox = new System.Windows.Forms.TextBox();
            this.rifBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KadrovskiBox
            // 
            this.KadrovskiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KadrovskiBox.Location = new System.Drawing.Point(15, 20);
            this.KadrovskiBox.Name = "KadrovskiBox";
            this.KadrovskiBox.Size = new System.Drawing.Size(203, 23);
            this.KadrovskiBox.TabIndex = 0;
            this.KadrovskiBox.Text = "Kadrovski broj:";
            this.KadrovskiBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(450, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "RIF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(428, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMT:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(428, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "FLOK:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(60, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum razduzenja:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Datum zaduzenja:\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // brojOpremeBox
            // 
            this.brojOpremeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojOpremeBox.Location = new System.Drawing.Point(0, 60);
            this.brojOpremeBox.Name = "brojOpremeBox";
            this.brojOpremeBox.Size = new System.Drawing.Size(218, 23);
            this.brojOpremeBox.TabIndex = 7;
            this.brojOpremeBox.Text = "Interni broj opreme:";
            this.brojOpremeBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addZaduzenje
            // 
            this.addZaduzenje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addZaduzenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addZaduzenje.Location = new System.Drawing.Point(0, 217);
            this.addZaduzenje.Name = "addZaduzenje";
            this.addZaduzenje.Size = new System.Drawing.Size(800, 36);
            this.addZaduzenje.TabIndex = 8;
            this.addZaduzenje.Text = "Unesi";
            this.addZaduzenje.UseVisualStyleBackColor = true;
            this.addZaduzenje.Click += new System.EventHandler(this.addZaduzenje_Click);
            // 
            // datZaduzenjaDTP
            // 
            this.datZaduzenjaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datZaduzenjaDTP.Location = new System.Drawing.Point(224, 101);
            this.datZaduzenjaDTP.Name = "datZaduzenjaDTP";
            this.datZaduzenjaDTP.Size = new System.Drawing.Size(231, 32);
            this.datZaduzenjaDTP.TabIndex = 9;
            this.datZaduzenjaDTP.Format = DateTimePickerFormat.Custom;
            this.datZaduzenjaDTP.CustomFormat = "yyyy-MM-dd";
            // 
            // datRazduzenjaDTP
            // 
            this.datRazduzenjaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datRazduzenjaDTP.Location = new System.Drawing.Point(319, 151);
            this.datRazduzenjaDTP.Name = "datRazduzenjaDTP";
            this.datRazduzenjaDTP.Size = new System.Drawing.Size(233, 32);
            this.datRazduzenjaDTP.TabIndex = 10;
            this.datRazduzenjaDTP.Format = DateTimePickerFormat.Custom;
            this.datRazduzenjaDTP.CustomFormat = "yyyy-MM-dd";
            // 
            // cadrovskiBox
            // 
            this.cadrovskiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cadrovskiBox.Location = new System.Drawing.Point(224, 17);
            this.cadrovskiBox.Name = "cadrovskiBox";
            this.cadrovskiBox.Size = new System.Drawing.Size(100, 32);
            this.cadrovskiBox.TabIndex = 11;
            // 
            // internalBox
            // 
            this.internalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.internalBox.Location = new System.Drawing.Point(224, 57);
            this.internalBox.Name = "internalBox";
            this.internalBox.Size = new System.Drawing.Size(100, 32);
            this.internalBox.TabIndex = 12;
            // 
            // flokBox
            // 
            this.flokBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flokBox.Location = new System.Drawing.Point(526, 15);
            this.flokBox.Name = "flokBox";
            this.flokBox.Size = new System.Drawing.Size(100, 32);
            this.flokBox.TabIndex = 13;
            // 
            // imtBox
            // 
            this.imtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imtBox.Location = new System.Drawing.Point(526, 55);
            this.imtBox.Name = "imtBox";
            this.imtBox.Size = new System.Drawing.Size(100, 32);
            this.imtBox.TabIndex = 14;
            // 
            // rifBox
            // 
            this.rifBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rifBox.Location = new System.Drawing.Point(526, 95);
            this.rifBox.Name = "rifBox";
            this.rifBox.Size = new System.Drawing.Size(100, 32);
            this.rifBox.TabIndex = 15;
            // 
            // TableFormZaduzenjec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 253);
            this.Controls.Add(this.rifBox);
            this.Controls.Add(this.imtBox);
            this.Controls.Add(this.flokBox);
            this.Controls.Add(this.internalBox);
            this.Controls.Add(this.cadrovskiBox);
            this.Controls.Add(this.datRazduzenjaDTP);
            this.Controls.Add(this.datZaduzenjaDTP);
            this.Controls.Add(this.addZaduzenje);
            this.Controls.Add(this.brojOpremeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KadrovskiBox);
            this.Name = "TableFormZaduzenjec";
            this.Text = "TableFormZaduzenjec";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox internalBox;
        private System.Windows.Forms.TextBox flokBox;
        private System.Windows.Forms.TextBox imtBox;
        private System.Windows.Forms.TextBox rifBox;

        private System.Windows.Forms.DateTimePicker datZaduzenjaDTP;
        private System.Windows.Forms.DateTimePicker datRazduzenjaDTP;
        private System.Windows.Forms.TextBox cadrovskiBox;

        private System.Windows.Forms.Button addZaduzenje;

        private System.Windows.Forms.Label KadrovskiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label brojOpremeBox;

        #endregion
    }
}