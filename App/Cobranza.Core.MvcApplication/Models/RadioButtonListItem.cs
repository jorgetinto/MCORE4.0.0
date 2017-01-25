namespace Cobranza.Core.MvcApplication.Models
{
    public class RadioButtonListItem<T>
    {
        public bool Selected { get; set; }

        public string Text { get; set; }

        public T Value { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}