namespace frmRekeningSaldo
{
    partial class frmRekeningSaldo
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
            this.lblVerrichting = new System.Windows.Forms.Label();
            this.lblStandText = new System.Windows.Forms.Label();
            this.lblStand = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVerrichting
            // 
            this.lblVerrichting.BackColor = System.Drawing.Color.White;
            this.lblVerrichting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVerrichting.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerrichting.Location = new System.Drawing.Point(13, 13);
            this.lblVerrichting.Name = "lblVerrichting";
            this.lblVerrichting.Size = new System.Drawing.Size(237, 137);
            this.lblVerrichting.TabIndex = 0;
            // 
            // lblStandText
            // 
            this.lblStandText.AutoSize = true;
            this.lblStandText.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandText.Location = new System.Drawing.Point(293, 13);
            this.lblStandText.Name = "lblStandText";
            this.lblStandText.Size = new System.Drawing.Size(89, 17);
            this.lblStandText.TabIndex = 1;
            this.lblStandText.Text = "Rekeningstand:";
            // 
            // lblStand
            // 
            this.lblStand.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStand.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblStand.Location = new System.Drawing.Point(256, 39);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(158, 30);
            this.lblStand.TabIndex = 2;
            this.lblStand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToevoegen.Location = new System.Drawing.Point(259, 72);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(155, 78);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Voeg verrichting toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // frmRekeningSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 163);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.lblStandText);
            this.Controls.Add(this.lblVerrichting);
            this.Name = "frmRekeningSaldo";
            this.Text = "Rekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerrichting;
        private System.Windows.Forms.Label lblStandText;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Button btnToevoegen;
    }
}

