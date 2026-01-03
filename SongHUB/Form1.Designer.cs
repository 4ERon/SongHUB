namespace SongHUB
{
    partial class Form1
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
            uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            SuspendLayout();
            // 
            // uiRichTextBox1
            // 
            uiRichTextBox1.FillColor = Color.White;
            uiRichTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiRichTextBox1.Location = new Point(412, 209);
            uiRichTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiRichTextBox1.MinimumSize = new Size(1, 1);
            uiRichTextBox1.Name = "uiRichTextBox1";
            uiRichTextBox1.Padding = new Padding(2);
            uiRichTextBox1.ShowText = false;
            uiRichTextBox1.Size = new Size(873, 513);
            uiRichTextBox1.TabIndex = 0;
            uiRichTextBox1.TagString = "";
            uiRichTextBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox1.Location = new Point(49, 72);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.Radius = 10;
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(342, 55);
            uiTextBox1.TabIndex = 2;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "Title";
            // 
            // uiTextBox2
            // 
            uiTextBox2.Font = new Font("Microsoft Sans Serif", 12F);
            uiTextBox2.Location = new Point(412, 72);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Padding = new Padding(5);
            uiTextBox2.Radius = 10;
            uiTextBox2.ShowText = false;
            uiTextBox2.Size = new Size(305, 55);
            uiTextBox2.TabIndex = 3;
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox2.Watermark = "Singer";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton1.Location = new Point(1135, 743);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(150, 51);
            uiButton1.TabIndex = 4;
            uiButton1.Text = "Add";
            uiButton1.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.FromArgb(255, 128, 128);
            uiButton2.FillColor2 = Color.FromArgb(255, 192, 192);
            uiButton2.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton2.Location = new Point(950, 743);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(150, 51);
            uiButton2.TabIndex = 5;
            uiButton2.Text = "Delete";
            uiButton2.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("Microsoft Sans Serif", 12F);
            uiButton3.Location = new Point(49, 819);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(150, 51);
            uiButton3.TabIndex = 7;
            uiButton3.Text = "Save";
            uiButton3.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiPanel1
            // 
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(49, 209);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(342, 585);
            uiPanel1.TabIndex = 8;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("Microsoft Sans Serif", 12F);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.Items.AddRange(new object[] { "Fast", "Slow" });
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(1060, 145);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(225, 44);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 9;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 882);
            Controls.Add(uiComboBox1);
            Controls.Add(uiPanel1);
            Controls.Add(uiButton3);
            Controls.Add(uiButton1);
            Controls.Add(uiButton2);
            Controls.Add(uiTextBox2);
            Controls.Add(uiTextBox1);
            Controls.Add(uiRichTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIComboBox uiComboBox1;
    }
}
