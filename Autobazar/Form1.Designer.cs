namespace Autobazar
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
            comboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            text4 = new TextBox();
            text3 = new TextBox();
            text2 = new TextBox();
            text1 = new TextBox();
            add = new Button();
            exit = new Button();
            delete = new Button();
            listBox1 = new ListBox();
            edit = new Button();
            save = new Button();
            labelError = new Label();
            discard = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 3;
            label1.Text = "Výrobce";
            label1.Click += label1_Click;
            // 
            // comboBox
            // 
            comboBox.Font = new Font("Segoe UI", 12F);
            comboBox.ImeMode = ImeMode.Off;
            comboBox.Items.AddRange(new object[] { "Nové", "Servis", "Opravené", "Vydané" });
            comboBox.Location = new Point(181, 185);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 29);
            comboBox.TabIndex = 5;
            comboBox.Tag = "combobox";
            comboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 10;
            label2.Text = "Typ auta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 11;
            label3.Text = "Rok výroby";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 12;
            label4.Text = "Najeté kilometry";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(12, 182);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 13;
            label5.Text = "Stav";
            // 
            // text4
            // 
            text4.Font = new Font("Segoe UI", 14F);
            text4.Location = new Point(181, 140);
            text4.Name = "text4";
            text4.Size = new Size(101, 32);
            text4.TabIndex = 4;
            text4.Tag = "txt4";
            // 
            // text3
            // 
            text3.Font = new Font("Segoe UI", 14F);
            text3.Location = new Point(181, 98);
            text3.Name = "text3";
            text3.Size = new Size(66, 32);
            text3.TabIndex = 3;
            text3.Tag = "txt3";
            // 
            // text2
            // 
            text2.Font = new Font("Segoe UI", 14F);
            text2.Location = new Point(181, 54);
            text2.Name = "text2";
            text2.Size = new Size(167, 32);
            text2.TabIndex = 2;
            text2.Tag = "txt2";
            // 
            // text1
            // 
            text1.Font = new Font("Segoe UI", 14F);
            text1.Location = new Point(181, 12);
            text1.Name = "text1";
            text1.Size = new Size(167, 32);
            text1.TabIndex = 1;
            text1.Tag = "txt1";
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 12F);
            add.Location = new Point(12, 233);
            add.Name = "add";
            add.Size = new Size(84, 31);
            add.TabIndex = 18;
            add.TabStop = false;
            add.Tag = "add";
            add.Text = "Přidat";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // exit
            // 
            exit.Font = new Font("Segoe UI", 12F);
            exit.Location = new Point(704, 407);
            exit.Name = "exit";
            exit.Size = new Size(84, 31);
            exit.TabIndex = 20;
            exit.TabStop = false;
            exit.Tag = "exit";
            exit.Text = "Odejít";
            exit.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            delete.Enabled = false;
            delete.Font = new Font("Segoe UI", 12F);
            delete.Location = new Point(496, 407);
            delete.Name = "delete";
            delete.Size = new Size(109, 31);
            delete.TabIndex = 21;
            delete.TabStop = false;
            delete.Tag = "delete";
            delete.Text = "Odstranit";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 13F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(396, 12);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(392, 372);
            listBox1.TabIndex = 22;
            listBox1.TabStop = false;
            listBox1.UseTabStops = false;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // edit
            // 
            edit.Enabled = false;
            edit.Font = new Font("Segoe UI", 12F);
            edit.Location = new Point(396, 407);
            edit.Name = "edit";
            edit.Size = new Size(94, 31);
            edit.TabIndex = 23;
            edit.TabStop = false;
            edit.Tag = "edit";
            edit.Text = "Upravit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // save
            // 
            save.Enabled = false;
            save.Font = new Font("Segoe UI", 12F);
            save.Location = new Point(102, 233);
            save.Name = "save";
            save.Size = new Size(123, 31);
            save.TabIndex = 24;
            save.TabStop = false;
            save.Tag = "save";
            save.Text = "Uložit změny";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 15F);
            labelError.Location = new Point(12, 285);
            labelError.MaximumSize = new Size(354, 120);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 28);
            labelError.TabIndex = 25;
            // 
            // discard
            // 
            discard.Enabled = false;
            discard.Font = new Font("Segoe UI", 12F);
            discard.Location = new Point(231, 233);
            discard.Name = "discard";
            discard.Size = new Size(133, 31);
            discard.TabIndex = 26;
            discard.Text = "Zahodit změny";
            discard.UseVisualStyleBackColor = true;
            discard.Click += discard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(discard);
            Controls.Add(labelError);
            Controls.Add(save);
            Controls.Add(edit);
            Controls.Add(listBox1);
            Controls.Add(delete);
            Controls.Add(exit);
            Controls.Add(add);
            Controls.Add(text1);
            Controls.Add(text2);
            Controls.Add(text3);
            Controls.Add(text4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Autoservis";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox comboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox text4;
        private TextBox text3;
        private TextBox text2;
        private TextBox text1;
        private Button add;
        private Button exit;
        private Button delete;
        private ListBox listBox1;
        private Button edit;
        private Button save;
        private Label labelError;
        private Button discard;
    }
}
