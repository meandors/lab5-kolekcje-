namespace Lab5
{
    partial class Form1
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
            this.lbColection = new System.Windows.Forms.ListBox();
            this.lbZbiory = new System.Windows.Forms.ListBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bIsBelongs = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.bSuma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbColection
            // 
            this.lbColection.FormattingEnabled = true;
            this.lbColection.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.lbColection.Location = new System.Drawing.Point(34, 37);
            this.lbColection.Name = "lbColection";
            this.lbColection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbColection.Size = new System.Drawing.Size(83, 121);
            this.lbColection.TabIndex = 0;
            // 
            // lbZbiory
            // 
            this.lbZbiory.FormattingEnabled = true;
            this.lbZbiory.Items.AddRange(new object[] {
            ""});
            this.lbZbiory.Location = new System.Drawing.Point(394, 37);
            this.lbZbiory.Name = "lbZbiory";
            this.lbZbiory.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbZbiory.Size = new System.Drawing.Size(83, 121);
            this.lbZbiory.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(231, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(231, 64);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 3;
            this.bCreate.Text = "Utwórz zbiór";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa zbioru";
            // 
            // bIsBelongs
            // 
            this.bIsBelongs.Location = new System.Drawing.Point(231, 93);
            this.bIsBelongs.Name = "bIsBelongs";
            this.bIsBelongs.Size = new System.Drawing.Size(75, 23);
            this.bIsBelongs.TabIndex = 5;
            this.bIsBelongs.Text = "Czy należy?";
            this.bIsBelongs.UseVisualStyleBackColor = true;
            this.bIsBelongs.Click += new System.EventHandler(this.bIsBelongs_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(231, 134);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(75, 23);
            this.bShow.TabIndex = 6;
            this.bShow.Text = "Wyświetl";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zbiory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kolekcja";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(119, 163);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(273, 50);
            this.tbResult.TabIndex = 9;
            // 
            // bSuma
            // 
            this.bSuma.Location = new System.Drawing.Point(483, 62);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(25, 25);
            this.bSuma.TabIndex = 10;
            this.bSuma.Text = "+";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(483, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bShow);
            this.Controls.Add(this.bIsBelongs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbZbiory);
            this.Controls.Add(this.lbColection);
            this.Name = "Form1";
            this.Text = "Kolekcje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbColection;
        private System.Windows.Forms.ListBox lbZbiory;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bIsBelongs;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Button bSuma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

