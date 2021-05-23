
namespace Optimiz_Kurs
{
    partial class AddTaskForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MinimButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskTextTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.VariantComboBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxT2Numeric = new System.Windows.Forms.NumericUpDown();
            this.MinT2Numeric = new System.Windows.Forms.NumericUpDown();
            this.MaxT1Numeric = new System.Windows.Forms.NumericUpDown();
            this.MinT1Numeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FunctionTextbox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SecondTypeTextbox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AccuracyNumeric = new System.Windows.Forms.NumericUpDown();
            this.AddEntityButton = new System.Windows.Forms.Button();
            this.AllTasksButton = new System.Windows.Forms.Button();
            this.DragControl = new Optimiz_Kurs.DragControl();
            this.DragControl2 = new Optimiz_Kurs.DragControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantComboBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxT2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinT2Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxT1Numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinT1Numeric)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(753, -4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(29, 25);
            this.ExitButton.TabIndex = 57;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(720, -4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(29, 25);
            this.MinimizeButton.TabIndex = 58;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            // 
            // MinimButton
            // 
            this.MinimButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.MinimButton.BackgroundImage = global::Optimiz_Kurs.Properties.Resources._2;
            this.MinimButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimButton.FlatAppearance.BorderSize = 0;
            this.MinimButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimButton.Location = new System.Drawing.Point(875, 3);
            this.MinimButton.Name = "MinimButton";
            this.MinimButton.Size = new System.Drawing.Size(29, 25);
            this.MinimButton.TabIndex = 63;
            this.MinimButton.UseVisualStyleBackColor = false;
            this.MinimButton.Click += new System.EventHandler(this.MinimButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.CloseButton.BackgroundImage = global::Optimiz_Kurs.Properties.Resources._1;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(910, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(29, 25);
            this.CloseButton.TabIndex = 62;
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Добавление новой задачи";
            // 
            // TaskTextTextbox
            // 
            this.TaskTextTextbox.Location = new System.Drawing.Point(11, 28);
            this.TaskTextTextbox.Multiline = true;
            this.TaskTextTextbox.Name = "TaskTextTextbox";
            this.TaskTextTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TaskTextTextbox.Size = new System.Drawing.Size(397, 310);
            this.TaskTextTextbox.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(33)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MinimButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 33);
            this.panel1.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TaskTextTextbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 349);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Текст задачи";
            // 
            // VariantComboBox
            // 
            this.VariantComboBox.Location = new System.Drawing.Point(6, 28);
            this.VariantComboBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.VariantComboBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.VariantComboBox.Name = "VariantComboBox";
            this.VariantComboBox.Size = new System.Drawing.Size(161, 29);
            this.VariantComboBox.TabIndex = 69;
            this.VariantComboBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VariantComboBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(433, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 64);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вариант задачи";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.MaxT2Numeric);
            this.groupBox3.Controls.Add(this.MinT2Numeric);
            this.groupBox3.Controls.Add(this.MaxT1Numeric);
            this.groupBox3.Controls.Add(this.MinT1Numeric);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(433, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 126);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ограничения первого рода";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(267, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Макс T2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(267, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Макс T1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(20, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Мин T2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Мин T1";
            // 
            // MaxT2Numeric
            // 
            this.MaxT2Numeric.DecimalPlaces = 2;
            this.MaxT2Numeric.Location = new System.Drawing.Point(356, 80);
            this.MaxT2Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxT2Numeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.MaxT2Numeric.Name = "MaxT2Numeric";
            this.MaxT2Numeric.Size = new System.Drawing.Size(125, 29);
            this.MaxT2Numeric.TabIndex = 70;
            this.MaxT2Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinT2Numeric
            // 
            this.MinT2Numeric.DecimalPlaces = 2;
            this.MinT2Numeric.Location = new System.Drawing.Point(101, 80);
            this.MinT2Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinT2Numeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.MinT2Numeric.Name = "MinT2Numeric";
            this.MinT2Numeric.Size = new System.Drawing.Size(125, 29);
            this.MinT2Numeric.TabIndex = 70;
            this.MinT2Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxT1Numeric
            // 
            this.MaxT1Numeric.DecimalPlaces = 2;
            this.MaxT1Numeric.Location = new System.Drawing.Point(356, 28);
            this.MaxT1Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxT1Numeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.MaxT1Numeric.Name = "MaxT1Numeric";
            this.MaxT1Numeric.Size = new System.Drawing.Size(125, 29);
            this.MaxT1Numeric.TabIndex = 70;
            this.MaxT1Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinT1Numeric
            // 
            this.MinT1Numeric.DecimalPlaces = 2;
            this.MinT1Numeric.Location = new System.Drawing.Point(101, 28);
            this.MinT1Numeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MinT1Numeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.MinT1Numeric.Name = "MinT1Numeric";
            this.MinT1Numeric.Size = new System.Drawing.Size(125, 29);
            this.MinT1Numeric.TabIndex = 70;
            this.MinT1Numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FunctionTextbox);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(612, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 64);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Целевая функция";
            // 
            // FunctionTextbox
            // 
            this.FunctionTextbox.Location = new System.Drawing.Point(6, 28);
            this.FunctionTextbox.Multiline = true;
            this.FunctionTextbox.Name = "FunctionTextbox";
            this.FunctionTextbox.Size = new System.Drawing.Size(306, 29);
            this.FunctionTextbox.TabIndex = 66;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SecondTypeTextbox);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(433, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 65);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ограничения второго рода";
            // 
            // SecondTypeTextbox
            // 
            this.SecondTypeTextbox.Location = new System.Drawing.Point(6, 28);
            this.SecondTypeTextbox.Multiline = true;
            this.SecondTypeTextbox.Name = "SecondTypeTextbox";
            this.SecondTypeTextbox.Size = new System.Drawing.Size(279, 29);
            this.SecondTypeTextbox.TabIndex = 66;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.AccuracyNumeric);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(731, 256);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(199, 64);
            this.groupBox6.TabIndex = 70;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Точность решения";
            // 
            // AccuracyNumeric
            // 
            this.AccuracyNumeric.DecimalPlaces = 5;
            this.AccuracyNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.AccuracyNumeric.Location = new System.Drawing.Point(6, 28);
            this.AccuracyNumeric.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AccuracyNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.AccuracyNumeric.Name = "AccuracyNumeric";
            this.AccuracyNumeric.Size = new System.Drawing.Size(187, 29);
            this.AccuracyNumeric.TabIndex = 69;
            this.AccuracyNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddEntityButton
            // 
            this.AddEntityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEntityButton.Location = new System.Drawing.Point(439, 326);
            this.AddEntityButton.Name = "AddEntityButton";
            this.AddEntityButton.Size = new System.Drawing.Size(244, 63);
            this.AddEntityButton.TabIndex = 72;
            this.AddEntityButton.Text = "Добавить задачу";
            this.AddEntityButton.UseVisualStyleBackColor = true;
            this.AddEntityButton.Click += new System.EventHandler(this.AddEntityButton_Click);
            // 
            // AllTasksButton
            // 
            this.AllTasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllTasksButton.Location = new System.Drawing.Point(689, 326);
            this.AllTasksButton.Name = "AllTasksButton";
            this.AllTasksButton.Size = new System.Drawing.Size(244, 63);
            this.AllTasksButton.TabIndex = 72;
            this.AllTasksButton.Text = "Просмотр списка задач";
            this.AllTasksButton.UseVisualStyleBackColor = true;
            this.AllTasksButton.Click += new System.EventHandler(this.AllTasksButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.selectControl = this.panel1;
            // 
            // DragControl2
            // 
            this.DragControl2.selectControl = this.label1;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(942, 403);
            this.Controls.Add(this.AllTasksButton);
            this.Controls.Add(this.AddEntityButton);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим исследователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariantComboBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxT2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinT2Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxT1Numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinT1Numeric)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccuracyNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private DragControl DragControl;
        private System.Windows.Forms.Button MinimButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskTextTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DragControl DragControl2;
        private System.Windows.Forms.NumericUpDown VariantComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox FunctionTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown MaxT2Numeric;
        private System.Windows.Forms.NumericUpDown MinT2Numeric;
        private System.Windows.Forms.NumericUpDown MaxT1Numeric;
        private System.Windows.Forms.NumericUpDown MinT1Numeric;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SecondTypeTextbox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown AccuracyNumeric;
        private System.Windows.Forms.Button AddEntityButton;
        private System.Windows.Forms.Button AllTasksButton;
    }
}

