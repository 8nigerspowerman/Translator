namespace Translator2
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
            this.textinput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.textoutput = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.Пе = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cmbSourceLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cmbTargetLanguage = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.SuspendLayout();
            // 
            // textinput
            // 
            this.textinput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textinput.BorderRadius = 25;
            this.textinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textinput.DefaultText = "";
            this.textinput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textinput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textinput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textinput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textinput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textinput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textinput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textinput.Location = new System.Drawing.Point(38, 30);
            this.textinput.Name = "textinput";
            this.textinput.PasswordChar = '\0';
            this.textinput.PlaceholderText = "Введите текст";
            this.textinput.SelectedText = "";
            this.textinput.Size = new System.Drawing.Size(377, 341);
            this.textinput.TabIndex = 0;
            this.textinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoutput
            // 
            this.textoutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textoutput.BorderRadius = 25;
            this.textoutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoutput.DefaultText = "";
            this.textoutput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textoutput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textoutput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textoutput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textoutput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textoutput.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textoutput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textoutput.Location = new System.Drawing.Point(515, 30);
            this.textoutput.Name = "textoutput";
            this.textoutput.PasswordChar = '\0';
            this.textoutput.PlaceholderText = "Вывод";
            this.textoutput.SelectedText = "";
            this.textoutput.Size = new System.Drawing.Size(377, 341);
            this.textoutput.TabIndex = 1;
            this.textoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Пе
            // 
            this.Пе.BorderRadius = 15;
            this.Пе.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Пе.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Пе.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Пе.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Пе.FillColor = System.Drawing.Color.Gray;
            this.Пе.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Пе.ForeColor = System.Drawing.Color.White;
            this.Пе.Location = new System.Drawing.Point(370, 419);
            this.Пе.Name = "Пе";
            this.Пе.Size = new System.Drawing.Size(180, 45);
            this.Пе.TabIndex = 4;
            this.Пе.Text = "Перевод";
            this.Пе.Click += new System.EventHandler(this.Пе_Click);
            // 
            // cmbSourceLanguage
            // 
            this.cmbSourceLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbSourceLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSourceLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSourceLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSourceLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSourceLanguage.ItemHeight = 30;
            this.cmbSourceLanguage.Items.AddRange(new object[] {
            "en",
            "ru",
            "es"});
            this.cmbSourceLanguage.Location = new System.Drawing.Point(150, 419);
            this.cmbSourceLanguage.Name = "cmbSourceLanguage";
            this.cmbSourceLanguage.Size = new System.Drawing.Size(140, 36);
            this.cmbSourceLanguage.TabIndex = 5;
            // 
            // cmbTargetLanguage
            // 
            this.cmbTargetLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cmbTargetLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTargetLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetLanguage.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTargetLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTargetLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTargetLanguage.ItemHeight = 30;
            this.cmbTargetLanguage.Items.AddRange(new object[] {
            "en",
            "ru",
            "es"});
            this.cmbTargetLanguage.Location = new System.Drawing.Point(640, 419);
            this.cmbTargetLanguage.Name = "cmbTargetLanguage";
            this.cmbTargetLanguage.Size = new System.Drawing.Size(140, 36);
            this.cmbTargetLanguage.TabIndex = 6;
            this.cmbTargetLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbTargetLanguage_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 516);
            this.Controls.Add(this.cmbTargetLanguage);
            this.Controls.Add(this.cmbSourceLanguage);
            this.Controls.Add(this.Пе);
            this.Controls.Add(this.textoutput);
            this.Controls.Add(this.textinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textinput;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox textoutput;
        private Siticone.Desktop.UI.WinForms.SiticoneButton Пе;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbSourceLanguage;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cmbTargetLanguage;
    }
}

