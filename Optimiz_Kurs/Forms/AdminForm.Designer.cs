
namespace Optimiz_Kurs
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MinimButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragControl = new Optimiz_Kurs.DragControl();
            this.DragControl2 = new Optimiz_Kurs.DragControl();
            this.AddTasksButton = new System.Windows.Forms.Button();
            this.AddUsersButton = new System.Windows.Forms.Button();
            this.OpenResearchForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.MinimButton.Location = new System.Drawing.Point(425, 4);
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
            this.CloseButton.Location = new System.Drawing.Point(460, 4);
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
            this.label1.Size = new System.Drawing.Size(336, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Добро пожаловать, Администратор";
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
            this.panel1.Size = new System.Drawing.Size(491, 33);
            this.panel1.TabIndex = 67;
            // 
            // DragControl
            // 
            this.DragControl.selectControl = this.panel1;
            // 
            // DragControl2
            // 
            this.DragControl2.selectControl = this.label1;
            // 
            // AddTasksButton
            // 
            this.AddTasksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddTasksButton.Location = new System.Drawing.Point(12, 49);
            this.AddTasksButton.Name = "AddTasksButton";
            this.AddTasksButton.Size = new System.Drawing.Size(467, 52);
            this.AddTasksButton.TabIndex = 68;
            this.AddTasksButton.Text = "Редактировать банк заданий";
            this.AddTasksButton.UseVisualStyleBackColor = true;
            this.AddTasksButton.Click += new System.EventHandler(this.AddTasksButton_Click);
            // 
            // AddUsersButton
            // 
            this.AddUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUsersButton.Location = new System.Drawing.Point(12, 107);
            this.AddUsersButton.Name = "AddUsersButton";
            this.AddUsersButton.Size = new System.Drawing.Size(467, 52);
            this.AddUsersButton.TabIndex = 68;
            this.AddUsersButton.Text = "Редактировать учетные записи";
            this.AddUsersButton.UseVisualStyleBackColor = true;
            this.AddUsersButton.Click += new System.EventHandler(this.AddUsersButton_Click);
            // 
            // OpenResearchForm
            // 
            this.OpenResearchForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenResearchForm.Location = new System.Drawing.Point(12, 165);
            this.OpenResearchForm.Name = "OpenResearchForm";
            this.OpenResearchForm.Size = new System.Drawing.Size(467, 52);
            this.OpenResearchForm.TabIndex = 68;
            this.OpenResearchForm.Text = "Открыть форму исследователя";
            this.OpenResearchForm.UseVisualStyleBackColor = true;
            this.OpenResearchForm.Click += new System.EventHandler(this.OpenResearchForm_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(491, 233);
            this.Controls.Add(this.OpenResearchForm);
            this.Controls.Add(this.AddUsersButton);
            this.Controls.Add(this.AddTasksButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.MinimizeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Режим исследователя";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private DragControl DragControl2;
        private System.Windows.Forms.Button AddTasksButton;
        private System.Windows.Forms.Button AddUsersButton;
        private System.Windows.Forms.Button OpenResearchForm;
    }
}

