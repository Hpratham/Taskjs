namespace CRM1
{
    partial class frmEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblStudFullName = new System.Windows.Forms.Label();
            this.lblStudMobileNo = new System.Windows.Forms.Label();
            this.lblStudAlternateMobileNo = new System.Windows.Forms.Label();
            this.lblStudEmailId = new System.Windows.Forms.Label();
            this.lblStudGender = new System.Windows.Forms.Label();
            this.lblPermenantAddress = new System.Windows.Forms.Label();
            this.lblPresentAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblGraduation = new System.Windows.Forms.Label();
            this.lblPG = new System.Windows.Forms.Label();
            this.lblOther = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblTimePrefered = new System.Windows.Forms.Label();
            this.lblEnquirySource = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtAlternateno = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.rtxtpresentaddress = new System.Windows.Forms.RichTextBox();
            this.rtxtpermenantaddress = new System.Windows.Forms.RichTextBox();
            this.cmbbxCountry = new System.Windows.Forms.ComboBox();
            this.cmbbxCity = new System.Windows.Forms.ComboBox();
            this.cmbbxState = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmbbxgraduation = new System.Windows.Forms.ComboBox();
            this.cmbbxPG = new System.Windows.Forms.ComboBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.chkbxSeminar = new System.Windows.Forms.CheckBox();
            this.chkbxfriendreference = new System.Windows.Forms.CheckBox();
            this.chkbxPoster = new System.Windows.Forms.CheckBox();
            this.chkbxOther = new System.Windows.Forms.CheckBox();
            this.rdbtnStudent = new System.Windows.Forms.RadioButton();
            this.rdbtnEmployed = new System.Windows.Forms.RadioButton();
            this.rdbtnnonEmployed = new System.Windows.Forms.RadioButton();
            this.chkbxMorning = new System.Windows.Forms.CheckBox();
            this.chkbxAfternoon = new System.Windows.Forms.CheckBox();
            this.chkbxWeekend = new System.Windows.Forms.CheckBox();
            this.chkbxEvenning = new System.Windows.Forms.CheckBox();
            this.cmbbxEnquirySource = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.grdCourse1 = new System.Windows.Forms.DataGridView();
            this.clmCourse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudFullName
            // 
            this.lblStudFullName.AutoSize = true;
            this.lblStudFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudFullName.Location = new System.Drawing.Point(13, 90);
            this.lblStudFullName.Name = "lblStudFullName";
            this.lblStudFullName.Size = new System.Drawing.Size(148, 25);
            this.lblStudFullName.TabIndex = 1;
            this.lblStudFullName.Text = "StudFullName";
            this.lblStudFullName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblStudMobileNo
            // 
            this.lblStudMobileNo.AutoSize = true;
            this.lblStudMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudMobileNo.Location = new System.Drawing.Point(12, 191);
            this.lblStudMobileNo.Name = "lblStudMobileNo";
            this.lblStudMobileNo.Size = new System.Drawing.Size(148, 25);
            this.lblStudMobileNo.TabIndex = 2;
            this.lblStudMobileNo.Text = "StudMobileNo";
            // 
            // lblStudAlternateMobileNo
            // 
            this.lblStudAlternateMobileNo.AutoSize = true;
            this.lblStudAlternateMobileNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudAlternateMobileNo.Location = new System.Drawing.Point(12, 330);
            this.lblStudAlternateMobileNo.Name = "lblStudAlternateMobileNo";
            this.lblStudAlternateMobileNo.Size = new System.Drawing.Size(171, 25);
            this.lblStudAlternateMobileNo.TabIndex = 3;
            this.lblStudAlternateMobileNo.Text = "StudAlternateNo";
            // 
            // lblStudEmailId
            // 
            this.lblStudEmailId.AutoSize = true;
            this.lblStudEmailId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudEmailId.Location = new System.Drawing.Point(24, 481);
            this.lblStudEmailId.Name = "lblStudEmailId";
            this.lblStudEmailId.Size = new System.Drawing.Size(128, 25);
            this.lblStudEmailId.TabIndex = 4;
            this.lblStudEmailId.Text = "StudEmailId";
            // 
            // lblStudGender
            // 
            this.lblStudGender.AutoSize = true;
            this.lblStudGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudGender.Location = new System.Drawing.Point(24, 661);
            this.lblStudGender.Name = "lblStudGender";
            this.lblStudGender.Size = new System.Drawing.Size(128, 25);
            this.lblStudGender.TabIndex = 5;
            this.lblStudGender.Text = "StudGender";
            // 
            // lblPermenantAddress
            // 
            this.lblPermenantAddress.AutoSize = true;
            this.lblPermenantAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermenantAddress.Location = new System.Drawing.Point(12, 813);
            this.lblPermenantAddress.Name = "lblPermenantAddress";
            this.lblPermenantAddress.Size = new System.Drawing.Size(196, 25);
            this.lblPermenantAddress.TabIndex = 6;
            this.lblPermenantAddress.Text = "PermenantAddress";
            // 
            // lblPresentAddress
            // 
            this.lblPresentAddress.AutoSize = true;
            this.lblPresentAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentAddress.Location = new System.Drawing.Point(600, 813);
            this.lblPresentAddress.Name = "lblPresentAddress";
            this.lblPresentAddress.Size = new System.Drawing.Size(166, 25);
            this.lblPresentAddress.TabIndex = 7;
            this.lblPresentAddress.Text = "PresentAddress";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(642, 96);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(88, 25);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(648, 182);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(63, 25);
            this.lblState.TabIndex = 9;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(648, 259);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 25);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(648, 372);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(648, 467);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(43, 25);
            this.lblPin.TabIndex = 12;
            this.lblPin.Text = "Pin";
            // 
            // lblGraduation
            // 
            this.lblGraduation.AutoSize = true;
            this.lblGraduation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGraduation.Location = new System.Drawing.Point(627, 562);
            this.lblGraduation.Name = "lblGraduation";
            this.lblGraduation.Size = new System.Drawing.Size(118, 25);
            this.lblGraduation.TabIndex = 13;
            this.lblGraduation.Text = "Graduation";
            // 
            // lblPG
            // 
            this.lblPG.AutoSize = true;
            this.lblPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPG.Location = new System.Drawing.Point(642, 668);
            this.lblPG.Name = "lblPG";
            this.lblPG.Size = new System.Drawing.Size(42, 25);
            this.lblPG.TabIndex = 14;
            this.lblPG.Text = "PG";
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOther.Location = new System.Drawing.Point(1268, 96);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(66, 25);
            this.lblOther.TabIndex = 15;
            this.lblOther.Text = "Other";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1276, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 25);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(1276, 352);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(110, 25);
            this.lblReference.TabIndex = 18;
            this.lblReference.Text = "Reference";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(1289, 531);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(82, 25);
            this.lblCourse.TabIndex = 19;
            this.lblCourse.Text = "Course";
            // 
            // lblTimePrefered
            // 
            this.lblTimePrefered.AutoSize = true;
            this.lblTimePrefered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePrefered.Location = new System.Drawing.Point(1289, 732);
            this.lblTimePrefered.Name = "lblTimePrefered";
            this.lblTimePrefered.Size = new System.Drawing.Size(142, 25);
            this.lblTimePrefered.TabIndex = 20;
            this.lblTimePrefered.Text = "TimePrefered";
            // 
            // lblEnquirySource
            // 
            this.lblEnquirySource.AutoSize = true;
            this.lblEnquirySource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnquirySource.Location = new System.Drawing.Point(1289, 837);
            this.lblEnquirySource.Name = "lblEnquirySource";
            this.lblEnquirySource.Size = new System.Drawing.Size(154, 25);
            this.lblEnquirySource.TabIndex = 21;
            this.lblEnquirySource.Text = "EnquirySource";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(306, 90);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(61, 18);
            this.lblfullname.TabIndex = 23;
            this.lblfullname.Text = "label24";
            // 
            // txtmobileno
            // 
            this.txtmobileno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobileno.Location = new System.Drawing.Point(180, 187);
            this.txtmobileno.MaxLength = 14;
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(366, 30);
            this.txtmobileno.TabIndex = 83;
            // 
            // txtAlternateno
            // 
            this.txtAlternateno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternateno.Location = new System.Drawing.Point(180, 326);
            this.txtAlternateno.MaxLength = 14;
            this.txtAlternateno.Name = "txtAlternateno";
            this.txtAlternateno.Size = new System.Drawing.Size(366, 30);
            this.txtAlternateno.TabIndex = 84;
            // 
            // txtemailid
            // 
            this.txtemailid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemailid.Location = new System.Drawing.Point(180, 477);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(366, 30);
            this.txtemailid.TabIndex = 85;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbtnFemale);
            this.panel1.Controls.Add(this.rdbtnMale);
            this.panel1.Location = new System.Drawing.Point(180, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 87);
            this.panel1.TabIndex = 113;
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFemale.Location = new System.Drawing.Point(213, 39);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(104, 29);
            this.rdbtnFemale.TabIndex = 22;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMale.Location = new System.Drawing.Point(18, 39);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(80, 29);
            this.rdbtnMale.TabIndex = 21;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // rtxtpresentaddress
            // 
            this.rtxtpresentaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtpresentaddress.Location = new System.Drawing.Point(214, 771);
            this.rtxtpresentaddress.Name = "rtxtpresentaddress";
            this.rtxtpresentaddress.Size = new System.Drawing.Size(366, 96);
            this.rtxtpresentaddress.TabIndex = 119;
            this.rtxtpresentaddress.Text = "";
            // 
            // rtxtpermenantaddress
            // 
            this.rtxtpermenantaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtpermenantaddress.Location = new System.Drawing.Point(791, 788);
            this.rtxtpermenantaddress.Name = "rtxtpermenantaddress";
            this.rtxtpermenantaddress.Size = new System.Drawing.Size(366, 96);
            this.rtxtpermenantaddress.TabIndex = 120;
            this.rtxtpermenantaddress.Text = "";
            // 
            // cmbbxCountry
            // 
            this.cmbbxCountry.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCountry.FormattingEnabled = true;
            this.cmbbxCountry.Location = new System.Drawing.Point(781, 92);
            this.cmbbxCountry.Name = "cmbbxCountry";
            this.cmbbxCountry.Size = new System.Drawing.Size(376, 31);
            this.cmbbxCountry.TabIndex = 121;
            this.cmbbxCountry.SelectedIndexChanged += new System.EventHandler(this.cmbbxCountry_SelectedIndexChanged);
            // 
            // cmbbxCity
            // 
            this.cmbbxCity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxCity.FormattingEnabled = true;
            this.cmbbxCity.Location = new System.Drawing.Point(781, 253);
            this.cmbbxCity.Name = "cmbbxCity";
            this.cmbbxCity.Size = new System.Drawing.Size(376, 31);
            this.cmbbxCity.TabIndex = 122;
            // 
            // cmbbxState
            // 
            this.cmbbxState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxState.FormattingEnabled = true;
            this.cmbbxState.Location = new System.Drawing.Point(781, 176);
            this.cmbbxState.Name = "cmbbxState";
            this.cmbbxState.Size = new System.Drawing.Size(376, 31);
            this.cmbbxState.TabIndex = 122;
            this.cmbbxState.SelectedIndexChanged += new System.EventHandler(this.cmbbxState_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Location = new System.Drawing.Point(781, 368);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(376, 30);
            this.dtp.TabIndex = 123;
            // 
            // cmbbxgraduation
            // 
            this.cmbbxgraduation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxgraduation.FormattingEnabled = true;
            this.cmbbxgraduation.Location = new System.Drawing.Point(781, 556);
            this.cmbbxgraduation.Name = "cmbbxgraduation";
            this.cmbbxgraduation.Size = new System.Drawing.Size(376, 31);
            this.cmbbxgraduation.TabIndex = 125;
            // 
            // cmbbxPG
            // 
            this.cmbbxPG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPG.FormattingEnabled = true;
            this.cmbbxPG.Location = new System.Drawing.Point(781, 662);
            this.cmbbxPG.Name = "cmbbxPG";
            this.cmbbxPG.Size = new System.Drawing.Size(376, 31);
            this.cmbbxPG.TabIndex = 126;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(1493, 89);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(366, 30);
            this.txtOther.TabIndex = 127;
            // 
            // chkbxSeminar
            // 
            this.chkbxSeminar.AutoSize = true;
            this.chkbxSeminar.Location = new System.Drawing.Point(1498, 305);
            this.chkbxSeminar.Name = "chkbxSeminar";
            this.chkbxSeminar.Size = new System.Drawing.Size(125, 20);
            this.chkbxSeminar.TabIndex = 129;
            this.chkbxSeminar.Text = "SeminarAttende";
            this.chkbxSeminar.UseVisualStyleBackColor = true;
            // 
            // chkbxfriendreference
            // 
            this.chkbxfriendreference.AutoSize = true;
            this.chkbxfriendreference.Location = new System.Drawing.Point(1726, 305);
            this.chkbxfriendreference.Name = "chkbxfriendreference";
            this.chkbxfriendreference.Size = new System.Drawing.Size(130, 20);
            this.chkbxfriendreference.TabIndex = 130;
            this.chkbxfriendreference.Text = "FriendReference";
            this.chkbxfriendreference.UseVisualStyleBackColor = true;
            // 
            // chkbxPoster
            // 
            this.chkbxPoster.AutoSize = true;
            this.chkbxPoster.Location = new System.Drawing.Point(1498, 400);
            this.chkbxPoster.Name = "chkbxPoster";
            this.chkbxPoster.Size = new System.Drawing.Size(68, 20);
            this.chkbxPoster.TabIndex = 131;
            this.chkbxPoster.Text = "Poster";
            this.chkbxPoster.UseVisualStyleBackColor = true;
            // 
            // chkbxOther
            // 
            this.chkbxOther.AutoSize = true;
            this.chkbxOther.Location = new System.Drawing.Point(1749, 400);
            this.chkbxOther.Name = "chkbxOther";
            this.chkbxOther.Size = new System.Drawing.Size(61, 20);
            this.chkbxOther.TabIndex = 132;
            this.chkbxOther.Text = "Other";
            this.chkbxOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnStudent
            // 
            this.rdbtnStudent.AutoSize = true;
            this.rdbtnStudent.Location = new System.Drawing.Point(1498, 176);
            this.rdbtnStudent.Name = "rdbtnStudent";
            this.rdbtnStudent.Size = new System.Drawing.Size(73, 20);
            this.rdbtnStudent.TabIndex = 136;
            this.rdbtnStudent.TabStop = true;
            this.rdbtnStudent.Text = "Student";
            this.rdbtnStudent.UseVisualStyleBackColor = true;
            // 
            // rdbtnEmployed
            // 
            this.rdbtnEmployed.AutoSize = true;
            this.rdbtnEmployed.Location = new System.Drawing.Point(1626, 236);
            this.rdbtnEmployed.Name = "rdbtnEmployed";
            this.rdbtnEmployed.Size = new System.Drawing.Size(90, 20);
            this.rdbtnEmployed.TabIndex = 137;
            this.rdbtnEmployed.TabStop = true;
            this.rdbtnEmployed.Text = "Employed";
            this.rdbtnEmployed.UseVisualStyleBackColor = true;
            // 
            // rdbtnnonEmployed
            // 
            this.rdbtnnonEmployed.AutoSize = true;
            this.rdbtnnonEmployed.Location = new System.Drawing.Point(1728, 176);
            this.rdbtnnonEmployed.Name = "rdbtnnonEmployed";
            this.rdbtnnonEmployed.Size = new System.Drawing.Size(115, 20);
            this.rdbtnnonEmployed.TabIndex = 138;
            this.rdbtnnonEmployed.TabStop = true;
            this.rdbtnnonEmployed.Text = "NonEmployed";
            this.rdbtnnonEmployed.UseVisualStyleBackColor = true;
            // 
            // chkbxMorning
            // 
            this.chkbxMorning.AutoSize = true;
            this.chkbxMorning.Location = new System.Drawing.Point(1498, 708);
            this.chkbxMorning.Name = "chkbxMorning";
            this.chkbxMorning.Size = new System.Drawing.Size(77, 20);
            this.chkbxMorning.TabIndex = 139;
            this.chkbxMorning.Text = "Morning";
            this.chkbxMorning.UseVisualStyleBackColor = true;
            this.chkbxMorning.CheckedChanged += new System.EventHandler(this.chkbxMorning_CheckedChanged);
            // 
            // chkbxAfternoon
            // 
            this.chkbxAfternoon.AutoSize = true;
            this.chkbxAfternoon.Location = new System.Drawing.Point(1755, 708);
            this.chkbxAfternoon.Name = "chkbxAfternoon";
            this.chkbxAfternoon.Size = new System.Drawing.Size(86, 20);
            this.chkbxAfternoon.TabIndex = 140;
            this.chkbxAfternoon.Text = "Afternoon";
            this.chkbxAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkbxWeekend
            // 
            this.chkbxWeekend.AutoSize = true;
            this.chkbxWeekend.Location = new System.Drawing.Point(1755, 769);
            this.chkbxWeekend.Name = "chkbxWeekend";
            this.chkbxWeekend.Size = new System.Drawing.Size(88, 20);
            this.chkbxWeekend.TabIndex = 141;
            this.chkbxWeekend.Text = "Weekend";
            this.chkbxWeekend.UseVisualStyleBackColor = true;
            // 
            // chkbxEvenning
            // 
            this.chkbxEvenning.AutoSize = true;
            this.chkbxEvenning.Location = new System.Drawing.Point(1498, 771);
            this.chkbxEvenning.Name = "chkbxEvenning";
            this.chkbxEvenning.Size = new System.Drawing.Size(78, 20);
            this.chkbxEvenning.TabIndex = 142;
            this.chkbxEvenning.Text = "Evening";
            this.chkbxEvenning.UseVisualStyleBackColor = true;
            // 
            // cmbbxEnquirySource
            // 
            this.cmbbxEnquirySource.FormattingEnabled = true;
            this.cmbbxEnquirySource.Location = new System.Drawing.Point(1498, 837);
            this.cmbbxEnquirySource.Name = "cmbbxEnquirySource";
            this.cmbbxEnquirySource.Size = new System.Drawing.Size(360, 24);
            this.cmbbxEnquirySource.TabIndex = 143;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(859, 932);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 30);
            this.btnUpdate.TabIndex = 144;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1047, 932);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 30);
            this.btnClear.TabIndex = 145;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(781, 462);
            this.txtPin.MaxLength = 8;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(376, 30);
            this.txtPin.TabIndex = 146;
            // 
            // grdCourse1
            // 
            this.grdCourse1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCourse1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdCourse1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCourse1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCourse});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCourse1.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdCourse1.GridColor = System.Drawing.SystemColors.Control;
            this.grdCourse1.Location = new System.Drawing.Point(1498, 493);
            this.grdCourse1.Name = "grdCourse1";
            this.grdCourse1.RowHeadersWidth = 51;
            this.grdCourse1.RowTemplate.Height = 24;
            this.grdCourse1.Size = new System.Drawing.Size(352, 150);
            this.grdCourse1.TabIndex = 147;
            // 
            // clmCourse
            // 
            this.clmCourse.HeaderText = "Select";
            this.clmCourse.MinimumWidth = 6;
            this.clmCourse.Name = "clmCourse";
            this.clmCourse.Width = 125;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 148;
            this.label1.Text = "Edit";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 996);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCourse1);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbbxEnquirySource);
            this.Controls.Add(this.chkbxEvenning);
            this.Controls.Add(this.chkbxWeekend);
            this.Controls.Add(this.chkbxAfternoon);
            this.Controls.Add(this.chkbxMorning);
            this.Controls.Add(this.rdbtnnonEmployed);
            this.Controls.Add(this.rdbtnEmployed);
            this.Controls.Add(this.rdbtnStudent);
            this.Controls.Add(this.chkbxOther);
            this.Controls.Add(this.chkbxPoster);
            this.Controls.Add(this.chkbxfriendreference);
            this.Controls.Add(this.chkbxSeminar);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.cmbbxPG);
            this.Controls.Add(this.cmbbxgraduation);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmbbxState);
            this.Controls.Add(this.cmbbxCity);
            this.Controls.Add(this.cmbbxCountry);
            this.Controls.Add(this.rtxtpermenantaddress);
            this.Controls.Add(this.rtxtpresentaddress);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.txtAlternateno);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.lblEnquirySource);
            this.Controls.Add(this.lblTimePrefered);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.lblPG);
            this.Controls.Add(this.lblGraduation);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblPresentAddress);
            this.Controls.Add(this.lblPermenantAddress);
            this.Controls.Add(this.lblStudGender);
            this.Controls.Add(this.lblStudEmailId);
            this.Controls.Add(this.lblStudAlternateMobileNo);
            this.Controls.Add(this.lblStudMobileNo);
            this.Controls.Add(this.lblStudFullName);
            this.Name = "frmEdit";
            this.Text = "frmEdit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStudFullName;
        private System.Windows.Forms.Label lblStudMobileNo;
        private System.Windows.Forms.Label lblStudAlternateMobileNo;
        private System.Windows.Forms.Label lblStudEmailId;
        private System.Windows.Forms.Label lblStudGender;
        private System.Windows.Forms.Label lblPermenantAddress;
        private System.Windows.Forms.Label lblPresentAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblGraduation;
        private System.Windows.Forms.Label lblPG;
        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblTimePrefered;
        private System.Windows.Forms.Label lblEnquirySource;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtAlternateno;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.RichTextBox rtxtpresentaddress;
        private System.Windows.Forms.RichTextBox rtxtpermenantaddress;
        private System.Windows.Forms.ComboBox cmbbxCountry;
        private System.Windows.Forms.ComboBox cmbbxCity;
        private System.Windows.Forms.ComboBox cmbbxState;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmbbxgraduation;
        private System.Windows.Forms.ComboBox cmbbxPG;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.CheckBox chkbxSeminar;
        private System.Windows.Forms.CheckBox chkbxfriendreference;
        private System.Windows.Forms.CheckBox chkbxPoster;
        private System.Windows.Forms.CheckBox chkbxOther;
        private System.Windows.Forms.RadioButton rdbtnStudent;
        private System.Windows.Forms.RadioButton rdbtnEmployed;
        private System.Windows.Forms.RadioButton rdbtnnonEmployed;
        private System.Windows.Forms.CheckBox chkbxMorning;
        private System.Windows.Forms.CheckBox chkbxAfternoon;
        private System.Windows.Forms.CheckBox chkbxWeekend;
        private System.Windows.Forms.CheckBox chkbxEvenning;
        private System.Windows.Forms.ComboBox cmbbxEnquirySource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.DataGridView grdCourse1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCourse;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
    }
}