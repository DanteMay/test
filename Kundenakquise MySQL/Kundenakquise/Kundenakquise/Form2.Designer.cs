namespace Kundenakquise
{
    partial class btnsafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnsafe));
            this.tbid = new System.Windows.Forms.TextBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datenbank1DataSet = new Kundenakquise.Datenbank1DataSet();
            this.tbnachname = new System.Windows.Forms.TextBox();
            this.tbvorname = new System.Windows.Forms.TextBox();
            this.tbadresse = new System.Windows.Forms.TextBox();
            this.tbort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kundeTableAdapter = new Kundenakquise.Datenbank1DataSetTableAdapters.KundeTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.tbplz = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.TextBox();
            this.monat = new System.Windows.Forms.TextBox();
            this.jahr = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.bankTableAdapter = new Kundenakquise.Datenbank1DataSetTableAdapters.BankTableAdapter();
            this.datenbank1DataSet1 = new Kundenakquise.Datenbank1DataSet();
            this.iBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iBANTableAdapter = new Kundenakquise.Datenbank1DataSetTableAdapters.IBANTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbid
            // 
            this.tbid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KundenID", true));
            this.tbid.Location = new System.Drawing.Point(89, 6);
            this.tbid.Name = "tbid";
            this.tbid.ReadOnly = true;
            this.tbid.Size = new System.Drawing.Size(163, 20);
            this.tbid.TabIndex = 0;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.datenbank1DataSet;
            // 
            // datenbank1DataSet
            // 
            this.datenbank1DataSet.DataSetName = "Datenbank1DataSet";
            this.datenbank1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbnachname
            // 
            this.tbnachname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KNachname", true));
            this.tbnachname.Location = new System.Drawing.Point(89, 32);
            this.tbnachname.Name = "tbnachname";
            this.tbnachname.ReadOnly = true;
            this.tbnachname.Size = new System.Drawing.Size(163, 20);
            this.tbnachname.TabIndex = 1;
            // 
            // tbvorname
            // 
            this.tbvorname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KVorname", true));
            this.tbvorname.Location = new System.Drawing.Point(89, 58);
            this.tbvorname.Name = "tbvorname";
            this.tbvorname.ReadOnly = true;
            this.tbvorname.Size = new System.Drawing.Size(163, 20);
            this.tbvorname.TabIndex = 2;
            // 
            // tbadresse
            // 
            this.tbadresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KAdresse", true));
            this.tbadresse.Location = new System.Drawing.Point(89, 110);
            this.tbadresse.Name = "tbadresse";
            this.tbadresse.ReadOnly = true;
            this.tbadresse.Size = new System.Drawing.Size(163, 20);
            this.tbadresse.TabIndex = 4;
            // 
            // tbort
            // 
            this.tbort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KOrt", true));
            this.tbort.Location = new System.Drawing.Point(89, 162);
            this.tbort.Name = "tbort";
            this.tbort.ReadOnly = true;
            this.tbort.Size = new System.Drawing.Size(163, 20);
            this.tbort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nachname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Geburtsdatum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ort";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Schließen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(17, 188);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 16;
            this.btnedit.Text = "Bearbeiten";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(98, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "PLZ";
            // 
            // tbplz
            // 
            this.tbplz.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KPostleitzahl", true));
            this.tbplz.Location = new System.Drawing.Point(89, 136);
            this.tbplz.Name = "tbplz";
            this.tbplz.ReadOnly = true;
            this.tbplz.Size = new System.Drawing.Size(163, 20);
            this.tbplz.TabIndex = 18;
            // 
            // tag
            // 
            this.tag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KTag", true));
            this.tag.Location = new System.Drawing.Point(89, 84);
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Size = new System.Drawing.Size(50, 20);
            this.tag.TabIndex = 20;
            // 
            // monat
            // 
            this.monat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KMonat", true));
            this.monat.Location = new System.Drawing.Point(145, 84);
            this.monat.Name = "monat";
            this.monat.ReadOnly = true;
            this.monat.Size = new System.Drawing.Size(55, 20);
            this.monat.TabIndex = 21;
            // 
            // jahr
            // 
            this.jahr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "KJahr", true));
            this.jahr.Location = new System.Drawing.Point(206, 84);
            this.jahr.Name = "jahr";
            this.jahr.ReadOnly = true;
            this.jahr.Size = new System.Drawing.Size(46, 20);
            this.jahr.TabIndex = 22;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.iBANBindingSource;
            this.listBox1.DisplayMember = "IBAN";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(286, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 23;
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataMember = "Bank";
            this.bankBindingSource.DataSource = this.datenbank1DataSet;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.bankBindingSource;
            this.listBox2.DisplayMember = "BName";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(402, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 24;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.bankBindingSource;
            this.listBox3.DisplayMember = "BNUmmer";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(518, 6);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 199);
            this.listBox3.TabIndex = 25;
            // 
            // bankTableAdapter
            // 
            this.bankTableAdapter.ClearBeforeFill = true;
            // 
            // datenbank1DataSet1
            // 
            this.datenbank1DataSet1.DataSetName = "Datenbank1DataSet";
            this.datenbank1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iBANBindingSource
            // 
            this.iBANBindingSource.DataMember = "IBAN";
            this.iBANBindingSource.DataSource = this.datenbank1DataSet1;
            // 
            // iBANTableAdapter
            // 
            this.iBANTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 271);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 27;
            // 
            // btnsafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 337);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.jahr);
            this.Controls.Add(this.monat);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbplz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbort);
            this.Controls.Add(this.tbadresse);
            this.Controls.Add(this.tbvorname);
            this.Controls.Add(this.tbnachname);
            this.Controls.Add(this.tbid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btnsafe";
            this.Text = "Kundendaten bearbeiten";
            this.Load += new System.EventHandler(this.btnsafe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.TextBox tbnachname;
        private System.Windows.Forms.TextBox tbvorname;
        private System.Windows.Forms.TextBox tbadresse;
        private System.Windows.Forms.TextBox tbort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button button2;
        private Datenbank1DataSet datenbank1DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private Datenbank1DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbplz;
        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.TextBox monat;
        private System.Windows.Forms.TextBox jahr;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private Datenbank1DataSetTableAdapters.BankTableAdapter bankTableAdapter;
        private Datenbank1DataSet datenbank1DataSet1;
        private System.Windows.Forms.BindingSource iBANBindingSource;
        private Datenbank1DataSetTableAdapters.IBANTableAdapter iBANTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}