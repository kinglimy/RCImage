using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace RCImageWinForm
{
    public partial class Form1 : Form
    {
        DataTable tableNormal = new DataTable("RCImage");
        DataTable tableError = new DataTable("RCError");
        IList<string> dataAreaIDList = new List<string>();
        string connectionString;
        int maxFileSize;
        int maxWidth;
        int maxHeight;
        string[] supportedExtensions;
    
        public Form1()
        {
            InitializeComponent();

            tableNormal.Columns.Add("RCName", typeof(string));
            tableNormal.Columns.Add("FullPath", typeof(string));
            tableNormal.Columns.Add("FileSize", typeof(int));
            tableNormal.Columns.Add("Image", typeof(System.Drawing.Image));
            tableNormal.Columns.Add("intWidth", typeof(int));
            tableNormal.Columns.Add("intHeight", typeof(int));

            tableError.Columns.Add("RCName", typeof(string));
            tableError.Columns.Add("FullPath", typeof(string));
            tableError.Columns.Add("FileSize", typeof(int));
            tableError.Columns.Add("Image", typeof(System.Drawing.Image));
            tableError.Columns.Add("intWidth", typeof(int));
            tableError.Columns.Add("intHeight", typeof(int));

            string file = System.Windows.Forms.Application.ExecutablePath;
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            connectionString =
                config.ConnectionStrings.ConnectionStrings["Image_RCConnectionString_SQL"].ConnectionString.ToString();

            maxFileSize = int.Parse(config.AppSettings.Settings["MaxFileSize"].Value.ToString());
            maxWidth = int.Parse(config.AppSettings.Settings["MaxWidth"].Value.ToString());
            maxHeight = int.Parse(config.AppSettings.Settings["MaxHeight"].Value.ToString());

            supportedExtensions = config.AppSettings.Settings["AllowFileStyle"].Value.ToString().Split('|');

            string[] allDataAreaID = config.AppSettings.Settings["AllowDataAreaID"].Value.ToString().Split('|');
            foreach (string s in allDataAreaID)
                dataAreaIDList.Add(s);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //tabControl1.TabPages[2].Hide();

            cmbDataAreaID.DataSource = dataAreaIDList;
            tabControl1.Controls.Remove(tpgConfig);
        }

        //private void btnRead_Click(object sender, EventArgs e)
        //{
        //    #region 注释掉从文件读取
        //    ////初始化一个OpenFileDialog类
        //    //OpenFileDialog fileDialog = new OpenFileDialog();

        //    ////判断用户是否正确的选择了文件
        //    //if (fileDialog.ShowDialog() == DialogResult.OK)
        //    //{
        //    //    //获取用户选择文件的后缀名
        //    //    string extension = Path.GetExtension(fileDialog.FileName);
        //    //    //声明允许的后缀名
        //    //    string[] str = new string[] { ".gif", ".jpge", ".jpg" };
        //    //    if (!((IList)str).Contains(extension))
        //    //    {
        //    //        MessageBox.Show("仅能上传gif,jpge,jpg格式的图片！");
        //    //    }
        //    //    else
        //    //    {
        //    //        //获取用户选择的文件，并判断文件大小不能超过20K，fileInfo.Length是以字节为单位的
        //    //        FileInfo fileInfo = new FileInfo(fileDialog.FileName);
        //    //        if (fileInfo.Length > 20480)
        //    //        {
        //    //            MessageBox.Show("上传的图片不能大于20K");
        //    //        }
        //    //        else
        //    //        {
        //    //            //在这里就可以写获取到正确文件后的代码了
        //    //            MessageBox.Show(Path.GetFullPath(fileDialog.FileName));
        //    //            picImage.Image = Image.FromFile(Path.GetFullPath(fileDialog.FileName));
        //    //            this.txtFileFullPath.Text = Path.GetFullPath(fileDialog.FileName);

        //    //            this.txtRC.Text = fileInfo.Name.Substring(0, fileInfo.Name.Length - 4);
        //    //        }
        //    //    }
        //    //}
        //    #endregion

        //    //string strConn = "Data Source=.;Initial Catalog=Image.RC;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connectionString);

        //    conn.Open();

        //    SqlCommand cmd = new SqlCommand(connectionString, conn);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.CommandText = connectionString;

        //    cmd.CommandText = "select Image from RCImage where RC=@RC";

        //    cmd.Parameters.Add("@RC", SqlDbType.NVarChar);
        //    cmd.Parameters["@RC"].Value = this.txtRC.Text;

        //    //SqlCommand cmd = new SqlCommand("select Image from RCImage where RC=@RC", conn);
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    reader.Read();

        //    if (reader.HasRows)
        //    {
        //        MemoryStream buf = new MemoryStream((byte[])reader[0]);
        //        Image image = Image.FromStream(buf, true);

        //        picImage.Image = image;
        //    }
        //    else
        //    {
        //        MessageBox.Show("找不到输入RC对应的记录");
        //    }
        //}

        private void btnOpen_Click(object sender, EventArgs e)
        {
            tableError.Clear();
            tableNormal.Clear();

            FolderBrowserDialog fbDlg = new FolderBrowserDialog();

            if (fbDlg.ShowDialog() == DialogResult.OK)
            {
                txtDir.Text = fbDlg.SelectedPath;

                string myDir = txtDir.Text.Trim().ToString();

                DirectoryInfo folder = new DirectoryInfo(myDir);

                foreach (FileInfo file in folder.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    //获取用户选择文件的后缀名
                    string extension = Path.GetExtension(file.Name);
                    //声明允许的后缀名
                    //string[] str = new string[] { ".gif", ".jpge", ".jpg" };
                    int fileWidth = int.MaxValue;
                    int fileHeight = int.MaxValue;

                    Image pic = null;

                    if (((IList)supportedExtensions).Contains(extension.ToLower()))
                    {
                        string pathImage = file.FullName;
                        pic = Image.FromFile(Path.GetFullPath(pathImage));

                        fileWidth = pic.Width;
                        fileHeight = pic.Height;
                    }

                    if (file.Length > maxFileSize || fileWidth > maxWidth || fileHeight > maxHeight || !((IList)supportedExtensions).Contains(extension))
                    {
                        DataRow row = tableError.NewRow();

                        row[0] = file.Name.Substring(0, file.Name.Length - 4);

                        string pathImage = file.FullName;
                        row[1] = pathImage;

                        row[2] = file.Length;

                        if (((IList)supportedExtensions).Contains(extension))
                        {
                            row[3] = pic;

                            row[4] = pic.Width;
                            row[5] = pic.Height;
                        }

                        tableError.Rows.Add(row);
                    }
                    else
                    {
                        DataRow row = tableNormal.NewRow();

                        row[0] = file.Name.Substring(0, file.Name.Length - 4);

                        string pathImage = file.FullName;
                        row[1] = pathImage;

                        row[2] = file.Length;

                        //Image pic = Image.FromFile(Path.GetFullPath(pathImage));

                        //row[3] = Image.FromFile(Path.GetFullPath(pathImage));
                        row[3] = pic;

                        row[4] = pic.Width;
                        row[5] = pic.Height;

                        tableNormal.Rows.Add(row);
                    }
                }

                dgvFileInfo.DataSource = tableNormal;
                dgvErrorFileInfo.DataSource = tableError;

                //if (tableNormal.Rows.Count > 0)
                //{
                //    txtFullPath2.Text = tableNormal.Rows[0][1].ToString();
                //    txtRCName2.Text = tableNormal.Rows[0][0].ToString();
                //    txtFileSize2.Text = tableNormal.Rows[0][2].ToString();

                //    picImage2.Image = (System.Drawing.Image)tableNormal.Rows[0][3];
                //}

            }

            fbDlg.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string strConn = "Data Source=.;Initial Catalog=Image.RC;Integrated Security=True";
            string dataAreaID = cmbDataAreaID.Text.ToString();

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd = new SqlCommand(connectionString, con);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = connectionString;

            cmd.Parameters.Add("@Image", SqlDbType.Image);
            cmd.Parameters.Add("@RC", SqlDbType.NVarChar);
            cmd.Parameters.Add("@DataAreaID", SqlDbType.NVarChar);

            for (int i = 0; i < tableNormal.Rows.Count; i++)
            {
                string path = tableNormal.Rows[i][1].ToString();

                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                Byte[] imgByte = new Byte[fs.Length];
                fs.Read(imgByte, 0, imgByte.Length);
                fs = null;

                cmd.CommandText = "select RC from RCImage where RC=@RC and DataAreaID=@DataAreaID";
                cmd.Parameters["@RC"].Value = tableNormal.Rows[i][0].ToString();
                cmd.Parameters["@Image"].Value = imgByte;
                cmd.Parameters["@DataAreaID"].Value = dataAreaID;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.HasRows)
                {
                    cmd.CommandText = "delete from RCImage where RC=@RC and DataAreaID=@DataAreaID";
                    reader.Close();
                    cmd.ExecuteNonQuery();
                }

                reader.Close();
                cmd.CommandText = "insert into RCImage values(@RC,@Image,@DataAreaID)";
                cmd.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Save " + tableNormal.Rows.Count + " records！");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (int.TryParse(txtConfigFileSize.Text.Trim().ToString(), out a) == false
                    && int.TryParse(txtMaxWidth.Text.Trim().ToString(), out a) == false
                    && int.TryParse(txtMaxHeight.Text.Trim().ToString(), out a) == false) //判断是否可以转换为整型
            {
                MessageBox.Show("Please enter a number!");
            }
            else
            {
                UpdateAppConfig("MaxFileSize", txtConfigFileSize.Text.Trim().ToString());
                UpdateAppConfig("AllowFileStyle", txtConfigFileExtensions.Text.Trim().ToString());

                UpdateAppConfig("MaxWidth", txtMaxWidth.Text.Trim().ToString());
                UpdateAppConfig("MaxHeight", txtMaxHeight.Text.Trim().ToString());

                this.maxFileSize = int.Parse(txtConfigFileSize.Text.Trim().ToString());
                this.supportedExtensions = txtConfigFileExtensions.Text.Trim().ToString().Split('|');

                this.maxWidth = int.Parse(txtMaxWidth.Text.Trim().ToString());
                this.maxHeight = int.Parse(txtMaxHeight.Text.Trim().ToString());

                MessageBox.Show("Config successful!");
            }


        }

        ///<summary>  
        ///在*.exe.config文件中appSettings配置节增加一对键值对  
        ///</summary>  
        ///<param name="newKey"></param>  
        ///<param name="newValue"></param>  
        public static void UpdateAppConfig(string newKey, string newValue)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            bool exist = false;
            foreach (string key in config.AppSettings.Settings.AllKeys)
            {
                if (key == newKey)
                {
                    exist = true;
                }
            }
            if (exist)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            config.AppSettings.Settings.Add(newKey, newValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void btnReadConfig_Click(object sender, EventArgs e)
        {
            string file = System.Windows.Forms.Application.ExecutablePath;
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(file);
            connectionString =
                config.ConnectionStrings.ConnectionStrings["Image_RCConnectionString"].ConnectionString.ToString();

            txtConfigFileSize.Text = config.AppSettings.Settings["MaxFileSize"].Value.ToString();

            supportedExtensions = config.AppSettings.Settings["AllowFileStyle"].Value.ToString().Split('|');

            txtMaxWidth.Text = config.AppSettings.Settings["MaxWidth"].Value.ToString();
            txtMaxHeight.Text = config.AppSettings.Settings["MaxHeight"].Value.ToString();
        }

        private void btnShowConfig_Click(object sender, EventArgs e)
        {
            if (btnShowConfig.Text.ToString() == "Show config")
            {
                tabControl1.Controls.Add(tpgConfig);
                btnShowConfig.Text = "Hide config";
            }
            else
            {
                tabControl1.Controls.Remove(tpgConfig);
                btnShowConfig.Text = "Show config";
            }
        }
    }
}
