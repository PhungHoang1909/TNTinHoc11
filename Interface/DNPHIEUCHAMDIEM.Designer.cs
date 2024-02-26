namespace Interface
{
    partial class DNPHIEUCHAMDIEM
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DNPHIEUCHAMDIEM));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_danhsachnopbai = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.hinhgv = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttoi = new System.Windows.Forms.Button();
            this.btlui = new System.Windows.Forms.Button();
            this.btcham = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_danhsachnopbai)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dg_danhsachnopbai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(785, 396);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thí sinh đã nộp bài";
            // 
            // dg_danhsachnopbai
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_danhsachnopbai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_danhsachnopbai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_danhsachnopbai.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_danhsachnopbai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_danhsachnopbai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_danhsachnopbai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_danhsachnopbai.Location = new System.Drawing.Point(4, 27);
            this.dg_danhsachnopbai.Margin = new System.Windows.Forms.Padding(4);
            this.dg_danhsachnopbai.Name = "dg_danhsachnopbai";
            this.dg_danhsachnopbai.Size = new System.Drawing.Size(777, 365);
            this.dg_danhsachnopbai.TabIndex = 1;
            this.dg_danhsachnopbai.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_danhsachnopbai_RowEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.hinhgv);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(805, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(203, 254);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hình";
            // 
            // hinhgv
            // 
            this.hinhgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hinhgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hinhgv.Location = new System.Drawing.Point(4, 27);
            this.hinhgv.Margin = new System.Windows.Forms.Padding(4);
            this.hinhgv.Name = "hinhgv";
            this.hinhgv.Size = new System.Drawing.Size(195, 223);
            this.hinhgv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhgv.TabIndex = 0;
            this.hinhgv.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.bttoi);
            this.groupBox1.Controls.Add(this.btlui);
            this.groupBox1.Controls.Add(this.btcham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(809, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(199, 135);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // bttoi
            // 
            this.bttoi.Location = new System.Drawing.Point(105, 81);
            this.bttoi.Margin = new System.Windows.Forms.Padding(4);
            this.bttoi.Name = "bttoi";
            this.bttoi.Size = new System.Drawing.Size(85, 43);
            this.bttoi.TabIndex = 2;
            this.bttoi.Text = ">";
            this.bttoi.UseVisualStyleBackColor = true;
            this.bttoi.Click += new System.EventHandler(this.bttoi_Click);
            // 
            // btlui
            // 
            this.btlui.Location = new System.Drawing.Point(8, 81);
            this.btlui.Margin = new System.Windows.Forms.Padding(4);
            this.btlui.Name = "btlui";
            this.btlui.Size = new System.Drawing.Size(85, 43);
            this.btlui.TabIndex = 1;
            this.btlui.Text = "<";
            this.btlui.UseVisualStyleBackColor = true;
            this.btlui.Click += new System.EventHandler(this.btlui_Click);
            // 
            // btcham
            // 
            this.btcham.Location = new System.Drawing.Point(8, 31);
            this.btcham.Margin = new System.Windows.Forms.Padding(4);
            this.btcham.Name = "btcham";
            this.btcham.Size = new System.Drawing.Size(183, 43);
            this.btcham.TabIndex = 0;
            this.btcham.Text = "Chấm điểm";
            this.btcham.UseVisualStyleBackColor = true;
            this.btcham.Click += new System.EventHandler(this.btcham_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DNPHIEUCHAMDIEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Interface.Properties.Resources.blue_pink_halftone_background_53876_990041;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DNPHIEUCHAMDIEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH NỘP BÀI";
            this.Load += new System.EventHandler(this.DNPHIEUCHAMDIEM_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_danhsachnopbai)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox hinhgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttoi;
        private System.Windows.Forms.Button btlui;
        private System.Windows.Forms.Button btcham;
        private System.Windows.Forms.DataGridView dg_danhsachnopbai;
        private System.Windows.Forms.Timer timer1;
    }
}