namespace Maui.NullableDateTimePicker.Models
{
    public class PickerItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
