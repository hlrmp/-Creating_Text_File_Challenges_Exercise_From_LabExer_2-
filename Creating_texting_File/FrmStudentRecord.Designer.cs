namespace Creating_texting_File
{
    partial class FrmStudentRecord
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
            this.btnrecords = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.lv1 = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnrecords
            // 
            this.btnrecords.BackColor = System.Drawing.Color.Gray;
            this.btnrecords.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnrecords.FlatAppearance.BorderSize = 3;
            this.btnrecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnrecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnrecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecords.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecords.ForeColor = System.Drawing.Color.White;
            this.btnrecords.Location = new System.Drawing.Point(521, 71);
            this.btnrecords.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnrecords.Name = "btnrecords";
            this.btnrecords.Size = new System.Drawing.Size(182, 41);
            this.btnrecords.TabIndex = 23;
            this.btnrecords.Text = "Register";
            this.btnrecords.UseVisualStyleBackColor = false;
            this.btnrecords.Click += new System.EventHandler(this.btnrecords_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Gray;
            this.btnUpload.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnUpload.FlatAppearance.BorderSize = 3;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(521, 242);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(182, 41);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.Color.Gray;
            this.btnfind.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnfind.FlatAppearance.BorderSize = 3;
            this.btnfind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnfind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnfind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfind.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.ForeColor = System.Drawing.Color.White;
            this.btnfind.Location = new System.Drawing.Point(521, 151);
            this.btnfind.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(182, 41);
            this.btnfind.TabIndex = 25;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // lv1
            // 
            this.lv1.HideSelection = false;
            this.lv1.Location = new System.Drawing.Point(36, 36);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(454, 379);
            this.lv1.TabIndex = 26;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.List;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(732, 441);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnrecords);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmStudentRecord";
            this.Text = "FrmStudentRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrecords;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}