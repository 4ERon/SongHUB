namespace SongHUB
{
    partial class Song
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
            editSong = new Sunny.UI.UIRichTextBox();
            txtTitle = new Sunny.UI.UITextBox();
            txtSinger = new Sunny.UI.UITextBox();
            btnAdd = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            cmbType = new Sunny.UI.UIComboBox();
            dgvSongs = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
            SuspendLayout();
            // 
            // editSong
            // 
            editSong.FillColor = Color.White;
            editSong.Font = new Font("Microsoft Sans Serif", 12F);
            editSong.Location = new Point(412, 209);
            editSong.Margin = new Padding(4, 5, 4, 5);
            editSong.MinimumSize = new Size(1, 1);
            editSong.Name = "editSong";
            editSong.Padding = new Padding(2);
            editSong.ShowText = false;
            editSong.Size = new Size(873, 513);
            editSong.TabIndex = 0;
            editSong.TagString = "";
            editSong.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Microsoft Sans Serif", 12F);
            txtTitle.Location = new Point(411, 49);
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
            txtSinger.Location = new Point(774, 49);
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
            btnSave.Location = new Point(49, 743);
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
            // dgvSongs
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSongs.BackgroundColor = Color.White;
            dgvSongs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSongs.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSongs.EnableHeadersVisualStyles = false;
            dgvSongs.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongs.GridColor = Color.FromArgb(80, 160, 255);
            dgvSongs.Location = new Point(49, 209);
            dgvSongs.Name = "dgvSongs";
            dgvSongs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSongs.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvSongs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSongs.SelectedIndex = -1;
            dgvSongs.Size = new Size(342, 513);
            dgvSongs.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvSongs.TabIndex = 10;
            // 
            // Song
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 882);
            Controls.Add(dgvSongs);
            Controls.Add(cmbType);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtSinger);
            Controls.Add(txtTitle);
            Controls.Add(editSong);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Song";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIRichTextBox editSong;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UITextBox txtSinger;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UIDataGridView dgvSongs;
    }
}
