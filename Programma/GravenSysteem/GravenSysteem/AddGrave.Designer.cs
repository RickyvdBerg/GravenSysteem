﻿namespace GravenSysteem
{
    partial class AddGrave
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
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGrave));
            this.lblBurial = new System.Windows.Forms.Label();
            this.cmbBurial = new System.Windows.Forms.ComboBox();
            this.lblGraveType = new System.Windows.Forms.Label();
            this.cmbGraveType = new System.Windows.Forms.ComboBox();
            this.txtBoxGrave = new System.Windows.Forms.TextBox();
            this.lblGrave = new System.Windows.Forms.Label();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGraveCover = new System.Windows.Forms.Label();
            this.cmbGraveCover = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkBoxReserved = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GroupBoxReserve = new System.Windows.Forms.GroupBox();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoornaam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStraat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWoonplaats = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGemeente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBoxReserve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBurial
            // 
            this.lblBurial.AutoSize = true;
            this.lblBurial.Location = new System.Drawing.Point(19, 20);
            this.lblBurial.Name = "lblBurial";
            this.lblBurial.Size = new System.Drawing.Size(72, 13);
            this.lblBurial.TabIndex = 0;
            this.lblBurial.Text = "Begraafplaats";
            // 
            // cmbBurial
            // 
            this.cmbBurial.FormattingEnabled = true;
            this.cmbBurial.Items.AddRange(new object[] {
            "Algemene Begraafplaats"});
            this.cmbBurial.Location = new System.Drawing.Point(97, 17);
            this.cmbBurial.Name = "cmbBurial";
            this.cmbBurial.Size = new System.Drawing.Size(121, 21);
            this.cmbBurial.TabIndex = 1;
            // 
            // lblGraveType
            // 
            this.lblGraveType.AutoSize = true;
            this.lblGraveType.Location = new System.Drawing.Point(41, 47);
            this.lblGraveType.Name = "lblGraveType";
            this.lblGraveType.Size = new System.Drawing.Size(50, 13);
            this.lblGraveType.TabIndex = 2;
            this.lblGraveType.Text = "Grafsoort";
            // 
            // cmbGraveType
            // 
            this.cmbGraveType.FormattingEnabled = true;
            this.cmbGraveType.Items.AddRange(new object[] {
            "Algemene Begraafplaats"});
            this.cmbGraveType.Location = new System.Drawing.Point(97, 44);
            this.cmbGraveType.Name = "cmbGraveType";
            this.cmbGraveType.Size = new System.Drawing.Size(121, 21);
            this.cmbGraveType.TabIndex = 3;
            // 
            // txtBoxGrave
            // 
            this.txtBoxGrave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxGrave.Location = new System.Drawing.Point(97, 71);
            this.txtBoxGrave.Name = "txtBoxGrave";
            this.txtBoxGrave.Size = new System.Drawing.Size(121, 20);
            this.txtBoxGrave.TabIndex = 4;
            // 
            // lblGrave
            // 
            this.lblGrave.AutoSize = true;
            this.lblGrave.Location = new System.Drawing.Point(64, 74);
            this.lblGrave.Name = "lblGrave";
            this.lblGrave.Size = new System.Drawing.Size(27, 13);
            this.lblGrave.TabIndex = 5;
            this.lblGrave.Text = "Graf";
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDescription.Location = new System.Drawing.Point(97, 97);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(121, 20);
            this.txtBoxDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(24, 100);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Omschrijving";
            // 
            // lblGraveCover
            // 
            this.lblGraveCover.AutoSize = true;
            this.lblGraveCover.Location = new System.Drawing.Point(14, 126);
            this.lblGraveCover.Name = "lblGraveCover";
            this.lblGraveCover.Size = new System.Drawing.Size(77, 26);
            this.lblGraveCover.TabIndex = 8;
            this.lblGraveCover.Text = "Grafbedekking\r\nGraf";
            // 
            // cmbGraveCover
            // 
            this.cmbGraveCover.FormattingEnabled = true;
            this.cmbGraveCover.Location = new System.Drawing.Point(97, 123);
            this.cmbGraveCover.Name = "cmbGraveCover";
            this.cmbGraveCover.Size = new System.Drawing.Size(121, 21);
            this.cmbGraveCover.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Grafische sleutel";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(97, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(116, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum afkoop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Datum ruiming";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(116, 110);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Datum delven\r\ngraf";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(116, 153);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker4.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum afstand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Onderhoud door";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Conditie";
            // 
            // chkBoxReserved
            // 
            this.chkBoxReserved.AutoSize = true;
            this.chkBoxReserved.Location = new System.Drawing.Point(15, 227);
            this.chkBoxReserved.Name = "chkBoxReserved";
            this.chkBoxReserved.Size = new System.Drawing.Size(81, 17);
            this.chkBoxReserved.TabIndex = 24;
            this.chkBoxReserved.Text = "Reserveren";
            this.chkBoxReserved.UseVisualStyleBackColor = true;
            this.chkBoxReserved.CheckedChanged += new System.EventHandler(this.chkBoxReserved_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Overledenen in het graf";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(616, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(364, 92);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechthebbende";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Adres";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(48, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(310, 20);
            this.textBox4.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Naam";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Algemene Begraafplaats"});
            this.comboBox1.Location = new System.Drawing.Point(97, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Algemene Begraafplaats"});
            this.comboBox2.Location = new System.Drawing.Point(97, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 21);
            this.comboBox2.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Location = new System.Drawing.Point(264, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 196);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Location = new System.Drawing.Point(616, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 98);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Onderhoud";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.lblBurial);
            this.groupBox4.Controls.Add(this.cmbBurial);
            this.groupBox4.Controls.Add(this.lblGraveType);
            this.groupBox4.Controls.Add(this.cmbGraveType);
            this.groupBox4.Controls.Add(this.txtBoxGrave);
            this.groupBox4.Controls.Add(this.lblGrave);
            this.groupBox4.Controls.Add(this.txtBoxDescription);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblDescription);
            this.groupBox4.Controls.Add(this.cmbGraveCover);
            this.groupBox4.Controls.Add(this.lblGraveCover);
            this.groupBox4.Location = new System.Drawing.Point(15, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 196);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Algemene informatie";
            // 
            // GroupBoxReserve
            // 
            this.GroupBoxReserve.Controls.Add(this.dateTimePicker6);
            this.GroupBoxReserve.Controls.Add(this.label13);
            this.GroupBoxReserve.Controls.Add(this.label12);
            this.GroupBoxReserve.Controls.Add(this.dateTimePicker5);
            this.GroupBoxReserve.Controls.Add(this.textBox2);
            this.GroupBoxReserve.Controls.Add(this.label11);
            this.GroupBoxReserve.Location = new System.Drawing.Point(102, 213);
            this.GroupBoxReserve.Name = "GroupBoxReserve";
            this.GroupBoxReserve.Size = new System.Drawing.Size(878, 48);
            this.GroupBoxReserve.TabIndex = 33;
            this.GroupBoxReserve.TabStop = false;
            this.GroupBoxReserve.Text = "Reserve";
            this.GroupBoxReserve.Visible = false;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Location = new System.Drawing.Point(672, 15);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker6.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(643, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Tot";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Van";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(437, 14);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker5.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(48, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Naam";
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Overledenen";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Location = new System.Drawing.Point(15, 280);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(965, 132);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colVoornaam,
            this.colStraat,
            this.colWoonplaats,
            this.colGemeente,
            this.colLand});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "dev-dc01.GA_TST.dbo";
            this.sqlDataSource1.Name = "sqlDataSource1";
            tableQuery1.Name = "Overledenen";
            tableInfo1.Name = "Overledenen";
            columnInfo1.Name = "Id";
            columnInfo2.Name = "Voornaam";
            columnInfo3.Name = "Straat";
            columnInfo4.Name = "Woonplaats";
            columnInfo5.Name = "Gemeente";
            columnInfo6.Name = "Land";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5,
            columnInfo6});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colVoornaam
            // 
            this.colVoornaam.FieldName = "Voornaam";
            this.colVoornaam.Name = "colVoornaam";
            this.colVoornaam.Visible = true;
            this.colVoornaam.VisibleIndex = 1;
            // 
            // colStraat
            // 
            this.colStraat.FieldName = "Straat";
            this.colStraat.Name = "colStraat";
            this.colStraat.Visible = true;
            this.colStraat.VisibleIndex = 2;
            // 
            // colWoonplaats
            // 
            this.colWoonplaats.FieldName = "Woonplaats";
            this.colWoonplaats.Name = "colWoonplaats";
            this.colWoonplaats.Visible = true;
            this.colWoonplaats.VisibleIndex = 3;
            // 
            // colGemeente
            // 
            this.colGemeente.FieldName = "Gemeente";
            this.colGemeente.Name = "colGemeente";
            this.colGemeente.Visible = true;
            this.colGemeente.VisibleIndex = 4;
            // 
            // colLand
            // 
            this.colLand.FieldName = "Land";
            this.colLand.Name = "colLand";
            this.colLand.Visible = true;
            this.colLand.VisibleIndex = 5;
            // 
            // AddGrave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(992, 423);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.GroupBoxReserve);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkBoxReserved);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddGrave";
            this.Text = "AddGrave";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.GroupBoxReserve.ResumeLayout(false);
            this.GroupBoxReserve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBurial;
        private System.Windows.Forms.ComboBox cmbBurial;
        private System.Windows.Forms.Label lblGraveType;
        private System.Windows.Forms.ComboBox cmbGraveType;
        private System.Windows.Forms.TextBox txtBoxGrave;
        private System.Windows.Forms.Label lblGrave;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGraveCover;
        private System.Windows.Forms.ComboBox cmbGraveCover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkBoxReserved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox GroupBoxReserve;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colVoornaam;
        private DevExpress.XtraGrid.Columns.GridColumn colStraat;
        private DevExpress.XtraGrid.Columns.GridColumn colWoonplaats;
        private DevExpress.XtraGrid.Columns.GridColumn colGemeente;
        private DevExpress.XtraGrid.Columns.GridColumn colLand;
    }
}