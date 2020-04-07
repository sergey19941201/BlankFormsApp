using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BlankFormsApp.Helpers
{
    public class Grouping<Key, ObjectType> : ObservableCollection<ObjectType>
    {
        public Key Name { get; private set; }
        public Grouping(Key name, IEnumerable<ObjectType> items)
        {
            Name = name;
            foreach (ObjectType item in items)
                Items.Add(item);
        }
    }
}