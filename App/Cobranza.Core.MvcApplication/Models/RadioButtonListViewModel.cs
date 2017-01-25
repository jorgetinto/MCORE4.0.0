using System.Collections.Generic;

namespace Cobranza.Core.MvcApplication.Models
{
    public class RadioButtonListViewModel<T>
    {
        private T selectedValue;

        private ICollection<RadioButtonListItem<T>> listItems;

        public string Id { get; set; }

        public T SelectedValue
        {
            get
            {
                return this.selectedValue;
            }

            set
            {
                this.selectedValue = value;

                this.UpdatedSelectedItems();
            }
        }

        public ICollection<RadioButtonListItem<T>> ListItems
        {
            get
            {
                return this.listItems;
            }

            set
            {
                listItems = value;

                this.UpdatedSelectedItems();
            }
        }

        private void UpdatedSelectedItems()
        {
            if (this.ListItems == null)
            {
                return;
            }

            foreach (var li in this.ListItems)
            {
                li.Selected = object.Equals(li.Value, this.SelectedValue);
            }
        }
    }
}