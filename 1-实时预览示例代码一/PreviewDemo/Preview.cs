using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;

using System.Runtime.InteropServices;

namespace PreviewDemo
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Preview : System.Windows.Forms.Form
	{
        #region ����

        private uint iLastErr = 0;
		private Int32[] m_lUserID = { -1, -1, - 1, -1 };
        private Int32 m_lUserID_flag = 0;
        //private Int32 m_lUserID1 = -1;
        //private Int32 m_lUserID2 = -1;
        private bool m_bInitSDK = false;
        private bool m_bRecord = false;
        //private bool m_bTalk = false;
        private Int32[] m_lRealHandle = { -1, -1, - 1, -1 };
        private Int32 m_lRealHandle_flag = 0;
        Graphics pictureborder;
        //private int lVoiceComHandle = -1;
        private string str;

        //CHCNetSDK.REALDATACALLBACK RealData = null;
		private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPreview;
		private System.Windows.Forms.PictureBox RealPlayWnd1;
        private TextBox textBoxIP;
        private TextBox textBoxPort;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnBMP;
        private Button btnJPEG;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBoxChannel;
        private Button btnRecord;
        private Label label14;
        private Button btn_Exit;
        private Button btnPTZ;
        private Label label15;
        private GroupBox ��¼����;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private PictureBox RealPlayWnd2;
        private PictureBox RealPlayWnd3;
        private PictureBox RealPlayWnd4;
        private TabPage ¼������;
        private TabPage tabPage5;
        #endregion

        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.Container components = null;

		public Preview()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();
			m_bInitSDK = CHCNetSDK.NET_DVR_Init();
			if (m_bInitSDK == false)
			{
				MessageBox.Show("NET_DVR_Init error!");
				return;
			}
			else
			{
                //����SDK��־ To save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
			}
			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
            if (m_lRealHandle[0] >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[0]);
            }
            if (m_lRealHandle[1] >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[1]);
            }
            if (m_lUserID[0] >= 0)
			{
				CHCNetSDK.NET_DVR_Logout(m_lUserID[0]);
			}
            if (m_lUserID[1] >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID[1]);
            }
            //if (m_lUserID1 >= 0)
            //{
            //    CHCNetSDK.NET_DVR_Logout(m_lUserID1);
            //}
            if (m_bInitSDK == true)
			{
				CHCNetSDK.NET_DVR_Cleanup();
			}
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.RealPlayWnd1 = new System.Windows.Forms.PictureBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBMP = new System.Windows.Forms.Button();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btnPTZ = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.��¼���� = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RealPlayWnd2 = new System.Windows.Forms.PictureBox();
            this.RealPlayWnd3 = new System.Windows.Forms.PictureBox();
            this.RealPlayWnd4 = new System.Windows.Forms.PictureBox();
            this.¼������ = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd1)).BeginInit();
            this.��¼����.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(79, 146);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 34);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "��¼";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(123, 59);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(120, 28);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "��Ԥ��";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // RealPlayWnd1
            // 
            this.RealPlayWnd1.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd1.Location = new System.Drawing.Point(272, 12);
            this.RealPlayWnd1.Name = "RealPlayWnd1";
            this.RealPlayWnd1.Size = new System.Drawing.Size(640, 480);
            this.RealPlayWnd1.TabIndex = 4;
            this.RealPlayWnd1.TabStop = false;
            this.RealPlayWnd1.Click += new System.EventHandler(this.RealPlayWnd_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(78, 24);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(165, 25);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "192.168.117.154";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(79, 53);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(164, 25);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "8000";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(79, 84);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(164, 25);
            this.textBoxUserName.TabIndex = 4;
            this.textBoxUserName.Text = "admin";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(79, 115);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(164, 25);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.Text = "12345";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "�豸IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "�豸�˿�";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "�û���";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "����";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ԥ��";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "��¼";
            // 
            // btnBMP
            // 
            this.btnBMP.Location = new System.Drawing.Point(123, 93);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(120, 29);
            this.btnBMP.TabIndex = 8;
            this.btnBMP.Text = "Capture BMP ";
            this.btnBMP.UseVisualStyleBackColor = true;
            this.btnBMP.Click += new System.EventHandler(this.btnBMP_Click);
            // 
            // btnJPEG
            // 
            this.btnJPEG.Location = new System.Drawing.Point(124, 128);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(119, 28);
            this.btnJPEG.TabIndex = 9;
            this.btnJPEG.Text = "Capture JPEG";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "BMPץͼ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "JPEGץͼ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Ԥ��/ץͼͨ��";
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.Location = new System.Drawing.Point(123, 24);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(120, 25);
            this.textBoxChannel.TabIndex = 6;
            this.textBoxChannel.Text = "1";
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(124, 162);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(119, 28);
            this.btnRecord.TabIndex = 10;
            this.btnRecord.Text = "Start Record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 22;
            this.label14.Text = "�ͻ���¼��";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(123, 230);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 28);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Tag = "";
            this.btn_Exit.Text = "�˳� Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btnPTZ
            // 
            this.btnPTZ.Location = new System.Drawing.Point(124, 196);
            this.btnPTZ.Name = "btnPTZ";
            this.btnPTZ.Size = new System.Drawing.Size(119, 28);
            this.btnPTZ.TabIndex = 23;
            this.btnPTZ.Text = "PTZ1";
            this.btnPTZ.UseVisualStyleBackColor = true;
            this.btnPTZ.Click += new System.EventHandler(this.btnPTZ_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 24;
            this.label15.Text = "��̨����";
            // 
            // ��¼����
            // 
            this.��¼����.Controls.Add(this.btnLogin);
            this.��¼����.Controls.Add(this.textBoxIP);
            this.��¼����.Controls.Add(this.textBoxPort);
            this.��¼����.Controls.Add(this.textBoxUserName);
            this.��¼����.Controls.Add(this.textBoxPassword);
            this.��¼����.Controls.Add(this.label5);
            this.��¼����.Controls.Add(this.label6);
            this.��¼����.Controls.Add(this.label10);
            this.��¼����.Controls.Add(this.label7);
            this.��¼����.Controls.Add(this.label8);
            this.��¼����.Location = new System.Drawing.Point(12, 12);
            this.��¼����.Name = "��¼����";
            this.��¼����.Size = new System.Drawing.Size(254, 191);
            this.��¼����.TabIndex = 29;
            this.��¼����.TabStop = false;
            this.��¼����.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxChannel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_Exit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnPTZ);
            this.groupBox1.Controls.Add(this.btnPreview);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnJPEG);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnBMP);
            this.groupBox1.Controls.Add(this.btnRecord);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 283);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.¼������);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 498);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(254, 480);
            this.tabControl1.TabIndex = 31;
            // 
            // RealPlayWnd2
            // 
            this.RealPlayWnd2.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd2.Location = new System.Drawing.Point(918, 12);
            this.RealPlayWnd2.Name = "RealPlayWnd2";
            this.RealPlayWnd2.Size = new System.Drawing.Size(640, 480);
            this.RealPlayWnd2.TabIndex = 32;
            this.RealPlayWnd2.TabStop = false;
            this.RealPlayWnd2.Click += new System.EventHandler(this.RealPlayWnd2_Click);
            // 
            // RealPlayWnd3
            // 
            this.RealPlayWnd3.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd3.Location = new System.Drawing.Point(273, 498);
            this.RealPlayWnd3.Name = "RealPlayWnd3";
            this.RealPlayWnd3.Size = new System.Drawing.Size(640, 480);
            this.RealPlayWnd3.TabIndex = 33;
            this.RealPlayWnd3.TabStop = false;
            this.RealPlayWnd3.Click += new System.EventHandler(this.RealPlayWnd3_Click);
            // 
            // RealPlayWnd4
            // 
            this.RealPlayWnd4.BackColor = System.Drawing.SystemColors.WindowText;
            this.RealPlayWnd4.Location = new System.Drawing.Point(919, 498);
            this.RealPlayWnd4.Name = "RealPlayWnd4";
            this.RealPlayWnd4.Size = new System.Drawing.Size(640, 480);
            this.RealPlayWnd4.TabIndex = 34;
            this.RealPlayWnd4.TabStop = false;
            this.RealPlayWnd4.Click += new System.EventHandler(this.RealPlayWnd4_Click);
            // 
            // ¼������
            // 
            this.¼������.Location = new System.Drawing.Point(4, 25);
            this.¼������.Name = "¼������";
            this.¼������.Size = new System.Drawing.Size(246, 451);
            this.¼������.TabIndex = 2;
            this.¼������.Text = "¼������";
            this.¼������.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(246, 451);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Preview
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 18);
            this.ClientSize = new System.Drawing.Size(1591, 984);
            this.Controls.Add(this.RealPlayWnd4);
            this.Controls.Add(this.RealPlayWnd3);
            this.Controls.Add(this.RealPlayWnd2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.��¼����);
            this.Controls.Add(this.RealPlayWnd1);
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd1)).EndInit();
            this.��¼����.ResumeLayout(false);
            this.��¼����.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd4)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Preview());
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void btnLogin_Click(object sender, System.EventArgs e)//��¼
        {
            if (textBoxIP.Text == "" || textBoxPort.Text == "" ||
				textBoxUserName.Text == "" || textBoxPassword.Text == "")
			{
				MessageBox.Show("Please input IP, Port, User name and Password!");
				return;
			}
            if (m_lUserID[m_lUserID_flag] < 0)
            {
                string DVRIPAddress = textBoxIP.Text; //�豸IP��ַ��������
                Int16 DVRPortNumber = Int16.Parse(textBoxPort.Text);//�豸����˿ں�
                string DVRUserName = textBoxUserName.Text;//�豸��¼�û���
                string DVRPassword = textBoxPassword.Text;//�豸��¼����

                CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo = new CHCNetSDK.NET_DVR_DEVICEINFO_V30();

                //��¼�豸 Login the device
                m_lUserID[m_lUserID_flag] = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
                if (m_lUserID[m_lUserID_flag] < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Login_V30 failed, error code= " + iLastErr; //��¼ʧ�ܣ���������
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //��¼�ɹ�
                    MessageBox.Show("Login Success!");
                    btnLogin.Text = "�˳�";
                }
            }
            else
            {
                //ע����¼ Logout the device
                if (m_lRealHandle[m_lRealHandle_flag] >= 0)
                {
                    MessageBox.Show("Please stop live view firstly");
                    return;
                }

                if (!CHCNetSDK.NET_DVR_Logout(m_lUserID[m_lUserID_flag]))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_Logout failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;           
                }
                m_lUserID[m_lUserID_flag] = -1;
                btnLogin.Text = "��¼";
            }
            return;
		}

        private void btnPreview_Click(object sender, System.EventArgs e)//ʵʱ��ʾ
        {
            if(m_lUserID[m_lUserID_flag] < 0)
            {
                MessageBox.Show("Please login the device firstly");
                return;
            }

            if (m_lRealHandle[m_lRealHandle_flag] < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                if(m_lRealHandle_flag == 0)
                {
                    lpPreviewInfo.hPlayWnd = RealPlayWnd1.Handle;//Ԥ������
                }
                else if (m_lRealHandle_flag == 1)
                {
                    lpPreviewInfo.hPlayWnd = RealPlayWnd2.Handle;//Ԥ������
                }
                else if (m_lRealHandle_flag == 2)
                {
                    lpPreviewInfo.hPlayWnd = RealPlayWnd3.Handle;//Ԥ������
                }
                else if (m_lRealHandle_flag == 3)
                {
                    lpPreviewInfo.hPlayWnd = RealPlayWnd4.Handle;//Ԥ������
                }

                lpPreviewInfo.lChannel = Int16.Parse(textBoxChannel.Text);//Ԥte�����豸ͨ��
                lpPreviewInfo.dwStreamType = 0;//�������ͣ�0-��������1-��������2-����3��3-����4���Դ�����
                lpPreviewInfo.dwLinkMode = 0;//���ӷ�ʽ��0- TCP��ʽ��1- UDP��ʽ��2- �ಥ��ʽ��3- RTP��ʽ��4-RTP/RTSP��5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = false; //0- ������ȡ����1- ����ȡ��
                lpPreviewInfo.dwDisplayBufNum = 15; //���ſⲥ�Ż�������󻺳�֡��
                
                IntPtr pUser = new IntPtr();//�û�����

                //��Ԥ�� Start live view 
                m_lRealHandle[m_lRealHandle_flag] = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID[m_lUserID_flag], ref lpPreviewInfo, null/*RealData*/, pUser);
                if (m_lRealHandle[m_lRealHandle_flag] < 0)
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_RealPlay_V40 failed, error code= " + iLastErr; //Ԥ��ʧ�ܣ���������
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    //Ԥ���ɹ�
                    btnPreview.Text = "�ر�Ԥ��";
                }
            }
            else
            {
                //ֹͣԤ�� Stop live view 
                if (!CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[m_lRealHandle_flag]))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopRealPlay failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                m_lRealHandle[m_lRealHandle_flag] = -1;
                btnPreview.Text = "��Ԥ��";

            }
            return;
		}

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr pUser)
		{
            if (dwBufSize > 0)
            {
                byte[] sData = new byte[dwBufSize];
                Marshal.Copy(pBuffer, sData, 0, (Int32)dwBufSize);

                string str = "ʵʱ������.ps";
                FileStream fs = new FileStream(str, FileMode.Create);
                int iLen = (int)dwBufSize;
                fs.Write(sData, 0, iLen);
                fs.Close();            
            }
		}

        private void btnBMP_Click(object sender, EventArgs e)//��ȡͼƬ
        {
            string sBmpPicFileName;
            //ͼƬ����·�����ļ��� the path and file name to save
            string time_now = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            sBmpPicFileName = "G:\\����ͷ����\\" + time_now + ".JPEG";

            //CHCNetSDK.netdvrsetca;

            //BMPץͼ Capture a BMP picture
            if (!CHCNetSDK.NET_DVR_CapturePicture(m_lRealHandle[m_lRealHandle_flag], sBmpPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CapturePicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the BMP file and the saved file is \n" + sBmpPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btnJPEG_Click(object sender, EventArgs e)//��ȡͼƬ
        {
            string sJpegPicFileName;
            //ͼƬ����·�����ļ��� the path and file name to save
            string time_now = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            sJpegPicFileName = "G:\\����ͷ����\\" + time_now + ".JPEG";

            int lChannel = Int16.Parse(textBoxChannel.Text); //ͨ���� Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 1; //ͼ������ Image quality
            lpJpegPara.wPicSize = 6; //ץͼ�ֱ��� Picture size: 2- 4CIF��0xff- Auto(ʹ�õ�ǰ�����ֱ���)��ץͼ�ֱ�����Ҫ�豸֧�֣�����ȡֵ��ο�SDK�ĵ�

            //JPEGץͼ Capture a JPEG picture
            //CHCNetSDK.NET_DVR_CaptureJPEGPicture_NEW(m_lUserID, lChannel, ref lpJpegPara,);

            if (!CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID[m_lUserID_flag], lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "NET_DVR_CaptureJPEGPicture failed, error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "Successful to capture the JPEG file and the saved file is " + sJpegPicFileName;
                MessageBox.Show(str);
            }
            return;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //¼�񱣴�·�����ļ��� the path and file name to save
            string sVideoFileName;
            string time_now = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            sVideoFileName = "G:\\����ͷ����\\" + time_now + ".mp4";

            if (m_bRecord == false)
            {
                //ǿ��I֡ Make a I frame
                int lChannel = Int16.Parse(textBoxChannel.Text); //ͨ���� Channel number
                CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID[m_lUserID_flag], lChannel);

                //��ʼ¼�� Start recording
                if (!CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle[m_lRealHandle_flag], sVideoFileName))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_SaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {                  
                    btnRecord.Text = "Stop Record";
                    m_bRecord = true;
                }
            }
            else
            {
                //ֹͣ¼�� Stop recording
                if (!CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle[m_lRealHandle_flag]))
                {
                    iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                    str = "NET_DVR_StopSaveRealData failed, error code= " + iLastErr;
                    MessageBox.Show(str);
                    return;
                }
                else
                {
                    str = "Successful to stop recording and the saved file is " + sVideoFileName;
                    MessageBox.Show(str);
                    btnRecord.Text = "Start Record";
                    m_bRecord = false;
                }            
            }

            return;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //ֹͣԤ�� Stop live view 
            if (m_lRealHandle[m_lRealHandle_flag] >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[m_lRealHandle_flag]);
                m_lRealHandle[m_lRealHandle_flag] = -1;
            }

            //ע����¼ Logout the device
            if (m_lUserID[m_lUserID_flag] >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID[m_lUserID_flag]);
                m_lUserID[m_lUserID_flag] = -1;
            }

            CHCNetSDK.NET_DVR_Cleanup();

            Application.Exit();
        }

        private void btnPTZ_Click(object sender, EventArgs e)
        {
            PTZControl dlg = new PTZControl();
            dlg.m_lUserID = m_lUserID[m_lUserID_flag];
            dlg.m_lChannel = 1;
            dlg.m_lRealHandle = m_lRealHandle[m_lRealHandle_flag];
            dlg.ShowDialog();
        }

        #region �����Ƶ�����¼�
        private void RealPlayWnd_Click(object sender, EventArgs e)
        {
            pictureborder = this.CreateGraphics();
            pictureborder.Clear(Color.FromArgb(240, 240, 240));
            pictureborder.DrawRectangle(new Pen(Color.Red, 2),
                RealPlayWnd1.Location.X - 1, RealPlayWnd1.Location.Y - 1, 
                RealPlayWnd1.Size.Width + 2, RealPlayWnd1.Size.Height + 2);
            m_lRealHandle_flag = 0;
            m_lUserID_flag = 0;
            if (m_lUserID[m_lUserID_flag] < 0)
            {
                btnLogin.Text = "��¼";
            }
            else
            {
                btnLogin.Text = "�˳�";
            }


            if (m_lRealHandle[m_lRealHandle_flag] < 0)
            {
                btnPreview.Text = "��Ԥ��";
            }
            else
            {
                btnPreview.Text = "�ر�Ԥ��";
            }
        }

        private void RealPlayWnd2_Click(object sender, EventArgs e)
        {
            pictureborder = this.CreateGraphics();
            pictureborder.Clear(Color.FromArgb(240, 240, 240));
            pictureborder.DrawRectangle(new Pen(Color.Red, 2),
                RealPlayWnd2.Location.X - 1, RealPlayWnd2.Location.Y - 1,
                RealPlayWnd2.Size.Width + 2, RealPlayWnd2.Size.Height + 2);
            m_lRealHandle_flag = 1;
            m_lUserID_flag = 1;
            if (m_lUserID[m_lUserID_flag] < 0)
            {
                btnLogin.Text = "��¼";
            }
            else
            {
                btnLogin.Text = "�˳�";
            }


            if (m_lRealHandle[m_lRealHandle_flag] < 0)
            {
                btnPreview.Text = "��Ԥ��";
            }
            else
            {
                btnPreview.Text = "�ر�Ԥ��";
            }
        }

        private void RealPlayWnd3_Click(object sender, EventArgs e)
        {
            pictureborder = this.CreateGraphics();
            pictureborder.Clear(Color.FromArgb(240, 240, 240));
            pictureborder.DrawRectangle(new Pen(Color.Red, 2),
                RealPlayWnd3.Location.X - 1, RealPlayWnd3.Location.Y - 1,
                RealPlayWnd3.Size.Width + 2, RealPlayWnd3.Size.Height + 2);
            m_lRealHandle_flag = 2;
            m_lUserID_flag = 2;
            if (m_lUserID[m_lUserID_flag] < 0)
            {
                btnLogin.Text = "��¼";
            }
            else
            {
                btnLogin.Text = "�˳�";
            }


            if (m_lRealHandle[m_lRealHandle_flag] < 0)
            {
                btnPreview.Text = "��Ԥ��";
            }
            else
            {
                btnPreview.Text = "�ر�Ԥ��";
            }
        }

        private void RealPlayWnd4_Click(object sender, EventArgs e)
        {
            pictureborder = this.CreateGraphics();
            pictureborder.Clear(Color.FromArgb(240, 240, 240));
            pictureborder.DrawRectangle(new Pen(Color.Red, 2),
                RealPlayWnd4.Location.X - 1, RealPlayWnd4.Location.Y - 1,
                RealPlayWnd4.Size.Width + 2, RealPlayWnd4.Size.Height + 2);
            m_lRealHandle_flag = 3;
            m_lUserID_flag = 3;
            if (m_lUserID[m_lUserID_flag] < 0)
            {
                btnLogin.Text = "��¼";
            }
            else
            {
                btnLogin.Text = "�˳�";
            }


            if (m_lRealHandle[m_lRealHandle_flag] < 0)
            {
                btnPreview.Text = "��Ԥ��";
            }
            else
            {
                btnPreview.Text = "�ر�Ԥ��";
            }
        }
        #endregion
    }
}
