using System;
using GeometrySDK;
using System.Windows.Forms;

namespace Sdk_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取加密的内容信息
            string mi = @"" + textBox1.Text;
            // 公钥
            string pubKey = @"" + textBox2.Text;

            GeometryRSA rsa = new GeometryRSA();
            // 解密后的内容
            textBox3.Text = rsa.DecryptByPublicKey(mi, pubKey);
        }
    }
}
