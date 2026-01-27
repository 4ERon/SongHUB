namespace SongHUB
{
    partial class AddSong
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSong));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtLyrics = new Sunny.UI.UIRichTextBox();
            txtTitle = new Sunny.UI.UITextBox();
            txtSinger = new Sunny.UI.UITextBox();
            btnDelete = new Sunny.UI.UIButton();
            cmbType = new Sunny.UI.UIComboBox();
            dgvSongList = new Sunny.UI.UIDataGridView();
            btnSave = new Sunny.UI.UIButton();
            btnRefresh = new Sunny.UI.UIButton();
            txtSearch = new Sunny.UI.UITextBox();
            btnClose = new Sunny.UI.UIImageButton();
            btnMinimize = new Sunny.UI.UIImageButton();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvSongList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtLyrics
            // 
            txtLyrics.FillColor = Color.LightGray;
            txtLyrics.Font = new Font("Microsoft Sans Serif", 12F);
            txtLyrics.Location = new Point(23, 156);
            txtLyrics.Margin = new Padding(4, 5, 4, 5);
            txtLyrics.MinimumSize = new Size(1, 1);
            txtLyrics.Name = "txtLyrics";
            txtLyrics.Padding = new Padding(2);
            txtLyrics.RectColor = Color.Lime;
            txtLyrics.ShowText = false;
            txtLyrics.Size = new Size(894, 551);
            txtLyrics.TabIndex = 6;
            txtLyrics.TagString = "";
            txtLyrics.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.FillColor = Color.MintCream;
            txtTitle.Font = new Font("Microsoft Sans Serif", 12F);
            txtTitle.Location = new Point(23, 79);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.Radius = 10;
            txtTitle.RectColor = Color.Lime;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(342, 55);
            txtTitle.TabIndex = 0;
            txtTitle.TextAlignment = ContentAlignment.MiddleLeft;
            txtTitle.Watermark = "Title";
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtSinger
            // 
            txtSinger.FillColor = Color.MintCream;
            txtSinger.Font = new Font("Microsoft Sans Serif", 12F);
            txtSinger.Location = new Point(388, 79);
            txtSinger.Margin = new Padding(4, 5, 4, 5);
            txtSinger.MinimumSize = new Size(1, 16);
            txtSinger.Name = "txtSinger";
            txtSinger.Padding = new Padding(5);
            txtSinger.Radius = 10;
            txtSinger.RectColor = Color.Lime;
            txtSinger.ShowText = false;
            txtSinger.Size = new Size(305, 55);
            txtSinger.TabIndex = 1;
            txtSinger.TextAlignment = ContentAlignment.MiddleLeft;
            txtSinger.Watermark = "Singer";
            txtSinger.TextChanged += txtSinger_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.FillColor = Color.FromArgb(255, 128, 128);
            btnDelete.FillColor2 = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(582, 738);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = Color.Lime;
            btnDelete.Size = new Size(150, 51);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // cmbType
            // 
            cmbType.DataSource = null;
            cmbType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbType.FillColor = Color.MintCream;
            cmbType.Font = new Font("Microsoft Sans Serif", 12F);
            cmbType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbType.Items.AddRange(new object[] { "Fast", "Slow" });
            cmbType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbType.Location = new Point(710, 79);
            cmbType.Margin = new Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(0, 0, 30, 2);
            cmbType.RectColor = Color.Lime;
            cmbType.Size = new Size(207, 55);
            cmbType.SymbolSize = 24;
            cmbType.TabIndex = 2;
            cmbType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbType.Watermark = "Type";
            // 
            // dgvSongList
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvSongList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSongList.BackgroundColor = Color.LightGray;
            dgvSongList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSongList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSongList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSongList.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSongList.EnableHeadersVisualStyles = false;
            dgvSongList.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongList.GridColor = Color.FromArgb(0, 192, 0);
            dgvSongList.Location = new Point(25, 272);
            dgvSongList.Name = "dgvSongList";
            dgvSongList.ReadOnly = true;
            dgvSongList.RectColor = Color.Lime;
            dgvSongList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSongList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSongList.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSongList.ScrollBarColor = Color.FromArgb(0, 192, 0);
            dgvSongList.ScrollBarRectColor = Color.ForestGreen;
            dgvSongList.ScrollBarStyleInherited = false;
            dgvSongList.SelectedIndex = -1;
            dgvSongList.Size = new Size(346, 575);
            dgvSongList.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvSongList.TabIndex = 10;
            dgvSongList.CellClick += dgvSongList_CellClick;
            // 
            // btnSave
            // 
            btnSave.BackgroundImage = (Image)resources.GetObject("btnSave.BackgroundImage");
            btnSave.FillColor = Color.FromArgb(30, 189, 199);
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(767, 738);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.RectColor = Color.Lime;
            btnSave.Size = new Size(150, 51);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FillColor = Color.FromArgb(0, 192, 0);
            btnRefresh.FillColor2 = Color.FromArgb(255, 192, 192);
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F);
            btnRefresh.Location = new Point(267, 213);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RectColor = Color.Lime;
            btnRefresh.Size = new Size(104, 42);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.TipsColor = Color.LightGreen;
            btnRefresh.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearch
            // 
            txtSearch.FillColor = Color.MintCream;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Icon = Properties.Resources.search;
            txtSearch.Location = new Point(25, 124);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Lime;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(342, 55);
            txtSearch.TabIndex = 1;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "Search Song";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(1281, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 39);
            btnClose.TabIndex = 13;
            btnClose.TabStop = false;
            btnClose.Text = null;
            btnClose.Click += btnClose_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Font = new Font("Microsoft Sans Serif", 12F);
            btnMinimize.Image = (Image)resources.GetObject("btnMinimize.Image");
            btnMinimize.Location = new Point(1226, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(34, 39);
            btnMinimize.TabIndex = 14;
            btnMinimize.TabStop = false;
            btnMinimize.Text = null;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 49, 49);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1337, 71);
            panel1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 13);
            label3.Name = "label3";
            label3.Size = new Size(143, 38);
            label3.TabIndex = 13;
            label3.Text = "SongHUB";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 82, 82);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(cmbType);
            panel2.Controls.Add(txtTitle);
            panel2.Controls.Add(txtSinger);
            panel2.Controls.Add(txtLyrics);
            panel2.Location = new Point(388, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(949, 816);
            panel2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 0;
            label1.Text = "Add Song";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 213);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 13;
            label2.Text = "All Song";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddSong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 49, 49);
            ClientSize = new Size(1337, 882);
            Controls.Add(label2);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dgvSongList);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddSong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSongList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIRichTextBox txtLyrics;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UITextBox txtSinger;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UIDataGridView dgvSongList;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIButton btnRefresh;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIImageButton btnClose;
        private Sunny.UI.UIImageButton btnMinimize;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}
