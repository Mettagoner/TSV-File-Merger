namespace TsvMerger
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
            this.file_list = new System.Windows.Forms.ListBox();
            this.select_files = new System.Windows.Forms.Button();
            this.merge_files = new System.Windows.Forms.Button();
            this.save_to_location = new System.Windows.Forms.Button();
            this.progress_bar = new System.Windows.Forms.ProgressBar();
            this.instructions_textbox = new System.Windows.Forms.TextBox();
            this.progress_bar_label = new System.Windows.Forms.Label();
            this.ownership_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file_list
            // 
            this.file_list.FormattingEnabled = true;
            this.file_list.Location = new System.Drawing.Point(99, 214);
            this.file_list.Name = "file_list";
            this.file_list.Size = new System.Drawing.Size(400, 173);
            this.file_list.TabIndex = 0;
            // 
            // select_files
            // 
            this.select_files.Location = new System.Drawing.Point(99, 144);
            this.select_files.Name = "select_files";
            this.select_files.Size = new System.Drawing.Size(172, 50);
            this.select_files.TabIndex = 1;
            this.select_files.Text = "Select Files";
            this.select_files.UseVisualStyleBackColor = true;
            this.select_files.Click += new System.EventHandler(this.select_files_Click);
            // 
            // merge_files
            // 
            this.merge_files.Location = new System.Drawing.Point(573, 226);
            this.merge_files.Name = "merge_files";
            this.merge_files.Size = new System.Drawing.Size(172, 50);
            this.merge_files.TabIndex = 2;
            this.merge_files.Text = "Merge Files";
            this.merge_files.UseVisualStyleBackColor = true;
            this.merge_files.Click += new System.EventHandler(this.merge_files_Click);
            // 
            // save_to_location
            // 
            this.save_to_location.Location = new System.Drawing.Point(573, 135);
            this.save_to_location.Name = "save_to_location";
            this.save_to_location.Size = new System.Drawing.Size(172, 50);
            this.save_to_location.TabIndex = 3;
            this.save_to_location.Text = "Save As";
            this.save_to_location.UseVisualStyleBackColor = true;
            this.save_to_location.Click += new System.EventHandler(this.save_to_location_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(573, 348);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(172, 39);
            this.progress_bar.Step = 1;
            this.progress_bar.TabIndex = 5;
            // 
            // instructions_textbox
            // 
            this.instructions_textbox.Location = new System.Drawing.Point(99, 12);
            this.instructions_textbox.Multiline = true;
            this.instructions_textbox.Name = "instructions_textbox";
            this.instructions_textbox.ReadOnly = true;
            this.instructions_textbox.Size = new System.Drawing.Size(646, 102);
            this.instructions_textbox.TabIndex = 6;
            // 
            // progress_bar_label
            // 
            this.progress_bar_label.AutoSize = true;
            this.progress_bar_label.Location = new System.Drawing.Point(573, 329);
            this.progress_bar_label.Name = "progress_bar_label";
            this.progress_bar_label.Size = new System.Drawing.Size(70, 13);
            this.progress_bar_label.TabIndex = 7;
            this.progress_bar_label.Text = "Progress Bar:";
            // 
            // ownership_label
            // 
            this.ownership_label.AutoSize = true;
            this.ownership_label.Location = new System.Drawing.Point(99, 425);
            this.ownership_label.Name = "ownership_label";
            this.ownership_label.Size = new System.Drawing.Size(35, 13);
            this.ownership_label.TabIndex = 8;
            this.ownership_label.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ownership_label);
            this.Controls.Add(this.progress_bar_label);
            this.Controls.Add(this.instructions_textbox);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.save_to_location);
            this.Controls.Add(this.merge_files);
            this.Controls.Add(this.select_files);
            this.Controls.Add(this.file_list);
            this.Name = "Form1";
            this.Text = "TSV File Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox file_list;
        private System.Windows.Forms.Button select_files;
        private System.Windows.Forms.Button merge_files;
        private System.Windows.Forms.Button save_to_location;
        private System.Windows.Forms.ProgressBar progress_bar;
        private System.Windows.Forms.TextBox instructions_textbox;
        private System.Windows.Forms.Label progress_bar_label;
        private System.Windows.Forms.Label ownership_label;
    }
}

