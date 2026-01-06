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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            txtLyrics = new Sunny.UI.UIRichTextBox();
            txtTitle = new Sunny.UI.UITextBox();
            txtSinger = new Sunny.UI.UITextBox();
            btnAdd = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            cmbType = new Sunny.UI.UIComboBox();
            dgvSongList = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSongList).BeginInit();
            SuspendLayout();
            // 
            // txtLyrics
            // 
            txtLyrics.FillColor = Color.White;
            txtLyrics.Font = new Font("Microsoft Sans Serif", 12F);
            txtLyrics.Location = new Point(412, 209);
            txtLyrics.Margin = new Padding(4, 5, 4, 5);
            txtLyrics.MinimumSize = new Size(1, 1);
            txtLyrics.Name = "txtLyrics";
            txtLyrics.Padding = new Padding(2);
            txtLyrics.ShowText = false;
            txtLyrics.Size = new Size(873, 513);
            txtLyrics.TabIndex = 0;
            txtLyrics.TagString = "";
            txtLyrics.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Sans Serif", 12F);
            txtTitle.Location = new Point(49, 72);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.Radius = 10;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(342, 55);
            txtTitle.TabIndex = 2;
            txtTitle.TextAlignment = ContentAlignment.MiddleLeft;
            txtTitle.Watermark = "Title";
            // 
            // txtSinger
            // 
            txtSinger.Font = new Font("Microsoft Sans Serif", 12F);
            txtSinger.Location = new Point(412, 72);
            txtSinger.Margin = new Padding(4, 5, 4, 5);
            txtSinger.MinimumSize = new Size(1, 16);
            txtSinger.Name = "txtSinger";
            txtSinger.Padding = new Padding(5);
            txtSinger.Radius = 10;
            txtSinger.ShowText = false;
            txtSinger.Size = new Size(305, 55);
            txtSinger.TabIndex = 3;
            txtSinger.TextAlignment = ContentAlignment.MiddleLeft;
            txtSinger.Watermark = "Singer";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(1135, 743);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 51);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.FillColor = Color.FromArgb(255, 128, 128);
            btnDelete.FillColor2 = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(950, 743);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 51);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(45, 762);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 51);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // cmbType
            // 
            cmbType.DataSource = null;
            cmbType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cmbType.FillColor = Color.White;
            cmbType.Font = new Font("Microsoft Sans Serif", 12F);
            cmbType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbType.Items.AddRange(new object[] { "Fast", "Slow" });
            cmbType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbType.Location = new Point(1060, 145);
            cmbType.Margin = new Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(0, 0, 30, 2);
            cmbType.Size = new Size(225, 44);
            cmbType.SymbolSize = 24;
            cmbType.TabIndex = 9;
            cmbType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbType.Watermark = "Type";
            // 
            // dgvSongList
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvSongList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSongList.BackgroundColor = Color.White;
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
            dgvSongList.GridColor = Color.FromArgb(80, 160, 255);
            dgvSongList.Location = new Point(45, 209);
            dgvSongList.Name = "dgvSongList";
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
            dgvSongList.SelectedIndex = -1;
            dgvSongList.Size = new Size(346, 513);
            dgvSongList.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvSongList.TabIndex = 10;
            dgvSongList.CellClick += dgvSongList_CellClick;
            // 
            // Song
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 882);
            Controls.Add(dgvSongList);
            Controls.Add(cmbType);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtSinger);
            Controls.Add(txtTitle);
            Controls.Add(txtLyrics);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Song";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSongList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIRichTextBox txtLyrics;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UITextBox txtSinger;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UIDataGridView dgvSongList;
    }
}
