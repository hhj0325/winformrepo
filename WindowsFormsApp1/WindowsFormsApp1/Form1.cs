using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private String captchaStr = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            setFrom1Texts();
        }

        /// <summary>
        /// 设置组件文本
        /// </summary>
        private void setFrom1Texts()
        {
            this.label1.Text = Properties.Resource.account;
            this.label2.Text = Properties.Resource.password;
            this.label3.Text = Properties.Resource.captcha;

            this.label5.Text = Properties.Resource.login;
            this.label6.Text = Properties.Resource.tips;
            this.button1.Text = Properties.Resource.login;
            this.button2.Text = Properties.Resource.reset;
            this.Text = Properties.Resource.login;

            this.label4.Text = makeCaptcha();
        }

        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <returns></returns>
        private string makeCaptcha()
        {
            Random random = new Random();
            captchaStr = random.Next(9999).ToString();
            while (captchaStr.Length < 4)
            {
                captchaStr = random.Next(9999).ToString();
            }
            return captchaStr;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String formAccount = textBox1.Text;
            String formPassword = textBox2.Text;
            String formCaptcha = textBox3.Text;
            if (checkCaptcha(formCaptcha))
            {
                if (checkAccountAndPassword(formAccount, formPassword))
                {
                    this.label6.Text = Properties.Resource.tips_login_success;
                    resetForm();
                    this.DialogResult = DialogResult.OK;    //返回一个登录成功的对话框状态
                    this.Close();    //关闭登录窗口
                }
            }
        }

        /// <summary>
        /// 检查账号密码
        /// </summary>
        /// <param name="formAccount"></param>
        /// <param name="formPassword"></param>
        /// <returns></returns>
        private bool checkAccountAndPassword(string formAccount, string formPassword)
        {
            Boolean result = "hhj".Equals(formAccount) && "123".Equals(formPassword);
            if (!result)
            {
                this.label6.Text = Properties.Resource.tips_account_password_error;
                this.label4.Text = makeCaptcha();
            }
            return result;
        }

        /// <summary>
        /// 检查验证码
        /// </summary>
        /// <param name="formCaptcha"></param>
        /// <returns></returns>
        private bool checkCaptcha(string formCaptcha)
        {
            Boolean result = captchaStr.Equals(formCaptcha);
            if (!result)
            {
                this.label6.Text = Properties.Resource.tips_captcha_error;
                this.label4.Text = makeCaptcha();
            }
            return result;
        }

        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        /// <summary>
        /// 重置实现
        /// </summary>
        private void resetForm()
        {
            label4.Text = makeCaptcha();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            captchaStr = "";
        }
    }
}