
namespace IESLab2
{
    partial class MainForm
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
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.WidthButton = new System.Windows.Forms.Button();
            this.Steps = new System.Windows.Forms.Label();
            this.DepthButton = new System.Windows.Forms.Button();
            this.LimitBox = new System.Windows.Forms.CheckBox();
            this.LimitationPanel = new System.Windows.Forms.Panel();
            this.Level = new System.Windows.Forms.TextBox();
            this.StatusPanel.SuspendLayout();
            this.LimitationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.StatusPanel.Controls.Add(this.Close);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusPanel.Location = new System.Drawing.Point(613, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(25, 476);
            this.StatusPanel.TabIndex = 0;
            this.StatusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseDown);
            this.StatusPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseMove);
            this.StatusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseUp);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(0, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(25, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseButton_Click);
            // 
            // OutputField
            // 
            this.OutputField.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputField.Location = new System.Drawing.Point(12, 12);
            this.OutputField.Multiline = true;
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(323, 452);
            this.OutputField.TabIndex = 1;
            // 
            // WidthButton
            // 
            this.WidthButton.BackColor = System.Drawing.Color.Cyan;
            this.WidthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WidthButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthButton.Location = new System.Drawing.Point(354, 54);
            this.WidthButton.Name = "WidthButton";
            this.WidthButton.Size = new System.Drawing.Size(94, 49);
            this.WidthButton.TabIndex = 2;
            this.WidthButton.Text = "Поиск в ширину";
            this.WidthButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.WidthButton.UseVisualStyleBackColor = false;
            this.WidthButton.Click += new System.EventHandler(this.WidthButton_Click);
            // 
            // Steps
            // 
            this.Steps.AutoSize = true;
            this.Steps.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Steps.Location = new System.Drawing.Point(342, 13);
            this.Steps.Name = "Steps";
            this.Steps.Size = new System.Drawing.Size(173, 24);
            this.Steps.TabIndex = 3;
            this.Steps.Text = "Количество шагов: ";
            // 
            // DepthButton
            // 
            this.DepthButton.BackColor = System.Drawing.Color.Cyan;
            this.DepthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepthButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthButton.Location = new System.Drawing.Point(354, 122);
            this.DepthButton.Name = "DepthButton";
            this.DepthButton.Size = new System.Drawing.Size(94, 49);
            this.DepthButton.TabIndex = 4;
            this.DepthButton.Text = "Поиск в глубину";
            this.DepthButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DepthButton.UseVisualStyleBackColor = false;
            this.DepthButton.Click += new System.EventHandler(this.DepthButton_Click);
            // 
            // LimitBox
            // 
            this.LimitBox.AutoSize = true;
            this.LimitBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LimitBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LimitBox.Location = new System.Drawing.Point(454, 122);
            this.LimitBox.Name = "LimitBox";
            this.LimitBox.Size = new System.Drawing.Size(143, 25);
            this.LimitBox.TabIndex = 5;
            this.LimitBox.Text = "С ограничением";
            this.LimitBox.UseVisualStyleBackColor = true;
            this.LimitBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LimitationPanel
            // 
            this.LimitationPanel.Controls.Add(this.Level);
            this.LimitationPanel.Location = new System.Drawing.Point(454, 149);
            this.LimitationPanel.Name = "LimitationPanel";
            this.LimitationPanel.Size = new System.Drawing.Size(120, 22);
            this.LimitationPanel.TabIndex = 6;
            this.LimitationPanel.Visible = false;
            // 
            // Level
            // 
            this.Level.BackColor = System.Drawing.SystemColors.Window;
            this.Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Level.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level.Location = new System.Drawing.Point(0, 0);
            this.Level.MaxLength = 3;
            this.Level.Multiline = true;
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(120, 22);
            this.Level.TabIndex = 0;
            this.Level.Text = "100";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Level.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Level_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(638, 476);
            this.Controls.Add(this.LimitationPanel);
            this.Controls.Add(this.LimitBox);
            this.Controls.Add(this.DepthButton);
            this.Controls.Add(this.Steps);
            this.Controls.Add(this.WidthButton);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.StatusPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.97D;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.StatusPanel.ResumeLayout(false);
            this.LimitationPanel.ResumeLayout(false);
            this.LimitationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Button WidthButton;
        private System.Windows.Forms.Label Steps;
        private System.Windows.Forms.Button DepthButton;
        private System.Windows.Forms.CheckBox LimitBox;
        private System.Windows.Forms.Panel LimitationPanel;
        private System.Windows.Forms.TextBox Level;
    }
}

