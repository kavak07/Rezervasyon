namespace Rezervasyon
{
    partial class addFlight
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.lb = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.flightNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.from = new DevExpress.XtraEditors.ComboBoxEdit();
            this.to = new DevExpress.XtraEditors.ComboBoxEdit();
            this.time = new DevExpress.XtraEditors.SpinEdit();
            this.estTime = new DevExpress.XtraEditors.TimeSpanEdit();
            this.date = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.lb);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.flightNumber);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.from);
            this.groupControl1.Controls.Add(this.to);
            this.groupControl1.Controls.Add(this.time);
            this.groupControl1.Controls.Add(this.estTime);
            this.groupControl1.Controls.Add(this.date);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 228);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "UÇUŞ BİLGİLERİ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(173, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(13, 13);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "DK";
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(16, 117);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(38, 13);
            this.lb.TabIndex = 10;
            this.lb.Text = "NEREYE";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 91);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "NEREDEN";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "SÜRE";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "PLANLANAN SAAT";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "TARİH";
            // 
            // flightNumber
            // 
            this.flightNumber.Location = new System.Drawing.Point(114, 36);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(139, 20);
            this.flightNumber.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UÇUŞ NO";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(114, 88);
            this.from.Name = "from";
            this.from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.from.Properties.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.from.Size = new System.Drawing.Size(139, 20);
            this.from.TabIndex = 9;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(114, 114);
            this.to.Name = "to";
            this.to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.to.Properties.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kilis",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.to.Size = new System.Drawing.Size(139, 20);
            this.to.TabIndex = 11;
            // 
            // time
            // 
            this.time.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.time.Location = new System.Drawing.Point(114, 166);
            this.time.Name = "time";
            this.time.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.time.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.time.Size = new System.Drawing.Size(53, 20);
            this.time.TabIndex = 7;
            // 
            // estTime
            // 
            this.estTime.EditValue = System.TimeSpan.Parse("01:00:00");
            this.estTime.Location = new System.Drawing.Point(114, 140);
            this.estTime.Name = "estTime";
            this.estTime.Properties.AllowEditDays = false;
            this.estTime.Properties.AllowEditSeconds = false;
            this.estTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.estTime.Properties.DisplayFormat.FormatString = "90:00";
            this.estTime.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.estTime.Properties.Mask.EditMask = "90:00";
            this.estTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.estTime.Properties.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal;
            this.estTime.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.SpinButtons;
            this.estTime.Size = new System.Drawing.Size(92, 20);
            this.estTime.TabIndex = 5;
            // 
            // date
            // 
            this.date.EditValue = null;
            this.date.Location = new System.Drawing.Point(114, 62);
            this.date.Name = "date";
            this.date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date.Properties.DisplayFormat.FormatString = "";
            this.date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.Properties.EditFormat.FormatString = "";
            this.date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date.Size = new System.Drawing.Size(139, 20);
            this.date.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(221, 246);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // addFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 281);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Name = "addFlight";
            this.Text = "UÇUŞ EKLE";
            this.Load += new System.EventHandler(this.addFlight_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit flightNumber;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit from;
        private DevExpress.XtraEditors.ComboBoxEdit to;
        private DevExpress.XtraEditors.SpinEdit time;
        private DevExpress.XtraEditors.TimeSpanEdit estTime;
        private DevExpress.XtraEditors.DateEdit date;
    }
}