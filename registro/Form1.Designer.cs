using System.Windows.Forms;

namespace registro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.italiano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matematica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inglese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informatica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistemiReti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpsit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telecomunicazioni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.loginStudente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loginDocente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.elimina = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aggiungi = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.materiaAggiungi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.materiaElimina = new System.Windows.Forms.ComboBox();
            this.nomeStudente = new System.Windows.Forms.TextBox();
            this.cognomeStudente = new System.Windows.Forms.TextBox();
            this.cognomeDocente = new System.Windows.Forms.TextBox();
            this.nomeDocente = new System.Windows.Forms.TextBox();
            this.votoAggiungi = new System.Windows.Forms.NumericUpDown();
            this.votoElimina = new System.Windows.Forms.ComboBox();
            this.matricolaStudente = new System.Windows.Forms.MaskedTextBox();
            this.matricolaDocente = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.studenteVoti = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoAggiungi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ColumnHeadersVisible = false;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.italiano,
            this.storia,
            this.matematica,
            this.inglese,
            this.informatica,
            this.sistemiReti,
            this.tpsit,
            this.telecomunicazioni});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.Location = new System.Drawing.Point(255, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGrid.Size = new System.Drawing.Size(862, 370);
            this.dataGrid.TabIndex = 0;
            // 
            // italiano
            // 
            this.italiano.HeaderText = "Italiano";
            this.italiano.Name = "italiano";
            this.italiano.ReadOnly = true;
            // 
            // storia
            // 
            this.storia.HeaderText = "Storia";
            this.storia.Name = "storia";
            this.storia.ReadOnly = true;
            // 
            // matematica
            // 
            this.matematica.HeaderText = "Matematica";
            this.matematica.Name = "matematica";
            this.matematica.ReadOnly = true;
            // 
            // inglese
            // 
            this.inglese.HeaderText = "Inglese";
            this.inglese.Name = "inglese";
            this.inglese.ReadOnly = true;
            // 
            // informatica
            // 
            this.informatica.HeaderText = "Informatica";
            this.informatica.Name = "informatica";
            this.informatica.ReadOnly = true;
            // 
            // sistemiReti
            // 
            this.sistemiReti.HeaderText = "Sistemi e Reti";
            this.sistemiReti.Name = "sistemiReti";
            this.sistemiReti.ReadOnly = true;
            // 
            // tpsit
            // 
            this.tpsit.HeaderText = "TPSIT";
            this.tpsit.Name = "tpsit";
            this.tpsit.ReadOnly = true;
            // 
            // telecomunicazioni
            // 
            this.telecomunicazioni.HeaderText = "Telecomunicazioni";
            this.telecomunicazioni.Name = "telecomunicazioni";
            this.telecomunicazioni.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Studente";
            // 
            // loginStudente
            // 
            this.loginStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginStudente.Location = new System.Drawing.Point(15, 135);
            this.loginStudente.Name = "loginStudente";
            this.loginStudente.Size = new System.Drawing.Size(234, 41);
            this.loginStudente.TabIndex = 4;
            this.loginStudente.Text = "Login";
            this.loginStudente.UseVisualStyleBackColor = true;
            this.loginStudente.Click += new System.EventHandler(this.loginStudente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "Studente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Docente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cognome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(12, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome";
            // 
            // loginDocente
            // 
            this.loginDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.loginDocente.Location = new System.Drawing.Point(15, 341);
            this.loginDocente.Name = "loginDocente";
            this.loginDocente.Size = new System.Drawing.Size(234, 41);
            this.loginDocente.TabIndex = 12;
            this.loginDocente.Text = "Login";
            this.loginDocente.UseVisualStyleBackColor = true;
            this.loginDocente.Click += new System.EventHandler(this.loginDocente_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "ID Docente";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(12, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(237, 39);
            this.label9.TabIndex = 18;
            this.label9.Text = "Oppure";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label15.Location = new System.Drawing.Point(1123, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(237, 39);
            this.label15.TabIndex = 26;
            this.label15.Text = "Elimina voti";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(1123, 288);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 17);
            this.label17.TabIndex = 23;
            this.label17.Text = "Voto";
            // 
            // elimina
            // 
            this.elimina.Enabled = false;
            this.elimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.elimina.Location = new System.Drawing.Point(1126, 314);
            this.elimina.Name = "elimina";
            this.elimina.Size = new System.Drawing.Size(234, 41);
            this.elimina.TabIndex = 21;
            this.elimina.Text = "Elimina";
            this.elimina.UseVisualStyleBackColor = true;
            this.elimina.Click += new System.EventHandler(this.elimina_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(1123, 261);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Materia";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label10.Location = new System.Drawing.Point(1123, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 39);
            this.label10.TabIndex = 32;
            this.label10.Text = "Aggiungi voti";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(1123, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Voto";
            // 
            // aggiungi
            // 
            this.aggiungi.Enabled = false;
            this.aggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aggiungi.Location = new System.Drawing.Point(1126, 135);
            this.aggiungi.Name = "aggiungi";
            this.aggiungi.Size = new System.Drawing.Size(234, 41);
            this.aggiungi.TabIndex = 29;
            this.aggiungi.Text = "Aggiungi";
            this.aggiungi.UseVisualStyleBackColor = true;
            this.aggiungi.Click += new System.EventHandler(this.aggiungi_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(1123, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Materia";
            // 
            // materiaAggiungi
            // 
            this.materiaAggiungi.Enabled = false;
            this.materiaAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materiaAggiungi.FormattingEnabled = true;
            this.materiaAggiungi.Items.AddRange(new object[] {
            "Italiano",
            "Storia",
            "Matematica",
            "Inglese",
            "Informatica",
            "Sistemi e Reti",
            "TPSIT",
            "Telecomunicazioni"});
            this.materiaAggiungi.Location = new System.Drawing.Point(1211, 79);
            this.materiaAggiungi.Name = "materiaAggiungi";
            this.materiaAggiungi.Size = new System.Drawing.Size(149, 24);
            this.materiaAggiungi.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(1123, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(237, 39);
            this.label13.TabIndex = 33;
            this.label13.Text = "Oppure";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materiaElimina
            // 
            this.materiaElimina.Enabled = false;
            this.materiaElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materiaElimina.FormattingEnabled = true;
            this.materiaElimina.Items.AddRange(new object[] {
            "Italiano",
            "Storia",
            "Matematica",
            "Inglese",
            "Informatica",
            "Sistemi e Reti",
            "TPSIT",
            "Telecomunicazioni"});
            this.materiaElimina.Location = new System.Drawing.Point(1210, 258);
            this.materiaElimina.Name = "materiaElimina";
            this.materiaElimina.Size = new System.Drawing.Size(149, 24);
            this.materiaElimina.TabIndex = 35;
            this.materiaElimina.SelectedIndexChanged += new System.EventHandler(this.materiaElimina_SelectedIndexChanged);
            // 
            // nomeStudente
            // 
            this.nomeStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeStudente.Location = new System.Drawing.Point(100, 79);
            this.nomeStudente.Name = "nomeStudente";
            this.nomeStudente.Size = new System.Drawing.Size(149, 23);
            this.nomeStudente.TabIndex = 38;
            this.nomeStudente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cognomeStudente
            // 
            this.cognomeStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cognomeStudente.Location = new System.Drawing.Point(100, 106);
            this.cognomeStudente.Name = "cognomeStudente";
            this.cognomeStudente.Size = new System.Drawing.Size(149, 23);
            this.cognomeStudente.TabIndex = 39;
            this.cognomeStudente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cognomeDocente
            // 
            this.cognomeDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cognomeDocente.Location = new System.Drawing.Point(100, 312);
            this.cognomeDocente.Name = "cognomeDocente";
            this.cognomeDocente.Size = new System.Drawing.Size(149, 23);
            this.cognomeDocente.TabIndex = 42;
            this.cognomeDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nomeDocente
            // 
            this.nomeDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeDocente.Location = new System.Drawing.Point(100, 285);
            this.nomeDocente.Name = "nomeDocente";
            this.nomeDocente.Size = new System.Drawing.Size(149, 23);
            this.nomeDocente.TabIndex = 41;
            this.nomeDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // votoAggiungi
            // 
            this.votoAggiungi.Enabled = false;
            this.votoAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.votoAggiungi.Location = new System.Drawing.Point(1211, 107);
            this.votoAggiungi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.votoAggiungi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.votoAggiungi.Name = "votoAggiungi";
            this.votoAggiungi.Size = new System.Drawing.Size(149, 23);
            this.votoAggiungi.TabIndex = 43;
            this.votoAggiungi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.votoAggiungi.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // votoElimina
            // 
            this.votoElimina.Enabled = false;
            this.votoElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.votoElimina.FormattingEnabled = true;
            this.votoElimina.Location = new System.Drawing.Point(1210, 285);
            this.votoElimina.Name = "votoElimina";
            this.votoElimina.Size = new System.Drawing.Size(149, 24);
            this.votoElimina.TabIndex = 44;
            // 
            // matricolaStudente
            // 
            this.matricolaStudente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.matricolaStudente.Location = new System.Drawing.Point(100, 52);
            this.matricolaStudente.Mask = "000000";
            this.matricolaStudente.Name = "matricolaStudente";
            this.matricolaStudente.Size = new System.Drawing.Size(149, 23);
            this.matricolaStudente.TabIndex = 46;
            this.matricolaStudente.Text = "000000";
            this.matricolaStudente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matricolaDocente
            // 
            this.matricolaDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.matricolaDocente.Location = new System.Drawing.Point(100, 258);
            this.matricolaDocente.Mask = "000000";
            this.matricolaDocente.Name = "matricolaDocente";
            this.matricolaDocente.Size = new System.Drawing.Size(149, 23);
            this.matricolaDocente.TabIndex = 47;
            this.matricolaDocente.Text = "000000";
            this.matricolaDocente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.Location = new System.Drawing.Point(1123, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "Studente";
            // 
            // studenteVoti
            // 
            this.studenteVoti.Enabled = false;
            this.studenteVoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.studenteVoti.FormattingEnabled = true;
            this.studenteVoti.Location = new System.Drawing.Point(1210, 12);
            this.studenteVoti.Name = "studenteVoti";
            this.studenteVoti.Size = new System.Drawing.Size(149, 24);
            this.studenteVoti.TabIndex = 49;
            this.studenteVoti.SelectedIndexChanged += new System.EventHandler(this.studenteVoti_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 394);
            this.Controls.Add(this.studenteVoti);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.matricolaDocente);
            this.Controls.Add(this.matricolaStudente);
            this.Controls.Add(this.votoElimina);
            this.Controls.Add(this.votoAggiungi);
            this.Controls.Add(this.cognomeDocente);
            this.Controls.Add(this.nomeDocente);
            this.Controls.Add(this.cognomeStudente);
            this.Controls.Add(this.nomeStudente);
            this.Controls.Add(this.materiaElimina);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.aggiungi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.materiaAggiungi);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.elimina);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loginDocente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginStudente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoAggiungi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginStudente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button loginDocente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button elimina;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button aggiungi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox materiaAggiungi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox materiaElimina;
        private System.Windows.Forms.TextBox nomeStudente;
        private System.Windows.Forms.TextBox cognomeStudente;
        private System.Windows.Forms.TextBox cognomeDocente;
        private System.Windows.Forms.TextBox nomeDocente;
        private DataGridViewTextBoxColumn italiano;
        private DataGridViewTextBoxColumn storia;
        private DataGridViewTextBoxColumn matematica;
        private DataGridViewTextBoxColumn inglese;
        private DataGridViewTextBoxColumn informatica;
        private DataGridViewTextBoxColumn sistemiReti;
        private DataGridViewTextBoxColumn tpsit;
        private DataGridViewTextBoxColumn telecomunicazioni;
        private NumericUpDown votoAggiungi;
        private ComboBox votoElimina;
        private MaskedTextBox matricolaStudente;
        private MaskedTextBox matricolaDocente;
        private Label label14;
        private ComboBox studenteVoti;
    }
}

