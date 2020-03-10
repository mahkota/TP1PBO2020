namespace TP1
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.buttonBeli = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBeli
            // 
            this.buttonBeli.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBeli.Image = ((System.Drawing.Image)(resources.GetObject("buttonBeli.Image")));
            this.buttonBeli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBeli.Location = new System.Drawing.Point(0, 0);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(163, 60);
            this.buttonBeli.TabIndex = 0;
            this.buttonBeli.Text = "Beli";
            this.buttonBeli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBeli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBeli.UseVisualStyleBackColor = true;
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKatalog.Image = ((System.Drawing.Image)(resources.GetObject("buttonKatalog.Image")));
            this.buttonKatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKatalog.Location = new System.Drawing.Point(0, 66);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(163, 60);
            this.buttonKatalog.TabIndex = 1;
            this.buttonKatalog.Text = "Katalog";
            this.buttonKatalog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKatalog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonKatalog.UseVisualStyleBackColor = true;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogout.Location = new System.Drawing.Point(0, 456);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(163, 60);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.buttonLogout);
            this.panelSidebar.Controls.Add(this.buttonKatalog);
            this.panelSidebar.Controls.Add(this.buttonBeli);
            this.panelSidebar.Location = new System.Drawing.Point(21, 21);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(163, 515);
            this.panelSidebar.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(204, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 516);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(695, 448);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.comboBox1.Location = new System.Drawing.Point(18, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.comboBox2.Location = new System.Drawing.Point(145, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(752, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1800570 - Fachri Veryawan Mahkota";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(953, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tugas Praktikum 1";
            this.Load += new System.EventHandler(this.MainProgram_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeli;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}