namespace GestionSalaraies
{
    partial class GestionSalarie
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.gbSal = new System.Windows.Forms.GroupBox();
            this.tbSalBrut = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCompteBloque = new System.Windows.Forms.CheckBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSal = new System.Windows.Forms.ComboBox();
            this.epSal = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCom = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCommission = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCA = new System.Windows.Forms.TextBox();
            this.cbCom = new System.Windows.Forms.CheckBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbSal.SuspendLayout();
            this.PnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSal)).BeginInit();
            this.gbCom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisir un salarié :";
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Location = new System.Drawing.Point(331, 37);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(75, 23);
            this.BtnNouveau.TabIndex = 2;
            this.BtnNouveau.Text = "Nouveau";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // gbSal
            // 
            this.gbSal.Controls.Add(this.gbCom);
            this.gbSal.Controls.Add(this.cbCom);
            this.gbSal.Controls.Add(this.dtDate);
            this.gbSal.Controls.Add(this.tbSalBrut);
            this.gbSal.Controls.Add(this.label7);
            this.gbSal.Controls.Add(this.label6);
            this.gbSal.Controls.Add(this.PnlBtn);
            this.gbSal.Controls.Add(this.cbRole);
            this.gbSal.Controls.Add(this.label5);
            this.gbSal.Controls.Add(this.cbCompteBloque);
            this.gbSal.Controls.Add(this.tbNom);
            this.gbSal.Controls.Add(this.label4);
            this.gbSal.Controls.Add(this.tbMDP);
            this.gbSal.Controls.Add(this.label3);
            this.gbSal.Controls.Add(this.tbID);
            this.gbSal.Controls.Add(this.label2);
            this.gbSal.Location = new System.Drawing.Point(23, 84);
            this.gbSal.Name = "gbSal";
            this.gbSal.Size = new System.Drawing.Size(576, 470);
            this.gbSal.TabIndex = 3;
            this.gbSal.TabStop = false;
            this.gbSal.Text = "Details Salariés";
            // 
            // tbSalBrut
            // 
            this.tbSalBrut.Location = new System.Drawing.Point(88, 147);
            this.tbSalBrut.Name = "tbSalBrut";
            this.tbSalBrut.Size = new System.Drawing.Size(137, 20);
            this.tbSalBrut.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salaire Brut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date de Naissance:";
            // 
            // PnlBtn
            // 
            this.PnlBtn.Controls.Add(this.btnModif);
            this.PnlBtn.Controls.Add(this.btnValider);
            this.PnlBtn.Controls.Add(this.btnAnnuler);
            this.PnlBtn.Location = new System.Drawing.Point(6, 366);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(360, 77);
            this.PnlBtn.TabIndex = 13;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(3, 25);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(240, 25);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 11;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(121, 25);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 10;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(69, 319);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(137, 21);
            this.cbRole.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rôle:";
            // 
            // cbCompteBloque
            // 
            this.cbCompteBloque.AutoSize = true;
            this.cbCompteBloque.Location = new System.Drawing.Point(88, 196);
            this.cbCompteBloque.Name = "cbCompteBloque";
            this.cbCompteBloque.Size = new System.Drawing.Size(97, 17);
            this.cbCompteBloque.TabIndex = 6;
            this.cbCompteBloque.Text = "Compte bloqué";
            this.cbCompteBloque.UseVisualStyleBackColor = true;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(88, 111);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(137, 20);
            this.tbNom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom:";
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(88, 67);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(137, 20);
            this.tbMDP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(88, 30);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(137, 20);
            this.tbID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identifiant:";
            // 
            // cbSal
            // 
            this.cbSal.FormattingEnabled = true;
            this.cbSal.Location = new System.Drawing.Point(147, 39);
            this.cbSal.Name = "cbSal";
            this.cbSal.Size = new System.Drawing.Size(164, 21);
            this.cbSal.TabIndex = 4;
            this.cbSal.SelectedIndexChanged += new System.EventHandler(this.cbSal_SelectedIndexChanged);
            // 
            // epSal
            // 
            this.epSal.ContainerControl = this;
            // 
            // gbCom
            // 
            this.gbCom.Controls.Add(this.tbCA);
            this.gbCom.Controls.Add(this.label9);
            this.gbCom.Controls.Add(this.tbCommission);
            this.gbCom.Controls.Add(this.label8);
            this.gbCom.Location = new System.Drawing.Point(319, 58);
            this.gbCom.Name = "gbCom";
            this.gbCom.Size = new System.Drawing.Size(243, 155);
            this.gbCom.TabIndex = 5;
            this.gbCom.TabStop = false;
            this.gbCom.Text = "Details Commercial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Commission :";
            // 
            // tbCommission
            // 
            this.tbCommission.Location = new System.Drawing.Point(97, 44);
            this.tbCommission.Name = "tbCommission";
            this.tbCommission.Size = new System.Drawing.Size(135, 20);
            this.tbCommission.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Chiffre d\'affaires :";
            // 
            // tbCA
            // 
            this.tbCA.Location = new System.Drawing.Point(100, 109);
            this.tbCA.Name = "tbCA";
            this.tbCA.Size = new System.Drawing.Size(135, 20);
            this.tbCA.TabIndex = 3;
            // 
            // cbCom
            // 
            this.cbCom.AutoSize = true;
            this.cbCom.Location = new System.Drawing.Point(319, 19);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(80, 17);
            this.cbCom.TabIndex = 6;
            this.cbCom.Text = "Commercial";
            this.cbCom.UseVisualStyleBackColor = true;
            this.cbCom.Click += new System.EventHandler(this.cbCom_Click);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(108, 245);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 18;
            this.dtDate.Value = new System.DateTime(2020, 10, 8, 10, 4, 15, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImage = global::GestionSalaraies.Properties.Resources.male_1354358_640;
            this.panel1.Location = new System.Drawing.Point(605, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 348);
            this.panel1.TabIndex = 5;
            // 
            // GestionSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbSal);
            this.Controls.Add(this.gbSal);
            this.Controls.Add(this.BtnNouveau);
            this.Controls.Add(this.label1);
            this.Name = "GestionSalarie";
            this.Text = "Gestion des Salariés";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GestionSalarie_FormClosed);
            this.Load += new System.EventHandler(this.GestionSalarie_Load);
            this.gbSal.ResumeLayout(false);
            this.gbSal.PerformLayout();
            this.PnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epSal)).EndInit();
            this.gbCom.ResumeLayout(false);
            this.gbCom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.GroupBox gbSal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCompteBloque;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.ComboBox cbSal;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Panel PnlBtn;
        private System.Windows.Forms.ErrorProvider epSal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSalBrut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbCom;
        private System.Windows.Forms.GroupBox gbCom;
        private System.Windows.Forms.TextBox tbCA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCommission;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Panel panel1;
    }
}