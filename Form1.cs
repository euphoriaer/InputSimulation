using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inputSimulation
{
    public partial class Form1 : Form
    {
        #region 鼠标

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [System.Runtime.InteropServices.DllImport("user32")]
        private static extern int keybd_event(int vk_return, int scanline, int keyDown, int dwExtraInfo);

        //移动鼠标
        private const int MOUSEEVENTF_MOVE = 0x0001;

        //模拟鼠标左键按下
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;

        //模拟鼠标左键抬起
        private const int MOUSEEVENTF_LEFTUP = 0x0004;

        //模拟鼠标右键按下
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        //模拟鼠标右键抬起
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;

        //模拟鼠标中键按下
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;

        //模拟鼠标中键抬起
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;

        //标示是否采用绝对坐标
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        //模拟鼠标滚轮滚动操作，必须配合dwData参数
        private const int MOUSEEVENTF_WHEEL = 0x0800;

        //模拟键盘s
        private int KEYS = 83;//0x53;

        public static void TestMoveMouse()
        {
            Console.WriteLine("模拟鼠标移动5个像素点。");
            mouse_event(MOUSEEVENTF_MOVE, 50, 50, 0, 0);//相对当前鼠标位置x轴和y轴分别移动50像素
                                                        //mouse_event(MOUSEEVENTF_WHEEL, 0, 0, -20, 0);//鼠标滚动，使界面向下滚动20的高度
        }

        public void KeyS()
        {
    
            if (!string.IsNullOrEmpty(keyNum.Text))
            {
                byte[] array = new byte[1];   //定义一组数组array
                array = System.Text.Encoding.ASCII.GetBytes(keyNum.Text.ToUpper()); //string转换的字母
                int asciicode = (short)(array[0]);
                KEYS = asciicode;
            }

            Console.WriteLine("模拟按下");
            keybd_event(KEYS, 0, 0, 0);
            keybd_event(KEYS, 0, 2, 0);
            Thread.Sleep(30);
        }

        public static void MouseLeft()
        {
            Console.WriteLine("模拟左键");
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            Thread.Sleep(30);
        }

        public static void MouseRight()
        {
            Console.WriteLine("模拟右键");
            mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            Thread.Sleep(30);
        }

        #endregion 鼠标

        private int inputMs = 3000;
        private int inMouseLeft = 3000;
        private int inMouseRight = 3000;

        private bool isRuning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkKey.Checked = false;
            checkMouseLeft.Checked = false;
        }

        private void checkKey_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkMouse_CheckedChanged(object sender, EventArgs e)
        {
        }

        private bool onceRun = true;

        private void Run_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(keyMs.Text))
            {
                if (keyMs.Text.Contains("-"))
                {
                    var randomNumbers=keyMs.Text.Split('-');
                    int x1 = int.Parse(randomNumbers[0]);
                    int x2 = int.Parse(randomNumbers[1]);
					Random random = new Random();
					inputMs = random.Next(x1, x2);
					Debug.WriteLine(inputMs);
				}
                else
                {
					int.TryParse(keyMs.Text, out inputMs);
				}
                
            }

            if (!string.IsNullOrEmpty(mouseLeftMs.Text))
            {
				if (mouseLeftMs.Text.Contains("-"))
				{
					var randomNumbers = mouseLeftMs.Text.Split('-');
					int x1 = int.Parse(randomNumbers[0]);
					int x2 = int.Parse(randomNumbers[1]);
					Random random = new Random();
					inMouseLeft = random.Next(x1, x2);
                    Debug.WriteLine(inMouseLeft);
                }
                else
                {
					int.TryParse(mouseLeftMs.Text, out inMouseLeft);
				}
				
            }

            if (!string.IsNullOrEmpty(mouseRighMs.Text))
            {
				if (mouseRighMs.Text.Contains("-"))
				{
					var randomNumbers = mouseRighMs.Text.Split('-');
					int x1 = int.Parse(randomNumbers[0]);
					int x2 = int.Parse(randomNumbers[1]);
					Random random = new Random();
					inMouseRight = random.Next(x1, x2);
					Debug.WriteLine(inMouseRight);
				}
                else
                {
					int.TryParse(mouseRighMs.Text, out inMouseRight);
				}
				
            }

            if (isRuning)
            {
                isRuning = false;
                Run.Text = "执行";
                checkKey.Checked = isRuning;
                checkMouseLeft.Checked = isRuning;
                checkMouseRight.Checked = isRuning;

                checkKey.Enabled = true;
                checkMouseLeft.Enabled = true;
                checkMouseRight.Enabled = true;
            }
            else
            {
                if (checkKey.Checked == false)
                {
                    checkKey.Enabled = false;
                }

                if (checkMouseLeft.Checked == false)
                {
                    checkMouseLeft.Enabled = false;
                }

                if (checkMouseRight.Checked == false)
                {
                    checkMouseRight.Enabled = false;
                }

                isRuning = true;
                Run.Text = "停止";

                if (checkKey.Enabled)
                    if (checkKey.Checked)
                    {
                        Task.Run(() =>
                        {
                            while (checkKey.Checked)
                            {
								if (keyMs.Text.Contains("-"))
								{
									var randomNumbers = keyMs.Text.Split('-');
									int x1 = int.Parse(randomNumbers[0]);
									int x2 = int.Parse(randomNumbers[1]);
									Random random = new Random();
									inputMs = random.Next(x1, x2);
									Debug.WriteLine(inputMs);
								}
								Thread.Sleep(inputMs);
                                KeyS();
                                checkKey.Checked = isRuning;
                            }
                        });
                    }

                if (checkMouseLeft.Enabled)
                    if (checkMouseLeft.Checked)
                    {
                        Task.Run(() =>
                        {
                            while (checkMouseLeft.Checked)
                            {
								if (mouseLeftMs.Text.Contains("-"))
								{
									var randomNumbers = mouseLeftMs.Text.Split('-');
									int x1 = int.Parse(randomNumbers[0]);
									int x2 = int.Parse(randomNumbers[1]);
									Random random = new Random();
									inMouseLeft = random.Next(x1, x2);
									Debug.WriteLine(inMouseLeft);
								}
								Thread.Sleep(inMouseLeft);
                                MouseLeft();
                                checkMouseLeft.Checked = isRuning;
                            }
                        });
                    }

                if (checkMouseRight.Enabled)
                    if (checkMouseRight.Checked)
                    {
                        Task.Run(() =>
                        {
                            while (checkMouseRight.Checked)
                            {
								if (mouseRighMs.Text.Contains("-"))
								{
									var randomNumbers = mouseRighMs.Text.Split('-');
									int x1 = int.Parse(randomNumbers[0]);
									int x2 = int.Parse(randomNumbers[1]);
									Random random = new Random();
									inMouseRight = random.Next(x1, x2);
									Debug.WriteLine(inMouseRight);
								}
								Thread.Sleep(inMouseRight);
                                MouseRight();
                                checkMouseRight.Checked = isRuning;
                            }
                        });
                    }
            }
        }

        private void KeyInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void Mouse_TextChanged(object sender, EventArgs e)
        {
        }

        private void IsTop_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void isTop_CheckedChanged_1(object sender, EventArgs e)
        {
            this.TopMost = isTop.Checked;
        }
    }
}