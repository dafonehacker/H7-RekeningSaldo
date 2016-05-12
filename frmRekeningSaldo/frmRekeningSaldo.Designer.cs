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
            this.lblStandText = new System.Windows.Forms.Label();
            this.lblStand = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lstVerrichtingen = new System.Windows.Forms.ListBox();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.lblBedrag = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtOmschrijving = new System.Windows.Forms.TextBox();
            this.txtBedrag = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btnToevoegen.Size = new System.Drawing.Size(155, 77);
            this.btnToevoegen.TabIndex = 3;
            this.btnToevoegen.Text = "Voeg verrichting toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // lstVerrichtingen
            // 
            this.lstVerrichtingen.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVerrichtingen.FormattingEnabled = true;
            this.lstVerrichtingen.ItemHeight = 15;
            this.lstVerrichtingen.Location = new System.Drawing.Point(11, 10);
            this.lstVerrichtingen.Name = "lstVerrichtingen";
            this.lstVerrichtingen.Size = new System.Drawing.Size(236, 139);
            this.lstVerrichtingen.TabIndex = 4;
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOmschrijving.Location = new System.Drawing.Point(12, 161);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(144, 15);
            this.lblOmschrijving.TabIndex = 5;
            this.lblOmschrijving.Text = "Voeg een omschrijving toe:";
            // 
            // lblBedrag
            // 
            this.lblBedrag.AutoSize = true;
            this.lblBedrag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBedrag.Location = new System.Drawing.Point(12, 219);
            this.lblBedrag.Name = "lblBedrag";
            this.lblBedrag.Size = new System.Drawing.Size(213, 15);
            this.lblBedrag.TabIndex = 6;
            this.lblBedrag.Text = "Geef het bedrag in (eventueel negatief):";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(12, 190);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(151, 15);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Geef de datum (dd/mm/jjjj):";
            // 
            // txtOmschrijving
            // 
            this.txtOmschrijving.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOmschrijving.Location = new System.Drawing.Point(162, 158);
            this.txtOmschrijving.Name = "txtOmschrijving";
            this.txtOmschrijving.Size = new System.Drawing.Size(252, 23);
            this.txtOmschrijving.TabIndex = 8;
            // 
            // txtBedrag
            // 
            this.txtBedrag.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBedrag.Location = new System.Drawing.Point(231, 216);
            this.txtBedrag.Name = "txtBedrag";
            this.txtBedrag.Size = new System.Drawing.Size(183, 23);
            this.txtBedrag.TabIndex = 9;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(169, 187);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(245, 23);
            this.txtDatum.TabIndex = 10;
            // 
            // frmRekeningSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 249);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.txtBedrag);
            this.Controls.Add(this.txtOmschrijving);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblBedrag);
            this.Controls.Add(this.lblOmschrijving);
            this.Controls.Add(this.lstVerrichtingen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.lblStandText);
            this.Name = "frmRekeningSaldo";
            this.Text = "Rekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStandText;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ListBox lstVerrichtingen;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Label lblBedrag;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtOmschrijving;
        private System.Windows.Forms.TextBox txtBedrag;
        private System.Windows.Forms.TextBox txtDatum;
    }
}

