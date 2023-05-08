namespace EvaulationManager {
    partial class FrmEvaluation {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblAktivnost = new System.Windows.Forms.Label();
            this.cboActivities = new System.Windows.Forms.ComboBox();
            this.lblUvjetZaPotpis = new System.Windows.Forms.Label();
            this.txtMinForSignature = new System.Windows.Forms.TextBox();
            this.lblUvjetZaOcjenu = new System.Windows.Forms.Label();
            this.txtMinForGrade = new System.Windows.Forms.TextBox();
            this.txtActivityDescription = new System.Windows.Forms.TextBox();
            this.lblOcjenivac = new System.Windows.Forms.Label();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.lblDatumEvaulacije = new System.Windows.Forms.Label();
            this.txtEvaulationData = new System.Windows.Forms.TextBox();
            this.lblBodovi = new System.Windows.Forms.Label();
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAktivnost
            // 
            this.lblAktivnost.AutoSize = true;
            this.lblAktivnost.Location = new System.Drawing.Point(12, 9);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(64, 16);
            this.lblAktivnost.TabIndex = 0;
            this.lblAktivnost.Text = "Aktivnost:";
            // 
            // cboActivities
            // 
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(15, 28);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(183, 24);
            this.cboActivities.TabIndex = 1;
            // 
            // lblUvjetZaPotpis
            // 
            this.lblUvjetZaPotpis.AutoSize = true;
            this.lblUvjetZaPotpis.Location = new System.Drawing.Point(209, 9);
            this.lblUvjetZaPotpis.Name = "lblUvjetZaPotpis";
            this.lblUvjetZaPotpis.Size = new System.Drawing.Size(98, 16);
            this.lblUvjetZaPotpis.TabIndex = 2;
            this.lblUvjetZaPotpis.Text = "Uvjet za potpis:";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(212, 29);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(123, 22);
            this.txtMinForSignature.TabIndex = 3;
            // 
            // lblUvjetZaOcjenu
            // 
            this.lblUvjetZaOcjenu.AutoSize = true;
            this.lblUvjetZaOcjenu.Location = new System.Drawing.Point(338, 9);
            this.lblUvjetZaOcjenu.Name = "lblUvjetZaOcjenu";
            this.lblUvjetZaOcjenu.Size = new System.Drawing.Size(101, 16);
            this.lblUvjetZaOcjenu.TabIndex = 4;
            this.lblUvjetZaOcjenu.Text = "Uvjet za ocjenu:";
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(341, 30);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(159, 22);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(15, 58);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(485, 150);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // lblOcjenivac
            // 
            this.lblOcjenivac.AutoSize = true;
            this.lblOcjenivac.Location = new System.Drawing.Point(87, 212);
            this.lblOcjenivac.Name = "lblOcjenivac";
            this.lblOcjenivac.Size = new System.Drawing.Size(70, 16);
            this.lblOcjenivac.TabIndex = 7;
            this.lblOcjenivac.Text = "Ocjenivač:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(90, 231);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(161, 22);
            this.txtTeacher.TabIndex = 8;
            // 
            // lblDatumEvaulacije
            // 
            this.lblDatumEvaulacije.AutoSize = true;
            this.lblDatumEvaulacije.Location = new System.Drawing.Point(254, 212);
            this.lblDatumEvaulacije.Name = "lblDatumEvaulacije";
            this.lblDatumEvaulacije.Size = new System.Drawing.Size(114, 16);
            this.lblDatumEvaulacije.TabIndex = 9;
            this.lblDatumEvaulacije.Text = "Datum evaulacije:";
            // 
            // txtEvaulationData
            // 
            this.txtEvaulationData.Location = new System.Drawing.Point(257, 231);
            this.txtEvaulationData.Name = "txtEvaulationData";
            this.txtEvaulationData.ReadOnly = true;
            this.txtEvaulationData.Size = new System.Drawing.Size(159, 22);
            this.txtEvaulationData.TabIndex = 10;
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(419, 213);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(53, 16);
            this.lblBodovi.TabIndex = 11;
            this.lblBodovi.Text = "Bodovi:";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(422, 232);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(75, 22);
            this.numPoints.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(425, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(341, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 325);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.lblBodovi);
            this.Controls.Add(this.txtEvaulationData);
            this.Controls.Add(this.lblDatumEvaulacije);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.lblOcjenivac);
            this.Controls.Add(this.txtActivityDescription);
            this.Controls.Add(this.txtMinForGrade);
            this.Controls.Add(this.lblUvjetZaOcjenu);
            this.Controls.Add(this.txtMinForSignature);
            this.Controls.Add(this.lblUvjetZaPotpis);
            this.Controls.Add(this.cboActivities);
            this.Controls.Add(this.lblAktivnost);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaulation";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAktivnost;
        private System.Windows.Forms.ComboBox cboActivities;
        private System.Windows.Forms.Label lblUvjetZaPotpis;
        private System.Windows.Forms.TextBox txtMinForSignature;
        private System.Windows.Forms.Label lblUvjetZaOcjenu;
        private System.Windows.Forms.TextBox txtMinForGrade;
        private System.Windows.Forms.TextBox txtActivityDescription;
        private System.Windows.Forms.Label lblOcjenivac;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label lblDatumEvaulacije;
        private System.Windows.Forms.TextBox txtEvaulationData;
        private System.Windows.Forms.Label lblBodovi;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}