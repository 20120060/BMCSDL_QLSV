namespace Home
{
    partial class Home
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
            this.PTable = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PMenu = new System.Windows.Forms.Panel();
            this.PImplement = new System.Windows.Forms.Panel();
            this.btnI_Student = new System.Windows.Forms.Button();
            this.btnI_class = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.PList = new System.Windows.Forms.Panel();
            this.btnL_student = new System.Windows.Forms.Button();
            this.btnL_class = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.PMenu.SuspendLayout();
            this.PImplement.SuspendLayout();
            this.PList.SuspendLayout();
            this.SuspendLayout();
            // 
            // PTable
            // 
            this.PTable.Location = new System.Drawing.Point(182, 81);
            this.PTable.Name = "PTable";
            this.PTable.Size = new System.Drawing.Size(754, 399);
            this.PTable.TabIndex = 0;
            this.PTable.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(516, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PMenu
            // 
            this.PMenu.AutoScroll = true;
            this.PMenu.Controls.Add(this.PImplement);
            this.PMenu.Controls.Add(this.btnI);
            this.PMenu.Controls.Add(this.PList);
            this.PMenu.Controls.Add(this.btnL);
            this.PMenu.Location = new System.Drawing.Point(12, 81);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(156, 351);
            this.PMenu.TabIndex = 2;
            // 
            // PImplement
            // 
            this.PImplement.Controls.Add(this.btnI_Student);
            this.PImplement.Controls.Add(this.btnI_class);
            this.PImplement.Dock = System.Windows.Forms.DockStyle.Top;
            this.PImplement.Location = new System.Drawing.Point(0, 230);
            this.PImplement.Name = "PImplement";
            this.PImplement.Size = new System.Drawing.Size(156, 114);
            this.PImplement.TabIndex = 6;
            // 
            // btnI_Student
            // 
            this.btnI_Student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnI_Student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnI_Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI_Student.Location = new System.Drawing.Point(0, 58);
            this.btnI_Student.Name = "btnI_Student";
            this.btnI_Student.Size = new System.Drawing.Size(156, 52);
            this.btnI_Student.TabIndex = 1;
            this.btnI_Student.Text = "Student";
            this.btnI_Student.UseVisualStyleBackColor = false;
            this.btnI_Student.Click += new System.EventHandler(this.btnI_Student_Click);
            // 
            // btnI_class
            // 
            this.btnI_class.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnI_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnI_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI_class.Location = new System.Drawing.Point(0, 0);
            this.btnI_class.Name = "btnI_class";
            this.btnI_class.Size = new System.Drawing.Size(156, 58);
            this.btnI_class.TabIndex = 0;
            this.btnI_class.Text = "Class";
            this.btnI_class.UseVisualStyleBackColor = false;
            this.btnI_class.Click += new System.EventHandler(this.btnI_class_Click);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(0, 166);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(156, 64);
            this.btnI.TabIndex = 5;
            this.btnI.Text = "Implement";
            this.btnI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.button4_Click);
            // 
            // PList
            // 
            this.PList.Controls.Add(this.btnL_student);
            this.PList.Controls.Add(this.btnL_class);
            this.PList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PList.Location = new System.Drawing.Point(0, 65);
            this.PList.Name = "PList";
            this.PList.Size = new System.Drawing.Size(156, 101);
            this.PList.TabIndex = 4;
            // 
            // btnL_student
            // 
            this.btnL_student.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnL_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnL_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL_student.Location = new System.Drawing.Point(0, 51);
            this.btnL_student.Name = "btnL_student";
            this.btnL_student.Size = new System.Drawing.Size(156, 51);
            this.btnL_student.TabIndex = 1;
            this.btnL_student.Text = "List Student";
            this.btnL_student.UseVisualStyleBackColor = false;
            this.btnL_student.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnL_class
            // 
            this.btnL_class.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnL_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnL_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL_class.Location = new System.Drawing.Point(0, 0);
            this.btnL_class.Name = "btnL_class";
            this.btnL_class.Size = new System.Drawing.Size(156, 51);
            this.btnL_class.TabIndex = 0;
            this.btnL_class.Text = "List Class";
            this.btnL_class.UseVisualStyleBackColor = false;
            this.btnL_class.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(0, 0);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(156, 65);
            this.btnL.TabIndex = 3;
            this.btnL.Text = "List";
            this.btnL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.button3_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 511);
            this.Controls.Add(this.PMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PTable);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.PMenu.ResumeLayout(false);
            this.PImplement.ResumeLayout(false);
            this.PList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button btnL_student;
        private System.Windows.Forms.Button btnL_class;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Panel PList;
        private System.Windows.Forms.Panel PImplement;
        private System.Windows.Forms.Button btnI_Student;
        private System.Windows.Forms.Button btnI_class;
    }
}

