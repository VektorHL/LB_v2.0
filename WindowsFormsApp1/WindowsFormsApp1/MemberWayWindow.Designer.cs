
namespace WindowsFormsApp1
{
    partial class MemberWayWindow
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
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Size = new System.Drawing.Size(644, 411);
            this.panel1.TabIndex = 0;
            // 
            // moves_label
            // 
            this.moves_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moves_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moves_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moves_label.Location = new System.Drawing.Point(0, 0);
            this.moves_label.Name = "moves_label";
            this.moves_label.Size = new System.Drawing.Size(644, 43);
            this.moves_label.TabIndex = 4;
            this.moves_label.Text = "МАРШРУТ СОТРУДНИКА";
            this.moves_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.fullName,
            this.room,
            this.time_in,
            this.time_out,
            this.duration});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 43);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 368);
            this.dataGridView.TabIndex = 1;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.Width = 80;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "ФИО";
            this.fullName.MinimumWidth = 30;
            this.fullName.Name = "fullName";
            this.fullName.Width = 150;
            // 
            // room
            // 
            this.room.HeaderText = "Зона";
            this.room.Name = "room";
            this.room.Width = 140;
            // 
            // time_in
            // 
            this.time_in.HeaderText = "Время входа";
            this.time_in.Name = "time_in";
            this.time_in.Width = 70;
            // 
            // time_out
            // 
            this.time_out.HeaderText = "Время выхода";
            this.time_out.Name = "time_out";
            this.time_out.Width = 70;
            // 
            // duration
            // 
            this.duration.HeaderText = "Длительность";
            this.duration.Name = "duration";
            this.duration.Width = 90;
            // 
            // MemberWayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.panel1);
            this.Name = "MemberWayWindow";
            this.Text = "member_way";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label moves_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_out;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
    }
}