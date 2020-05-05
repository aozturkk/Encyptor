using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace encryptor
{
    public partial class Form1 : Form
    {
        crypto cryp = new crypto();
        string filePath;
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            base64Panel.Visible = true;
            hashingPanel.Visible = false;
            aesPanel.Visible = false;

        }

        private void Base64Encode_Click(object sender, EventArgs e)
        {
            base64Output.Text = cryp.base64Encode(base64Text.Text);
        }

        private void Base64Decode_Click(object sender, EventArgs e)
        {
            base64Output.Text = cryp.base64Decode(base64Text.Text);
        }

    
     

        private void Base64_Click(object sender, EventArgs e)
        {
            hashingPanel.Visible = false;
            base64Panel.Visible = true;          
            aesPanel.Visible = false;
        }

        private void Hash_Click(object sender, EventArgs e)
        {
            hashingPanel.Visible = true;
            base64Panel.Visible = false;
            aesPanel.Visible = false;
        }

        private void fileHashing_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            filePath = file.FileName;
            fileName = file.SafeFileName;

            hashFileNameLabel.Text = "/../"+ file.SafeFileName;

           
           
        }

        private void calculateHash_Click(object sender, EventArgs e)
        {
            if (hashTextOption.Checked && hasingText.Text != "")
            {
                md5Output.Text = cryp.md5hash(ASCIIEncoding.ASCII.GetBytes(hasingText.Text));
                sha256Output.Text = cryp.sha256Hash(ASCIIEncoding.ASCII.GetBytes(hasingText.Text));

            }else if(hashFileOption.Checked && filePath !=null){


                byte[] stream = File.ReadAllBytes(filePath);
                md5Output.Text = cryp.md5hash(stream);
                sha256Output.Text = cryp.sha256Hash(stream);
              
            }
        }


     
        private void aesEncrypt_Click(object sender, EventArgs e)
        {


           
            if (aesTextOption.Checked && aesText.Text != "")
            {
                aesOutput.Text = Convert.ToBase64String(cryp.aesEncrypt(Encoding.ASCII.GetBytes(aesText.Text),
                                                                        aesKey.Text,
                                                                        aesIV.Text));

            }
            else if (aesFileOption.Checked && filePath != null)
            {


                byte[] stream = File.ReadAllBytes(filePath);
                byte[] encryptFile = cryp.aesEncrypt(stream,aesKey.Text,aesIV.Text);

              
                FileStream file = new FileStream(fileName + ".aes", FileMode.Create);

               
                file.Write(encryptFile, 0, encryptFile.Length);

                file.Close();
            }

        }

        private void aesDecrypt_Click(object sender, EventArgs e)
        {
            

            if (aesTextOption.Checked && aesText.Text != "")
            {
                try
                {
                    byte[] cipherTextBytes = Convert.FromBase64String(aesText.Text);
                    aesOutput.Text = Encoding.ASCII.GetString(cryp.aesDecrypt(cipherTextBytes, aesKey.Text,
                                                                            aesIV.Text
                    ));
                }
                catch
                {
                    aesOutput.Text = "Invalid Input";
                }

            }
            else if (aesFileOption.Checked && filePath != null)
            {


                byte[] stream = File.ReadAllBytes(filePath);
                byte[] encryptFile = cryp.aesDecrypt(stream, aesKey.Text, aesIV.Text);

               
                FileStream file = new FileStream("decrypted_"+fileName.Remove(fileName.Length - 4), FileMode.Create);

              
                file.Write(encryptFile, 0, encryptFile.Length);

                file.Close();
            }

        }

        private void aesFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            filePath = file.FileName;
            fileName = file.SafeFileName;

            aesFileNameLabel.Text = "/../" + file.SafeFileName;
        }

        private void aes_Click(object sender, EventArgs e)
        {
            hashingPanel.Visible = false;
            base64Panel.Visible = false;
            aesPanel.Visible = true;
        }
    }
}
