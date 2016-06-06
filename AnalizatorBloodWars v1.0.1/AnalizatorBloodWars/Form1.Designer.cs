namespace AnalizatorBloodWars
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
            this.panelStartowy = new System.Windows.Forms.Panel();
            this.btnCopyPaste = new System.Windows.Forms.Button();
            this.btnFromList = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAnalizatorBW = new System.Windows.Forms.Label();
            this.dalejStrStart = new System.Windows.Forms.Button();
            this.zakonczStrStart = new System.Windows.Forms.Button();
            this.textBoxStrStart = new System.Windows.Forms.RichTextBox();
            this.pStartpWybieranie = new System.Windows.Forms.Panel();
            this.rtbItemki = new System.Windows.Forms.RichTextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbSuffixItemka = new System.Windows.Forms.ComboBox();
            this.cbNazwaItemka = new System.Windows.Forms.ComboBox();
            this.cbPreffixItemka = new System.Windows.Forms.ComboBox();
            this.rodzajItemka = new System.Windows.Forms.ComboBox();
            this.panelWyboru = new System.Windows.Forms.Panel();
            this.StrWyboruWstecz = new System.Windows.Forms.Button();
            this.StrWyboruDalej = new System.Windows.Forms.Button();
            this.StrWyboruZakoncz = new System.Windows.Forms.Button();
            this.panelCheckBox = new System.Windows.Forms.Panel();
            this.chbDystans = new System.Windows.Forms.CheckBox();
            this.chbPalna2h = new System.Windows.Forms.CheckBox();
            this.chbPalna1h = new System.Windows.Forms.CheckBox();
            this.chbBiala2h = new System.Windows.Forms.CheckBox();
            this.chbBiala1h = new System.Windows.Forms.CheckBox();
            this.chbAmulet = new System.Windows.Forms.CheckBox();
            this.chbPierscien = new System.Windows.Forms.CheckBox();
            this.chbSpodnie = new System.Windows.Forms.CheckBox();
            this.chbZbroja = new System.Windows.Forms.CheckBox();
            this.chbHelm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stronaSprawdzenia = new System.Windows.Forms.Panel();
            this.strSprRichTextBox = new System.Windows.Forms.RichTextBox();
            this.strSprWstecz = new System.Windows.Forms.Button();
            this.strSprDalej = new System.Windows.Forms.Button();
            this.strSprZakoncz = new System.Windows.Forms.Button();
            this.strSprAnalizator = new System.Windows.Forms.Label();
            this.stronaWyniku = new System.Windows.Forms.Panel();
            this.strWynikuWynik = new System.Windows.Forms.ListBox();
            this.strWynikuLoczenia = new System.Windows.Forms.RichTextBox();
            this.strWynikuWstecz = new System.Windows.Forms.Button();
            this.strWynikuZakoncz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelStartowy.SuspendLayout();
            this.pStartpWybieranie.SuspendLayout();
            this.panelWyboru.SuspendLayout();
            this.panelCheckBox.SuspendLayout();
            this.stronaSprawdzenia.SuspendLayout();
            this.stronaWyniku.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartowy
            // 
            this.panelStartowy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStartowy.BackgroundImage")));
            this.panelStartowy.Controls.Add(this.btnCopyPaste);
            this.panelStartowy.Controls.Add(this.btnFromList);
            this.panelStartowy.Controls.Add(this.label3);
            this.panelStartowy.Controls.Add(this.labelAnalizatorBW);
            this.panelStartowy.Controls.Add(this.dalejStrStart);
            this.panelStartowy.Controls.Add(this.zakonczStrStart);
            this.panelStartowy.Controls.Add(this.textBoxStrStart);
            this.panelStartowy.Controls.Add(this.pStartpWybieranie);
            this.panelStartowy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartowy.Location = new System.Drawing.Point(0, 0);
            this.panelStartowy.Name = "panelStartowy";
            this.panelStartowy.Size = new System.Drawing.Size(983, 520);
            this.panelStartowy.TabIndex = 0;
            // 
            // btnCopyPaste
            // 
            this.btnCopyPaste.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCopyPaste.AutoSize = true;
            this.btnCopyPaste.BackColor = System.Drawing.Color.DarkRed;
            this.btnCopyPaste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopyPaste.BackgroundImage")));
            this.btnCopyPaste.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCopyPaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCopyPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPaste.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCopyPaste.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopyPaste.Location = new System.Drawing.Point(457, 90);
            this.btnCopyPaste.Name = "btnCopyPaste";
            this.btnCopyPaste.Size = new System.Drawing.Size(220, 27);
            this.btnCopyPaste.TabIndex = 7;
            this.btnCopyPaste.Text = "Kopiowanie przedmiotów z gry";
            this.btnCopyPaste.UseVisualStyleBackColor = false;
            this.btnCopyPaste.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFromList
            // 
            this.btnFromList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFromList.BackColor = System.Drawing.Color.DarkRed;
            this.btnFromList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFromList.BackgroundImage")));
            this.btnFromList.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFromList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFromList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFromList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFromList.Location = new System.Drawing.Point(457, 57);
            this.btnFromList.Name = "btnFromList";
            this.btnFromList.Size = new System.Drawing.Size(220, 27);
            this.btnFromList.TabIndex = 6;
            this.btnFromList.Text = "Wybieranie z listy przedmiotów";
            this.btnFromList.UseVisualStyleBackColor = false;
            this.btnFromList.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(222, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wybierz sposób wprowadzania:";
            // 
            // labelAnalizatorBW
            // 
            this.labelAnalizatorBW.BackColor = System.Drawing.Color.Black;
            this.labelAnalizatorBW.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAnalizatorBW.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnalizatorBW.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAnalizatorBW.Location = new System.Drawing.Point(0, 0);
            this.labelAnalizatorBW.Name = "labelAnalizatorBW";
            this.labelAnalizatorBW.Size = new System.Drawing.Size(983, 45);
            this.labelAnalizatorBW.TabIndex = 0;
            this.labelAnalizatorBW.Text = "Analizator BloodWars";
            this.labelAnalizatorBW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnalizatorBW.Click += new System.EventHandler(this.labelAnalizatorBW_Click);
            // 
            // dalejStrStart
            // 
            this.dalejStrStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dalejStrStart.AutoSize = true;
            this.dalejStrStart.BackColor = System.Drawing.Color.DarkRed;
            this.dalejStrStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dalejStrStart.BackgroundImage")));
            this.dalejStrStart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.dalejStrStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.dalejStrStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dalejStrStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dalejStrStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dalejStrStart.Location = new System.Drawing.Point(808, 481);
            this.dalejStrStart.Name = "dalejStrStart";
            this.dalejStrStart.Size = new System.Drawing.Size(75, 27);
            this.dalejStrStart.TabIndex = 3;
            this.dalejStrStart.Text = "Dalej >";
            this.dalejStrStart.UseVisualStyleBackColor = false;
            this.dalejStrStart.Click += new System.EventHandler(this.dalejStrStart_Click);
            // 
            // zakonczStrStart
            // 
            this.zakonczStrStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.zakonczStrStart.AutoSize = true;
            this.zakonczStrStart.BackColor = System.Drawing.Color.DarkRed;
            this.zakonczStrStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zakonczStrStart.BackgroundImage")));
            this.zakonczStrStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.zakonczStrStart.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.zakonczStrStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zakonczStrStart.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakonczStrStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.zakonczStrStart.Location = new System.Drawing.Point(896, 481);
            this.zakonczStrStart.Name = "zakonczStrStart";
            this.zakonczStrStart.Size = new System.Drawing.Size(75, 27);
            this.zakonczStrStart.TabIndex = 2;
            this.zakonczStrStart.Text = "Zakończ";
            this.zakonczStrStart.UseVisualStyleBackColor = false;
            this.zakonczStrStart.Click += new System.EventHandler(this.zakonczStrStart_Click);
            // 
            // textBoxStrStart
            // 
            this.textBoxStrStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStrStart.Location = new System.Drawing.Point(22, 132);
            this.textBoxStrStart.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.textBoxStrStart.Name = "textBoxStrStart";
            this.textBoxStrStart.Size = new System.Drawing.Size(926, 343);
            this.textBoxStrStart.TabIndex = 1;
            this.textBoxStrStart.Text = "";
            this.textBoxStrStart.Visible = false;
            this.textBoxStrStart.WordWrap = false;
            this.textBoxStrStart.Click += new System.EventHandler(this.textBoxStrStart_Click);
            // 
            // pStartpWybieranie
            // 
            this.pStartpWybieranie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pStartpWybieranie.AutoSize = true;
            this.pStartpWybieranie.BackgroundImage = global::AnalizatorBloodWars.Properties.Resources.zbrojownia_tlo;
            this.pStartpWybieranie.Controls.Add(this.rtbItemki);
            this.pStartpWybieranie.Controls.Add(this.btnDodaj);
            this.pStartpWybieranie.Controls.Add(this.cbSuffixItemka);
            this.pStartpWybieranie.Controls.Add(this.cbNazwaItemka);
            this.pStartpWybieranie.Controls.Add(this.cbPreffixItemka);
            this.pStartpWybieranie.Controls.Add(this.rodzajItemka);
            this.pStartpWybieranie.Location = new System.Drawing.Point(22, 132);
            this.pStartpWybieranie.Name = "pStartpWybieranie";
            this.pStartpWybieranie.Size = new System.Drawing.Size(929, 346);
            this.pStartpWybieranie.TabIndex = 13;
            this.pStartpWybieranie.Visible = false;
            // 
            // rtbItemki
            // 
            this.rtbItemki.Enabled = false;
            this.rtbItemki.Location = new System.Drawing.Point(133, 128);
            this.rtbItemki.Name = "rtbItemki";
            this.rtbItemki.Size = new System.Drawing.Size(659, 185);
            this.rtbItemki.TabIndex = 13;
            this.rtbItemki.Text = "";
            // 
            // btnDodaj
            // 
            this.btnDodaj.AutoSize = true;
            this.btnDodaj.BackColor = System.Drawing.Color.DarkRed;
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodaj.Location = new System.Drawing.Point(404, 81);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 27);
            this.btnDodaj.TabIndex = 12;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // cbSuffixItemka
            // 
            this.cbSuffixItemka.FormattingEnabled = true;
            this.cbSuffixItemka.Location = new System.Drawing.Point(601, 40);
            this.cbSuffixItemka.Name = "cbSuffixItemka";
            this.cbSuffixItemka.Size = new System.Drawing.Size(121, 21);
            this.cbSuffixItemka.TabIndex = 11;
            // 
            // cbNazwaItemka
            // 
            this.cbNazwaItemka.FormattingEnabled = true;
            this.cbNazwaItemka.Location = new System.Drawing.Point(388, 35);
            this.cbNazwaItemka.Name = "cbNazwaItemka";
            this.cbNazwaItemka.Size = new System.Drawing.Size(121, 21);
            this.cbNazwaItemka.TabIndex = 10;
            // 
            // cbPreffixItemka
            // 
            this.cbPreffixItemka.FormattingEnabled = true;
            this.cbPreffixItemka.Location = new System.Drawing.Point(182, 40);
            this.cbPreffixItemka.Name = "cbPreffixItemka";
            this.cbPreffixItemka.Size = new System.Drawing.Size(121, 21);
            this.cbPreffixItemka.TabIndex = 9;
            // 
            // rodzajItemka
            // 
            this.rodzajItemka.FormattingEnabled = true;
            this.rodzajItemka.Location = new System.Drawing.Point(388, 3);
            this.rodzajItemka.Name = "rodzajItemka";
            this.rodzajItemka.Size = new System.Drawing.Size(121, 21);
            this.rodzajItemka.TabIndex = 8;
            this.rodzajItemka.SelectedIndexChanged += new System.EventHandler(this.rodzajItemka_SelectedIndexChanged);
            // 
            // panelWyboru
            // 
            this.panelWyboru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelWyboru.BackgroundImage")));
            this.panelWyboru.Controls.Add(this.label4);
            this.panelWyboru.Controls.Add(this.StrWyboruWstecz);
            this.panelWyboru.Controls.Add(this.StrWyboruDalej);
            this.panelWyboru.Controls.Add(this.StrWyboruZakoncz);
            this.panelWyboru.Controls.Add(this.panelCheckBox);
            this.panelWyboru.Controls.Add(this.label1);
            this.panelWyboru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWyboru.Location = new System.Drawing.Point(0, 0);
            this.panelWyboru.Name = "panelWyboru";
            this.panelWyboru.Size = new System.Drawing.Size(983, 520);
            this.panelWyboru.TabIndex = 1;
            this.panelWyboru.Visible = false;
            // 
            // StrWyboruWstecz
            // 
            this.StrWyboruWstecz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StrWyboruWstecz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StrWyboruWstecz.BackgroundImage")));
            this.StrWyboruWstecz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.StrWyboruWstecz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrWyboruWstecz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrWyboruWstecz.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.StrWyboruWstecz.Location = new System.Drawing.Point(708, 478);
            this.StrWyboruWstecz.Name = "StrWyboruWstecz";
            this.StrWyboruWstecz.Size = new System.Drawing.Size(75, 23);
            this.StrWyboruWstecz.TabIndex = 4;
            this.StrWyboruWstecz.Text = "Wstecz <";
            this.StrWyboruWstecz.UseVisualStyleBackColor = true;
            this.StrWyboruWstecz.Click += new System.EventHandler(this.StrWyboruWstecz_Click);
            // 
            // StrWyboruDalej
            // 
            this.StrWyboruDalej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StrWyboruDalej.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StrWyboruDalej.BackgroundImage")));
            this.StrWyboruDalej.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.StrWyboruDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrWyboruDalej.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrWyboruDalej.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StrWyboruDalej.Location = new System.Drawing.Point(800, 478);
            this.StrWyboruDalej.Name = "StrWyboruDalej";
            this.StrWyboruDalej.Size = new System.Drawing.Size(78, 24);
            this.StrWyboruDalej.TabIndex = 5;
            this.StrWyboruDalej.Text = "Dalej >";
            this.StrWyboruDalej.UseVisualStyleBackColor = true;
            this.StrWyboruDalej.Click += new System.EventHandler(this.StrWyboruDalej_Click);
            // 
            // StrWyboruZakoncz
            // 
            this.StrWyboruZakoncz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StrWyboruZakoncz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StrWyboruZakoncz.BackgroundImage")));
            this.StrWyboruZakoncz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.StrWyboruZakoncz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StrWyboruZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StrWyboruZakoncz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StrWyboruZakoncz.Location = new System.Drawing.Point(891, 478);
            this.StrWyboruZakoncz.Name = "StrWyboruZakoncz";
            this.StrWyboruZakoncz.Size = new System.Drawing.Size(75, 23);
            this.StrWyboruZakoncz.TabIndex = 6;
            this.StrWyboruZakoncz.Text = "Zakończ";
            this.StrWyboruZakoncz.UseVisualStyleBackColor = true;
            this.StrWyboruZakoncz.Click += new System.EventHandler(this.StrWyboruZakoncz_Click);
            // 
            // panelCheckBox
            // 
            this.panelCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelCheckBox.AutoSize = true;
            this.panelCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCheckBox.BackgroundImage")));
            this.panelCheckBox.Controls.Add(this.chbDystans);
            this.panelCheckBox.Controls.Add(this.chbPalna2h);
            this.panelCheckBox.Controls.Add(this.chbPalna1h);
            this.panelCheckBox.Controls.Add(this.chbBiala2h);
            this.panelCheckBox.Controls.Add(this.chbBiala1h);
            this.panelCheckBox.Controls.Add(this.chbAmulet);
            this.panelCheckBox.Controls.Add(this.chbPierscien);
            this.panelCheckBox.Controls.Add(this.chbSpodnie);
            this.panelCheckBox.Controls.Add(this.chbZbroja);
            this.panelCheckBox.Controls.Add(this.chbHelm);
            this.panelCheckBox.Location = new System.Drawing.Point(397, 135);
            this.panelCheckBox.Name = "panelCheckBox";
            this.panelCheckBox.Size = new System.Drawing.Size(203, 290);
            this.panelCheckBox.TabIndex = 0;
            // 
            // chbDystans
            // 
            this.chbDystans.AutoSize = true;
            this.chbDystans.BackColor = System.Drawing.Color.Transparent;
            this.chbDystans.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbDystans.ForeColor = System.Drawing.Color.LightGray;
            this.chbDystans.Location = new System.Drawing.Point(29, 253);
            this.chbDystans.Name = "chbDystans";
            this.chbDystans.Size = new System.Drawing.Size(107, 20);
            this.chbDystans.TabIndex = 9;
            this.chbDystans.Text = "Dystansowa";
            this.chbDystans.UseVisualStyleBackColor = false;
            this.chbDystans.CheckedChanged += new System.EventHandler(this.chbDystans_CheckedChanged);
            // 
            // chbPalna2h
            // 
            this.chbPalna2h.AutoSize = true;
            this.chbPalna2h.BackColor = System.Drawing.Color.Transparent;
            this.chbPalna2h.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPalna2h.ForeColor = System.Drawing.Color.LightGray;
            this.chbPalna2h.Location = new System.Drawing.Point(28, 227);
            this.chbPalna2h.Name = "chbPalna2h";
            this.chbPalna2h.Size = new System.Drawing.Size(138, 20);
            this.chbPalna2h.TabIndex = 8;
            this.chbPalna2h.Text = "Palna dwuręczna";
            this.chbPalna2h.UseVisualStyleBackColor = false;
            this.chbPalna2h.CheckedChanged += new System.EventHandler(this.chbPalna2h_CheckedChanged);
            // 
            // chbPalna1h
            // 
            this.chbPalna1h.AutoSize = true;
            this.chbPalna1h.BackColor = System.Drawing.Color.Transparent;
            this.chbPalna1h.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPalna1h.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chbPalna1h.Location = new System.Drawing.Point(29, 201);
            this.chbPalna1h.Name = "chbPalna1h";
            this.chbPalna1h.Size = new System.Drawing.Size(147, 20);
            this.chbPalna1h.TabIndex = 7;
            this.chbPalna1h.Text = "Palna jednoręczna";
            this.chbPalna1h.UseVisualStyleBackColor = false;
            this.chbPalna1h.CheckedChanged += new System.EventHandler(this.chbPalna1h_CheckedChanged);
            // 
            // chbBiala2h
            // 
            this.chbBiala2h.AutoSize = true;
            this.chbBiala2h.BackColor = System.Drawing.Color.Transparent;
            this.chbBiala2h.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbBiala2h.ForeColor = System.Drawing.Color.LightGray;
            this.chbBiala2h.Location = new System.Drawing.Point(29, 175);
            this.chbBiala2h.Name = "chbBiala2h";
            this.chbBiala2h.Size = new System.Drawing.Size(133, 20);
            this.chbBiala2h.TabIndex = 6;
            this.chbBiala2h.Text = "Biała dwuręczna";
            this.chbBiala2h.UseVisualStyleBackColor = false;
            this.chbBiala2h.CheckedChanged += new System.EventHandler(this.chbBiala2h_CheckedChanged);
            // 
            // chbBiala1h
            // 
            this.chbBiala1h.AutoSize = true;
            this.chbBiala1h.BackColor = System.Drawing.Color.Transparent;
            this.chbBiala1h.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbBiala1h.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chbBiala1h.Location = new System.Drawing.Point(29, 149);
            this.chbBiala1h.Name = "chbBiala1h";
            this.chbBiala1h.Size = new System.Drawing.Size(142, 20);
            this.chbBiala1h.TabIndex = 5;
            this.chbBiala1h.Text = "Biała jednoręczna";
            this.chbBiala1h.UseVisualStyleBackColor = false;
            this.chbBiala1h.CheckedChanged += new System.EventHandler(this.chbBiala1h_CheckedChanged);
            // 
            // chbAmulet
            // 
            this.chbAmulet.AutoSize = true;
            this.chbAmulet.BackColor = System.Drawing.Color.Transparent;
            this.chbAmulet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbAmulet.ForeColor = System.Drawing.Color.LightGray;
            this.chbAmulet.Location = new System.Drawing.Point(29, 120);
            this.chbAmulet.Name = "chbAmulet";
            this.chbAmulet.Size = new System.Drawing.Size(72, 20);
            this.chbAmulet.TabIndex = 4;
            this.chbAmulet.Text = "Amulet";
            this.chbAmulet.UseVisualStyleBackColor = false;
            this.chbAmulet.CheckedChanged += new System.EventHandler(this.chbAmulet_CheckedChanged);
            // 
            // chbPierscien
            // 
            this.chbPierscien.AutoSize = true;
            this.chbPierscien.BackColor = System.Drawing.Color.Transparent;
            this.chbPierscien.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbPierscien.ForeColor = System.Drawing.Color.LightGray;
            this.chbPierscien.Location = new System.Drawing.Point(29, 96);
            this.chbPierscien.Name = "chbPierscien";
            this.chbPierscien.Size = new System.Drawing.Size(85, 20);
            this.chbPierscien.TabIndex = 3;
            this.chbPierscien.Text = "Pierścień";
            this.chbPierscien.UseVisualStyleBackColor = false;
            this.chbPierscien.CheckedChanged += new System.EventHandler(this.chbPierscien_CheckedChanged);
            // 
            // chbSpodnie
            // 
            this.chbSpodnie.AutoSize = true;
            this.chbSpodnie.BackColor = System.Drawing.Color.Transparent;
            this.chbSpodnie.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSpodnie.ForeColor = System.Drawing.Color.LightGray;
            this.chbSpodnie.Location = new System.Drawing.Point(29, 70);
            this.chbSpodnie.Name = "chbSpodnie";
            this.chbSpodnie.Size = new System.Drawing.Size(79, 20);
            this.chbSpodnie.TabIndex = 2;
            this.chbSpodnie.Text = "Spodnie";
            this.chbSpodnie.UseVisualStyleBackColor = false;
            this.chbSpodnie.CheckedChanged += new System.EventHandler(this.chbSpodnie_CheckedChanged);
            // 
            // chbZbroja
            // 
            this.chbZbroja.AutoSize = true;
            this.chbZbroja.BackColor = System.Drawing.Color.Transparent;
            this.chbZbroja.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbZbroja.ForeColor = System.Drawing.Color.LightGray;
            this.chbZbroja.Location = new System.Drawing.Point(29, 45);
            this.chbZbroja.Name = "chbZbroja";
            this.chbZbroja.Size = new System.Drawing.Size(67, 20);
            this.chbZbroja.TabIndex = 1;
            this.chbZbroja.Text = "zbroja";
            this.chbZbroja.UseVisualStyleBackColor = false;
            this.chbZbroja.CheckedChanged += new System.EventHandler(this.chbZbroja_CheckedChanged);
            // 
            // chbHelm
            // 
            this.chbHelm.AutoSize = true;
            this.chbHelm.BackColor = System.Drawing.Color.Transparent;
            this.chbHelm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbHelm.ForeColor = System.Drawing.Color.LightGray;
            this.chbHelm.Location = new System.Drawing.Point(29, 19);
            this.chbHelm.Name = "chbHelm";
            this.chbHelm.Size = new System.Drawing.Size(58, 20);
            this.chbHelm.TabIndex = 0;
            this.chbHelm.Text = "Hełm";
            this.chbHelm.UseVisualStyleBackColor = false;
            this.chbHelm.CheckedChanged += new System.EventHandler(this.chbHelm_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Analizator BloodWars";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stronaSprawdzenia
            // 
            this.stronaSprawdzenia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stronaSprawdzenia.BackgroundImage")));
            this.stronaSprawdzenia.Controls.Add(this.label7);
            this.stronaSprawdzenia.Controls.Add(this.strSprRichTextBox);
            this.stronaSprawdzenia.Controls.Add(this.strSprWstecz);
            this.stronaSprawdzenia.Controls.Add(this.strSprDalej);
            this.stronaSprawdzenia.Controls.Add(this.strSprZakoncz);
            this.stronaSprawdzenia.Controls.Add(this.strSprAnalizator);
            this.stronaSprawdzenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stronaSprawdzenia.Location = new System.Drawing.Point(0, 0);
            this.stronaSprawdzenia.Name = "stronaSprawdzenia";
            this.stronaSprawdzenia.Size = new System.Drawing.Size(983, 520);
            this.stronaSprawdzenia.TabIndex = 7;
            this.stronaSprawdzenia.Visible = false;
            // 
            // strSprRichTextBox
            // 
            this.strSprRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strSprRichTextBox.Location = new System.Drawing.Point(38, 116);
            this.strSprRichTextBox.Name = "strSprRichTextBox";
            this.strSprRichTextBox.Size = new System.Drawing.Size(895, 346);
            this.strSprRichTextBox.TabIndex = 6;
            this.strSprRichTextBox.Text = "";
            // 
            // strSprWstecz
            // 
            this.strSprWstecz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strSprWstecz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strSprWstecz.BackgroundImage")));
            this.strSprWstecz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.strSprWstecz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strSprWstecz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strSprWstecz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strSprWstecz.Location = new System.Drawing.Point(727, 479);
            this.strSprWstecz.Name = "strSprWstecz";
            this.strSprWstecz.Size = new System.Drawing.Size(75, 23);
            this.strSprWstecz.TabIndex = 5;
            this.strSprWstecz.Text = "Wstecz <";
            this.strSprWstecz.UseVisualStyleBackColor = true;
            this.strSprWstecz.Click += new System.EventHandler(this.strSprWstecz_Click);
            // 
            // strSprDalej
            // 
            this.strSprDalej.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strSprDalej.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strSprDalej.BackgroundImage")));
            this.strSprDalej.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.strSprDalej.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strSprDalej.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strSprDalej.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strSprDalej.Location = new System.Drawing.Point(810, 479);
            this.strSprDalej.Name = "strSprDalej";
            this.strSprDalej.Size = new System.Drawing.Size(75, 23);
            this.strSprDalej.TabIndex = 4;
            this.strSprDalej.Text = "Dalej >";
            this.strSprDalej.UseVisualStyleBackColor = true;
            this.strSprDalej.Click += new System.EventHandler(this.strSprDalej_Click);
            // 
            // strSprZakoncz
            // 
            this.strSprZakoncz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strSprZakoncz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strSprZakoncz.BackgroundImage")));
            this.strSprZakoncz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.strSprZakoncz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strSprZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strSprZakoncz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strSprZakoncz.Location = new System.Drawing.Point(895, 479);
            this.strSprZakoncz.Name = "strSprZakoncz";
            this.strSprZakoncz.Size = new System.Drawing.Size(75, 23);
            this.strSprZakoncz.TabIndex = 3;
            this.strSprZakoncz.Text = "Zakończ";
            this.strSprZakoncz.UseVisualStyleBackColor = true;
            this.strSprZakoncz.Click += new System.EventHandler(this.strSprZakoncz_Click);
            // 
            // strSprAnalizator
            // 
            this.strSprAnalizator.BackColor = System.Drawing.Color.Black;
            this.strSprAnalizator.Dock = System.Windows.Forms.DockStyle.Top;
            this.strSprAnalizator.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strSprAnalizator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strSprAnalizator.Location = new System.Drawing.Point(0, 0);
            this.strSprAnalizator.Name = "strSprAnalizator";
            this.strSprAnalizator.Size = new System.Drawing.Size(983, 45);
            this.strSprAnalizator.TabIndex = 2;
            this.strSprAnalizator.Text = "Analizator BloodWars";
            this.strSprAnalizator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stronaWyniku
            // 
            this.stronaWyniku.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stronaWyniku.BackgroundImage")));
            this.stronaWyniku.Controls.Add(this.label6);
            this.stronaWyniku.Controls.Add(this.label5);
            this.stronaWyniku.Controls.Add(this.strWynikuWynik);
            this.stronaWyniku.Controls.Add(this.strWynikuLoczenia);
            this.stronaWyniku.Controls.Add(this.strWynikuWstecz);
            this.stronaWyniku.Controls.Add(this.strWynikuZakoncz);
            this.stronaWyniku.Controls.Add(this.label2);
            this.stronaWyniku.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stronaWyniku.Location = new System.Drawing.Point(0, 0);
            this.stronaWyniku.Name = "stronaWyniku";
            this.stronaWyniku.Size = new System.Drawing.Size(983, 520);
            this.stronaWyniku.TabIndex = 4;
            this.stronaWyniku.Visible = false;
            this.stronaWyniku.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // strWynikuWynik
            // 
            this.strWynikuWynik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.strWynikuWynik.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strWynikuWynik.FormattingEnabled = true;
            this.strWynikuWynik.ItemHeight = 14;
            this.strWynikuWynik.Location = new System.Drawing.Point(53, 158);
            this.strWynikuWynik.Name = "strWynikuWynik";
            this.strWynikuWynik.Size = new System.Drawing.Size(351, 298);
            this.strWynikuWynik.TabIndex = 5;
            this.strWynikuWynik.SelectedIndexChanged += new System.EventHandler(this.strWynikuWynik_SelectedIndexChanged);
            // 
            // strWynikuLoczenia
            // 
            this.strWynikuLoczenia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.strWynikuLoczenia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strWynikuLoczenia.Location = new System.Drawing.Point(552, 158);
            this.strWynikuLoczenia.Name = "strWynikuLoczenia";
            this.strWynikuLoczenia.Size = new System.Drawing.Size(345, 304);
            this.strWynikuLoczenia.TabIndex = 4;
            this.strWynikuLoczenia.Text = "";
            // 
            // strWynikuWstecz
            // 
            this.strWynikuWstecz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strWynikuWstecz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strWynikuWstecz.BackgroundImage")));
            this.strWynikuWstecz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.strWynikuWstecz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strWynikuWstecz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strWynikuWstecz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strWynikuWstecz.Location = new System.Drawing.Point(789, 479);
            this.strWynikuWstecz.Name = "strWynikuWstecz";
            this.strWynikuWstecz.Size = new System.Drawing.Size(80, 23);
            this.strWynikuWstecz.TabIndex = 3;
            this.strWynikuWstecz.Text = "Wstecz <";
            this.strWynikuWstecz.UseVisualStyleBackColor = true;
            this.strWynikuWstecz.Click += new System.EventHandler(this.strWynikuWstecz_Click);
            // 
            // strWynikuZakoncz
            // 
            this.strWynikuZakoncz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.strWynikuZakoncz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strWynikuZakoncz.BackgroundImage")));
            this.strWynikuZakoncz.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.strWynikuZakoncz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strWynikuZakoncz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.strWynikuZakoncz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.strWynikuZakoncz.Location = new System.Drawing.Point(884, 477);
            this.strWynikuZakoncz.Name = "strWynikuZakoncz";
            this.strWynikuZakoncz.Size = new System.Drawing.Size(82, 24);
            this.strWynikuZakoncz.TabIndex = 2;
            this.strWynikuZakoncz.Text = "Zakończ";
            this.strWynikuZakoncz.UseVisualStyleBackColor = true;
            this.strWynikuZakoncz.Click += new System.EventHandler(this.strWynikuZakoncz_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(983, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Analizator BloodWars";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(183, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(666, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wybierz, które przedmioty chcesz znaleźć i połączyć : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Przedmioty, które można uzyskać : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(510, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(441, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Przedmioty z których powstał wybrany : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(368, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Znalezione przedmioty : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(983, 520);
            this.Controls.Add(this.panelStartowy);
            this.Controls.Add(this.stronaSprawdzenia);
            this.Controls.Add(this.panelWyboru);
            this.Controls.Add(this.stronaWyniku);
            this.Name = "Form1";
            this.Text = "Analizator BloodWars";
            this.panelStartowy.ResumeLayout(false);
            this.panelStartowy.PerformLayout();
            this.pStartpWybieranie.ResumeLayout(false);
            this.pStartpWybieranie.PerformLayout();
            this.panelWyboru.ResumeLayout(false);
            this.panelWyboru.PerformLayout();
            this.panelCheckBox.ResumeLayout(false);
            this.panelCheckBox.PerformLayout();
            this.stronaSprawdzenia.ResumeLayout(false);
            this.stronaSprawdzenia.PerformLayout();
            this.stronaWyniku.ResumeLayout(false);
            this.stronaWyniku.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStartowy;
        private System.Windows.Forms.Label labelAnalizatorBW;
        private System.Windows.Forms.RichTextBox textBoxStrStart;
        private System.Windows.Forms.Button dalejStrStart;
        private System.Windows.Forms.Button zakonczStrStart;
        private System.Windows.Forms.Panel panelWyboru;
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StrWyboruWstecz;
        private System.Windows.Forms.Button StrWyboruDalej;
        private System.Windows.Forms.Button StrWyboruZakoncz;
        private System.Windows.Forms.Panel panelCheckBox;
        private System.Windows.Forms.CheckBox chbPalna2h;
        private System.Windows.Forms.CheckBox chbPalna1h;
        private System.Windows.Forms.CheckBox chbBiala2h;
        private System.Windows.Forms.CheckBox chbBiala1h;
        private System.Windows.Forms.CheckBox chbAmulet;
        private System.Windows.Forms.CheckBox chbPierscien;
        private System.Windows.Forms.CheckBox chbSpodnie;
        private System.Windows.Forms.CheckBox chbZbroja;
        private System.Windows.Forms.CheckBox chbHelm;
        private System.Windows.Forms.Panel stronaSprawdzenia;
        private System.Windows.Forms.Button strSprWstecz;
        private System.Windows.Forms.Button strSprDalej;
        private System.Windows.Forms.Button strSprZakoncz;
        private System.Windows.Forms.Label strSprAnalizator;
        private System.Windows.Forms.RichTextBox strSprRichTextBox;
        private System.Windows.Forms.Panel stronaWyniku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button strWynikuWstecz;
        private System.Windows.Forms.Button strWynikuZakoncz;
        private System.Windows.Forms.RichTextBox strWynikuLoczenia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbDystans;
        private System.Windows.Forms.Panel pStartpWybieranie;
        private System.Windows.Forms.RichTextBox rtbItemki;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbSuffixItemka;
        private System.Windows.Forms.ComboBox cbNazwaItemka;
        private System.Windows.Forms.ComboBox cbPreffixItemka;
        private System.Windows.Forms.ComboBox rodzajItemka;
        private System.Windows.Forms.Button btnCopyPaste;
        private System.Windows.Forms.Button btnFromList;
        private System.Windows.Forms.ListBox strWynikuWynik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

