namespace CSP.DataScience.Tool
{
    partial class MainFormNew
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            btn_OpenFile = new Button();
            tb_FileName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cb_SourceLanguages = new ComboBox();
            cb_TargetLanguage = new ComboBox();
            label4 = new Label();
            btn_Convert = new Button();
            groupBox1 = new GroupBox();
            cb_NLPColumns = new ComboBox();
            label5 = new Label();
            groupBox_NLP = new GroupBox();
            cb_CategoryColns = new ComboBox();
            btn_GenerateCorrectLabeling = new Button();
            label6 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBox1.SuspendLayout();
            groupBox_NLP.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 41);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "Select CSV File to Translate ";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.Filter = "CSV Files|*.csv";
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "CSV Files|*.csv";
            // 
            // btn_OpenFile
            // 
            btn_OpenFile.Location = new Point(503, 41);
            btn_OpenFile.Name = "btn_OpenFile";
            btn_OpenFile.Size = new Size(75, 23);
            btn_OpenFile.TabIndex = 1;
            btn_OpenFile.Text = "Open";
            btn_OpenFile.UseVisualStyleBackColor = true;
            btn_OpenFile.Click += btn_OpenFile_Click;
            // 
            // tb_FileName
            // 
            tb_FileName.Location = new Point(228, 38);
            tb_FileName.Name = "tb_FileName";
            tb_FileName.Size = new Size(237, 23);
            tb_FileName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 92);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 3;
            label2.Text = "Source Language:";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 133);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 4;
            label3.Text = "Target Language:";
            // 
            // cb_SourceLanguages
            // 
            cb_SourceLanguages.FormattingEnabled = true;
            cb_SourceLanguages.Items.AddRange(new object[] { "af\tAfrikaans", "sq\tAlbanian", "am\tAmharic", "ar\tArabic", "hy\tArmenian", "as\tAssamese", "ay\tAymara", "az\tAzerbaijani", "bm\tBambara", "eu\tBasque", "be\tBelarusian", "bn\tBengali", "bho\tBhojpuri", "bs\tBosnian", "bg\tBulgarian", "ca\tCatalan", "ceb\tCebuano", "co\tCorsican", "hr\tCroatian", "cs\tCzech", "da\tDanish", "dv\tDhivehi", "doi\tDogri", "nl\tDutch", "en\tEnglish", "eo\tEsperanto", "et\tEstonian", "ee\tEwe", "fil\tFilipino (Tagalog)", "fi\tFinnish", "fr\tFrench", "fy\tFrisian", "gl\tGalician", "ka\tGeorgian", "de\tGerman", "el\tGreek", "gn\tGuarani", "gu\tGujarati", "ht\tHaitian Creole", "ha\tHausa", "haw\tHawaiian", "he\tHebrew", "hi\tHindi", "hmn\tHmong", "hu\tHungarian", "is\tIcelandic", "ig\tIgbo", "ilo\tIlocano", "id\tIndonesian", "ga\tIrish", "it\tItalian", "ja\tJapanese", "kn\tKannada", "kk\tKazakh", "km\tKhmer", "rw\tKinyarwanda", "gom\tKonkani", "ko\tKorean", "kri\tKrio", "ku\tKurdish", "ckb\tKurdish (Sorani)", "ky\tKyrgyz", "lo\tLao", "la\tLatin", "lv\tLatvian", "ln\tLingala", "lt\tLithuanian", "lg\tLuganda", "lb\tLuxembourgish", "mk\tMacedonian", "mai\tMaithili", "mg\tMalagasy", "ms\tMalay", "ml\tMalayalam", "mt\tMaltese", "mi\tMaori", "mr\tMarathi", "lus\tMizo", "mn\tMongolian", "my\tMyanmar (Burmese)", "ne\tNepali", "no\tNorwegian", "ny\tNyanja (Chichewa)", "or\tOdia (Oriya)", "om\tOromo", "ps\tPashto", "fa\tPersian", "pl\tPolish", "pt\tPortuguese (Portugal, Brazil)", "pa\tPunjabi", "qu\tQuechua", "ro\tRomanian", "ru\tRussian", "sm\tSamoan", "sa\tSanskrit", "gd\tScots Gaelic", "nso\tSepedi", "sr\tSerbian", "st\tSesotho", "sn\tShona", "sd\tSindhi", "si\tSinhala (Sinhalese)", "sk\tSlovak", "sl\tSlovenian", "so\tSomali", "es\tSpanish", "su\tSundanese", "sw\tSwahili", "sv\tSwedish", "tl\tTagalog (Filipino)", "tg\tTajik", "ta\tTamil", "tt\tTatar", "te\tTelugu", "th\tThai", "ti\tTigrinya", "ts\tTsonga", "tr\tTurkish", "tk\tTurkmen", "ak\tTwi (Akan)", "uk\tUkrainian", "ur\tUrdu", "ug\tUyghur", "uz\tUzbek", "vi\tVietnamese", "cy\tWelsh", "xh\tXhosa", "yi\tYiddish", "yo\tYoruba", "zu\tZulu" });
            cb_SourceLanguages.Location = new Point(228, 92);
            cb_SourceLanguages.Name = "cb_SourceLanguages";
            cb_SourceLanguages.Size = new Size(237, 23);
            cb_SourceLanguages.TabIndex = 5;
            cb_SourceLanguages.Visible = false;
            // 
            // cb_TargetLanguage
            // 
            cb_TargetLanguage.FormattingEnabled = true;
            cb_TargetLanguage.Items.AddRange(new object[] { "af\tAfrikaans", "sq\tAlbanian", "am\tAmharic", "ar\tArabic", "hy\tArmenian", "as\tAssamese", "ay\tAymara", "az\tAzerbaijani", "bm\tBambara", "eu\tBasque", "be\tBelarusian", "bn\tBengali", "bho\tBhojpuri", "bs\tBosnian", "bg\tBulgarian", "ca\tCatalan", "ceb\tCebuano", "co\tCorsican", "hr\tCroatian", "cs\tCzech", "da\tDanish", "dv\tDhivehi", "doi\tDogri", "nl\tDutch", "en\tEnglish", "eo\tEsperanto", "et\tEstonian", "ee\tEwe", "fil\tFilipino (Tagalog)", "fi\tFinnish", "fr\tFrench", "fy\tFrisian", "gl\tGalician", "ka\tGeorgian", "de\tGerman", "el\tGreek", "gn\tGuarani", "gu\tGujarati", "ht\tHaitian Creole", "ha\tHausa", "haw\tHawaiian", "he\tHebrew", "hi\tHindi", "hmn\tHmong", "hu\tHungarian", "is\tIcelandic", "ig\tIgbo", "ilo\tIlocano", "id\tIndonesian", "ga\tIrish", "it\tItalian", "ja\tJapanese", "kn\tKannada", "kk\tKazakh", "km\tKhmer", "rw\tKinyarwanda", "gom\tKonkani", "ko\tKorean", "kri\tKrio", "ku\tKurdish", "ckb\tKurdish (Sorani)", "ky\tKyrgyz", "lo\tLao", "la\tLatin", "lv\tLatvian", "ln\tLingala", "lt\tLithuanian", "lg\tLuganda", "lb\tLuxembourgish", "mk\tMacedonian", "mai\tMaithili", "mg\tMalagasy", "ms\tMalay", "ml\tMalayalam", "mt\tMaltese", "mi\tMaori", "mr\tMarathi", "lus\tMizo", "mn\tMongolian", "my\tMyanmar (Burmese)", "ne\tNepali", "no\tNorwegian", "ny\tNyanja (Chichewa)", "or\tOdia (Oriya)", "om\tOromo", "ps\tPashto", "fa\tPersian", "pl\tPolish", "pt\tPortuguese (Portugal, Brazil)", "pa\tPunjabi", "qu\tQuechua", "ro\tRomanian", "ru\tRussian", "sm\tSamoan", "sa\tSanskrit", "gd\tScots Gaelic", "nso\tSepedi", "sr\tSerbian", "st\tSesotho", "sn\tShona", "sd\tSindhi", "si\tSinhala (Sinhalese)", "sk\tSlovak", "sl\tSlovenian", "so\tSomali", "es\tSpanish", "su\tSundanese", "sw\tSwahili", "sv\tSwedish", "tl\tTagalog (Filipino)", "tg\tTajik", "ta\tTamil", "tt\tTatar", "te\tTelugu", "th\tThai", "ti\tTigrinya", "ts\tTsonga", "tr\tTurkish", "tk\tTurkmen", "ak\tTwi (Akan)", "uk\tUkrainian", "ur\tUrdu", "ug\tUyghur", "uz\tUzbek", "vi\tVietnamese", "cy\tWelsh", "xh\tXhosa", "yi\tYiddish", "yo\tYoruba", "zu\tZulu" });
            cb_TargetLanguage.Location = new Point(228, 133);
            cb_TargetLanguage.Name = "cb_TargetLanguage";
            cb_TargetLanguage.Size = new Size(237, 23);
            cb_TargetLanguage.TabIndex = 6;
            cb_TargetLanguage.Text = "en";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 212);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 7;
            label4.Text = "Convert  Ouput";
            label4.Click += label4_Click;
            // 
            // btn_Convert
            // 
            btn_Convert.Location = new Point(229, 208);
            btn_Convert.Name = "btn_Convert";
            btn_Convert.Size = new Size(114, 23);
            btn_Convert.TabIndex = 8;
            btn_Convert.Text = "&Convert &Load";
            btn_Convert.UseVisualStyleBackColor = true;
            btn_Convert.Click += btn_Convert_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cb_NLPColumns);
            groupBox1.Controls.Add(btn_Convert);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btn_OpenFile);
            groupBox1.Controls.Add(cb_TargetLanguage);
            groupBox1.Controls.Add(tb_FileName);
            groupBox1.Controls.Add(cb_SourceLanguages);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(28, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 262);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Translation";
            // 
            // cb_NLPColumns
            // 
            cb_NLPColumns.FormattingEnabled = true;
            cb_NLPColumns.Location = new Point(229, 171);
            cb_NLPColumns.Name = "cb_NLPColumns";
            cb_NLPColumns.Size = new Size(236, 23);
            cb_NLPColumns.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 174);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 0;
            label5.Text = "Column To Translate";
            // 
            // groupBox_NLP
            // 
            groupBox_NLP.Controls.Add(cb_CategoryColns);
            groupBox_NLP.Controls.Add(btn_GenerateCorrectLabeling);
            groupBox_NLP.Controls.Add(label6);
            groupBox_NLP.Location = new Point(29, 309);
            groupBox_NLP.Name = "groupBox_NLP";
            groupBox_NLP.Size = new Size(738, 185);
            groupBox_NLP.TabIndex = 10;
            groupBox_NLP.TabStop = false;
            groupBox_NLP.Text = "NLP Mapping";
            // 
            // cb_CategoryColns
            // 
            cb_CategoryColns.FormattingEnabled = true;
            cb_CategoryColns.Location = new Point(380, 34);
            cb_CategoryColns.Name = "cb_CategoryColns";
            cb_CategoryColns.Size = new Size(235, 23);
            cb_CategoryColns.TabIndex = 6;
            // 
            // btn_GenerateCorrectLabeling
            // 
            btn_GenerateCorrectLabeling.Location = new Point(380, 78);
            btn_GenerateCorrectLabeling.Name = "btn_GenerateCorrectLabeling";
            btn_GenerateCorrectLabeling.Size = new Size(180, 23);
            btn_GenerateCorrectLabeling.TabIndex = 4;
            btn_GenerateCorrectLabeling.Text = "Generate Correct Label";
            btn_GenerateCorrectLabeling.UseVisualStyleBackColor = true;
            btn_GenerateCorrectLabeling.Click += btn_GenerateCorrectLabeling_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 36);
            label6.Name = "label6";
            label6.Size = new Size(283, 15);
            label6.TabIndex = 1;
            label6.Text = "Label or Category Column containing the categories";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 606);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // backgroundWorker2
            // 
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;
            // 
            // MainFormNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox_NLP);
            Controls.Add(groupBox1);
            Name = "MainFormNew";
            Text = "Main Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox_NLP.ResumeLayout(false);
            groupBox_NLP.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button btn_OpenFile;
        private TextBox tb_FileName;
        private Label label2;
        private Label label3;
        private ComboBox cb_SourceLanguages;
        private ComboBox cb_TargetLanguage;
        private Label label4;
        private Button btn_Convert;
        private GroupBox groupBox1;
        private GroupBox groupBox_NLP;
        private Label label6;
        private Label label5;
        private Button btn_GenerateCorrectLabeling;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ComboBox cb_CategoryColns;
        private ComboBox cb_NLPColumns;
    }
}
