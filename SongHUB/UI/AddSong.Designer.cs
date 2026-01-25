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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSong));
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
            ((System.ComponentModel.ISupportInitialize)dgvSongList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            SuspendLayout();
            // 
            // txtLyrics
            // 
            txtLyrics.FillColor = Color.LightGray;
            txtLyrics.Font = new Font("Microsoft Sans Serif", 12F);
            txtLyrics.Location = new Point(411, 200);
            txtLyrics.Margin = new Padding(4, 5, 4, 5);
            txtLyrics.MinimumSize = new Size(1, 1);
            txtLyrics.Name = "txtLyrics";
            txtLyrics.Padding = new Padding(2);
            txtLyrics.RectColor = Color.Lime;
            txtLyrics.ShowText = false;
            txtLyrics.Size = new Size(894, 575);
            txtLyrics.TabIndex = 0;
            txtLyrics.TagString = "";
            txtLyrics.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.FillColor = Color.MintCream;
            txtTitle.Font = new Font("Microsoft Sans Serif", 12F);
            txtTitle.Location = new Point(411, 124);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.Radius = 10;
            txtTitle.RectColor = Color.Lime;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(342, 55);
            txtTitle.TabIndex = 2;
            txtTitle.TextAlignment = ContentAlignment.MiddleLeft;
            txtTitle.Watermark = "Title";
            // 
            // txtSinger
            // 
            txtSinger.FillColor = Color.MintCream;
            txtSinger.Font = new Font("Microsoft Sans Serif", 12F);
            txtSinger.Location = new Point(776, 124);
            txtSinger.Margin = new Padding(4, 5, 4, 5);
            txtSinger.MinimumSize = new Size(1, 16);
            txtSinger.Name = "txtSinger";
            txtSinger.Padding = new Padding(5);
            txtSinger.Radius = 10;
            txtSinger.RectColor = Color.Lime;
            txtSinger.ShowText = false;
            txtSinger.Size = new Size(305, 55);
            txtSinger.TabIndex = 3;
            txtSinger.TextAlignment = ContentAlignment.MiddleLeft;
            txtSinger.Watermark = "Singer";
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.FromArgb(255, 128, 128);
            btnDelete.FillColor2 = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(949, 796);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = Color.Lime;
            btnDelete.Size = new Size(150, 51);
            btnDelete.TabIndex = 5;
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
            cmbType.Location = new Point(1098, 124);
            cmbType.Margin = new Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(0, 0, 30, 2);
            cmbType.RectColor = Color.Lime;
            cmbType.Size = new Size(207, 55);
            cmbType.SymbolSize = 24;
            cmbType.TabIndex = 9;
            cmbType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbType.Watermark = "Type";
            // 
            // dgvSongList
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            dgvSongList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSongList.BackgroundColor = Color.LightGray;
            dgvSongList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSongList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSongList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvSongList.DefaultCellStyle = dataGridViewCellStyle8;
            dgvSongList.EnableHeadersVisualStyles = false;
            dgvSongList.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongList.GridColor = Color.FromArgb(0, 192, 0);
            dgvSongList.Location = new Point(44, 200);
            dgvSongList.Name = "dgvSongList";
            dgvSongList.ReadOnly = true;
            dgvSongList.RectColor = Color.Lime;
            dgvSongList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvSongList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvSongList.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongList.RowsDefaultCellStyle = dataGridViewCellStyle10;
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
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(1134, 796);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.RectColor = Color.Lime;
            btnSave.Size = new Size(150, 51);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FillColor = Color.FromArgb(0, 192, 0);
            btnRefresh.FillColor2 = Color.FromArgb(255, 192, 192);
            btnRefresh.Font = new Font("Microsoft Sans Serif", 12F);
            btnRefresh.Location = new Point(44, 124);
            btnRefresh.MinimumSize = new Size(1, 1);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.RectColor = Color.Lime;
            btnRefresh.Size = new Size(123, 51);
            btnRefresh.TabIndex = 12;
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
            txtSearch.Location = new Point(44, 38);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.Radius = 10;
            txtSearch.RectColor = Color.Lime;
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(342, 55);
            txtSearch.TabIndex = 3;
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
            // AddSong
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 74, 74);
            ClientSize = new Size(1337, 882);
            Controls.Add(btnMinimize);
            Controls.Add(btnClose);
            Controls.Add(txtSearch);
            Controls.Add(btnRefresh);
            Controls.Add(btnSave);
            Controls.Add(dgvSongList);
            Controls.Add(cmbType);
            Controls.Add(btnDelete);
            Controls.Add(txtSinger);
            Controls.Add(txtTitle);
            Controls.Add(txtLyrics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddSong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSongList).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ResumeLayout(false);
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
    }
}
