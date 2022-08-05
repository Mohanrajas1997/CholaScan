﻿namespace Chola
{
    partial class frmScan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScan));
            this.pnlBatch = new System.Windows.Forms.Panel();
            this.txtAgreemntNo = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtGnsaRefNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PacketRecv_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStartRanger = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnClrScan = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtBaseCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTranCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMicrCode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChqNo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblScanSerialNo = new System.Windows.Forms.Label();
            this.pnlImgType = new System.Windows.Forms.Panel();
            this.rdoUV = new System.Windows.Forms.RadioButton();
            this.rdoGray = new System.Windows.Forms.RadioButton();
            this.rdoBW = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlImgSide = new System.Windows.Forms.Panel();
            this.rdoRear = new System.Windows.Forms.RadioButton();
            this.rdoFront = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.picChq = new System.Windows.Forms.PictureBox();
            this.dgvScan = new System.Windows.Forms.DataGridView();
            this.axRanger1 = new AxRANGERLib.AxRanger();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.rdoReScanning = new System.Windows.Forms.RadioButton();
            this.rdoNewScanning = new System.Windows.Forms.RadioButton();
            this.dgvReScan = new System.Windows.Forms.DataGridView();
            this.pnlBatch.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlImgType.SuspendLayout();
            this.pnlImgSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axRanger1)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReScan)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBatch
            // 
            this.pnlBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBatch.Controls.Add(this.txtAgreemntNo);
            this.pnlBatch.Controls.Add(this.txtRemarks);
            this.pnlBatch.Controls.Add(this.txtGnsaRefNo);
            this.pnlBatch.Controls.Add(this.label7);
            this.pnlBatch.Controls.Add(this.PacketRecv_Date);
            this.pnlBatch.Controls.Add(this.label1);
            this.pnlBatch.Controls.Add(this.txtStatus);
            this.pnlBatch.Controls.Add(this.label5);
            this.pnlBatch.Controls.Add(this.label4);
            this.pnlBatch.Controls.Add(this.txtMode);
            this.pnlBatch.Controls.Add(this.label3);
            this.pnlBatch.Controls.Add(this.label2);
            this.pnlBatch.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBatch.Location = new System.Drawing.Point(8, 30);
            this.pnlBatch.Name = "pnlBatch";
            this.pnlBatch.Size = new System.Drawing.Size(708, 97);
            this.pnlBatch.TabIndex = 1;
            // 
            // txtAgreemntNo
            // 
            this.txtAgreemntNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgreemntNo.Location = new System.Drawing.Point(570, 11);
            this.txtAgreemntNo.MaxLength = 10;
            this.txtAgreemntNo.Name = "txtAgreemntNo";
            this.txtAgreemntNo.Size = new System.Drawing.Size(123, 21);
            this.txtAgreemntNo.TabIndex = 2;
            this.txtAgreemntNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(112, 65);
            this.txtRemarks.MaxLength = 45;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(581, 21);
            this.txtRemarks.TabIndex = 5;
            // 
            // txtGnsaRefNo
            // 
            this.txtGnsaRefNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGnsaRefNo.Location = new System.Drawing.Point(343, 11);
            this.txtGnsaRefNo.MaxLength = 45;
            this.txtGnsaRefNo.Name = "txtGnsaRefNo";
            this.txtGnsaRefNo.Size = new System.Drawing.Size(123, 21);
            this.txtGnsaRefNo.TabIndex = 1;
            this.txtGnsaRefNo.Leave += new System.EventHandler(this.txtGnsaRefNo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(263, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Gnsa Ref No";
            // 
            // PacketRecv_Date
            // 
            this.PacketRecv_Date.Checked = false;
            this.PacketRecv_Date.CustomFormat = "dd-MM-yyyy";
            this.PacketRecv_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PacketRecv_Date.Location = new System.Drawing.Point(112, 11);
            this.PacketRecv_Date.Name = "PacketRecv_Date";
            this.PacketRecv_Date.Size = new System.Drawing.Size(123, 21);
            this.PacketRecv_Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Packet Date";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(343, 38);
            this.txtStatus.MaxLength = 5;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(123, 21);
            this.txtStatus.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Packet Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Packet Remarks";
            // 
            // txtMode
            // 
            this.txtMode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMode.Location = new System.Drawing.Point(112, 38);
            this.txtMode.MaxLength = 45;
            this.txtMode.Name = "txtMode";
            this.txtMode.Size = new System.Drawing.Size(123, 21);
            this.txtMode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Packet Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agreement No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Packet Details";
            // 
            // btnStartRanger
            // 
            this.btnStartRanger.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStartRanger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartRanger.Location = new System.Drawing.Point(531, 3);
            this.btnStartRanger.Name = "btnStartRanger";
            this.btnStartRanger.Size = new System.Drawing.Size(78, 24);
            this.btnStartRanger.TabIndex = 7;
            this.btnStartRanger.Text = "Start";
            this.btnStartRanger.UseVisualStyleBackColor = false;
            this.btnStartRanger.Click += new System.EventHandler(this.btnStartRanger_Click);
            // 
            // btnScan
            // 
            this.btnScan.Enabled = false;
            this.btnScan.Location = new System.Drawing.Point(531, 29);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(78, 24);
            this.btnScan.TabIndex = 9;
            this.btnScan.Text = "Scan Cheque";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(531, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 24);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Complete";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(615, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 24);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Red;
            this.btnShutdown.Enabled = false;
            this.btnShutdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShutdown.Location = new System.Drawing.Point(615, 3);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(78, 24);
            this.btnShutdown.TabIndex = 8;
            this.btnShutdown.Text = "Stop";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnClrScan
            // 
            this.btnClrScan.Location = new System.Drawing.Point(615, 29);
            this.btnClrScan.Name = "btnClrScan";
            this.btnClrScan.Size = new System.Drawing.Size(78, 24);
            this.btnClrScan.TabIndex = 10;
            this.btnClrScan.Text = "Clear Scan";
            this.btnClrScan.UseVisualStyleBackColor = true;
            this.btnClrScan.Click += new System.EventHandler(this.btnClrScan_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlButton.Controls.Add(this.txtBaseCode);
            this.pnlButton.Controls.Add(this.label11);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.txtTranCode);
            this.pnlButton.Controls.Add(this.label14);
            this.pnlButton.Controls.Add(this.txtMicrCode);
            this.pnlButton.Controls.Add(this.label13);
            this.pnlButton.Controls.Add(this.txtChqNo);
            this.pnlButton.Controls.Add(this.label12);
            this.pnlButton.Controls.Add(this.lblScanSerialNo);
            this.pnlButton.Controls.Add(this.pnlImgType);
            this.pnlButton.Controls.Add(this.label10);
            this.pnlButton.Controls.Add(this.pnlImgSide);
            this.pnlButton.Controls.Add(this.label9);
            this.pnlButton.Controls.Add(this.btnShutdown);
            this.pnlButton.Controls.Add(this.btnClrScan);
            this.pnlButton.Controls.Add(this.btnStartRanger);
            this.pnlButton.Controls.Add(this.btnScan);
            this.pnlButton.Controls.Add(this.btnClose);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(8, 133);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(708, 118);
            this.pnlButton.TabIndex = 2;
            // 
            // txtBaseCode
            // 
            this.txtBaseCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseCode.Location = new System.Drawing.Point(112, 15);
            this.txtBaseCode.MaxLength = 45;
            this.txtBaseCode.Name = "txtBaseCode";
            this.txtBaseCode.Size = new System.Drawing.Size(123, 21);
            this.txtBaseCode.TabIndex = 0;
            this.txtBaseCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaseCode_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Base Code";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(615, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 24);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(531, 55);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 24);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTranCode
            // 
            this.txtTranCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranCode.Location = new System.Drawing.Point(344, 45);
            this.txtTranCode.MaxLength = 45;
            this.txtTranCode.Name = "txtTranCode";
            this.txtTranCode.Size = new System.Drawing.Size(123, 21);
            this.txtTranCode.TabIndex = 3;
            this.txtTranCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTranCode_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(274, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Tran Code";
            // 
            // txtMicrCode
            // 
            this.txtMicrCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMicrCode.Location = new System.Drawing.Point(112, 42);
            this.txtMicrCode.MaxLength = 45;
            this.txtMicrCode.Name = "txtMicrCode";
            this.txtMicrCode.Size = new System.Drawing.Size(123, 21);
            this.txtMicrCode.TabIndex = 2;
            this.txtMicrCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMicrCode_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Micr Code";
            // 
            // txtChqNo
            // 
            this.txtChqNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChqNo.Location = new System.Drawing.Point(344, 15);
            this.txtChqNo.MaxLength = 45;
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Size = new System.Drawing.Size(123, 21);
            this.txtChqNo.TabIndex = 1;
            this.txtChqNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtChqNo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Cheque No";
            // 
            // lblScanSerialNo
            // 
            this.lblScanSerialNo.AutoSize = true;
            this.lblScanSerialNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanSerialNo.ForeColor = System.Drawing.Color.Red;
            this.lblScanSerialNo.Location = new System.Drawing.Point(10, 2);
            this.lblScanSerialNo.Name = "lblScanSerialNo";
            this.lblScanSerialNo.Size = new System.Drawing.Size(86, 13);
            this.lblScanSerialNo.TabIndex = 24;
            this.lblScanSerialNo.Text = "Scan Serial No";
            // 
            // pnlImgType
            // 
            this.pnlImgType.Controls.Add(this.rdoUV);
            this.pnlImgType.Controls.Add(this.rdoGray);
            this.pnlImgType.Controls.Add(this.rdoBW);
            this.pnlImgType.Location = new System.Drawing.Point(344, 76);
            this.pnlImgType.Name = "pnlImgType";
            this.pnlImgType.Size = new System.Drawing.Size(159, 20);
            this.pnlImgType.TabIndex = 6;
            // 
            // rdoUV
            // 
            this.rdoUV.AutoSize = true;
            this.rdoUV.Location = new System.Drawing.Point(104, 0);
            this.rdoUV.Name = "rdoUV";
            this.rdoUV.Size = new System.Drawing.Size(40, 17);
            this.rdoUV.TabIndex = 2;
            this.rdoUV.Text = "UV";
            this.rdoUV.UseVisualStyleBackColor = true;
            this.rdoUV.CheckedChanged += new System.EventHandler(this.rdoUV_CheckedChanged);
            // 
            // rdoGray
            // 
            this.rdoGray.AutoSize = true;
            this.rdoGray.Location = new System.Drawing.Point(49, 0);
            this.rdoGray.Name = "rdoGray";
            this.rdoGray.Size = new System.Drawing.Size(52, 17);
            this.rdoGray.TabIndex = 1;
            this.rdoGray.Text = "Gray";
            this.rdoGray.UseVisualStyleBackColor = true;
            this.rdoGray.CheckedChanged += new System.EventHandler(this.rdoGray_CheckedChanged);
            // 
            // rdoBW
            // 
            this.rdoBW.AutoSize = true;
            this.rdoBW.Checked = true;
            this.rdoBW.Location = new System.Drawing.Point(0, 0);
            this.rdoBW.Name = "rdoBW";
            this.rdoBW.Size = new System.Drawing.Size(43, 17);
            this.rdoBW.TabIndex = 0;
            this.rdoBW.TabStop = true;
            this.rdoBW.Text = "BW";
            this.rdoBW.UseVisualStyleBackColor = true;
            this.rdoBW.CheckedChanged += new System.EventHandler(this.rdoBW_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Image Type";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlImgSide
            // 
            this.pnlImgSide.Controls.Add(this.rdoRear);
            this.pnlImgSide.Controls.Add(this.rdoFront);
            this.pnlImgSide.Location = new System.Drawing.Point(112, 76);
            this.pnlImgSide.Name = "pnlImgSide";
            this.pnlImgSide.Size = new System.Drawing.Size(123, 20);
            this.pnlImgSide.TabIndex = 5;
            // 
            // rdoRear
            // 
            this.rdoRear.AutoSize = true;
            this.rdoRear.Location = new System.Drawing.Point(71, 0);
            this.rdoRear.Name = "rdoRear";
            this.rdoRear.Size = new System.Drawing.Size(52, 17);
            this.rdoRear.TabIndex = 1;
            this.rdoRear.Text = "Rear";
            this.rdoRear.UseVisualStyleBackColor = true;
            this.rdoRear.CheckedChanged += new System.EventHandler(this.rdoRear_CheckedChanged);
            // 
            // rdoFront
            // 
            this.rdoFront.AutoSize = true;
            this.rdoFront.Checked = true;
            this.rdoFront.Location = new System.Drawing.Point(0, 0);
            this.rdoFront.Name = "rdoFront";
            this.rdoFront.Size = new System.Drawing.Size(55, 17);
            this.rdoFront.TabIndex = 0;
            this.rdoFront.TabStop = true;
            this.rdoFront.Text = "Front";
            this.rdoFront.UseVisualStyleBackColor = true;
            this.rdoFront.CheckedChanged += new System.EventHandler(this.rdoFront_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Image Side";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picChq
            // 
            this.picChq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picChq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picChq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picChq.ErrorImage = null;
            this.picChq.Location = new System.Drawing.Point(12, 257);
            this.picChq.Name = "picChq";
            this.picChq.Size = new System.Drawing.Size(447, 45);
            this.picChq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChq.TabIndex = 34;
            this.picChq.TabStop = false;
            // 
            // dgvScan
            // 
            this.dgvScan.AllowUserToAddRows = false;
            this.dgvScan.AllowUserToDeleteRows = false;
            this.dgvScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScan.Location = new System.Drawing.Point(4, 23);
            this.dgvScan.Name = "dgvScan";
            this.dgvScan.ReadOnly = true;
            this.dgvScan.Size = new System.Drawing.Size(568, 214);
            this.dgvScan.TabIndex = 3;
            this.dgvScan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_CellContentClick);
            this.dgvScan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScan_CellDoubleClick);
            // 
            // axRanger1
            // 
            this.axRanger1.Enabled = true;
            this.axRanger1.Location = new System.Drawing.Point(642, 308);
            this.axRanger1.Name = "axRanger1";
            this.axRanger1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRanger1.OcxState")));
            this.axRanger1.Size = new System.Drawing.Size(96, 93);
            this.axRanger1.TabIndex = 45;
            this.axRanger1.TransportNewState += new AxRANGERLib._DRangerEvents_TransportNewStateEventHandler(this.axRanger1_TransportNewState);
            this.axRanger1.TransportChangeOptionsState += new AxRANGERLib._DRangerEvents_TransportChangeOptionsStateEventHandler(this.axRanger1_TransportChangeOptionsState);
            this.axRanger1.TransportFeedingStopped += new AxRANGERLib._DRangerEvents_TransportFeedingStoppedEventHandler(this.axRanger1_TransportFeedingStopped);
            this.axRanger1.TransportNewItem += new System.EventHandler(this.axRanger1_TransportNewItem);
            this.axRanger1.TransportSetItemOutput += new AxRANGERLib._DRangerEvents_TransportSetItemOutputEventHandler(this.axRanger1_TransportSetItemOutput);
            this.axRanger1.TransportItemInPocket += new AxRANGERLib._DRangerEvents_TransportItemInPocketEventHandler(this.axRanger1_TransportItemInPocket);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.rdoReScanning);
            this.pnlGrid.Controls.Add(this.rdoNewScanning);
            this.pnlGrid.Controls.Add(this.dgvScan);
            this.pnlGrid.Controls.Add(this.dgvReScan);
            this.pnlGrid.Location = new System.Drawing.Point(720, 9);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(576, 242);
            this.pnlGrid.TabIndex = 46;
            // 
            // rdoReScanning
            // 
            this.rdoReScanning.AutoSize = true;
            this.rdoReScanning.Location = new System.Drawing.Point(198, 4);
            this.rdoReScanning.Name = "rdoReScanning";
            this.rdoReScanning.Size = new System.Drawing.Size(87, 17);
            this.rdoReScanning.TabIndex = 49;
            this.rdoReScanning.Text = "ReScan list";
            this.rdoReScanning.UseVisualStyleBackColor = true;
            this.rdoReScanning.CheckedChanged += new System.EventHandler(this.rdoReScanning_CheckedChanged);
            // 
            // rdoNewScanning
            // 
            this.rdoNewScanning.AutoSize = true;
            this.rdoNewScanning.Checked = true;
            this.rdoNewScanning.Location = new System.Drawing.Point(81, 4);
            this.rdoNewScanning.Name = "rdoNewScanning";
            this.rdoNewScanning.Size = new System.Drawing.Size(72, 17);
            this.rdoNewScanning.TabIndex = 48;
            this.rdoNewScanning.TabStop = true;
            this.rdoNewScanning.Text = "Scan list";
            this.rdoNewScanning.UseVisualStyleBackColor = true;
            this.rdoNewScanning.CheckedChanged += new System.EventHandler(this.rdoNewScanning_CheckedChanged);
            // 
            // dgvReScan
            // 
            this.dgvReScan.AllowUserToAddRows = false;
            this.dgvReScan.AllowUserToDeleteRows = false;
            this.dgvReScan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReScan.Location = new System.Drawing.Point(3, 22);
            this.dgvReScan.Name = "dgvReScan";
            this.dgvReScan.ReadOnly = true;
            this.dgvReScan.Size = new System.Drawing.Size(568, 214);
            this.dgvReScan.TabIndex = 47;
            this.dgvReScan.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReScan_CellContentDoubleClick);
            // 
            // frmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 487);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.axRanger1);
            this.Controls.Add(this.picChq);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlBatch);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmScan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheque Scanning";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanChq_FormClosing);
            this.Load += new System.EventHandler(this.ScanChq_Load);
            this.SizeChanged += new System.EventHandler(this.ScanChq_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmScan_KeyDown);
            this.pnlBatch.ResumeLayout(false);
            this.pnlBatch.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.pnlImgType.ResumeLayout(false);
            this.pnlImgType.PerformLayout();
            this.pnlImgSide.ResumeLayout(false);
            this.pnlImgSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picChq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axRanger1)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGnsaRefNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PacketRecv_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartRanger;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShutdown;
        private System.Windows.Forms.Button btnClrScan;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlImgType;
        private System.Windows.Forms.RadioButton rdoGray;
        private System.Windows.Forms.RadioButton rdoBW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlImgSide;
        private System.Windows.Forms.RadioButton rdoRear;
        private System.Windows.Forms.RadioButton rdoFront;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdoUV;
        private System.Windows.Forms.TextBox txtTranCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMicrCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtChqNo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblScanSerialNo;
        private System.Windows.Forms.PictureBox picChq;
        private System.Windows.Forms.DataGridView dgvScan;
        private AxRANGERLib.AxRanger axRanger1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtAgreemntNo;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtBaseCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvReScan;
        private System.Windows.Forms.RadioButton rdoReScanning;
        private System.Windows.Forms.RadioButton rdoNewScanning;
    }
}