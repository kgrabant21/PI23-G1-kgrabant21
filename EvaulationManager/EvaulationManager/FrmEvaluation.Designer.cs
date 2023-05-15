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
            this.lblAktivnost.Location = new System.Drawing.Point(9, 7);
            this.lblAktivnost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAktivnost.Name = "lblAktivnost";
            this.lblAktivnost.Size = new System.Drawing.Size(57, 15);
            this.lblAktivnost.TabIndex = 0;
            this.lblAktivnost.Text = "Aktivnost:";
            // 
            // cboActivities
            // 
            this.cboActivities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivities.FormattingEnabled = true;
            this.cboActivities.Location = new System.Drawing.Point(11, 23);
            this.cboActivities.Margin = new System.Windows.Forms.Padding(2);
            this.cboActivities.Name = "cboActivities";
            this.cboActivities.Size = new System.Drawing.Size(138, 21);
            this.cboActivities.TabIndex = 1;
            this.cboActivities.SelectedIndexChanged += new System.EventHandler(this.cboActivities_SelectedIndexChanged_1);
            // 
            // lblUvjetZaPotpis
            // 
            this.lblUvjetZaPotpis.AutoSize = true;
            this.lblUvjetZaPotpis.Location = new System.Drawing.Point(157, 7);
            this.lblUvjetZaPotpis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUvjetZaPotpis.Name = "lblUvjetZaPotpis";
            this.lblUvjetZaPotpis.Size = new System.Drawing.Size(89, 15);
            this.lblUvjetZaPotpis.TabIndex = 2;
            this.lblUvjetZaPotpis.Text = "Uvjet za potpis:";
            // 
            // txtMinForSignature
            // 
            this.txtMinForSignature.Location = new System.Drawing.Point(159, 24);
            this.txtMinForSignature.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinForSignature.Name = "txtMinForSignature";
            this.txtMinForSignature.ReadOnly = true;
            this.txtMinForSignature.Size = new System.Drawing.Size(93, 20);
            this.txtMinForSignature.TabIndex = 3;
            // 
            // lblUvjetZaOcjenu
            // 
            this.lblUvjetZaOcjenu.AutoSize = true;
            this.lblUvjetZaOcjenu.Location = new System.Drawing.Point(254, 7);
            this.lblUvjetZaOcjenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUvjetZaOcjenu.Name = "lblUvjetZaOcjenu";
            this.lblUvjetZaOcjenu.Size = new System.Drawing.Size(93, 15);
            this.lblUvjetZaOcjenu.TabIndex = 4;
            this.lblUvjetZaOcjenu.Text = "Uvjet za ocjenu:";
            // 
            // txtMinForGrade
            // 
            this.txtMinForGrade.Location = new System.Drawing.Point(256, 24);
            this.txtMinForGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinForGrade.Name = "txtMinForGrade";
            this.txtMinForGrade.ReadOnly = true;
            this.txtMinForGrade.Size = new System.Drawing.Size(120, 20);
            this.txtMinForGrade.TabIndex = 5;
            // 
            // txtActivityDescription
            // 
            this.txtActivityDescription.Location = new System.Drawing.Point(11, 47);
            this.txtActivityDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtActivityDescription.Multiline = true;
            this.txtActivityDescription.Name = "txtActivityDescription";
            this.txtActivityDescription.Size = new System.Drawing.Size(365, 123);
            this.txtActivityDescription.TabIndex = 6;
            // 
            // lblOcjenivac
            // 
            this.lblOcjenivac.AutoSize = true;
            this.lblOcjenivac.Location = new System.Drawing.Point(65, 172);
            this.lblOcjenivac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOcjenivac.Name = "lblOcjenivac";
            this.lblOcjenivac.Size = new System.Drawing.Size(63, 15);
            this.lblOcjenivac.TabIndex = 7;
            this.lblOcjenivac.Text = "Ocjenivač:";
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(68, 188);
            this.txtTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(122, 20);
            this.txtTeacher.TabIndex = 8;
            // 
            // lblDatumEvaulacije
            // 
            this.lblDatumEvaulacije.AutoSize = true;
            this.lblDatumEvaulacije.Location = new System.Drawing.Point(190, 172);
            this.lblDatumEvaulacije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumEvaulacije.Name = "lblDatumEvaulacije";
            this.lblDatumEvaulacije.Size = new System.Drawing.Size(105, 15);
            this.lblDatumEvaulacije.TabIndex = 9;
            this.lblDatumEvaulacije.Text = "Datum evaulacije:";
            // 
            // txtEvaulationData
            // 
            this.txtEvaulationData.Location = new System.Drawing.Point(193, 188);
            this.txtEvaulationData.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvaulationData.Name = "txtEvaulationData";
            this.txtEvaulationData.ReadOnly = true;
            this.txtEvaulationData.Size = new System.Drawing.Size(120, 20);
            this.txtEvaulationData.TabIndex = 10;
            // 
            // lblBodovi
            // 
            this.lblBodovi.AutoSize = true;
            this.lblBodovi.Location = new System.Drawing.Point(314, 173);
            this.lblBodovi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBodovi.Name = "lblBodovi";
            this.lblBodovi.Size = new System.Drawing.Size(47, 15);
            this.lblBodovi.TabIndex = 11;
            this.lblBodovi.Text = "Bodovi:";
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(316, 188);
            this.numPoints.Margin = new System.Windows.Forms.Padding(2);
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(56, 20);
            this.numPoints.TabIndex = 13;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(288, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 32);
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
            this.btnSave.Location = new System.Drawing.Point(197, 233);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 31);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 276);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEvaluation";
            this.Text = "FrmEvaulation";
            this.Load += new System.EventHandler(this.FrmEvaluation_Load_1);
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