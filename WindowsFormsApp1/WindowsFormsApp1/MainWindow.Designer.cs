
namespace WindowsFormsApp1
{
    partial class MainWindow
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
            this.MainWindow_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.moves_label = new System.Windows.Forms.Label();
            this.getMoves_label = new System.Windows.Forms.Label();
            this.moves_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inOut_panel = new System.Windows.Forms.Panel();
            this.IN_button = new System.Windows.Forms.Button();
            this.room_panel = new System.Windows.Forms.Panel();
            this.rooms_comboBox = new System.Windows.Forms.ComboBox();
            this.fullName_panel = new System.Windows.Forms.Panel();
            this.names_comboBox = new System.Windows.Forms.ComboBox();
            this.getMoves_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getMoves_names_comboBox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.getMoves_movesType_comboBox = new System.Windows.Forms.ComboBox();
            this.getMoves_button = new System.Windows.Forms.Button();
            this.MainWindow_tableLayoutPanel.SuspendLayout();
            this.moves_tableLayoutPanel.SuspendLayout();
            this.inOut_panel.SuspendLayout();
            this.room_panel.SuspendLayout();
            this.fullName_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow_tableLayoutPanel
            // 
            this.MainWindow_tableLayoutPanel.ColumnCount = 2;
            this.MainWindow_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainWindow_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.MainWindow_tableLayoutPanel.Controls.Add(this.moves_label, 0, 0);
            this.MainWindow_tableLayoutPanel.Controls.Add(this.getMoves_label, 1, 0);
            this.MainWindow_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainWindow_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindow_tableLayoutPanel.Name = "MainWindow_tableLayoutPanel";
            this.MainWindow_tableLayoutPanel.RowCount = 1;
            this.MainWindow_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindow_tableLayoutPanel.Size = new System.Drawing.Size(608, 46);
            this.MainWindow_tableLayoutPanel.TabIndex = 1;
            this.MainWindow_tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_tableLayoutPanel_Paint);
            // 
            // moves_label
            // 
            this.moves_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.moves_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moves_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moves_label.Location = new System.Drawing.Point(3, 0);
            this.moves_label.Name = "moves_label";
            this.moves_label.Size = new System.Drawing.Size(294, 46);
            this.moves_label.TabIndex = 3;
            this.moves_label.Text = "ДОБАВЛЕНИЕ ПЕРЕМЕЩЕНИЯ";
            this.moves_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getMoves_label
            // 
            this.getMoves_label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.getMoves_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getMoves_label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getMoves_label.Location = new System.Drawing.Point(303, 0);
            this.getMoves_label.Name = "getMoves_label";
            this.getMoves_label.Size = new System.Drawing.Size(302, 46);
            this.getMoves_label.TabIndex = 2;
            this.getMoves_label.Text = "СВОДКА О ПЕРЕМЕЩЕНИЯХ";
            this.getMoves_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // moves_tableLayoutPanel
            // 
            this.moves_tableLayoutPanel.ColumnCount = 1;
            this.moves_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.moves_tableLayoutPanel.Controls.Add(this.inOut_panel, 0, 2);
            this.moves_tableLayoutPanel.Controls.Add(this.room_panel, 0, 1);
            this.moves_tableLayoutPanel.Controls.Add(this.fullName_panel, 0, 0);
            this.moves_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.moves_tableLayoutPanel.Location = new System.Drawing.Point(0, 46);
            this.moves_tableLayoutPanel.Name = "moves_tableLayoutPanel";
            this.moves_tableLayoutPanel.RowCount = 3;
            this.moves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.moves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.moves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.moves_tableLayoutPanel.Size = new System.Drawing.Size(300, 215);
            this.moves_tableLayoutPanel.TabIndex = 2;
            // 
            // inOut_panel
            // 
            this.inOut_panel.Controls.Add(this.IN_button);
            this.inOut_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inOut_panel.Location = new System.Drawing.Point(3, 156);
            this.inOut_panel.Name = "inOut_panel";
            this.inOut_panel.Size = new System.Drawing.Size(294, 123);
            this.inOut_panel.TabIndex = 2;
            // 
            // IN_button
            // 
            this.IN_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IN_button.Location = new System.Drawing.Point(103, 16);
            this.IN_button.Name = "IN_button";
            this.IN_button.Size = new System.Drawing.Size(75, 30);
            this.IN_button.TabIndex = 0;
            this.IN_button.Text = "Добавить";
            this.IN_button.UseVisualStyleBackColor = true;
            this.IN_button.Click += new System.EventHandler(this.IN_button_Click);
            // 
            // room_panel
            // 
            this.room_panel.Controls.Add(this.rooms_comboBox);
            this.room_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.room_panel.Location = new System.Drawing.Point(3, 85);
            this.room_panel.Name = "room_panel";
            this.room_panel.Size = new System.Drawing.Size(294, 65);
            this.room_panel.TabIndex = 1;
            // 
            // rooms_comboBox
            // 
            this.rooms_comboBox.FormattingEnabled = true;
            this.rooms_comboBox.Location = new System.Drawing.Point(25, 24);
            this.rooms_comboBox.Name = "rooms_comboBox";
            this.rooms_comboBox.Size = new System.Drawing.Size(164, 21);
            this.rooms_comboBox.TabIndex = 2;
            this.rooms_comboBox.TabStop = false;
            this.rooms_comboBox.SelectedIndexChanged += new System.EventHandler(this.rooms_comboBox_SelectedIndexChanged);
            // 
            // fullName_panel
            // 
            this.fullName_panel.Controls.Add(this.names_comboBox);
            this.fullName_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullName_panel.Location = new System.Drawing.Point(3, 3);
            this.fullName_panel.Name = "fullName_panel";
            this.fullName_panel.Size = new System.Drawing.Size(294, 76);
            this.fullName_panel.TabIndex = 0;
            // 
            // names_comboBox
            // 
            this.names_comboBox.FormattingEnabled = true;
            this.names_comboBox.Location = new System.Drawing.Point(25, 29);
            this.names_comboBox.Name = "names_comboBox";
            this.names_comboBox.Size = new System.Drawing.Size(234, 21);
            this.names_comboBox.TabIndex = 1;
            this.names_comboBox.TabStop = false;
            this.names_comboBox.SelectedIndexChanged += new System.EventHandler(this.names_comboBox_SelectedIndexChanged);
            // 
            // getMoves_tableLayoutPanel
            // 
            this.getMoves_tableLayoutPanel.AutoSize = true;
            this.getMoves_tableLayoutPanel.ColumnCount = 1;
            this.getMoves_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.getMoves_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.getMoves_tableLayoutPanel.Location = new System.Drawing.Point(608, 46);
            this.getMoves_tableLayoutPanel.Name = "getMoves_tableLayoutPanel";
            this.getMoves_tableLayoutPanel.RowCount = 3;
            this.getMoves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.getMoves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.getMoves_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.getMoves_tableLayoutPanel.Size = new System.Drawing.Size(0, 215);
            this.getMoves_tableLayoutPanel.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(300, 46);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 215);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.getMoves_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 122);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.getMoves_names_comboBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 63);
            this.panel2.TabIndex = 1;
            // 
            // getMoves_names_comboBox
            // 
            this.getMoves_names_comboBox.FormattingEnabled = true;
            this.getMoves_names_comboBox.Location = new System.Drawing.Point(35, 21);
            this.getMoves_names_comboBox.Name = "getMoves_names_comboBox";
            this.getMoves_names_comboBox.Size = new System.Drawing.Size(234, 21);
            this.getMoves_names_comboBox.TabIndex = 1;
            this.getMoves_names_comboBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.getMoves_movesType_comboBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 79);
            this.panel3.TabIndex = 0;
            // 
            // getMoves_movesType_comboBox
            // 
            this.getMoves_movesType_comboBox.FormattingEnabled = true;
            this.getMoves_movesType_comboBox.Items.AddRange(new object[] {
            "Отчёт по сотруднику за текущий месяц",
            "Отчёт по зоне за день",
            "Отчёт по сотрудникам за день"});
            this.getMoves_movesType_comboBox.Location = new System.Drawing.Point(35, 29);
            this.getMoves_movesType_comboBox.Name = "getMoves_movesType_comboBox";
            this.getMoves_movesType_comboBox.Size = new System.Drawing.Size(234, 21);
            this.getMoves_movesType_comboBox.TabIndex = 5;
            this.getMoves_movesType_comboBox.TabStop = false;
            this.getMoves_movesType_comboBox.SelectedIndexChanged += new System.EventHandler(this.getMoves_movesType_comboBox_SelectedIndexChanged);
            // 
            // getMoves_button
            // 
            this.getMoves_button.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getMoves_button.Location = new System.Drawing.Point(112, 20);
            this.getMoves_button.Name = "getMoves_button";
            this.getMoves_button.Size = new System.Drawing.Size(90, 25);
            this.getMoves_button.TabIndex = 4;
            this.getMoves_button.Text = "Получить";
            this.getMoves_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.getMoves_button.UseVisualStyleBackColor = true;
            this.getMoves_button.Click += new System.EventHandler(this.getMoves_button_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(608, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.getMoves_tableLayoutPanel);
            this.Controls.Add(this.moves_tableLayoutPanel);
            this.Controls.Add(this.MainWindow_tableLayoutPanel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainWindow_tableLayoutPanel.ResumeLayout(false);
            this.moves_tableLayoutPanel.ResumeLayout(false);
            this.inOut_panel.ResumeLayout(false);
            this.room_panel.ResumeLayout(false);
            this.fullName_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainWindow_tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel moves_tableLayoutPanel;
        private System.Windows.Forms.Panel fullName_panel;
        private System.Windows.Forms.TableLayoutPanel getMoves_tableLayoutPanel;
        private System.Windows.Forms.Label getMoves_label;
        private System.Windows.Forms.Panel room_panel;
        private System.Windows.Forms.Panel inOut_panel;
        private System.Windows.Forms.Button IN_button;
        private System.Windows.Forms.Label moves_label;
        private System.Windows.Forms.ComboBox rooms_comboBox;
        private System.Windows.Forms.ComboBox names_comboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox getMoves_names_comboBox;
        private System.Windows.Forms.ComboBox getMoves_movesType_comboBox;
        private System.Windows.Forms.Button getMoves_button;
    }
}