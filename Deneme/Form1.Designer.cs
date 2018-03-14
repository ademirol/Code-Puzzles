namespace deneme
{
    partial class Form1
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
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.btsubmit = new System.Windows.Forms.Button();
            this.lblShape = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEnter.Location = new System.Drawing.Point(253, 28);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(642, 30);
            this.txtEnter.TabIndex = 0;
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExplanation.Location = new System.Drawing.Point(75, 28);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(142, 27);
            this.lblExplanation.TabIndex = 1;
            this.lblExplanation.Text = "Enter the text";
            // 
            // btsubmit
            // 
            this.btsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btsubmit.ForeColor = System.Drawing.SystemColors.Info;
            this.btsubmit.Location = new System.Drawing.Point(75, 89);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(156, 46);
            this.btsubmit.TabIndex = 2;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = false;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(142, 107);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(49, 17);
            this.lblShape.TabIndex = 3;
            this.lblShape.Text = "Shape";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(60, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 860);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1754, 1009);
            this.Controls.Add(this.btsubmit);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.txtEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.Panel panel1;
    }
}

