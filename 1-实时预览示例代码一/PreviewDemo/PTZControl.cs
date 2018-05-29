using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PreviewDemo
{
    public partial class PTZControl : Form
    {
        string str;
        private uint iLastErr = 0;
        public int m_lUserID = -1;
        public int m_lRealHandle = -1;
        public int m_lChannel = -1;
        private bool bAuto = false;
        public PTZControl()
        {
            InitializeComponent();
        }
        #region 方向键代码

        private void PTZControl_Load(object sender, EventArgs e)
        {
            comboBoxSpeed.SelectedIndex = 4;
            if (m_lRealHandle > -1)
            {
                checkBoxPreview.Checked = true;
            }
            else
            {
                checkBoxPreview.Checked = false;
            }
            this.Focus();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                if (!bAuto)
                {
                    CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_AUTO, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                    btnAuto.Text = "Stop";
                    bAuto = true;
                }
                else
                {
                    CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_AUTO, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                    btnAuto.Text = "Auto";
                    bAuto = false;
                }
            }
            else
            {
                if (!bAuto)
                {
                    CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_AUTO, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                    btnAuto.Text = "Stop";
                    bAuto = true;
                }
                else
                {
                    CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_AUTO, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                    btnAuto.Text = "Auto";
                    bAuto = false;
                }
            }
        }

        private void btnAmplification_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_IN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_IN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }
        private void btnAmplification_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_IN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_IN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }

        private void btnNarrow_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_OUT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_OUT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }
        private void btnNarrow_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkBoxPreview.Checked)
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_OUT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
            else
            {
                CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_OUT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
            }
        }
        #endregion


        #region 键盘控制代码
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string str;
            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.S:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.A:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.D:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.E:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_IN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_IN, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.Q:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_OUT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_OUT, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.Z:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.FOCUS_NEAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.FOCUS_NEAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.C:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.FOCUS_FAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.FOCUS_FAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.Add:
                    {
                        if (comboBoxSpeed.SelectedIndex <= 5)
                            comboBoxSpeed.SelectedIndex += 1;
                    }
                    break;
                case Keys.Subtract:
                    {
                        if (comboBoxSpeed.SelectedIndex >= 1)
                            comboBoxSpeed.SelectedIndex -= 1;
                    }
                    break;





                case Keys.D1:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 1))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D2:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 2))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D3:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 3))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D4:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 4))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D5:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 5))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D6:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 6))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D7:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 7))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D8:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 8))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }
                case Keys.D9:
                    {
                        if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 9))
                        {
                            iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                            str = "转到预置点失败 , error code= " + iLastErr;
                            MessageBox.Show(str);
                            break;
                        }
                        break;

                    }


                default: break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_UP, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.S:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.TILT_DOWN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.A:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_LEFT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.D:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.PAN_RIGHT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }

                    }
                    break;
                case Keys.E:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_IN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_IN, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.Q:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.ZOOM_OUT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.ZOOM_OUT, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.Z:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.FOCUS_NEAR, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.FOCUS_NEAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                case Keys.C:
                    {
                        if (checkBoxPreview.Checked)
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed(m_lRealHandle, CHCNetSDK.FOCUS_FAR, 1, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                        else
                        {
                            CHCNetSDK.NET_DVR_PTZControlWithSpeed_Other(m_lUserID, m_lChannel, CHCNetSDK.FOCUS_FAR, 0, (uint)comboBoxSpeed.SelectedIndex + 1);
                        }
                    }
                    break;
                default: break;
            }
        }

        #endregion

        #region 定点代码

        private void button_setport_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.SET_PRESET, Convert.ToUInt32(textBox1.Text)))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "设置预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "设置预置点成功";
                MessageBox.Show(str);
            }
            return;
        }

        private void button_turnto_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, Convert.ToUInt32(textBox1.Text)))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
                return;
            }
            else
            {
                str = "抓到预置点成功";
            }
            return;
        }

        private void button_port1_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 1))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port2_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 2))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port3_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 3))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port4_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 4))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port5_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 5))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port6_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 6))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_potr7_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET,7))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port8_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 8))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 9))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }

        private void button_port10_Click(object sender, EventArgs e)
        {
            if (!CHCNetSDK.NET_DVR_PTZPreset(m_lRealHandle, CHCNetSDK.GOTO_PRESET, 10))
            {
                iLastErr = CHCNetSDK.NET_DVR_GetLastError();
                str = "转到预置点失败 , error code= " + iLastErr;
                MessageBox.Show(str);
            }
        }
        #endregion
    }
}
