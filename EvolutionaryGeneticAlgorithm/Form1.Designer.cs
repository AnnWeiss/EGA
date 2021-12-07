namespace EvolutionaryGeneticAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Createbutton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.crossoverGroupBox = new System.Windows.Forms.GroupBox();
            this.PMXradioButton = new System.Windows.Forms.RadioButton();
            this.OXradioButton = new System.Windows.Forms.RadioButton();
            this.populationGroupBox = new System.Windows.Forms.GroupBox();
            this.nearestCityRadioButton = new System.Windows.Forms.RadioButton();
            this.nearestNeighborRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.crossoverGroupBox.SuspendLayout();
            this.populationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.Createbutton);
            this.splitContainer1.Panel2.Controls.Add(this.resetAllButton);
            this.splitContainer1.Panel2.Controls.Add(this.crossoverGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.populationGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 551);
            this.splitContainer1.SplitterDistance = 812;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(10, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(783, 498);
            this.listBox1.TabIndex = 0;
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(126, 389);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(143, 56);
            this.Createbutton.TabIndex = 6;
            this.Createbutton.Text = "Создать";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Location = new System.Drawing.Point(126, 451);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(143, 66);
            this.resetAllButton.TabIndex = 5;
            this.resetAllButton.Text = "Сбросить все";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // crossoverGroupBox
            // 
            this.crossoverGroupBox.Controls.Add(this.PMXradioButton);
            this.crossoverGroupBox.Controls.Add(this.OXradioButton);
            this.crossoverGroupBox.Location = new System.Drawing.Point(29, 214);
            this.crossoverGroupBox.Name = "crossoverGroupBox";
            this.crossoverGroupBox.Size = new System.Drawing.Size(327, 140);
            this.crossoverGroupBox.TabIndex = 4;
            this.crossoverGroupBox.TabStop = false;
            this.crossoverGroupBox.Text = "Кроссовер:";
            // 
            // PMXradioButton
            // 
            this.PMXradioButton.AutoSize = true;
            this.PMXradioButton.Location = new System.Drawing.Point(97, 90);
            this.PMXradioButton.Name = "PMXradioButton";
            this.PMXradioButton.Size = new System.Drawing.Size(167, 24);
            this.PMXradioButton.TabIndex = 1;
            this.PMXradioButton.TabStop = true;
            this.PMXradioButton.Text = "Частичный (РМХ)";
            this.PMXradioButton.UseVisualStyleBackColor = true;
            this.PMXradioButton.CheckedChanged += new System.EventHandler(this.RMXradioButton_CheckedChanged);
            // 
            // OXradioButton
            // 
            this.OXradioButton.AutoSize = true;
            this.OXradioButton.Location = new System.Drawing.Point(97, 39);
            this.OXradioButton.Name = "OXradioButton";
            this.OXradioButton.Size = new System.Drawing.Size(167, 24);
            this.OXradioButton.TabIndex = 0;
            this.OXradioButton.TabStop = true;
            this.OXradioButton.Text = "Порядковый (ОХ)";
            this.OXradioButton.UseVisualStyleBackColor = true;
            this.OXradioButton.CheckedChanged += new System.EventHandler(this.OXradioButton_CheckedChanged);
            // 
            // populationGroupBox
            // 
            this.populationGroupBox.Controls.Add(this.nearestCityRadioButton);
            this.populationGroupBox.Controls.Add(this.nearestNeighborRadioButton);
            this.populationGroupBox.Location = new System.Drawing.Point(29, 44);
            this.populationGroupBox.Name = "populationGroupBox";
            this.populationGroupBox.Size = new System.Drawing.Size(327, 140);
            this.populationGroupBox.TabIndex = 3;
            this.populationGroupBox.TabStop = false;
            this.populationGroupBox.Text = "Формирование нач.популяции:";
            // 
            // nearestCityRadioButton
            // 
            this.nearestCityRadioButton.AutoSize = true;
            this.nearestCityRadioButton.Location = new System.Drawing.Point(89, 88);
            this.nearestCityRadioButton.Name = "nearestCityRadioButton";
            this.nearestCityRadioButton.Size = new System.Drawing.Size(150, 24);
            this.nearestCityRadioButton.TabIndex = 1;
            this.nearestCityRadioButton.TabStop = true;
            this.nearestCityRadioButton.Text = "м.Ближ.Города";
            this.nearestCityRadioButton.UseVisualStyleBackColor = true;
            this.nearestCityRadioButton.CheckedChanged += new System.EventHandler(this.nearestCityRadioButton_CheckedChanged);
            // 
            // nearestNeighborRadioButton
            // 
            this.nearestNeighborRadioButton.AutoSize = true;
            this.nearestNeighborRadioButton.Location = new System.Drawing.Point(89, 46);
            this.nearestNeighborRadioButton.Name = "nearestNeighborRadioButton";
            this.nearestNeighborRadioButton.Size = new System.Drawing.Size(151, 24);
            this.nearestNeighborRadioButton.TabIndex = 0;
            this.nearestNeighborRadioButton.TabStop = true;
            this.nearestNeighborRadioButton.Text = "м.Ближ.Соседа";
            this.nearestNeighborRadioButton.UseVisualStyleBackColor = true;
            this.nearestNeighborRadioButton.CheckedChanged += new System.EventHandler(this.nearestNeighborRadioButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 551);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Эволюционно-генетический алгоритм";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.crossoverGroupBox.ResumeLayout(false);
            this.crossoverGroupBox.PerformLayout();
            this.populationGroupBox.ResumeLayout(false);
            this.populationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox populationGroupBox;
        private System.Windows.Forms.RadioButton nearestCityRadioButton;
        private System.Windows.Forms.RadioButton nearestNeighborRadioButton;
        private System.Windows.Forms.GroupBox crossoverGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.RadioButton PMXradioButton;
        private System.Windows.Forms.RadioButton OXradioButton;
        private System.Windows.Forms.Button Createbutton;
    }
}

