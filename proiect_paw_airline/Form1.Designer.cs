namespace proiect_paw_airline
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_idRuta = new System.Windows.Forms.TextBox();
            this.tb_nrZbor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nrLocuri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_orasPlecare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_taraPlecare = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_oraPlecare = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_oraSosire = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_taraDestinatie = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_orasDestinatie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_adaugaRuta = new System.Windows.Forms.Button();
            this.listview_rute = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nr_zbor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nr_locuri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oras_plecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tara_plecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ora_plecare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oras_sosire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tara_destinatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ora_sosire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkConnection = new System.Windows.Forms.Label();
            this.btn_printare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewRute = new System.Windows.Forms.DataGridView();
            this.btn_restaurare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRute)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID: ";
            // 
            // tb_idRuta
            // 
            this.tb_idRuta.Location = new System.Drawing.Point(107, 62);
            this.tb_idRuta.Name = "tb_idRuta";
            this.tb_idRuta.Size = new System.Drawing.Size(100, 20);
            this.tb_idRuta.TabIndex = 2;
            // 
            // tb_nrZbor
            // 
            this.tb_nrZbor.Location = new System.Drawing.Point(107, 100);
            this.tb_nrZbor.Name = "tb_nrZbor";
            this.tb_nrZbor.Size = new System.Drawing.Size(100, 20);
            this.tb_nrZbor.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numar zbor:";
            // 
            // tb_nrLocuri
            // 
            this.tb_nrLocuri.Location = new System.Drawing.Point(107, 136);
            this.tb_nrLocuri.Name = "tb_nrLocuri";
            this.tb_nrLocuri.Size = new System.Drawing.Size(100, 20);
            this.tb_nrLocuri.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numar locuri:";
            // 
            // tb_orasPlecare
            // 
            this.tb_orasPlecare.Location = new System.Drawing.Point(319, 62);
            this.tb_orasPlecare.Name = "tb_orasPlecare";
            this.tb_orasPlecare.Size = new System.Drawing.Size(100, 20);
            this.tb_orasPlecare.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Oras plecare:";
            // 
            // tb_taraPlecare
            // 
            this.tb_taraPlecare.Location = new System.Drawing.Point(319, 97);
            this.tb_taraPlecare.Name = "tb_taraPlecare";
            this.tb_taraPlecare.Size = new System.Drawing.Size(100, 20);
            this.tb_taraPlecare.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tara plecare:";
            // 
            // tb_oraPlecare
            // 
            this.tb_oraPlecare.Location = new System.Drawing.Point(319, 133);
            this.tb_oraPlecare.Name = "tb_oraPlecare";
            this.tb_oraPlecare.Size = new System.Drawing.Size(100, 20);
            this.tb_oraPlecare.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ora plecare:";
            // 
            // tb_oraSosire
            // 
            this.tb_oraSosire.Location = new System.Drawing.Point(557, 133);
            this.tb_oraSosire.Name = "tb_oraSosire";
            this.tb_oraSosire.Size = new System.Drawing.Size(100, 20);
            this.tb_oraSosire.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(471, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ora sosire:";
            // 
            // tb_taraDestinatie
            // 
            this.tb_taraDestinatie.Location = new System.Drawing.Point(557, 97);
            this.tb_taraDestinatie.Name = "tb_taraDestinatie";
            this.tb_taraDestinatie.Size = new System.Drawing.Size(100, 20);
            this.tb_taraDestinatie.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tara destinatie:";
            // 
            // tb_orasDestinatie
            // 
            this.tb_orasDestinatie.Location = new System.Drawing.Point(557, 62);
            this.tb_orasDestinatie.Name = "tb_orasDestinatie";
            this.tb_orasDestinatie.Size = new System.Drawing.Size(100, 20);
            this.tb_orasDestinatie.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(471, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Oras destinatie:";
            // 
            // btn_adaugaRuta
            // 
            this.btn_adaugaRuta.Location = new System.Drawing.Point(716, 83);
            this.btn_adaugaRuta.Name = "btn_adaugaRuta";
            this.btn_adaugaRuta.Size = new System.Drawing.Size(119, 23);
            this.btn_adaugaRuta.TabIndex = 19;
            this.btn_adaugaRuta.Text = "Adauga Ruta";
            this.btn_adaugaRuta.UseVisualStyleBackColor = true;
            this.btn_adaugaRuta.Click += new System.EventHandler(this.btn_adaugaRuta_Click);
            // 
            // listview_rute
            // 
            this.listview_rute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Nr_zbor,
            this.nr_locuri,
            this.oras_plecare,
            this.tara_plecare,
            this.ora_plecare,
            this.oras_sosire,
            this.tara_destinatie,
            this.ora_sosire});
            this.listview_rute.Location = new System.Drawing.Point(733, 12);
            this.listview_rute.Name = "listview_rute";
            this.listview_rute.Size = new System.Drawing.Size(80, 61);
            this.listview_rute.TabIndex = 20;
            this.listview_rute.UseCompatibleStateImageBehavior = false;
            this.listview_rute.View = System.Windows.Forms.View.Details;
            this.listview_rute.Visible = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 35;
            // 
            // Nr_zbor
            // 
            this.Nr_zbor.Text = "Nr zbor";
            this.Nr_zbor.Width = 50;
            // 
            // nr_locuri
            // 
            this.nr_locuri.Text = "Nr locuri";
            this.nr_locuri.Width = 57;
            // 
            // oras_plecare
            // 
            this.oras_plecare.Text = "Oras Plecare";
            this.oras_plecare.Width = 92;
            // 
            // tara_plecare
            // 
            this.tara_plecare.Text = "Tara Plecare";
            this.tara_plecare.Width = 79;
            // 
            // ora_plecare
            // 
            this.ora_plecare.Text = "Ora plecare";
            this.ora_plecare.Width = 72;
            // 
            // oras_sosire
            // 
            this.oras_sosire.Text = "Oras destinatie";
            this.oras_sosire.Width = 105;
            // 
            // tara_destinatie
            // 
            this.tara_destinatie.Text = "Tara Destinatie";
            this.tara_destinatie.Width = 92;
            // 
            // ora_sosire
            // 
            this.ora_sosire.Text = "Ora Sosire";
            this.ora_sosire.Width = 68;
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.Location = new System.Drawing.Point(159, 30);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(0, 13);
            this.checkConnection.TabIndex = 21;
            // 
            // btn_printare
            // 
            this.btn_printare.Location = new System.Drawing.Point(738, 208);
            this.btn_printare.Name = "btn_printare";
            this.btn_printare.Size = new System.Drawing.Size(75, 23);
            this.btn_printare.TabIndex = 22;
            this.btn_printare.Text = "Printare";
            this.btn_printare.UseVisualStyleBackColor = true;
            this.btn_printare.Click += new System.EventHandler(this.btn_printare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(716, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Afiseaza Companii";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewRute
            // 
            this.dataGridViewRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRute.Location = new System.Drawing.Point(12, 174);
            this.dataGridViewRute.Name = "dataGridViewRute";
            this.dataGridViewRute.Size = new System.Drawing.Size(688, 143);
            this.dataGridViewRute.TabIndex = 24;
            // 
            // btn_restaurare
            // 
            this.btn_restaurare.Location = new System.Drawing.Point(738, 258);
            this.btn_restaurare.Name = "btn_restaurare";
            this.btn_restaurare.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_restaurare.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurare.TabIndex = 25;
            this.btn_restaurare.Text = "Restaurare";
            this.btn_restaurare.UseVisualStyleBackColor = true;
            this.btn_restaurare.Click += new System.EventHandler(this.btn_restaurare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 356);
            this.Controls.Add(this.btn_restaurare);
            this.Controls.Add(this.dataGridViewRute);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_printare);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.listview_rute);
            this.Controls.Add(this.btn_adaugaRuta);
            this.Controls.Add(this.tb_oraSosire);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_taraDestinatie);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_orasDestinatie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_oraPlecare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_taraPlecare);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_orasPlecare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_nrLocuri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nrZbor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_idRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_idRuta;
        private System.Windows.Forms.TextBox tb_nrZbor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nrLocuri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_orasPlecare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_taraPlecare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_oraPlecare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_oraSosire;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_taraDestinatie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_orasDestinatie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_adaugaRuta;
        private System.Windows.Forms.ListView listview_rute;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Nr_zbor;
        private System.Windows.Forms.ColumnHeader nr_locuri;
        private System.Windows.Forms.ColumnHeader oras_plecare;
        private System.Windows.Forms.ColumnHeader tara_plecare;
        private System.Windows.Forms.ColumnHeader ora_plecare;
        private System.Windows.Forms.ColumnHeader oras_sosire;
        private System.Windows.Forms.ColumnHeader tara_destinatie;
        private System.Windows.Forms.ColumnHeader ora_sosire;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.Button btn_printare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_restaurare;
        private System.Windows.Forms.DataGridView dataGridViewRute;
    }
}

