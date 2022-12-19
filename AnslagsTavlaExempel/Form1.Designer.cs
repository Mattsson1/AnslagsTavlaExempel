namespace AnslagsTavlaExempel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.wheater_Button = new System.Windows.Forms.Button();
            this.dayScheme_Button = new System.Windows.Forms.Button();
            this.home_Button = new System.Windows.Forms.Button();
            this.activities_Button = new System.Windows.Forms.Button();
            this.bussTimes_Button = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.väder1 = new AnslagsTavlaExempel.Väder();
            this.startSida1 = new AnslagsTavlaExempel.StartSida();
            this.dagsschema1 = new AnslagsTavlaExempel.Dagsschema();
            this.busstider1 = new AnslagsTavlaExempel.Busstider();
            this.aktiviteter1 = new AnslagsTavlaExempel.Aktiviteter();
            this.tableLayoutPanel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.wheater_Button, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.dayScheme_Button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.home_Button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.activities_Button, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bussTimes_Button, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1240, 70);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // wheater_Button
            // 
            this.wheater_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wheater_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.wheater_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.wheater_Button.ForeColor = System.Drawing.Color.Green;
            this.wheater_Button.Image = ((System.Drawing.Image)(resources.GetObject("wheater_Button.Image")));
            this.wheater_Button.Location = new System.Drawing.Point(995, 3);
            this.wheater_Button.Name = "wheater_Button";
            this.wheater_Button.Size = new System.Drawing.Size(242, 64);
            this.wheater_Button.TabIndex = 6;
            this.wheater_Button.Text = "Väder";
            this.wheater_Button.UseVisualStyleBackColor = true;
            this.wheater_Button.Click += new System.EventHandler(this.wheater_Button_Click);
            // 
            // dayScheme_Button
            // 
            this.dayScheme_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dayScheme_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dayScheme_Button.Location = new System.Drawing.Point(251, 5);
            this.dayScheme_Button.Name = "dayScheme_Button";
            this.dayScheme_Button.Size = new System.Drawing.Size(242, 59);
            this.dayScheme_Button.TabIndex = 8;
            this.dayScheme_Button.Text = "Dagschema";
            this.dayScheme_Button.UseVisualStyleBackColor = true;
            this.dayScheme_Button.Click += new System.EventHandler(this.dayScheme_Button_Click);
            // 
            // home_Button
            // 
            this.home_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.home_Button.Location = new System.Drawing.Point(3, 5);
            this.home_Button.Name = "home_Button";
            this.home_Button.Size = new System.Drawing.Size(242, 59);
            this.home_Button.TabIndex = 7;
            this.home_Button.Text = "Startsida";
            this.home_Button.UseVisualStyleBackColor = true;
            this.home_Button.Click += new System.EventHandler(this.home_Button_Click);
            // 
            // activities_Button
            // 
            this.activities_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.activities_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.activities_Button.Location = new System.Drawing.Point(499, 4);
            this.activities_Button.Name = "activities_Button";
            this.activities_Button.Size = new System.Drawing.Size(242, 62);
            this.activities_Button.TabIndex = 9;
            this.activities_Button.Text = "Aktiviteter";
            this.activities_Button.UseVisualStyleBackColor = true;
            this.activities_Button.Click += new System.EventHandler(this.activities_Button_Click);
            // 
            // bussTimes_Button
            // 
            this.bussTimes_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bussTimes_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bussTimes_Button.Location = new System.Drawing.Point(747, 3);
            this.bussTimes_Button.Name = "bussTimes_Button";
            this.bussTimes_Button.Size = new System.Drawing.Size(242, 63);
            this.bussTimes_Button.TabIndex = 5;
            this.bussTimes_Button.Text = "Busstider";
            this.bussTimes_Button.UseVisualStyleBackColor = true;
            this.bussTimes_Button.Click += new System.EventHandler(this.bussTimes_Button_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainPanel.Controls.Add(this.väder1);
            this.mainPanel.Controls.Add(this.startSida1);
            this.mainPanel.Controls.Add(this.dagsschema1);
            this.mainPanel.Controls.Add(this.busstider1);
            this.mainPanel.Controls.Add(this.aktiviteter1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 70);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1240, 539);
            this.mainPanel.TabIndex = 14;
            // 
            // väder1
            // 
            this.väder1.Location = new System.Drawing.Point(-1, 0);
            this.väder1.Name = "väder1";
            this.väder1.Size = new System.Drawing.Size(1241, 539);
            this.väder1.TabIndex = 4;
            // 
            // startSida1
            // 
            this.startSida1.Location = new System.Drawing.Point(0, 0);
            this.startSida1.Name = "startSida1";
            this.startSida1.Size = new System.Drawing.Size(1240, 539);
            this.startSida1.TabIndex = 3;
            // 
            // dagsschema1
            // 
            this.dagsschema1.Location = new System.Drawing.Point(0, 0);
            this.dagsschema1.Name = "dagsschema1";
            this.dagsschema1.Size = new System.Drawing.Size(1240, 539);
            this.dagsschema1.TabIndex = 2;
            // 
            // busstider1
            // 
            this.busstider1.Location = new System.Drawing.Point(0, 0);
            this.busstider1.Name = "busstider1";
            this.busstider1.Size = new System.Drawing.Size(1240, 539);
            this.busstider1.TabIndex = 1;
            // 
            // aktiviteter1
            // 
            this.aktiviteter1.Location = new System.Drawing.Point(0, 0);
            this.aktiviteter1.Name = "aktiviteter1";
            this.aktiviteter1.Size = new System.Drawing.Size(1240, 539);
            this.aktiviteter1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1240, 609);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Button wheater_Button;
        private Button dayScheme_Button;
        private Button home_Button;
        private Button activities_Button;
        private Button bussTimes_Button;
        private Panel mainPanel;
        private Väder väder1;
        private StartSida startSida1;
        private Dagsschema dagsschema1;
        private Busstider busstider1;
        private Aktiviteter aktiviteter1;
    }
}