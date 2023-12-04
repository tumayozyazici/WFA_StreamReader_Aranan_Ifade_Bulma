namespace WFA_StreamReader_Aranan_Ifade_Bulma
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
            label1 = new Label();
            txt_search = new TextBox();
            btn_search = new Button();
            label2 = new Label();
            rtxt_find = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 28);
            label1.TabIndex = 0;
            label1.Text = "Aradığınız Kelimeyi Girin:";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(324, 58);
            txt_search.Margin = new Padding(4, 4, 4, 4);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(622, 34);
            txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(969, 53);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(134, 44);
            btn_search.TabIndex = 2;
            btn_search.Text = "ARA";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(364, 28);
            label2.TabIndex = 0;
            label2.Text = "Aradığınız Kelimenin Geçtiği Satırlar:";
            // 
            // rtxt_find
            // 
            rtxt_find.Dock = DockStyle.Bottom;
            rtxt_find.Location = new Point(0, 225);
            rtxt_find.Name = "rtxt_find";
            rtxt_find.Size = new Size(1200, 405);
            rtxt_find.TabIndex = 3;
            rtxt_find.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 630);
            Controls.Add(rtxt_find);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Kelime Arama";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_search;
        private Button btn_search;
        private Label label2;
        private RichTextBox rtxt_find;
    }
}
