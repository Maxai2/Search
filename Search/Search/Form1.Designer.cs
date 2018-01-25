namespace Search
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tLPSearch = new System.Windows.Forms.TableLayoutPanel();
            this.pSearchTools = new System.Windows.Forms.Panel();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lGender = new System.Windows.Forms.Label();
            this.lCountry = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBSurname = new System.Windows.Forms.TextBox();
            this.cBGender = new System.Windows.Forms.ComboBox();
            this.cBCountry = new System.Windows.Forms.ComboBox();
            this.mTBFromAge = new System.Windows.Forms.MaskedTextBox();
            this.mTBToAge = new System.Windows.Forms.MaskedTextBox();
            this.lFromAge = new System.Windows.Forms.Label();
            this.lToAge = new System.Windows.Forms.Label();
            this.bSearch = new System.Windows.Forms.Button();
            this.lBUsers = new System.Windows.Forms.ListBox();
            this.rTBFullInfo = new System.Windows.Forms.RichTextBox();
            this.lLogo = new System.Windows.Forms.Label();
            this.tLPSearch.SuspendLayout();
            this.pSearchTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPSearch
            // 
            this.tLPSearch.ColumnCount = 3;
            this.tLPSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.14371F));
            this.tLPSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.85629F));
            this.tLPSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tLPSearch.Controls.Add(this.pSearchTools, 2, 0);
            this.tLPSearch.Controls.Add(this.lBUsers, 0, 0);
            this.tLPSearch.Controls.Add(this.rTBFullInfo, 1, 0);
            this.tLPSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPSearch.Location = new System.Drawing.Point(0, 0);
            this.tLPSearch.Name = "tLPSearch";
            this.tLPSearch.RowCount = 1;
            this.tLPSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPSearch.Size = new System.Drawing.Size(845, 375);
            this.tLPSearch.TabIndex = 0;
            // 
            // pSearchTools
            // 
            this.pSearchTools.Controls.Add(this.lLogo);
            this.pSearchTools.Controls.Add(this.bSearch);
            this.pSearchTools.Controls.Add(this.lToAge);
            this.pSearchTools.Controls.Add(this.lFromAge);
            this.pSearchTools.Controls.Add(this.mTBToAge);
            this.pSearchTools.Controls.Add(this.mTBFromAge);
            this.pSearchTools.Controls.Add(this.cBCountry);
            this.pSearchTools.Controls.Add(this.cBGender);
            this.pSearchTools.Controls.Add(this.tBSurname);
            this.pSearchTools.Controls.Add(this.tBName);
            this.pSearchTools.Controls.Add(this.lAge);
            this.pSearchTools.Controls.Add(this.lCountry);
            this.pSearchTools.Controls.Add(this.lGender);
            this.pSearchTools.Controls.Add(this.lSurname);
            this.pSearchTools.Controls.Add(this.lName);
            this.pSearchTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearchTools.Location = new System.Drawing.Point(549, 3);
            this.pSearchTools.Name = "pSearchTools";
            this.pSearchTools.Size = new System.Drawing.Size(293, 369);
            this.pSearchTools.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(3, 80);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(3, 115);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(49, 13);
            this.lSurname.TabIndex = 1;
            this.lSurname.Text = "Surname";
            // 
            // lGender
            // 
            this.lGender.AutoSize = true;
            this.lGender.Location = new System.Drawing.Point(3, 154);
            this.lGender.Name = "lGender";
            this.lGender.Size = new System.Drawing.Size(42, 13);
            this.lGender.TabIndex = 2;
            this.lGender.Text = "Gender";
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Location = new System.Drawing.Point(3, 196);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(43, 13);
            this.lCountry.TabIndex = 3;
            this.lCountry.Text = "Country";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Location = new System.Drawing.Point(35, 246);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(26, 13);
            this.lAge.TabIndex = 4;
            this.lAge.Text = "Age";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(62, 80);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(222, 20);
            this.tBName.TabIndex = 5;
            // 
            // tBSurname
            // 
            this.tBSurname.Location = new System.Drawing.Point(62, 115);
            this.tBSurname.Name = "tBSurname";
            this.tBSurname.Size = new System.Drawing.Size(222, 20);
            this.tBSurname.TabIndex = 6;
            // 
            // cBGender
            // 
            this.cBGender.FormattingEnabled = true;
            this.cBGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Any"});
            this.cBGender.Location = new System.Drawing.Point(62, 151);
            this.cBGender.Name = "cBGender";
            this.cBGender.Size = new System.Drawing.Size(70, 21);
            this.cBGender.TabIndex = 7;
            // 
            // cBCountry
            // 
            this.cBCountry.FormattingEnabled = true;
            this.cBCountry.Location = new System.Drawing.Point(62, 193);
            this.cBCountry.Name = "cBCountry";
            this.cBCountry.Size = new System.Drawing.Size(121, 21);
            this.cBCountry.TabIndex = 8;
            // 
            // mTBFromAge
            // 
            this.mTBFromAge.Location = new System.Drawing.Point(67, 243);
            this.mTBFromAge.Mask = "00";
            this.mTBFromAge.Name = "mTBFromAge";
            this.mTBFromAge.Size = new System.Drawing.Size(20, 20);
            this.mTBFromAge.TabIndex = 9;
            this.mTBFromAge.ValidatingType = typeof(int);
            // 
            // mTBToAge
            // 
            this.mTBToAge.Location = new System.Drawing.Point(109, 243);
            this.mTBToAge.Mask = "00";
            this.mTBToAge.Name = "mTBToAge";
            this.mTBToAge.Size = new System.Drawing.Size(19, 20);
            this.mTBToAge.TabIndex = 10;
            this.mTBToAge.ValidatingType = typeof(int);
            // 
            // lFromAge
            // 
            this.lFromAge.AutoSize = true;
            this.lFromAge.Location = new System.Drawing.Point(63, 227);
            this.lFromAge.Name = "lFromAge";
            this.lFromAge.Size = new System.Drawing.Size(30, 13);
            this.lFromAge.TabIndex = 11;
            this.lFromAge.Text = "From";
            // 
            // lToAge
            // 
            this.lToAge.AutoSize = true;
            this.lToAge.Location = new System.Drawing.Point(108, 227);
            this.lToAge.Name = "lToAge";
            this.lToAge.Size = new System.Drawing.Size(20, 13);
            this.lToAge.TabIndex = 12;
            this.lToAge.Text = "To";
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bSearch.Image = ((System.Drawing.Image)(resources.GetObject("bSearch.Image")));
            this.bSearch.Location = new System.Drawing.Point(199, 241);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(36, 31);
            this.bSearch.TabIndex = 13;
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // lBUsers
            // 
            this.lBUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBUsers.Enabled = false;
            this.lBUsers.FormattingEnabled = true;
            this.lBUsers.Location = new System.Drawing.Point(3, 3);
            this.lBUsers.Name = "lBUsers";
            this.lBUsers.Size = new System.Drawing.Size(147, 369);
            this.lBUsers.TabIndex = 1;
            // 
            // rTBFullInfo
            // 
            this.rTBFullInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBFullInfo.Enabled = false;
            this.rTBFullInfo.Location = new System.Drawing.Point(156, 3);
            this.rTBFullInfo.Name = "rTBFullInfo";
            this.rTBFullInfo.Size = new System.Drawing.Size(387, 369);
            this.rTBFullInfo.TabIndex = 2;
            this.rTBFullInfo.Text = "";
            // 
            // lLogo
            // 
            this.lLogo.AutoSize = true;
            this.lLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lLogo.Location = new System.Drawing.Point(78, 19);
            this.lLogo.Name = "lLogo";
            this.lLogo.Size = new System.Drawing.Size(141, 25);
            this.lLogo.TabIndex = 14;
            this.lLogo.Text = "Search People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 375);
            this.Controls.Add(this.tLPSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tLPSearch.ResumeLayout(false);
            this.pSearchTools.ResumeLayout(false);
            this.pSearchTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPSearch;
        private System.Windows.Forms.Panel pSearchTools;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Label lToAge;
        private System.Windows.Forms.Label lFromAge;
        private System.Windows.Forms.MaskedTextBox mTBToAge;
        private System.Windows.Forms.MaskedTextBox mTBFromAge;
        private System.Windows.Forms.ComboBox cBCountry;
        private System.Windows.Forms.ComboBox cBGender;
        private System.Windows.Forms.TextBox tBSurname;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lGender;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ListBox lBUsers;
        private System.Windows.Forms.Label lLogo;
        private System.Windows.Forms.RichTextBox rTBFullInfo;
    }
}

