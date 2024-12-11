namespace GUI
{
    partial class phieumuontrasasch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mượnSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_phieumuonsach = new System.Windows.Forms.Label();
            this.macuonsach = new System.Windows.Forms.Label();
            this.madocgia = new System.Windows.Forms.Label();
            this.ngaymuon = new System.Windows.Forms.Label();
            this.ngaytra = new System.Windows.Forms.Label();
            this.text_macuonsach = new System.Windows.Forms.TextBox();
            this.textbox_madocgia = new System.Windows.Forms.TextBox();
            this.datetime_ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.datetime_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.dongy_button = new System.Windows.Forms.Button();
            this.phieutrasach = new System.Windows.Forms.Label();
            this.maphieumuon = new System.Windows.Forms.Label();
            this.text_maphieumuon = new System.Windows.Forms.TextBox();
            this.checkmaphieumuon_button = new System.Windows.Forms.Button();
            this.nhapngaytra = new System.Windows.Forms.Label();
            this.nhapngaytra_textbox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mượnSáchToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1686, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mượnSáchToolStripMenuItem
            // 
            this.mượnSáchToolStripMenuItem.Name = "mượnSáchToolStripMenuItem";
            this.mượnSáchToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.mượnSáchToolStripMenuItem.Text = "Mượn sách";
            this.mượnSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnSáchToolStripMenuItem_Click);
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
            this.trảSáchToolStripMenuItem.Click += new System.EventHandler(this.trảSáchToolStripMenuItem_Click);
            // 
            // label_phieumuonsach
            // 
            this.label_phieumuonsach.AutoSize = true;
            this.label_phieumuonsach.BackColor = System.Drawing.Color.Lavender;
            this.label_phieumuonsach.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phieumuonsach.Location = new System.Drawing.Point(624, 62);
            this.label_phieumuonsach.Name = "label_phieumuonsach";
            this.label_phieumuonsach.Size = new System.Drawing.Size(522, 70);
            this.label_phieumuonsach.TabIndex = 1;
            this.label_phieumuonsach.Text = "PHIẾU MƯỢN SÁCH";
            this.label_phieumuonsach.Visible = false;
            // 
            // macuonsach
            // 
            this.macuonsach.AutoSize = true;
            this.macuonsach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.macuonsach.Location = new System.Drawing.Point(50, 169);
            this.macuonsach.Name = "macuonsach";
            this.macuonsach.Size = new System.Drawing.Size(204, 38);
            this.macuonsach.TabIndex = 3;
            this.macuonsach.Text = "Mã cuốn sách:";
            this.macuonsach.Visible = false;
            // 
            // madocgia
            // 
            this.madocgia.AutoSize = true;
            this.madocgia.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.madocgia.Location = new System.Drawing.Point(50, 221);
            this.madocgia.Name = "madocgia";
            this.madocgia.Size = new System.Drawing.Size(171, 38);
            this.madocgia.TabIndex = 4;
            this.madocgia.Text = "Mã độc giả:";
            this.madocgia.Visible = false;
            // 
            // ngaymuon
            // 
            this.ngaymuon.AutoSize = true;
            this.ngaymuon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaymuon.Location = new System.Drawing.Point(50, 274);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(182, 38);
            this.ngaymuon.TabIndex = 5;
            this.ngaymuon.Text = "Ngày mượn:";
            this.ngaymuon.Visible = false;
            // 
            // ngaytra
            // 
            this.ngaytra.AutoSize = true;
            this.ngaytra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaytra.Location = new System.Drawing.Point(50, 328);
            this.ngaytra.Name = "ngaytra";
            this.ngaytra.Size = new System.Drawing.Size(139, 38);
            this.ngaytra.TabIndex = 6;
            this.ngaytra.Text = "Ngày trả:";
            this.ngaytra.Visible = false;
            // 
            // text_macuonsach
            // 
            this.text_macuonsach.Location = new System.Drawing.Point(341, 165);
            this.text_macuonsach.Name = "text_macuonsach";
            this.text_macuonsach.Size = new System.Drawing.Size(650, 26);
            this.text_macuonsach.TabIndex = 7;
            this.text_macuonsach.Visible = false;
            this.text_macuonsach.WordWrap = false;
            // 
            // textbox_madocgia
            // 
            this.textbox_madocgia.Location = new System.Drawing.Point(341, 221);
            this.textbox_madocgia.Name = "textbox_madocgia";
            this.textbox_madocgia.Size = new System.Drawing.Size(650, 26);
            this.textbox_madocgia.TabIndex = 8;
            this.textbox_madocgia.Visible = false;
            // 
            // datetime_ngaymuon
            // 
            this.datetime_ngaymuon.Location = new System.Drawing.Point(341, 284);
            this.datetime_ngaymuon.Name = "datetime_ngaymuon";
            this.datetime_ngaymuon.Size = new System.Drawing.Size(650, 26);
            this.datetime_ngaymuon.TabIndex = 9;
            this.datetime_ngaymuon.Visible = false;
            // 
            // datetime_ngaytra
            // 
            this.datetime_ngaytra.Location = new System.Drawing.Point(341, 340);
            this.datetime_ngaytra.Name = "datetime_ngaytra";
            this.datetime_ngaytra.Size = new System.Drawing.Size(650, 26);
            this.datetime_ngaytra.TabIndex = 10;
            this.datetime_ngaytra.Visible = false;
            // 
            // dongy_button
            // 
            this.dongy_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dongy_button.Location = new System.Drawing.Point(756, 421);
            this.dongy_button.Name = "dongy_button";
            this.dongy_button.Size = new System.Drawing.Size(271, 92);
            this.dongy_button.TabIndex = 11;
            this.dongy_button.Text = "Đồng ý";
            this.dongy_button.UseVisualStyleBackColor = true;
            this.dongy_button.Visible = false;
            this.dongy_button.Click += new System.EventHandler(this.dongy_button_Click);
            // 
            // phieutrasach
            // 
            this.phieutrasach.AutoSize = true;
            this.phieutrasach.BackColor = System.Drawing.Color.Lavender;
            this.phieutrasach.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phieutrasach.Location = new System.Drawing.Point(653, 62);
            this.phieutrasach.Name = "phieutrasach";
            this.phieutrasach.Size = new System.Drawing.Size(451, 70);
            this.phieutrasach.TabIndex = 12;
            this.phieutrasach.Text = "PHIẾU TRẢ SÁCH";
            this.phieutrasach.Visible = false;
            // 
            // maphieumuon
            // 
            this.maphieumuon.AutoSize = true;
            this.maphieumuon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphieumuon.Location = new System.Drawing.Point(205, 165);
            this.maphieumuon.Name = "maphieumuon";
            this.maphieumuon.Size = new System.Drawing.Size(315, 38);
            this.maphieumuon.TabIndex = 13;
            this.maphieumuon.Text = "Nhập mã phiếu mượn:";
            this.maphieumuon.Visible = false;
            // 
            // text_maphieumuon
            // 
            this.text_maphieumuon.Location = new System.Drawing.Point(550, 177);
            this.text_maphieumuon.Name = "text_maphieumuon";
            this.text_maphieumuon.Size = new System.Drawing.Size(650, 26);
            this.text_maphieumuon.TabIndex = 14;
            this.text_maphieumuon.Visible = false;
            this.text_maphieumuon.WordWrap = false;
            // 
            // checkmaphieumuon_button
            // 
            this.checkmaphieumuon_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkmaphieumuon_button.Location = new System.Drawing.Point(756, 558);
            this.checkmaphieumuon_button.Name = "checkmaphieumuon_button";
            this.checkmaphieumuon_button.Size = new System.Drawing.Size(271, 92);
            this.checkmaphieumuon_button.TabIndex = 15;
            this.checkmaphieumuon_button.Text = "Đồng ý";
            this.checkmaphieumuon_button.UseVisualStyleBackColor = true;
            this.checkmaphieumuon_button.Visible = false;
            
            // 
            // nhapngaytra
            // 
            this.nhapngaytra.AutoSize = true;
            this.nhapngaytra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhapngaytra.Location = new System.Drawing.Point(205, 221);
            this.nhapngaytra.Name = "nhapngaytra";
            this.nhapngaytra.Size = new System.Drawing.Size(213, 38);
            this.nhapngaytra.TabIndex = 16;
            this.nhapngaytra.Text = "Nhập ngày trả:";
            this.nhapngaytra.Visible = false;
            // 
            // nhapngaytra_textbox
            // 
            this.nhapngaytra_textbox.Location = new System.Drawing.Point(550, 233);
            this.nhapngaytra_textbox.Name = "nhapngaytra_textbox";
            this.nhapngaytra_textbox.Size = new System.Drawing.Size(650, 26);
            this.nhapngaytra_textbox.TabIndex = 17;
            this.nhapngaytra_textbox.Visible = false;
            this.nhapngaytra_textbox.WordWrap = false;
            // 
            // phieumuontrasasch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1686, 898);
            this.Controls.Add(this.nhapngaytra_textbox);
            this.Controls.Add(this.nhapngaytra);
            this.Controls.Add(this.checkmaphieumuon_button);
            this.Controls.Add(this.text_maphieumuon);
            this.Controls.Add(this.maphieumuon);
            this.Controls.Add(this.phieutrasach);
            this.Controls.Add(this.dongy_button);
            this.Controls.Add(this.datetime_ngaytra);
            this.Controls.Add(this.datetime_ngaymuon);
            this.Controls.Add(this.textbox_madocgia);
            this.Controls.Add(this.text_macuonsach);
            this.Controls.Add(this.ngaytra);
            this.Controls.Add(this.ngaymuon);
            this.Controls.Add(this.madocgia);
            this.Controls.Add(this.macuonsach);
            this.Controls.Add(this.label_phieumuonsach);
            this.Controls.Add(this.menuStrip1);
            this.Name = "phieumuontrasasch";
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mượnSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.Label label_phieumuonsach;
        private System.Windows.Forms.Label macuonsach;
        private System.Windows.Forms.Label madocgia;
        private System.Windows.Forms.Label ngaymuon;
        private System.Windows.Forms.Label ngaytra;
        private System.Windows.Forms.TextBox text_macuonsach;
        private System.Windows.Forms.TextBox textbox_madocgia;
        private System.Windows.Forms.DateTimePicker datetime_ngaymuon;
        private System.Windows.Forms.DateTimePicker datetime_ngaytra;
        private System.Windows.Forms.Button dongy_button;
        private System.Windows.Forms.Label phieutrasach;
        private System.Windows.Forms.Label maphieumuon;
        private System.Windows.Forms.TextBox text_maphieumuon;
        private System.Windows.Forms.Button checkmaphieumuon_button;
        private System.Windows.Forms.Label nhapngaytra;
        private System.Windows.Forms.TextBox nhapngaytra_textbox;
    }
}

