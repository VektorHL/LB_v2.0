
namespace WindowsFormsApp1
{
    partial class OvertimeWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.moves_label = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.moves_label);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 311);
            this.panel1.TabIndex = 0;
            // 
            // moves_label
            // 
            this.moves_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moves_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moves_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moves_label.Location = new System.Drawing.Point(0, 0);
            this.moves_label.Name = "moves_label";
            this.moves_label.Size = new System.Drawing.Size(514, 43);
            this.moves_label.TabIndex = 6;
            this.moves_label.Text = "ПЕРЕРАБОТКА СОТРУДНИКА";
            this.moves_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullName,
            this.plan,
            this.fact,
            this.overtime});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(514, 268);
            this.dataGridView.TabIndex = 3;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "ФИО";
            this.fullName.MinimumWidth = 60;
            this.fullName.Name = "fullName";
            this.fullName.Width = 150;
            // 
            // plan
            // 
            this.plan.HeaderText = "План, чч";
            this.plan.MinimumWidth = 50;
            this.plan.Name = "plan";
            // 
            // fact
            // 
            this.fact.HeaderText = "Фактически, чч";
            this.fact.MinimumWidth = 50;
            this.fact.Name = "fact";
            this.fact.Width = 120;
            // 
            // overtime
            // 
            this.overtime.HeaderText = "Переработка, чч";
            this.overtime.MinimumWidth = 50;
            this.overtime.Name = "overtime";
            // 
            // OvertimeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.panel1);
            this.Name = "OvertimeWindow";
            this.Text = "overtime";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label moves_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn fact;
        private System.Windows.Forms.DataGridViewTextBoxColumn overtime;
    }
}