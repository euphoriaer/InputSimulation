namespace inputSimulation
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkKey = new System.Windows.Forms.CheckBox();
            this.Run = new System.Windows.Forms.Button();
            this.checkMouseLeft = new System.Windows.Forms.CheckBox();
            this.keyMs = new System.Windows.Forms.TextBox();
            this.mouseLeftMs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isTop = new System.Windows.Forms.CheckBox();
            this.keyNum = new System.Windows.Forms.TextBox();
            this.checkMouseRight = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mouseRighMs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkKey
            // 
            this.checkKey.AutoSize = true;
            this.checkKey.Location = new System.Drawing.Point(73, 30);
            this.checkKey.Name = "checkKey";
            this.checkKey.Size = new System.Drawing.Size(72, 16);
            this.checkKey.TabIndex = 1;
            this.checkKey.Text = "模拟按键";
            this.checkKey.UseVisualStyleBackColor = true;
            this.checkKey.CheckedChanged += new System.EventHandler(this.checkKey_CheckedChanged);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(52, 145);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(362, 64);
            this.Run.TabIndex = 2;
            this.Run.Text = "执行";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // checkMouseLeft
            // 
            this.checkMouseLeft.AutoSize = true;
            this.checkMouseLeft.Location = new System.Drawing.Point(73, 65);
            this.checkMouseLeft.Name = "checkMouseLeft";
            this.checkMouseLeft.Size = new System.Drawing.Size(96, 16);
            this.checkMouseLeft.TabIndex = 3;
            this.checkMouseLeft.Text = "模拟左键按下";
            this.checkMouseLeft.UseVisualStyleBackColor = true;
            this.checkMouseLeft.CheckedChanged += new System.EventHandler(this.checkMouse_CheckedChanged);
            // 
            // keyMs
            // 
            this.keyMs.Location = new System.Drawing.Point(330, 25);
            this.keyMs.Name = "keyMs";
            this.keyMs.Size = new System.Drawing.Size(100, 21);
            this.keyMs.TabIndex = 4;
            this.keyMs.TextChanged += new System.EventHandler(this.KeyInput_TextChanged);
            // 
            // mouseLeftMs
            // 
            this.mouseLeftMs.Location = new System.Drawing.Point(330, 58);
            this.mouseLeftMs.Name = "mouseLeftMs";
            this.mouseLeftMs.Size = new System.Drawing.Size(100, 21);
            this.mouseLeftMs.TabIndex = 5;
            this.mouseLeftMs.TextChanged += new System.EventHandler(this.Mouse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "延时ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "延时ms";
            // 
            // isTop
            // 
            this.isTop.AutoSize = true;
            this.isTop.Location = new System.Drawing.Point(13, 13);
            this.isTop.Name = "isTop";
            this.isTop.Size = new System.Drawing.Size(48, 16);
            this.isTop.TabIndex = 8;
            this.isTop.Text = "置顶";
            this.isTop.UseVisualStyleBackColor = true;
            this.isTop.CheckedChanged += new System.EventHandler(this.isTop_CheckedChanged_1);
            // 
            // keyNum
            // 
            this.keyNum.Location = new System.Drawing.Point(142, 28);
            this.keyNum.Name = "keyNum";
            this.keyNum.Size = new System.Drawing.Size(55, 21);
            this.keyNum.TabIndex = 9;
            this.keyNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkMouseRight
            // 
            this.checkMouseRight.AutoSize = true;
            this.checkMouseRight.Location = new System.Drawing.Point(73, 97);
            this.checkMouseRight.Name = "checkMouseRight";
            this.checkMouseRight.Size = new System.Drawing.Size(96, 16);
            this.checkMouseRight.TabIndex = 10;
            this.checkMouseRight.Text = "模拟右键按下";
            this.checkMouseRight.UseMnemonic = false;
            this.checkMouseRight.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "延时ms";
            // 
            // mouseRighMs
            // 
            this.mouseRighMs.Location = new System.Drawing.Point(330, 95);
            this.mouseRighMs.Name = "mouseRighMs";
            this.mouseRighMs.Size = new System.Drawing.Size(100, 21);
            this.mouseRighMs.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 249);
            this.Controls.Add(this.mouseRighMs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkMouseRight);
            this.Controls.Add(this.keyNum);
            this.Controls.Add(this.isTop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mouseLeftMs);
            this.Controls.Add(this.keyMs);
            this.Controls.Add(this.checkMouseLeft);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.checkKey);
            this.Name = "Form1";
            this.Text = "键盘模拟";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkKey;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.CheckBox checkMouseLeft;
        private System.Windows.Forms.TextBox keyMs;
        private System.Windows.Forms.TextBox mouseLeftMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isTop;
        private System.Windows.Forms.TextBox keyNum;
        private System.Windows.Forms.CheckBox checkMouseRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mouseRighMs;
    }
}

