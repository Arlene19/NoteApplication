namespace NoteApplication.Forms
{
    partial class AddTaskForm
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
            txtTaskName = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            btnSaveTask = new Button();
            label3 = new Label();
            rtxtDescription = new RichTextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(32, 129);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(354, 27);
            txtTaskName.TabIndex = 1;
            txtTaskName.TextChanged += txtTaskName_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSaveTask);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rtxtDescription);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTaskName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 627);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 9);
            label2.Name = "label2";
            label2.Size = new Size(137, 41);
            label2.TabIndex = 8;
            label2.Text = "Add Task";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(292, 352);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(94, 29);
            btnSaveTask.TabIndex = 7;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 171);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(32, 205);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(354, 120);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            rtxtDescription.TextChanged += rtxtDescription_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 94);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Task Name";
            label1.Click += label1_Click;
            // 
            // AddTaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 627);
            Controls.Add(panel1);
            Name = "AddTaskForm";
            Text = "AddTaskForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtTaskName;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private RichTextBox rtxtDescription;
        private Button btnSaveTask;
        private Label label2;
    }
}