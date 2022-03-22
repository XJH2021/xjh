namespace 医院预约挂号系统
{
    partial class frm_个人信息
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
            this.lbl_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_Class = new System.Windows.Forms.Label();
            this.lbl_Specialty = new System.Windows.Forms.Label();
            this.txb_No = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.txb_Speciality = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_Class = new System.Windows.Forms.ComboBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.rdb_Male = new System.Windows.Forms.RadioButton();
            this.rdb_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.btn_OpenPhoto = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.ptb_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_No
            // 
            this.lbl_No.AutoSize = true;
            this.lbl_No.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_No.Location = new System.Drawing.Point(75, 61);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(69, 20);
            this.lbl_No.TabIndex = 0;
            this.lbl_No.Text = "学号：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Name.Location = new System.Drawing.Point(75, 127);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(69, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "姓名：";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_BirthDate.Location = new System.Drawing.Point(367, 61);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(69, 20);
            this.lbl_BirthDate.TabIndex = 2;
            this.lbl_BirthDate.Text = "生日：";
            // 
            // lbl_Class
            // 
            this.lbl_Class.AutoSize = true;
            this.lbl_Class.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Class.Location = new System.Drawing.Point(367, 127);
            this.lbl_Class.Name = "lbl_Class";
            this.lbl_Class.Size = new System.Drawing.Size(69, 20);
            this.lbl_Class.TabIndex = 3;
            this.lbl_Class.Text = "班级：";
            // 
            // lbl_Specialty
            // 
            this.lbl_Specialty.AutoSize = true;
            this.lbl_Specialty.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Specialty.Location = new System.Drawing.Point(367, 198);
            this.lbl_Specialty.Name = "lbl_Specialty";
            this.lbl_Specialty.Size = new System.Drawing.Size(69, 20);
            this.lbl_Specialty.TabIndex = 4;
            this.lbl_Specialty.Text = "特长：";
            // 
            // txb_No
            // 
            this.txb_No.Location = new System.Drawing.Point(148, 61);
            this.txb_No.Name = "txb_No";
            this.txb_No.Size = new System.Drawing.Size(100, 25);
            this.txb_No.TabIndex = 5;
            // 
            // txb_Name
            // 
            this.txb_Name.Location = new System.Drawing.Point(148, 127);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(100, 25);
            this.txb_Name.TabIndex = 6;
            // 
            // txb_Speciality
            // 
            this.txb_Speciality.Location = new System.Drawing.Point(444, 188);
            this.txb_Speciality.Name = "txb_Speciality";
            this.txb_Speciality.Size = new System.Drawing.Size(200, 25);
            this.txb_Speciality.TabIndex = 9;
            // 
            // dtp_BirthDate
            // 
            this.dtp_BirthDate.Location = new System.Drawing.Point(444, 61);
            this.dtp_BirthDate.Name = "dtp_BirthDate";
            this.dtp_BirthDate.Size = new System.Drawing.Size(200, 25);
            this.dtp_BirthDate.TabIndex = 10;
            // 
            // cmb_Class
            // 
            this.cmb_Class.FormattingEnabled = true;
            this.cmb_Class.Location = new System.Drawing.Point(444, 124);
            this.cmb_Class.Name = "cmb_Class";
            this.cmb_Class.Size = new System.Drawing.Size(200, 23);
            this.cmb_Class.TabIndex = 11;
            // 
            // rdb_Male
            // 
            this.rdb_Male.AutoSize = true;
            this.rdb_Male.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Male.Location = new System.Drawing.Point(148, 193);
            this.rdb_Male.Name = "rdb_Male";
            this.rdb_Male.Size = new System.Drawing.Size(50, 24);
            this.rdb_Male.TabIndex = 12;
            this.rdb_Male.TabStop = true;
            this.rdb_Male.Text = "男";
            this.rdb_Male.UseVisualStyleBackColor = true;
            // 
            // rdb_Female
            // 
            this.rdb_Female.AutoSize = true;
            this.rdb_Female.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdb_Female.Location = new System.Drawing.Point(204, 193);
            this.rdb_Female.Name = "rdb_Female";
            this.rdb_Female.Size = new System.Drawing.Size(50, 24);
            this.rdb_Female.TabIndex = 13;
            this.rdb_Female.TabStop = true;
            this.rdb_Female.Text = "女";
            this.rdb_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Gender.Location = new System.Drawing.Point(75, 193);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(69, 20);
            this.lbl_Gender.TabIndex = 14;
            this.lbl_Gender.Text = "性别：";
            // 
            // btn_OpenPhoto
            // 
            this.btn_OpenPhoto.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenPhoto.Location = new System.Drawing.Point(133, 386);
            this.btn_OpenPhoto.Name = "btn_OpenPhoto";
            this.btn_OpenPhoto.Size = new System.Drawing.Size(115, 33);
            this.btn_OpenPhoto.TabIndex = 15;
            this.btn_OpenPhoto.Text = "打开照片";
            this.btn_OpenPhoto.UseVisualStyleBackColor = true;
            this.btn_OpenPhoto.Click += new System.EventHandler(this.btn_OpenPhoto_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Update.Location = new System.Drawing.Point(550, 261);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 36);
            this.btn_Update.TabIndex = 16;
            this.btn_Update.Text = "更新";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Load.Location = new System.Drawing.Point(444, 261);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(80, 36);
            this.btn_Load.TabIndex = 17;
            this.btn_Load.Text = "载入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // ptb_Photo
            // 
            this.ptb_Photo.Location = new System.Drawing.Point(118, 239);
            this.ptb_Photo.Name = "ptb_Photo";
            this.ptb_Photo.Size = new System.Drawing.Size(148, 125);
            this.ptb_Photo.TabIndex = 18;
            this.ptb_Photo.TabStop = false;
            // 
            // frm_个人信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb_Photo);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_OpenPhoto);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.rdb_Female);
            this.Controls.Add(this.rdb_Male);
            this.Controls.Add(this.cmb_Class);
            this.Controls.Add(this.dtp_BirthDate);
            this.Controls.Add(this.txb_Speciality);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.txb_No);
            this.Controls.Add(this.lbl_Specialty);
            this.Controls.Add(this.lbl_Class);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_No);
            this.Name = "frm_个人信息";
            this.Text = "个人信息";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.Label lbl_Class;
        private System.Windows.Forms.Label lbl_Specialty;
        private System.Windows.Forms.TextBox txb_No;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.TextBox txb_Speciality;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtp_BirthDate;
        private System.Windows.Forms.ComboBox cmb_Class;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RadioButton rdb_Male;
        private System.Windows.Forms.RadioButton rdb_Female;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Button btn_OpenPhoto;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.PictureBox ptb_Photo;
    }
}