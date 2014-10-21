﻿namespace UniversityApp.UI
{
    partial class EnrollmentUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enrollDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.regiNoComboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student RegNo";
            // 
            // enrollButton
            // 
            this.enrollButton.Location = new System.Drawing.Point(364, 161);
            this.enrollButton.Name = "enrollButton";
            this.enrollButton.Size = new System.Drawing.Size(75, 23);
            this.enrollButton.TabIndex = 9;
            this.enrollButton.Text = "Enroll";
            this.enrollButton.UseVisualStyleBackColor = true;
            this.enrollButton.Click += new System.EventHandler(this.enrollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course Name";
            // 
            // enrollDateTimePicker
            // 
            this.enrollDateTimePicker.Location = new System.Drawing.Point(234, 118);
            this.enrollDateTimePicker.Name = "enrollDateTimePicker";
            this.enrollDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.enrollDateTimePicker.TabIndex = 13;
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(223, 25);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(211, 21);
            this.nameComboBox.TabIndex = 14;
            // 
            // regiNoComboBox
            // 
            this.regiNoComboBox.FormattingEnabled = true;
            this.regiNoComboBox.Location = new System.Drawing.Point(223, 75);
            this.regiNoComboBox.Name = "regiNoComboBox";
            this.regiNoComboBox.Size = new System.Drawing.Size(211, 21);
            this.regiNoComboBox.TabIndex = 15;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(45, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 177);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RegiNo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            // 
            // EnrollmentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 392);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.regiNoComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.enrollDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enrollButton);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentUI";
            this.Text = "EnrollmentUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enrollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker enrollDateTimePicker;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox regiNoComboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}