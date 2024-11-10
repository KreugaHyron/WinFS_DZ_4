namespace WinFS_DZ_4
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
            labelFirstName = new Label();
            labelLastName = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            labelPhone = new Label();
            labelEmail = new Label();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxEventType = new ComboBox();
            monthCalendarEventDate = new MonthCalendar();
            dateTimePickerEventTime = new DateTimePicker();
            groupBoxFormat = new GroupBox();
            radioButtonOffline = new RadioButton();
            radioButtonOnline = new RadioButton();
            checkedListBoxTopics = new CheckedListBox();
            checkBoxAgreement = new CheckBox();
            labelEventType = new Label();
            buttonSubmit = new Button();
            buttonClear = new Button();
            groupBoxFormat.SuspendLayout();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(105, 63);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(34, 15);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "Ім'я: ";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(81, 103);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(64, 15);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Прізвище:";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(145, 55);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(143, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(151, 100);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(137, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(81, 146);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(58, 15);
            labelPhone.TabIndex = 4;
            labelPhone.Text = "Телефон:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(77, 182);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 15);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Ел.пошта:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(145, 143);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(143, 23);
            textBoxPhone.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(145, 179);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(143, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // comboBoxEventType
            // 
            comboBoxEventType.FormattingEnabled = true;
            comboBoxEventType.Items.AddRange(new object[] { "Вебінар", "Конференція", "Майстер-клас" });
            comboBoxEventType.Location = new Point(145, 229);
            comboBoxEventType.Name = "comboBoxEventType";
            comboBoxEventType.Size = new Size(121, 23);
            comboBoxEventType.TabIndex = 8;
            // 
            // monthCalendarEventDate
            // 
            monthCalendarEventDate.Location = new Point(145, 264);
            monthCalendarEventDate.Name = "monthCalendarEventDate";
            monthCalendarEventDate.TabIndex = 9;
            // 
            // dateTimePickerEventTime
            // 
            dateTimePickerEventTime.Location = new Point(145, 451);
            dateTimePickerEventTime.Name = "dateTimePickerEventTime";
            dateTimePickerEventTime.Size = new Size(200, 23);
            dateTimePickerEventTime.TabIndex = 10;
            // 
            // groupBoxFormat
            // 
            groupBoxFormat.Controls.Add(radioButtonOffline);
            groupBoxFormat.Controls.Add(radioButtonOnline);
            groupBoxFormat.Location = new Point(387, 66);
            groupBoxFormat.Name = "groupBoxFormat";
            groupBoxFormat.Size = new Size(200, 100);
            groupBoxFormat.TabIndex = 11;
            groupBoxFormat.TabStop = false;
            groupBoxFormat.Text = "Формат";
            // 
            // radioButtonOffline
            // 
            radioButtonOffline.AutoSize = true;
            radioButtonOffline.Location = new Point(6, 59);
            radioButtonOffline.Name = "radioButtonOffline";
            radioButtonOffline.Size = new Size(118, 19);
            radioButtonOffline.TabIndex = 1;
            radioButtonOffline.TabStop = true;
            radioButtonOffline.Text = "Офлайн-формат";
            radioButtonOffline.UseVisualStyleBackColor = true;
            // 
            // radioButtonOnline
            // 
            radioButtonOnline.AutoSize = true;
            radioButtonOnline.Location = new Point(6, 34);
            radioButtonOnline.Name = "radioButtonOnline";
            radioButtonOnline.Size = new Size(116, 19);
            radioButtonOnline.TabIndex = 0;
            radioButtonOnline.TabStop = true;
            radioButtonOnline.Text = "Онлайн-формат";
            radioButtonOnline.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxTopics
            // 
            checkedListBoxTopics.FormattingEnabled = true;
            checkedListBoxTopics.Items.AddRange(new object[] { "Технології", "Маркетинг", "Фінанси" });
            checkedListBoxTopics.Location = new Point(387, 197);
            checkedListBoxTopics.Name = "checkedListBoxTopics";
            checkedListBoxTopics.Size = new Size(200, 94);
            checkedListBoxTopics.TabIndex = 12;
            // 
            // checkBoxAgreement
            // 
            checkBoxAgreement.AutoSize = true;
            checkBoxAgreement.Location = new Point(387, 317);
            checkBoxAgreement.Name = "checkBoxAgreement";
            checkBoxAgreement.Size = new Size(57, 19);
            checkBoxAgreement.TabIndex = 13;
            checkBoxAgreement.Text = "Згода";
            checkBoxAgreement.UseVisualStyleBackColor = true;
            // 
            // labelEventType
            // 
            labelEventType.AutoSize = true;
            labelEventType.Location = new Point(81, 232);
            labelEventType.Name = "labelEventType";
            labelEventType.Size = new Size(30, 15);
            labelEventType.TabIndex = 14;
            labelEventType.Text = "Тип:";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(387, 372);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(165, 23);
            buttonSubmit.TabIndex = 15;
            buttonSubmit.Text = "Зберегти та підтвердити";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(387, 418);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(165, 23);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 574);
            Controls.Add(buttonClear);
            Controls.Add(buttonSubmit);
            Controls.Add(labelEventType);
            Controls.Add(checkBoxAgreement);
            Controls.Add(checkedListBoxTopics);
            Controls.Add(groupBoxFormat);
            Controls.Add(dateTimePickerEventTime);
            Controls.Add(monthCalendarEventDate);
            Controls.Add(comboBoxEventType);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Name = "Form1";
            Text = "Form1";
            groupBoxFormat.ResumeLayout(false);
            groupBoxFormat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Label labelPhone;
        private Label labelEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private ComboBox comboBoxEventType;
        private MonthCalendar monthCalendarEventDate;
        private DateTimePicker dateTimePickerEventTime;
        private GroupBox groupBoxFormat;
        private RadioButton radioButtonOffline;
        private RadioButton radioButtonOnline;
        private CheckedListBox checkedListBoxTopics;
        private CheckBox checkBoxAgreement;
        private Label labelEventType;
        private Button buttonSubmit;
        private Button buttonClear;
    }
}
