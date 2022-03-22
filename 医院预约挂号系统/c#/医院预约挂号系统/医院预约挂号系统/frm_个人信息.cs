﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using static System.Environment;
using System.Drawing.Imaging;

namespace 医院预约挂号系统
{
    public partial class frm_个人信息 : Form
    {
        public frm_个人信息()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.cmb_Class.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_OpenPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPhotoDialog = new OpenFileDialog()
            {
                Title = "打开照片文件"
                ,
                Filter = "图像文件|*.bmp;*.jpg"
                ,
                InitialDirectory = GetFolderPath(SpecialFolder.MyPictures)
            };
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openPhotoDialog.FileName;
                this.ptb_Photo.Image = Image.FromFile(fileName);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=网上预约系统;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            SqlCommand sqlCommand2 = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand2.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_Class;";
            sqlCommand2.CommandText = "SELECT * FROM tb_Student WHERE No=@No;";
            sqlCommand2.Parameters.AddWithValue("@No", "3200707001");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable classTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(classTable);
            this.cmb_Class.DataSource = classTable;
            this.cmb_Class.DisplayMember = "Name";
            this.cmb_Class.ValueMember = "No";
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            byte[] photoBytes = null;
            if (sqlDataReader.Read())
            {
                this.txb_No.Text = sqlDataReader["No"].ToString();
                this.txb_Name.Text = sqlDataReader["Name"].ToString();
                this.rdb_Male.Checked = (bool)sqlDataReader["Gender"];
                this.rdb_Female.Checked = !(bool)sqlDataReader["Gender"];
                this.dtp_BirthDate.Value = (DateTime)sqlDataReader["BirthDate"];
                this.cmb_Class.SelectedValue = (int)sqlDataReader["ClassNo"];
                this.txb_Speciality.Text = sqlDataReader["Speciality"].ToString();
                photoBytes =
                    (sqlDataReader["Photo"] == DBNull.Value ? null : (byte[])sqlDataReader["Photo"]);
            }
            sqlDataReader.Close();
            if (photoBytes != null)
            {
                MemoryStream memoryStream = new MemoryStream(photoBytes);
                this.ptb_Photo.Image = Image.FromStream(memoryStream);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            MemoryStream memoryStream = new MemoryStream();
            this.ptb_Photo.Image.Save(memoryStream, ImageFormat.Bmp);
            byte[] photoBytes = new byte[memoryStream.Length];
            memoryStream.Seek(0, SeekOrigin.Begin);
            memoryStream.Read(photoBytes, 0, photoBytes.Length);
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
                "Server=(local);Database=EduBaseDemo;Integrated Security=sspi";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText =
                "UPDATE tb_Student" +
                 " SET Name=@Name,Gender=@Gender,BirthDate=@BirthDate,ClassNo=@ClassNo,Speciality=@Speciality,Photo=@Photo" +
                 " WHERE No=@No;";
            sqlCommand.Parameters.AddWithValue("@Name", this.txb_Name.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Gender", this.rdb_Male.Checked);
            sqlCommand.Parameters.AddWithValue("@BirthDate", this.dtp_BirthDate.Value);
            sqlCommand.Parameters.AddWithValue("@ClassNo", (int)this.cmb_Class.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@Speciality", this.txb_Speciality.Text.Trim());
            sqlCommand.Parameters.AddWithValue("@Photo", photoBytes);
            sqlCommand.Parameters.AddWithValue("@No", "3200707001");
            sqlConnection.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show($"更新{rowAffected}行。");
        }
    }
}
