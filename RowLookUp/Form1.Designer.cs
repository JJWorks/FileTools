namespace RowLookUp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceLocationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SourceFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExecuteGOButton = new System.Windows.Forms.Button();
            this.RRSaveButton = new System.Windows.Forms.Button();
            this.RROpenFileButton = new System.Windows.Forms.Button();
            this.RRSaveTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RRSourceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RangeStartTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RangeEndTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 413);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SaveButton);
            this.tabPage1.Controls.Add(this.OpenButton);
            this.tabPage1.Controls.Add(this.SaveLocationTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SourceLocationTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Top 10 Rows";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SaveLocationTextBox
            // 
            this.SaveLocationTextBox.Location = new System.Drawing.Point(139, 108);
            this.SaveLocationTextBox.Name = "SaveLocationTextBox";
            this.SaveLocationTextBox.Size = new System.Drawing.Size(349, 20);
            this.SaveLocationTextBox.TabIndex = 3;
            this.SaveLocationTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save File Name";
            // 
            // SourceLocationTextBox
            // 
            this.SourceLocationTextBox.Location = new System.Drawing.Point(139, 51);
            this.SourceLocationTextBox.Name = "SourceLocationTextBox";
            this.SourceLocationTextBox.Size = new System.Drawing.Size(349, 20);
            this.SourceLocationTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source File";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.RangeEndTextBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.RangeStartTextBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.RRSaveButton);
            this.tabPage2.Controls.Add(this.RROpenFileButton);
            this.tabPage2.Controls.Add(this.RRSaveTextBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.RRSourceTextBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Row Range";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SourceFileDialog
            // 
            this.SourceFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SourceFileDialog_FileOk);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(512, 51);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(63, 23);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Browse...";
            this.OpenButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(512, 105);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Browse...";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.Filter = "Text File | *.txt|All Files|*.*";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // ExecuteGOButton
            // 
            this.ExecuteGOButton.Location = new System.Drawing.Point(648, 440);
            this.ExecuteGOButton.Name = "ExecuteGOButton";
            this.ExecuteGOButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteGOButton.TabIndex = 1;
            this.ExecuteGOButton.Text = "OK";
            this.ExecuteGOButton.UseVisualStyleBackColor = true;
            this.ExecuteGOButton.Click += new System.EventHandler(this.ExecuteGOButton_Click);
            // 
            // RRSaveButton
            // 
            this.RRSaveButton.Location = new System.Drawing.Point(512, 105);
            this.RRSaveButton.Name = "RRSaveButton";
            this.RRSaveButton.Size = new System.Drawing.Size(63, 23);
            this.RRSaveButton.TabIndex = 11;
            this.RRSaveButton.Text = "Browse...";
            this.RRSaveButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RRSaveButton.UseVisualStyleBackColor = true;
            this.RRSaveButton.Click += new System.EventHandler(this.RRSaveButton_Click);
            // 
            // RROpenFileButton
            // 
            this.RROpenFileButton.Location = new System.Drawing.Point(512, 51);
            this.RROpenFileButton.Name = "RROpenFileButton";
            this.RROpenFileButton.Size = new System.Drawing.Size(63, 23);
            this.RROpenFileButton.TabIndex = 10;
            this.RROpenFileButton.Text = "Browse...";
            this.RROpenFileButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RROpenFileButton.UseVisualStyleBackColor = true;
            this.RROpenFileButton.Click += new System.EventHandler(this.RROpenFileButton_Click);
            // 
            // RRSaveTextBox
            // 
            this.RRSaveTextBox.Location = new System.Drawing.Point(139, 108);
            this.RRSaveTextBox.Name = "RRSaveTextBox";
            this.RRSaveTextBox.Size = new System.Drawing.Size(349, 20);
            this.RRSaveTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Save File Name";
            // 
            // RRSourceTextBox
            // 
            this.RRSourceTextBox.Location = new System.Drawing.Point(139, 51);
            this.RRSourceTextBox.Name = "RRSourceTextBox";
            this.RRSourceTextBox.Size = new System.Drawing.Size(349, 20);
            this.RRSourceTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Source File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Row Range";
            // 
            // RangeStartTextBox
            // 
            this.RangeStartTextBox.Location = new System.Drawing.Point(139, 166);
            this.RangeStartTextBox.Name = "RangeStartTextBox";
            this.RangeStartTextBox.Size = new System.Drawing.Size(48, 20);
            this.RangeStartTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "~";
            // 
            // RangeEndTextBox
            // 
            this.RangeEndTextBox.Location = new System.Drawing.Point(213, 166);
            this.RangeEndTextBox.Name = "RangeEndTextBox";
            this.RangeEndTextBox.Size = new System.Drawing.Size(48, 20);
            this.RangeEndTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 475);
            this.Controls.Add(this.ExecuteGOButton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "File Look Up";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox SaveLocationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceLocationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog SourceFileDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button ExecuteGOButton;
        private System.Windows.Forms.Button RRSaveButton;
        private System.Windows.Forms.Button RROpenFileButton;
        private System.Windows.Forms.TextBox RRSaveTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RRSourceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RangeEndTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RangeStartTextBox;
        private System.Windows.Forms.Label label5;
    }
}

