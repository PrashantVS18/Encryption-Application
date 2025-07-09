namespace EncryptionTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string result;
            result = armstrong.BusinessLayer.SSTCryptographer.Encrypt(txtString.Text.Trim(), txtKey.Text.Trim());
            txtResult.Text = result;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string result;
            result = armstrong.BusinessLayer.SSTCryptographer.Decrypt(txtString.Text.Trim(), txtKey.Text.Trim());
            txtResult.Text = result;
        }
    }
}