namespace Kundenakquise
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchinput = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datenbank1DataSet = new Kundenakquise.Datenbank1DataSet();
            this.kundeTableAdapter = new Kundenakquise.Datenbank1DataSetTableAdapters.KundeTableAdapter();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnadddoc = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnaddcustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbsearchinput = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ärzteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ärzteTableAdapter = new Kundenakquise.Datenbank1DataSetTableAdapters.ÄrzteTableAdapter();
            this.ärzteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnedit = new System.Windows.Forms.Button();
            this.tbtest = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ärzteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ärzteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchinput
            // 
            this.searchinput.Location = new System.Drawing.Point(263, 13);
            this.searchinput.Name = "searchinput";
            this.searchinput.Size = new System.Drawing.Size(121, 20);
            this.searchinput.TabIndex = 0;
            this.searchinput.Text = "Name eingeben";
            this.searchinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.DataSource = this.kundeBindingSource;
            this.listBox1.DisplayMember = "KNachname";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(132, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 199);
            this.listBox1.TabIndex = 1;
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
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.kundeBindingSource;
            this.listBox2.DisplayMember = "KVorname";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(274, 53);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(148, 199);
            this.listBox2.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.kundeBindingSource;
            this.listBox3.DisplayMember = "KAdresse";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(415, 53);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(148, 199);
            this.listBox3.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nach Kunden suchen:",
            "Nach Arzt suchen:"});
            this.comboBox1.Location = new System.Drawing.Point(136, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Nach Kunden suchen:";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnadddoc
            // 
            this.btnadddoc.Location = new System.Drawing.Point(5, 42);
            this.btnadddoc.Name = "btnadddoc";
            this.btnadddoc.Size = new System.Drawing.Size(121, 23);
            this.btnadddoc.TabIndex = 5;
            this.btnadddoc.Text = "Arzt hinzufügen";
            this.btnadddoc.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Schließen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnaddcustomer
            // 
            this.btnaddcustomer.Location = new System.Drawing.Point(5, 13);
            this.btnaddcustomer.Name = "btnaddcustomer";
            this.btnaddcustomer.Size = new System.Drawing.Size(121, 23);
            this.btnaddcustomer.TabIndex = 7;
            this.btnaddcustomer.Text = "Kunden hinzufügen";
            this.btnaddcustomer.UseVisualStyleBackColor = true;
            this.btnaddcustomer.Click += new System.EventHandler(this.btnaddcustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Adresse";
            // 
            // tbsearchinput
            // 
            this.tbsearchinput.Location = new System.Drawing.Point(263, 13);
            this.tbsearchinput.Name = "tbsearchinput";
            this.tbsearchinput.Size = new System.Drawing.Size(121, 20);
            this.tbsearchinput.TabIndex = 0;
            this.tbsearchinput.Text = "Name eingeben";
            this.tbsearchinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.datenbank1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // ärzteBindingSource
            // 
            this.ärzteBindingSource.DataMember = "Ärzte";
            this.ärzteBindingSource.DataSource = this.bindingSource1;
            // 
            // ärzteTableAdapter
            // 
            this.ärzteTableAdapter.ClearBeforeFill = true;
            // 
            // ärzteBindingSource1
            // 
            this.ärzteBindingSource1.DataMember = "Ärzte";
            this.ärzteBindingSource1.DataSource = this.datenbank1DataSet;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(5, 71);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(121, 23);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Bearbeiten...";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // tbtest
            // 
            this.tbtest.Location = new System.Drawing.Point(12, 131);
            this.tbtest.Name = "tbtest";
            this.tbtest.Size = new System.Drawing.Size(100, 20);
            this.tbtest.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 260);
            this.Controls.Add(this.tbtest);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnaddcustomer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnadddoc);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.searchinput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kundenakquise";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datenbank1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ärzteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ärzteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private Datenbank1DataSet datenbank1DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private Datenbank1DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnadddoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnaddcustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchinput;
        private System.Windows.Forms.TextBox tbsearchinput;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource ärzteBindingSource;
        private Datenbank1DataSetTableAdapters.ÄrzteTableAdapter ärzteTableAdapter;
        private System.Windows.Forms.BindingSource ärzteBindingSource1;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox tbtest;
    }
}

