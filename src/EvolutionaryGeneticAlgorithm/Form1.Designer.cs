﻿namespace EvolutionaryGeneticAlgorithm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.proportionalRadioButton = new System.Windows.Forms.RadioButton();
            this.betaRadioButton = new System.Windows.Forms.RadioButton();
            this.mutationGroupBox = new System.Windows.Forms.GroupBox();
            this.chromRadioButton = new System.Windows.Forms.RadioButton();
            this.macroRadioButton = new System.Windows.Forms.RadioButton();
            this.genRadioButton = new System.Windows.Forms.RadioButton();
            this.Createbutton = new System.Windows.Forms.Button();
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
            this.selectionGroupBox.SuspendLayout();
            this.mutationGroupBox.SuspendLayout();
            this.crossoverGroupBox.SuspendLayout();
            this.populationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
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
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.countLabel);
            this.splitContainer1.Panel2.Controls.Add(this.selectionGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.mutationGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.Createbutton);
            this.splitContainer1.Panel2.Controls.Add(this.crossoverGroupBox);
            this.splitContainer1.Panel2.Controls.Add(this.populationGroupBox);
            this.splitContainer1.Size = new System.Drawing.Size(1206, 1011);
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
            this.listBox1.Size = new System.Drawing.Size(783, 914);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 778);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(43, 781);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(161, 20);
            this.countLabel.TabIndex = 9;
            this.countLabel.Text = "Кол-во вычислений:";
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.proportionalRadioButton);
            this.selectionGroupBox.Controls.Add(this.betaRadioButton);
            this.selectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectionGroupBox.Location = new System.Drawing.Point(29, 605);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(327, 141);
            this.selectionGroupBox.TabIndex = 8;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Селекция:";
            // 
            // proportionalRadioButton
            // 
            this.proportionalRadioButton.AutoSize = true;
            this.proportionalRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proportionalRadioButton.Location = new System.Drawing.Point(67, 91);
            this.proportionalRadioButton.Name = "proportionalRadioButton";
            this.proportionalRadioButton.Size = new System.Drawing.Size(198, 26);
            this.proportionalRadioButton.TabIndex = 1;
            this.proportionalRadioButton.TabStop = true;
            this.proportionalRadioButton.Text = "Пропорциональная";
            this.proportionalRadioButton.UseVisualStyleBackColor = true;
            // 
            // betaRadioButton
            // 
            this.betaRadioButton.AutoSize = true;
            this.betaRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.betaRadioButton.Location = new System.Drawing.Point(67, 41);
            this.betaRadioButton.Name = "betaRadioButton";
            this.betaRadioButton.Size = new System.Drawing.Size(108, 26);
            this.betaRadioButton.TabIndex = 0;
            this.betaRadioButton.TabStop = true;
            this.betaRadioButton.Text = "β-турнир";
            this.betaRadioButton.UseVisualStyleBackColor = true;
            // 
            // mutationGroupBox
            // 
            this.mutationGroupBox.Controls.Add(this.chromRadioButton);
            this.mutationGroupBox.Controls.Add(this.macroRadioButton);
            this.mutationGroupBox.Controls.Add(this.genRadioButton);
            this.mutationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mutationGroupBox.Location = new System.Drawing.Point(29, 381);
            this.mutationGroupBox.Name = "mutationGroupBox";
            this.mutationGroupBox.Size = new System.Drawing.Size(327, 196);
            this.mutationGroupBox.TabIndex = 7;
            this.mutationGroupBox.TabStop = false;
            this.mutationGroupBox.Text = "Мутация:";
            // 
            // chromRadioButton
            // 
            this.chromRadioButton.AutoSize = true;
            this.chromRadioButton.Location = new System.Drawing.Point(67, 143);
            this.chromRadioButton.Name = "chromRadioButton";
            this.chromRadioButton.Size = new System.Drawing.Size(217, 26);
            this.chromRadioButton.TabIndex = 2;
            this.chromRadioButton.TabStop = true;
            this.chromRadioButton.Text = "Хромосомная (м.Б.С)";
            this.chromRadioButton.UseVisualStyleBackColor = true;
            this.chromRadioButton.CheckedChanged += new System.EventHandler(this.chromRadioButton_CheckedChanged);
            // 
            // macroRadioButton
            // 
            this.macroRadioButton.AutoSize = true;
            this.macroRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.macroRadioButton.Location = new System.Drawing.Point(67, 90);
            this.macroRadioButton.Name = "macroRadioButton";
            this.macroRadioButton.Size = new System.Drawing.Size(192, 26);
            this.macroRadioButton.TabIndex = 1;
            this.macroRadioButton.TabStop = true;
            this.macroRadioButton.Text = "Макро (сальтация)";
            this.macroRadioButton.UseVisualStyleBackColor = true;
            this.macroRadioButton.CheckedChanged += new System.EventHandler(this.macroRadioButton_CheckedChanged);
            // 
            // genRadioButton
            // 
            this.genRadioButton.AutoSize = true;
            this.genRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genRadioButton.Location = new System.Drawing.Point(67, 37);
            this.genRadioButton.Name = "genRadioButton";
            this.genRadioButton.Size = new System.Drawing.Size(190, 26);
            this.genRadioButton.TabIndex = 0;
            this.genRadioButton.TabStop = true;
            this.genRadioButton.Text = "Генная (точечная)";
            this.genRadioButton.UseVisualStyleBackColor = true;
            this.genRadioButton.CheckedChanged += new System.EventHandler(this.genRadioButton_CheckedChanged);
            // 
            // Createbutton
            // 
            this.Createbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Createbutton.Location = new System.Drawing.Point(126, 847);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(143, 56);
            this.Createbutton.TabIndex = 6;
            this.Createbutton.Text = "Создать";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // crossoverGroupBox
            // 
            this.crossoverGroupBox.Controls.Add(this.PMXradioButton);
            this.crossoverGroupBox.Controls.Add(this.OXradioButton);
            this.crossoverGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.PMXradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PMXradioButton.Location = new System.Drawing.Point(67, 90);
            this.PMXradioButton.Name = "PMXradioButton";
            this.PMXradioButton.Size = new System.Drawing.Size(182, 26);
            this.PMXradioButton.TabIndex = 1;
            this.PMXradioButton.TabStop = true;
            this.PMXradioButton.Text = "Частичный (РМХ)";
            this.PMXradioButton.UseVisualStyleBackColor = true;
            this.PMXradioButton.CheckedChanged += new System.EventHandler(this.RMXradioButton_CheckedChanged);
            // 
            // OXradioButton
            // 
            this.OXradioButton.AutoSize = true;
            this.OXradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OXradioButton.Location = new System.Drawing.Point(67, 39);
            this.OXradioButton.Name = "OXradioButton";
            this.OXradioButton.Size = new System.Drawing.Size(184, 26);
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
            this.populationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.nearestCityRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nearestCityRadioButton.Location = new System.Drawing.Point(67, 88);
            this.nearestCityRadioButton.Name = "nearestCityRadioButton";
            this.nearestCityRadioButton.Size = new System.Drawing.Size(165, 26);
            this.nearestCityRadioButton.TabIndex = 1;
            this.nearestCityRadioButton.TabStop = true;
            this.nearestCityRadioButton.Text = "м.Ближ.Города";
            this.nearestCityRadioButton.UseVisualStyleBackColor = true;
            this.nearestCityRadioButton.CheckedChanged += new System.EventHandler(this.nearestCityRadioButton_CheckedChanged);
            // 
            // nearestNeighborRadioButton
            // 
            this.nearestNeighborRadioButton.AutoSize = true;
            this.nearestNeighborRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nearestNeighborRadioButton.Location = new System.Drawing.Point(67, 46);
            this.nearestNeighborRadioButton.Name = "nearestNeighborRadioButton";
            this.nearestNeighborRadioButton.Size = new System.Drawing.Size(167, 26);
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
            this.ClientSize = new System.Drawing.Size(1206, 1011);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Эволюционно-генетический алгоритм";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            this.mutationGroupBox.ResumeLayout(false);
            this.mutationGroupBox.PerformLayout();
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
        private System.Windows.Forms.RadioButton PMXradioButton;
        private System.Windows.Forms.RadioButton OXradioButton;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.GroupBox mutationGroupBox;
        private System.Windows.Forms.RadioButton macroRadioButton;
        private System.Windows.Forms.RadioButton genRadioButton;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.RadioButton proportionalRadioButton;
        private System.Windows.Forms.RadioButton betaRadioButton;
        private System.Windows.Forms.RadioButton chromRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label countLabel;
    }
}

