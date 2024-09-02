namespace Example
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
            panel1 = new Panel();
            label1 = new Label();
            btnSer = new Button();
            btnBish = new Button();
            btnDuz = new Button();
            btnTk = new Button();
            btnYag = new Button();
            btnQiz = new Button();
            btnYan = new Button();
            btnQar = new Button();
            btnQir = new Button();
            listBox1 = new ListBox();
            BtnSync = new Button();
            BtnAsync = new Button();
            BtnReset = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSer);
            panel1.Controls.Add(btnBish);
            panel1.Controls.Add(btnDuz);
            panel1.Controls.Add(btnTk);
            panel1.Controls.Add(btnYag);
            panel1.Controls.Add(btnQiz);
            panel1.Controls.Add(btnYan);
            panel1.Controls.Add(btnQar);
            panel1.Controls.Add(btnQir);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1057, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 750);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 614);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // btnSer
            // 
            btnSer.AutoSize = true;
            btnSer.Dock = DockStyle.Top;
            btnSer.Location = new Point(0, 280);
            btnSer.Name = "btnSer";
            btnSer.Size = new Size(200, 35);
            btnSer.TabIndex = 8;
            btnSer.Text = "Servis et";
            btnSer.UseVisualStyleBackColor = true;
            // 
            // btnBish
            // 
            btnBish.AutoSize = true;
            btnBish.Dock = DockStyle.Top;
            btnBish.Location = new Point(0, 245);
            btnBish.Name = "btnBish";
            btnBish.Size = new Size(200, 35);
            btnBish.TabIndex = 7;
            btnBish.Text = "Bishir";
            btnBish.UseVisualStyleBackColor = true;
            // 
            // btnDuz
            // 
            btnDuz.AutoSize = true;
            btnDuz.Dock = DockStyle.Top;
            btnDuz.Location = new Point(0, 210);
            btnDuz.Name = "btnDuz";
            btnDuz.Size = new Size(200, 35);
            btnDuz.TabIndex = 6;
            btnDuz.Text = "Duz Tok";
            btnDuz.UseVisualStyleBackColor = true;
            // 
            // btnTk
            // 
            btnTk.AutoSize = true;
            btnTk.Dock = DockStyle.Top;
            btnTk.Location = new Point(0, 175);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(200, 35);
            btnTk.TabIndex = 5;
            btnTk.Text = "Yumurtani Tk";
            btnTk.UseVisualStyleBackColor = true;
            // 
            // btnYag
            // 
            btnYag.AutoSize = true;
            btnYag.Dock = DockStyle.Top;
            btnYag.Location = new Point(0, 140);
            btnYag.Name = "btnYag";
            btnYag.Size = new Size(200, 35);
            btnYag.TabIndex = 4;
            btnYag.Text = "Yag Tok\r\n";
            btnYag.UseVisualStyleBackColor = true;
            // 
            // btnQiz
            // 
            btnQiz.AutoSize = true;
            btnQiz.Dock = DockStyle.Top;
            btnQiz.Location = new Point(0, 105);
            btnQiz.Name = "btnQiz";
            btnQiz.Size = new Size(200, 35);
            btnQiz.TabIndex = 3;
            btnQiz.Text = "Tavani Qizdir";
            btnQiz.UseVisualStyleBackColor = true;
            // 
            // btnYan
            // 
            btnYan.AutoSize = true;
            btnYan.Dock = DockStyle.Top;
            btnYan.Location = new Point(0, 70);
            btnYan.Name = "btnYan";
            btnYan.Size = new Size(200, 35);
            btnYan.TabIndex = 2;
            btnYan.Text = "Qazi Yandir";
            btnYan.UseVisualStyleBackColor = true;
            // 
            // btnQar
            // 
            btnQar.AutoSize = true;
            btnQar.Dock = DockStyle.Top;
            btnQar.Location = new Point(0, 35);
            btnQar.Name = "btnQar";
            btnQar.Size = new Size(200, 35);
            btnQar.TabIndex = 1;
            btnQar.Text = "Yumurtani Qarishdir";
            btnQar.UseVisualStyleBackColor = true;
            // 
            // btnQir
            // 
            btnQir.AutoSize = true;
            btnQir.Dock = DockStyle.Top;
            btnQir.Location = new Point(0, 0);
            btnQir.Name = "btnQir";
            btnQir.Size = new Size(200, 35);
            btnQir.TabIndex = 0;
            btnQir.Text = "Yumurtani qir";
            btnQir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(0, 446);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1057, 304);
            listBox1.TabIndex = 1;
            // 
            // BtnSync
            // 
            BtnSync.Location = new Point(264, 55);
            BtnSync.Name = "BtnSync";
            BtnSync.Size = new Size(542, 105);
            BtnSync.TabIndex = 2;
            BtnSync.Text = "Start Cooking Sync";
            BtnSync.UseVisualStyleBackColor = true;
            BtnSync.Click += BtnSync_Click;
            // 
            // BtnAsync
            // 
            BtnAsync.Location = new Point(264, 188);
            BtnAsync.Name = "BtnAsync";
            BtnAsync.Size = new Size(542, 105);
            BtnAsync.TabIndex = 2;
            BtnAsync.Text = "Start Cooking Async";
            BtnAsync.UseVisualStyleBackColor = true;
            BtnAsync.Click += BtnAsync_Click;
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(264, 314);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(542, 105);
            BtnReset.TabIndex = 2;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(BtnReset);
            Controls.Add(BtnAsync);
            Controls.Add(BtnSync);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSer;
        private Button btnBish;
        private Button btnDuz;
        private Button btnTk;
        private Button btnYag;
        private Button btnQiz;
        private Button btnYan;
        private Button btnQar;
        private Button btnQir;
        private ListBox listBox1;
        private Button BtnSync;
        private Button BtnAsync;
        private Label label1;
        private Button BtnReset;
    }
}
