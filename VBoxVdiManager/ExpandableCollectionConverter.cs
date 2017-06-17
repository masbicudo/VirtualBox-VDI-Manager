using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;

internal class ExpandableCollectionConverter : ExpandableObjectConverter
{
    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destType)
    {
        if (destType == typeof(string))
        {
            return "(Collection)";
        }
        return base.ConvertTo(context, culture, value, destType);
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
        IList collection = value as IList;
        PropertyDescriptorCollection pds = new PropertyDescriptorCollection(null);

        for (int i = 0; i < collection.Count; i++)
        {
            ExpandableCollectionPropertyDescriptor pd = new ExpandableCollectionPropertyDescriptor(collection, i);
            //pd.RefreshRequired += (sender, args) =>
            //{
            //    var notifyValueGivenParentMethod = context.GetType().GetMethod("NotifyValueGivenParent", BindingFlags.NonPublic | BindingFlags.Instance);
            //    notifyValueGivenParentMethod.Invoke(context, new object[] { context.Instance, 1 });
            //};
            pds.Add(pd);
        }
        // return the property descriptor Collection
        return pds;
    }
}
