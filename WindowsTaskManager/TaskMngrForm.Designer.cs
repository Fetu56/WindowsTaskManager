
namespace WindowsTaskManager
{
    partial class TaskMngrForm
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
            this.ProcessKillBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessKillBtn
            // 
            this.ProcessKillBtn.Location = new System.Drawing.Point(729, 12);
            this.ProcessKillBtn.Name = "ProcessKillBtn";
            this.ProcessKillBtn.Size = new System.Drawing.Size(73, 73);
            this.ProcessKillBtn.TabIndex = 0;
            this.ProcessKillBtn.Text = "Kill process";
            this.ProcessKillBtn.UseVisualStyleBackColor = true;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(729, 91);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(73, 73);
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.ProcessKillBtn);
            this.Name = "Form1";
            this.Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ProcessKillBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

