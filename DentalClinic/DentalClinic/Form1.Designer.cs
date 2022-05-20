namespace DentalClinic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.PatientsList = new System.Windows.Forms.Button();
            this.IDs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 543);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(308, 513);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(84, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(308, 542);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(84, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(308, 571);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(84, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // PatientsList
            // 
            this.PatientsList.Location = new System.Drawing.Point(308, 600);
            this.PatientsList.Name = "PatientsList";
            this.PatientsList.Size = new System.Drawing.Size(84, 23);
            this.PatientsList.TabIndex = 4;
            this.PatientsList.Text = "Patients List";
            this.PatientsList.UseVisualStyleBackColor = true;
            this.PatientsList.Click += new System.EventHandler(this.PatientsList_Click);
            // 
            // IDs
            // 
            this.IDs.Location = new System.Drawing.Point(308, 629);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(84, 23);
            this.IDs.TabIndex = 5;
            this.IDs.Text = "IDs";
            this.IDs.UseVisualStyleBackColor = true;
            this.IDs.Click += new System.EventHandler(this.IDs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Financial info.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(695, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IDs);
            this.Controls.Add(this.PatientsList);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Daidamony Dental Center";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button PatientsList;
        private System.Windows.Forms.Button IDs;
        private System.Windows.Forms.Button button1;
    }
}