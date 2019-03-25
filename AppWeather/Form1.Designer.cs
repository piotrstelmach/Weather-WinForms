namespace AppWeather
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.weatherIconBox = new System.Windows.Forms.PictureBox();
            this.temperatureL = new System.Windows.Forms.Label();
            this.pressureL = new System.Windows.Forms.Label();
            this.WindSpeedL = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.getFiveDay = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Location = new System.Drawing.Point(35, 96);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 24);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "date";
            this.dateLabel.Visible = false;
            // 
            // weatherIconBox
            // 
            this.weatherIconBox.Location = new System.Drawing.Point(77, 149);
            this.weatherIconBox.Name = "weatherIconBox";
            this.weatherIconBox.Size = new System.Drawing.Size(50, 50);
            this.weatherIconBox.TabIndex = 1;
            this.weatherIconBox.TabStop = false;
            this.weatherIconBox.Visible = false;
            // 
            // temperatureL
            // 
            this.temperatureL.AutoSize = true;
            this.temperatureL.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.temperatureL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperatureL.Location = new System.Drawing.Point(164, 125);
            this.temperatureL.Name = "temperatureL";
            this.temperatureL.Size = new System.Drawing.Size(141, 24);
            this.temperatureL.TabIndex = 2;
            this.temperatureL.Text = "Temperature";
            this.temperatureL.Visible = false;
            // 
            // pressureL
            // 
            this.pressureL.AutoSize = true;
            this.pressureL.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.pressureL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureL.Location = new System.Drawing.Point(164, 162);
            this.pressureL.Name = "pressureL";
            this.pressureL.Size = new System.Drawing.Size(91, 24);
            this.pressureL.TabIndex = 3;
            this.pressureL.Text = "Pressure";
            this.pressureL.Visible = false;
            // 
            // WindSpeedL
            // 
            this.WindSpeedL.AutoSize = true;
            this.WindSpeedL.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.WindSpeedL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedL.Location = new System.Drawing.Point(164, 197);
            this.WindSpeedL.Name = "WindSpeedL";
            this.WindSpeedL.Size = new System.Drawing.Size(129, 24);
            this.WindSpeedL.TabIndex = 4;
            this.WindSpeedL.Text = "Wind speed";
            this.WindSpeedL.Visible = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.descriptionLabel.Location = new System.Drawing.Point(35, 238);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(120, 24);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "description";
            this.descriptionLabel.Visible = false;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.temperatureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperatureLabel.Location = new System.Drawing.Point(305, 125);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(0, 24);
            this.temperatureLabel.TabIndex = 6;
            this.temperatureLabel.Visible = false;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.pressureLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pressureLabel.Location = new System.Drawing.Point(266, 162);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(0, 24);
            this.pressureLabel.TabIndex = 7;
            this.pressureLabel.Visible = false;
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.WindSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.WindSpeedLabel.Location = new System.Drawing.Point(293, 197);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(0, 24);
            this.WindSpeedLabel.TabIndex = 8;
            this.WindSpeedLabel.Visible = false;
            // 
            // getFiveDay
            // 
            this.getFiveDay.Location = new System.Drawing.Point(115, 308);
            this.getFiveDay.Name = "getFiveDay";
            this.getFiveDay.Size = new System.Drawing.Size(131, 38);
            this.getFiveDay.TabIndex = 9;
            this.getFiveDay.Text = "Get hours forecast";
            this.getFiveDay.UseVisualStyleBackColor = true;
            this.getFiveDay.Visible = false;
            this.getFiveDay.Click += new System.EventHandler(this.getFiveDay_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(77, 46);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(176, 20);
            this.searchTextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(124, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search city";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get weather!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(395, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.getFiveDay);
            this.Controls.Add(this.WindSpeedLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.WindSpeedL);
            this.Controls.Add(this.pressureL);
            this.Controls.Add(this.temperatureL);
            this.Controls.Add(this.weatherIconBox);
            this.Controls.Add(this.dateLabel);
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.weatherIconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.PictureBox weatherIconBox;
        private System.Windows.Forms.Label temperatureL;
        private System.Windows.Forms.Label pressureL;
        private System.Windows.Forms.Label WindSpeedL;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Button getFiveDay;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

