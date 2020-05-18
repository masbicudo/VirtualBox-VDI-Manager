using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace VBoxVdiManager
{
    public class ExpandableCollectionPropertyDescriptor : PropertyDescriptor
    {
        private IList _collection;

        private readonly int _index = -1;

        internal event EventHandler RefreshRequired;

        public ExpandableCollectionPropertyDescriptor(IList coll, int idx) : base(GetDisplayName(coll, idx), null)
        {
            _collection = coll;
            _index = idx;
        }

        public override bool SupportsChangeEvents
        {
            get { return true; }
        }

        private static string GetDisplayName(IList list, int index)
        {

            return "[" + index + "]  " + CSharpName(list[index].GetType());
        }

        private static string CSharpName(Type type)
        {
            var sb = new StringBuilder();
            var name = type.Name;
            if (!type.IsGenericType)
                return name;
            sb.Append(name.Substring(0, name.IndexOf('`')));
            sb.Append("<");
            sb.Append(string.Join(", ", type.GetGenericArguments()
                .Select(CSharpName)));
            sb.Append(">");
            return sb.ToString();
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return new AttributeCollection(null);
            }
        }

        public override bool CanResetValue(object component)
        {

            return true;
        }

        public override Type ComponentType
        {
            get
            {
                return _collection[_index].GetType();
            }
        }

        public override object GetValue(object component)
        {
            OnRefreshRequired();

            return _collection[_index];
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override string Name
        {
            get { return _index.ToString(); }
        }

        public override Type PropertyType
        {
            get { return _collection[_index].GetType(); }
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

        public override void SetValue(object component, object value)
        {
            _collection[_index] = value;
        }

        protected virtual void OnRefreshRequired()
        {
            var handler = RefreshRequired;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}