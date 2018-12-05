using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Jigsaw
{
    public partial class JigsawMainForm : Form
    {
        Image showImage = Jigsaw.Properties.Resources._0;
        int widthSize = 4;
        int heightSize = 4;
        int showSize = 380 / 4;
        const int OFFSET = 0;
        int voidPicPosX = -1;
        int voidPicPosY = -1;
        int time = 0;
        const string NAME = "梦羽拼图";
        const string LABELDEFAULTTEXT = "欢迎使用支付宝捐赠！";
        const string BREAKRECORDS = "新纪录！你太棒了！";
        PictureBox[,] P = new PictureBox[10, 10];

        public JigsawMainForm()
        {
            InitializeComponent();
        }

        private void JigsawMainForm_Load(object sender, EventArgs e)
        {
            System.IO.Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].MouseClick += new MouseEventHandler(P_MouseClick);
                    P[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    P[i, j].BorderStyle = BorderStyle.FixedSingle;
                    P[i, j].Show();
                    MainPanel.Controls.Add(P[i, j]);
                }
            easy.MouseClick += new MouseEventHandler(grade_MouseClick);
            normal.MouseClick += new MouseEventHandler(grade_MouseClick);
            hard.MouseClick += new MouseEventHandler(grade_MouseClick);
            Reshow();
            //ControlPanel.BackgroundImage = showImage;
        }
        private void grade_MouseClick(object sender, MouseEventArgs e)
        {
            if (((RadioButton)sender).Name == "easy")
            {
                heightSize = 4;
                widthSize = 4;
            }
            else if (((RadioButton)sender).Name == "normal")
            {
                heightSize = 5;
                widthSize = 5;
            }
            else
            {
                heightSize = 6;
                widthSize = 6;
            }
            showSize = 380 / widthSize;
            Reshow();
        }
        private void P_MouseClick(object sender, MouseEventArgs e)
        {
            //((PictureBox)sender).Hide();
            if ((((((PictureBox)sender).Left + showSize == voidPicPosX) || (((PictureBox)sender).Left - showSize == voidPicPosX)) && ((PictureBox)sender).Top == voidPicPosY) || (((((PictureBox)sender).Top + showSize == voidPicPosY) || (((PictureBox)sender).Top - showSize == voidPicPosY)) && ((PictureBox)sender).Left == voidPicPosX))
            {
                int tempPosX = ((PictureBox)sender).Left;
                int tempPosY = ((PictureBox)sender).Top;
                ((PictureBox)sender).Left = voidPicPosX;
                ((PictureBox)sender).Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                int flag = 1;
                for (int i = 0; i < heightSize; i++)
                    for (int j = 0; j < widthSize; j++)
                        if (P[i, j].Left != j * showSize + OFFSET || P[i, j].Top != i * showSize + OFFSET)
                            flag = 0;
                if (flag == 1)
                {
                    P[heightSize - 1, widthSize - 1].Show();
                    voidPicPosX = -1;
                    voidPicPosY = -1;
                    start.Enabled = true;
                    StartToolStripMenuItem.Enabled = true;
                    timer.Enabled = false;
                    string[] score = GetRecord().Split(new string[] { "," }, StringSplitOptions.None);
                    int score0 = Convert.ToInt32(score[0]);
                    int score1 = Convert.ToInt32(score[1]);
                    int score2 = Convert.ToInt32(score[2]);
                    if (easy.Checked && score0 > time)
                    {
                        SetRecord(time + "," + score1 + "," + score2);
                        MessageBox.Show(BREAKRECORDS, NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (normal.Checked && score1 > time)
                    {
                        SetRecord(score0 + "," + time + "," + score2);
                        MessageBox.Show(BREAKRECORDS, NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (hard.Checked && score2 > time)
                    {
                        SetRecord(score0 + "," + score1 + "," + time);
                        MessageBox.Show(BREAKRECORDS, NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //time = 0;
                }
            }
        }

        public static Image AcquireRectangleImage(Image source, Rectangle rect)
        {
            if (source == null || rect.IsEmpty) return null;
            Bitmap bmSmall = new Bitmap(rect.Width, rect.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
            //Bitmap bmSmall = new Bitmap(rect.Width, rect.Height, source.PixelFormat);
            using (Graphics grSmall = Graphics.FromImage(bmSmall))
            {
                grSmall.DrawImage(source, new System.Drawing.Rectangle(0, 0, bmSmall.Width, bmSmall.Height), rect, GraphicsUnit.Pixel);
                grSmall.Dispose();
            }
            return bmSmall;
        }

        private void start_Click(object sender, EventArgs e)
        {
            start.Enabled = false;
            StartToolStripMenuItem.Enabled = false;
            P[heightSize - 1, widthSize - 1].Hide();
            voidPicPosX = (widthSize - 1) * showSize + OFFSET;
            voidPicPosY = (heightSize - 1) * showSize + OFFSET;
            Random ran = new Random();
            //ran.Next(1, 11) > 5
            int tempPosX;
            int tempPosY;
            int sleepTime = 200;
            int sleepInterval = 150 / (heightSize + widthSize - 2) / 2;
            for (int i = heightSize - 1, j = widthSize - 1; i >= 0; i--)
            {
                tempPosX = P[i, j].Left;
                tempPosY = P[i, j].Top;
                P[i, j].Left = voidPicPosX;
                P[i, j].Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                System.Threading.Thread.Sleep(sleepTime -= sleepInterval);
            }
            for (int j = widthSize - 2, i = 0; j >= 0; j--)
            {
                tempPosX = P[i, j].Left;
                tempPosY = P[i, j].Top;
                P[i, j].Left = voidPicPosX;
                P[i, j].Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                System.Threading.Thread.Sleep(sleepTime -= sleepInterval);
            }
            for (int i = 1, j = 0; i < heightSize; i++)
            {
                tempPosX = P[i, j].Left;
                tempPosY = P[i, j].Top;
                P[i, j].Left = voidPicPosX;
                P[i, j].Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                System.Threading.Thread.Sleep(sleepTime -= sleepInterval);
            }
            for (int j = 1, i = heightSize - 1; j < widthSize - 1; j++)
            {
                tempPosX = P[i, j].Left;
                tempPosY = P[i, j].Top;
                P[i, j].Left = voidPicPosX;
                P[i, j].Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                System.Threading.Thread.Sleep(sleepTime -= sleepInterval);
            }
            int[] enableCube = new int[4];
            int preDirection = 0;
            //k < (heightSize * widthSize) * 2
            for (int k = 0; k < (heightSize * widthSize) * 2; k++)
            {
                int enableCubeNum = 0;
                for (int i = 0; i < heightSize; i++)
                    for (int j = 0; j < widthSize; j++)
                    {
                        if (!(i == heightSize - 1 && j == widthSize - 1) && ((((P[i, j].Left + showSize == voidPicPosX) || ((P[i, j].Left - showSize == voidPicPosX))) && (P[i, j].Top == voidPicPosY)) || (((P[i, j].Top + showSize == voidPicPosY) || (P[i, j].Top - showSize == voidPicPosY)) && (P[i, j].Left == voidPicPosX))))
                        {
                            int direction;
                            if (P[i, j].Left - voidPicPosX > 0)
                                direction = -1;
                            else if (P[i, j].Left - voidPicPosX < 0)
                                direction = 1;
                            else if (P[i, j].Top - voidPicPosY > 0)
                                direction = -2;
                            else
                                direction = 2;
                            if (preDirection + direction != 0)
                                enableCube[enableCubeNum++] = i * 100 + j;
                        }
                    }
                int selectCube = enableCube[ran.Next(0, enableCubeNum)];
                int s_i = selectCube / 100;
                int s_j = selectCube % 100;
                tempPosX = P[s_i, s_j].Left;
                tempPosY = P[s_i, s_j].Top;
                P[s_i, s_j].Left = voidPicPosX;
                P[s_i, s_j].Top = voidPicPosY;
                voidPicPosX = tempPosX;
                voidPicPosY = tempPosY;
                if (P[s_i, s_j].Left - voidPicPosX > 0)
                    preDirection = 1;
                else if (P[s_i, s_j].Left - voidPicPosX < 0)
                    preDirection = -1;
                else if (P[s_i, s_j].Top - voidPicPosY > 0)
                    preDirection = 2;
                else
                    preDirection = -2;
                System.Threading.Thread.Sleep(50);
            }
            time = 0;
            if(timeLabel.Text != LABELDEFAULTTEXT)
                timeLabel.Text = "用时：" + time + "秒";
            timer.Enabled = true;
        }

        private void Reshow()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                {
                    P[i, j].Hide();
                }
            voidPicPosX = -1;
            voidPicPosY = -1;
            start.Enabled = true;
            StartToolStripMenuItem.Enabled = true;
            time = 0;
            timeLabel.Text = LABELDEFAULTTEXT;
            timer.Enabled = false;
            ShowPictureBox.Image = Properties.Resources._1;
            Rectangle rect = new Rectangle(0, 0, showImage.Width / widthSize, showImage.Height / heightSize);
            //MessageBox.Show(imageList1.Images.Count);
            for (int i = 0; i < heightSize; i++)
                for (int j = 0; j < widthSize; j++)
                {
                    rect.X = j * showImage.Width / widthSize;
                    rect.Y = i * showImage.Height / heightSize;
                    P[i, j].Image = AcquireRectangleImage(showImage, rect);
                    P[i, j].Left = j * showSize + OFFSET;
                    P[i, j].Top = i * showSize + OFFSET;
                    P[i, j].Width = showSize;
                    P[i, j].Height = showSize;
                    P[i, j].Show();
                }
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此游戏为送给张梦宇的生日礼物。", NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("移动滑块拼出正确顺序的图形。", NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void records_Click(object sender, EventArgs e)
        {
            string[] score = GetRecord().Split(new string[] { "," }, StringSplitOptions.None);
            string score0 = score[0];
            string score1 = score[1];
            string score2 = score[2];
            MessageBox.Show("简单模式：" + score0 + "秒\n普通模式：" + score1 + "秒\n困难模式：" + score2 + "秒", NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (choosePicture.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    showImage = Image.FromFile(choosePicture.FileName);
                    Reshow();
                }
                catch
                {
                    MessageBox.Show("所选图片无效，请重新选择！", NAME, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (ShowPictureBox.Image == showImage)
                timeLabel.Text = "用时：" + ++time + "秒";
            else
                ++time;
        }

        private string GetRecord()
        {
            string record = "", defaultRecord = "10000,10000,10000";
            try
            {
                StreamReader recordFile = new StreamReader(@"Record.rec");
                record = Encoding.ASCII.GetString(Convert.FromBase64String(recordFile.ReadLine()));
                recordFile.Close();
            }
            catch
            {
                return defaultRecord;
            }
            string[] score = record.Split(new string[] { "," }, StringSplitOptions.None);
            if (score.Length != 3)
                return defaultRecord;
            for (int i = 0; i < score.Length; i++)
                if (!Regex.IsMatch(score[i], @"^[+-]?\d+$"))
                    return "10000,10000,10000";
            return record;
        }
        private void SetRecord(string record)
        {
            try
            {
                StreamWriter scoreRecordFile = new StreamWriter(new FileStream(@"Record.rec", FileMode.OpenOrCreate), Encoding.ASCII);
                scoreRecordFile.WriteLine(Convert.ToBase64String(Encoding.ASCII.GetBytes(record)));
                scoreRecordFile.Close();
                FileInfo info = new FileInfo(@"Record.rec");
                if (info.Exists && info.Attributes != FileAttributes.Hidden)
                    info.Attributes = FileAttributes.Hidden;
            }
            catch
            {
            }
        }

        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_Click(null, null);
        }

        private void RecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            records_Click(null, null);
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_Click(null, null);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPictureBox_Click(object sender, EventArgs e)
        {
            if (ShowPictureBox.Image == showImage)
            {
                timeLabel.Text = LABELDEFAULTTEXT;
                ShowPictureBox.Image = Properties.Resources._1;
            }
            else
            {
                timeLabel.Text = "用时：" + time + "秒";
                ShowPictureBox.Image = showImage;
            }

        }
    }
}
