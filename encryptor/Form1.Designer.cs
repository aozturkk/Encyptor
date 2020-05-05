namespace encryptor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.base64Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.base64Output = new System.Windows.Forms.RichTextBox();
            this.base64Decode = new System.Windows.Forms.Button();
            this.base64Encode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.base64Text = new System.Windows.Forms.RichTextBox();
            this.base64 = new System.Windows.Forms.Button();
            this.hashingPanel = new System.Windows.Forms.Panel();
            this.hashFileOption = new System.Windows.Forms.RadioButton();
            this.hashTextOption = new System.Windows.Forms.RadioButton();
            this.calculateHash = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sha256Output = new System.Windows.Forms.RichTextBox();
            this.hashFileNameLabel = new System.Windows.Forms.Label();
            this.fileHashing = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.md5Output = new System.Windows.Forms.RichTextBox();
            this.hasingText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.aesPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.aesDecrypt = new System.Windows.Forms.Button();
            this.aesIV = new System.Windows.Forms.TextBox();
            this.aesKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.aesFileOption = new System.Windows.Forms.RadioButton();
            this.aesTextOption = new System.Windows.Forms.RadioButton();
            this.aesEncrypt = new System.Windows.Forms.Button();
            this.aesFileNameLabel = new System.Windows.Forms.Label();
            this.aesFile = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.aesOutput = new System.Windows.Forms.RichTextBox();
            this.aesText = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hash = new System.Windows.Forms.Button();
            this.aes = new System.Windows.Forms.Button();
            this.base64Panel.SuspendLayout();
            this.hashingPanel.SuspendLayout();
            this.aesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // base64Panel
            // 
            this.base64Panel.Controls.Add(this.label3);
            this.base64Panel.Controls.Add(this.base64Output);
            this.base64Panel.Controls.Add(this.base64Decode);
            this.base64Panel.Controls.Add(this.base64Encode);
            this.base64Panel.Controls.Add(this.label2);
            this.base64Panel.Controls.Add(this.label1);
            this.base64Panel.Controls.Add(this.base64Text);
            this.base64Panel.Location = new System.Drawing.Point(148, 31);
            this.base64Panel.Name = "base64Panel";
            this.base64Panel.Size = new System.Drawing.Size(404, 392);
            this.base64Panel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output :";
            // 
            // base64Output
            // 
            this.base64Output.Location = new System.Drawing.Point(3, 234);
            this.base64Output.Name = "base64Output";
            this.base64Output.Size = new System.Drawing.Size(335, 157);
            this.base64Output.TabIndex = 5;
            this.base64Output.Text = "";
            // 
            // base64Decode
            // 
            this.base64Decode.Location = new System.Drawing.Point(198, 188);
            this.base64Decode.Name = "base64Decode";
            this.base64Decode.Size = new System.Drawing.Size(75, 23);
            this.base64Decode.TabIndex = 4;
            this.base64Decode.Text = "Decode";
            this.base64Decode.UseVisualStyleBackColor = true;
            this.base64Decode.Click += new System.EventHandler(this.Base64Decode_Click);
            // 
            // base64Encode
            // 
            this.base64Encode.Location = new System.Drawing.Point(41, 188);
            this.base64Encode.Name = "base64Encode";
            this.base64Encode.Size = new System.Drawing.Size(75, 23);
            this.base64Encode.TabIndex = 3;
            this.base64Encode.Text = "Encode";
            this.base64Encode.UseVisualStyleBackColor = true;
            this.base64Encode.Click += new System.EventHandler(this.Base64Encode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base64";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text :";
            // 
            // base64Text
            // 
            this.base64Text.Location = new System.Drawing.Point(3, 43);
            this.base64Text.Name = "base64Text";
            this.base64Text.Size = new System.Drawing.Size(335, 137);
            this.base64Text.TabIndex = 0;
            this.base64Text.Text = "";
            // 
            // base64
            // 
            this.base64.Location = new System.Drawing.Point(21, 29);
            this.base64.Name = "base64";
            this.base64.Size = new System.Drawing.Size(75, 23);
            this.base64.TabIndex = 1;
            this.base64.Text = "Base64";
            this.base64.UseVisualStyleBackColor = true;
            this.base64.Click += new System.EventHandler(this.Base64_Click);
            // 
            // hashingPanel
            // 
            this.hashingPanel.Controls.Add(this.hashFileOption);
            this.hashingPanel.Controls.Add(this.hashTextOption);
            this.hashingPanel.Controls.Add(this.calculateHash);
            this.hashingPanel.Controls.Add(this.label7);
            this.hashingPanel.Controls.Add(this.sha256Output);
            this.hashingPanel.Controls.Add(this.hashFileNameLabel);
            this.hashingPanel.Controls.Add(this.fileHashing);
            this.hashingPanel.Controls.Add(this.label6);
            this.hashingPanel.Controls.Add(this.md5Output);
            this.hashingPanel.Controls.Add(this.hasingText);
            this.hashingPanel.Controls.Add(this.label4);
            this.hashingPanel.Location = new System.Drawing.Point(145, 29);
            this.hashingPanel.Name = "hashingPanel";
            this.hashingPanel.Size = new System.Drawing.Size(404, 391);
            this.hashingPanel.TabIndex = 2;
            // 
            // hashFileOption
            // 
            this.hashFileOption.AutoSize = true;
            this.hashFileOption.Location = new System.Drawing.Point(3, 150);
            this.hashFileOption.Name = "hashFileOption";
            this.hashFileOption.Size = new System.Drawing.Size(47, 17);
            this.hashFileOption.TabIndex = 16;
            this.hashFileOption.Text = "File :";
            this.hashFileOption.UseVisualStyleBackColor = true;
            // 
            // hashTextOption
            // 
            this.hashTextOption.AutoSize = true;
            this.hashTextOption.Checked = true;
            this.hashTextOption.Location = new System.Drawing.Point(3, 98);
            this.hashTextOption.Name = "hashTextOption";
            this.hashTextOption.Size = new System.Drawing.Size(52, 17);
            this.hashTextOption.TabIndex = 15;
            this.hashTextOption.TabStop = true;
            this.hashTextOption.Text = "Text :";
            this.hashTextOption.UseVisualStyleBackColor = true;
            // 
            // calculateHash
            // 
            this.calculateHash.Location = new System.Drawing.Point(140, 199);
            this.calculateHash.Name = "calculateHash";
            this.calculateHash.Size = new System.Drawing.Size(75, 23);
            this.calculateHash.TabIndex = 14;
            this.calculateHash.Text = "Calculate";
            this.calculateHash.UseVisualStyleBackColor = true;
            this.calculateHash.Click += new System.EventHandler(this.calculateHash_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "sha256 :";
            // 
            // sha256Output
            // 
            this.sha256Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sha256Output.Location = new System.Drawing.Point(57, 285);
            this.sha256Output.Name = "sha256Output";
            this.sha256Output.Size = new System.Drawing.Size(246, 34);
            this.sha256Output.TabIndex = 12;
            this.sha256Output.Text = "";
            // 
            // hashFileNameLabel
            // 
            this.hashFileNameLabel.AutoSize = true;
            this.hashFileNameLabel.Location = new System.Drawing.Point(138, 152);
            this.hashFileNameLabel.Name = "hashFileNameLabel";
            this.hashFileNameLabel.Size = new System.Drawing.Size(68, 13);
            this.hashFileNameLabel.TabIndex = 11;
            this.hashFileNameLabel.Text = "Choose file ..";
            // 
            // fileHashing
            // 
            this.fileHashing.Location = new System.Drawing.Point(57, 147);
            this.fileHashing.Name = "fileHashing";
            this.fileHashing.Size = new System.Drawing.Size(75, 23);
            this.fileHashing.TabIndex = 10;
            this.fileHashing.Text = "File";
            this.fileHashing.UseVisualStyleBackColor = true;
            this.fileHashing.Click += new System.EventHandler(this.fileHashing_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "md5 :";
            // 
            // md5Output
            // 
            this.md5Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.md5Output.Location = new System.Drawing.Point(57, 234);
            this.md5Output.Name = "md5Output";
            this.md5Output.Size = new System.Drawing.Size(246, 34);
            this.md5Output.TabIndex = 6;
            this.md5Output.Text = "";
            // 
            // hasingText
            // 
            this.hasingText.Location = new System.Drawing.Point(57, 87);
            this.hasingText.Name = "hasingText";
            this.hasingText.Size = new System.Drawing.Size(263, 39);
            this.hasingText.TabIndex = 4;
            this.hasingText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(137, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hashing";
            // 
            // aesPanel
            // 
            this.aesPanel.Controls.Add(this.label8);
            this.aesPanel.Controls.Add(this.label5);
            this.aesPanel.Controls.Add(this.aesDecrypt);
            this.aesPanel.Controls.Add(this.aesIV);
            this.aesPanel.Controls.Add(this.aesKey);
            this.aesPanel.Controls.Add(this.label12);
            this.aesPanel.Controls.Add(this.label11);
            this.aesPanel.Controls.Add(this.aesFileOption);
            this.aesPanel.Controls.Add(this.aesTextOption);
            this.aesPanel.Controls.Add(this.aesEncrypt);
            this.aesPanel.Controls.Add(this.aesFileNameLabel);
            this.aesPanel.Controls.Add(this.aesFile);
            this.aesPanel.Controls.Add(this.label9);
            this.aesPanel.Controls.Add(this.aesOutput);
            this.aesPanel.Controls.Add(this.aesText);
            this.aesPanel.Controls.Add(this.label10);
            this.aesPanel.Location = new System.Drawing.Point(145, 29);
            this.aesPanel.Name = "aesPanel";
            this.aesPanel.Size = new System.Drawing.Size(404, 391);
            this.aesPanel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "(Must be 8 byte)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "(Must be 16 byte)";
            // 
            // aesDecrypt
            // 
            this.aesDecrypt.Location = new System.Drawing.Point(188, 234);
            this.aesDecrypt.Name = "aesDecrypt";
            this.aesDecrypt.Size = new System.Drawing.Size(75, 23);
            this.aesDecrypt.TabIndex = 23;
            this.aesDecrypt.Text = "Decrypt";
            this.aesDecrypt.UseVisualStyleBackColor = true;
            this.aesDecrypt.Click += new System.EventHandler(this.aesDecrypt_Click);
            // 
            // aesIV
            // 
            this.aesIV.Location = new System.Drawing.Point(57, 184);
            this.aesIV.Name = "aesIV";
            this.aesIV.Size = new System.Drawing.Size(255, 20);
            this.aesIV.TabIndex = 21;
            // 
            // aesKey
            // 
            this.aesKey.Location = new System.Drawing.Point(57, 155);
            this.aesKey.Name = "aesKey";
            this.aesKey.Size = new System.Drawing.Size(255, 20);
            this.aesKey.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "IV :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Key :";
            // 
            // aesFileOption
            // 
            this.aesFileOption.AutoSize = true;
            this.aesFileOption.Location = new System.Drawing.Point(3, 113);
            this.aesFileOption.Name = "aesFileOption";
            this.aesFileOption.Size = new System.Drawing.Size(47, 17);
            this.aesFileOption.TabIndex = 16;
            this.aesFileOption.Text = "File :";
            this.aesFileOption.UseVisualStyleBackColor = true;
            // 
            // aesTextOption
            // 
            this.aesTextOption.AutoSize = true;
            this.aesTextOption.Checked = true;
            this.aesTextOption.Location = new System.Drawing.Point(3, 61);
            this.aesTextOption.Name = "aesTextOption";
            this.aesTextOption.Size = new System.Drawing.Size(52, 17);
            this.aesTextOption.TabIndex = 15;
            this.aesTextOption.TabStop = true;
            this.aesTextOption.Text = "Text :";
            this.aesTextOption.UseVisualStyleBackColor = true;
            // 
            // aesEncrypt
            // 
            this.aesEncrypt.Location = new System.Drawing.Point(93, 234);
            this.aesEncrypt.Name = "aesEncrypt";
            this.aesEncrypt.Size = new System.Drawing.Size(75, 23);
            this.aesEncrypt.TabIndex = 14;
            this.aesEncrypt.Text = "Encrypt";
            this.aesEncrypt.UseVisualStyleBackColor = true;
            this.aesEncrypt.Click += new System.EventHandler(this.aesEncrypt_Click);
            // 
            // aesFileNameLabel
            // 
            this.aesFileNameLabel.AutoSize = true;
            this.aesFileNameLabel.Location = new System.Drawing.Point(138, 115);
            this.aesFileNameLabel.Name = "aesFileNameLabel";
            this.aesFileNameLabel.Size = new System.Drawing.Size(68, 13);
            this.aesFileNameLabel.TabIndex = 11;
            this.aesFileNameLabel.Text = "Choose file ..";
            // 
            // aesFile
            // 
            this.aesFile.Location = new System.Drawing.Point(57, 110);
            this.aesFile.Name = "aesFile";
            this.aesFile.Size = new System.Drawing.Size(75, 23);
            this.aesFile.TabIndex = 10;
            this.aesFile.Text = "File";
            this.aesFile.UseVisualStyleBackColor = true;
            this.aesFile.Click += new System.EventHandler(this.aesFile_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Output :";
            // 
            // aesOutput
            // 
            this.aesOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.aesOutput.Location = new System.Drawing.Point(56, 263);
            this.aesOutput.Name = "aesOutput";
            this.aesOutput.Size = new System.Drawing.Size(266, 90);
            this.aesOutput.TabIndex = 6;
            this.aesOutput.Text = "";
            // 
            // aesText
            // 
            this.aesText.Location = new System.Drawing.Point(57, 50);
            this.aesText.Name = "aesText";
            this.aesText.Size = new System.Drawing.Size(263, 39);
            this.aesText.TabIndex = 4;
            this.aesText.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(183, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Aes";
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(21, 70);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(75, 23);
            this.hash.TabIndex = 3;
            this.hash.Text = "Hash";
            this.hash.UseVisualStyleBackColor = true;
            this.hash.Click += new System.EventHandler(this.Hash_Click);
            // 
            // aes
            // 
            this.aes.Location = new System.Drawing.Point(21, 114);
            this.aes.Name = "aes";
            this.aes.Size = new System.Drawing.Size(75, 23);
            this.aes.TabIndex = 4;
            this.aes.Text = "Aes";
            this.aes.UseVisualStyleBackColor = true;
            this.aes.Click += new System.EventHandler(this.aes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.aesPanel);
            this.Controls.Add(this.aes);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.hashingPanel);
            this.Controls.Add(this.base64);
            this.Controls.Add(this.base64Panel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Encryptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.base64Panel.ResumeLayout(false);
            this.base64Panel.PerformLayout();
            this.hashingPanel.ResumeLayout(false);
            this.hashingPanel.PerformLayout();
            this.aesPanel.ResumeLayout(false);
            this.aesPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel base64Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox base64Output;
        private System.Windows.Forms.Button base64Decode;
        private System.Windows.Forms.Button base64Encode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox base64Text;
        private System.Windows.Forms.Button base64;
        private System.Windows.Forms.Panel hashingPanel;
        private System.Windows.Forms.Label hashFileNameLabel;
        private System.Windows.Forms.Button fileHashing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox md5Output;
        private System.Windows.Forms.RichTextBox hasingText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button hash;
        private System.Windows.Forms.RadioButton hashFileOption;
        private System.Windows.Forms.RadioButton hashTextOption;
        private System.Windows.Forms.Button calculateHash;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox sha256Output;
        private System.Windows.Forms.Panel aesPanel;
        private System.Windows.Forms.RadioButton aesFileOption;
        private System.Windows.Forms.RadioButton aesTextOption;
        private System.Windows.Forms.Button aesEncrypt;
        private System.Windows.Forms.Label aesFileNameLabel;
        private System.Windows.Forms.Button aesFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox aesOutput;
        private System.Windows.Forms.RichTextBox aesText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox aesIV;
        private System.Windows.Forms.TextBox aesKey;
        private System.Windows.Forms.Button aesDecrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button aes;
    }
}

