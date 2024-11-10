using System.Text;

namespace WinFS_DZ_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (!checkBoxAgreement.Checked)
            {
                MessageBox.Show("Ви повинні погодитись з умовами участі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string email = textBoxEmail.Text;
            string phone = textBoxPhone.Text;
            string eventType = comboBoxEventType.SelectedItem?.ToString() ?? "не вибрано";
            DateTime eventDate = monthCalendarEventDate.SelectionRange.Start;
            DateTime eventTime = dateTimePickerEventTime.Value;
            string format = radioButtonOnline.Checked ? "Онлайн" : "Офлайн";

            StringBuilder selectedTopics = new StringBuilder();
            foreach (object item in checkedListBoxTopics.CheckedItems)
            {
                selectedTopics.Append(item.ToString() + ", ");
            }
            if (selectedTopics.Length > 0)
                selectedTopics.Length -= 2;

            string message = $"Реєстрація успішна!\n\n" +
                             $"Ім'я: {firstName}\n" +
                             $"Прізвище: {lastName}\n" +
                             $"Формат: {format}\n" +
                             $"Подія: {eventType}\n" +
                             $"Дата: {eventDate.ToShortDateString()}\n" +
                             $"Час: {eventTime.ToShortTimeString()}\n" +
                             $"Теми: {selectedTopics}";

            MessageBox.Show(message, "Підтвердження реєстрації", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            comboBoxEventType.SelectedIndex = -1;
            monthCalendarEventDate.SetDate(DateTime.Now);
            dateTimePickerEventTime.Value = DateTime.Now;
            radioButtonOnline.Checked = false;
            radioButtonOffline.Checked = false;
            foreach (int i in checkedListBoxTopics.CheckedIndices)
            {
                checkedListBoxTopics.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkBoxAgreement.Checked = false;
        }
    }
}
