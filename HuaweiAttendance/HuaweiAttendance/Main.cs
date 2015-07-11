using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyControls;
using System.Data.SqlClient;

namespace HuaweiAttendance
{

    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            dltextbox.Delay = 1000;

        }

        //For animated panels direction
        string rightDirection = "right";
        int RightTimeOut = 0;

        //For animated panels position
        int optionsX;
        int optionsY;
        int rightX;
        int rightY;

        //获取屏幕的宽度和高度
        int w = System.Windows.Forms.SystemInformation.VirtualScreen.Width;
        int h = System.Windows.Forms.SystemInformation.VirtualScreen.Height;

        //设置主窗体全屏，并设置背景色
        private void setFullScreen()
        {
            this.MaximumSize = new Size(w, h);
            this.MinimumSize = new Size(w, h);
            this.Location = new Point(0, 0);
            this.Width = w;
            this.Height = h;
        }

        //设置主面板的位置，使之在中央 
        //Tips:全屏化后控件位置难控制可以使用panel容器方法解决
        private void setMainPanelPosition()
        {
            int mX = (Width - pnlMain.Width) / 2;
            int mY = (Height - pnlMain.Height) / 2;
            pnlMain.Location = new Point(mX, mY);
        }

        //设置初始控件位置 
        private void setRightOptionsPanelPosition()
        {
            int y = Height;
            rightY = 0;
            rightX = Width + pnlRightOptions.Width;
            pnlRightOptions.Size = new Size(pnlRightOptions.Width, y);
            pnlRightOptions.Location = new Point(rightX, rightY);
            int rX = pnlRightMain.Location.X;
            int rY = (pnlRightOptions.Height - pnlRightMain.Height) / 2;
            pnlRightMain.Location = new Point(rX, rY);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            setFullScreen();
            setRightOptionsPanelPosition();
            setMainPanelPosition();
            RightOptions.Start();
            ColorChange.Start();
            this.ActiveControl = this.dltextbox;
            //this.dltextbox.Focus();           
        }


        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y >= Height - 15 && e.X < (Width - pnlRightOptions.Width))
            {
                rightDirection = "right";
            }
            if (e.X >= Width - 15)
            {
                rightDirection = "left";
                RightTimeOut = 0;
            }
            if (e.X < (Width - pnlRightOptions.Width))
            {
                rightDirection = "Left";
            }
        }


        private void RightOptions_Tick(object sender, EventArgs e)
        {
            if (RightTimeOut < 1000)
            {
                RightTimeOut++;
            }
            if (RightTimeOut == 1000)
            {
                if (rightDirection == "left")
                {
                    rightDirection = "right";
                }
            }
            if (rightDirection == "left")
            {
                if (rightX > Width - pnlRightOptions.Width)
                {
                    rightX -= 2;
                    pnlRightOptions.Location = new Point(rightX, rightY);
                }
            }
            else
            {
                if (rightX < Width)
                {
                    rightX += 2;
                }
                pnlRightOptions.Location = new Point(rightX, rightY);
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            rightDirection = "right";
        }

        private void ColorChange_Tick(object sender, EventArgs e)
        {
            if (pnlLogo.BackColor == Color.Red)
            {
                pnlLogo.BackColor = Color.Crimson;
                //this.dltextbox.Focus();

            }
            else if (pnlLogo.BackColor == Color.Crimson)
            {

                pnlLogo.BackColor = Color.DarkOrange;
                pnlSwipe.BackColor = Color.Crimson;
                //this.dltextbox.Focus();
            }
            else if (pnlLogo.BackColor == Color.DarkOrange)
            {

                pnlLogo.BackColor = Color.Purple;
                //this.dltextbox.Focus();
            }
            else if (pnlLogo.BackColor == Color.Purple)
            {

                pnlLogo.BackColor = Color.Red;
                pnlSwipe.BackColor = System.Drawing.SystemColors.HotTrack;
                //this.dltextbox.Focus();
            }
            else
            {

                pnlLogo.BackColor = Color.Red;
                //this.dltextbox.Focus();
            }
        }


        private void dltextbox_TextChanged(object sender, EventArgs e)
        {
            DateTime dDateTime = DateTime.Now;
            string sqlFormattedDate = dDateTime.Date.ToString("yyyy-MM-dd");
            string sqlFormattedTime = dDateTime.ToLongTimeString().ToString();
            string EmpolyeeID = cvtID(dltextbox.Text);


            #region connectDB

            //MessageBox.Show(sqlFormattedTime);

            string str;
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=AttendenceData");

            str = "insert into CheckTable values('" + EmpolyeeID + "','" + sqlFormattedDate + "','" + sqlFormattedTime + "')";

            SqlCommand myCommand = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();

                myCommand.ExecuteNonQuery();

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                    //添加刷卡人姓名信息     
                    pnlSwipe.Hide();
                    pnlThx.Show();
                    timerThx.Start();
                }
            }
            #endregion
        }


        public void focusReturn(object sender, MouseEventArgs e)
        {
            dltextbox.Focus();
        }

        private void timerThx_Tick(object sender, EventArgs e)
        {
            pnlThx.Hide();
            pnlSwipe.Show();
            timerThx.Stop();
        }

        private string cvtID(string originalTxt)
        {

            string tempCardID = originalTxt.Trim().Remove(0, originalTxt.Length - 7);
            string resultID = string.Empty;
            tempCardID = Convert.ToString(Convert.ToInt32(tempCardID, 16), 2); ;
            tempCardID = "0" + tempCardID;
            tempCardID = tempCardID.Substring(0, tempCardID.Length - 1);
            resultID = Convert.ToInt32(tempCardID, 2).ToString();
            return resultID;

        }

       






    }
}
