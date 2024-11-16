namespace NoteApplication
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
            btnAddTask = new Button();
            tasksPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(tasksPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 627);
            panel1.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.AllowDrop = true;
            btnAddTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddTask.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddTask.BackColor = Color.White;
            btnAddTask.FlatStyle = FlatStyle.Flat;
            btnAddTask.ForeColor = Color.Black;
            btnAddTask.Location = new Point(12, 561);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(136, 54);
            btnAddTask.TabIndex = 2;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // tasksPanel
            // 
            tasksPanel.AllowDrop = true;
            tasksPanel.AutoScroll = true;
            tasksPanel.Location = new Point(0, 0);
            tasksPanel.Name = "tasksPanel";
            tasksPanel.Size = new Size(422, 627);
            tasksPanel.TabIndex = 4;
            tasksPanel.Paint += tasksPanel_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 627);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Note Pad";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddTask;
        private FlowLayoutPanel tasksPanel;
    }
}
