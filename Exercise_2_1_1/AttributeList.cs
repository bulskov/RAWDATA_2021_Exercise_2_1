using System.Collections.Generic;


namespace Exercise2_1
{
    public class AttributeList
    {
        private readonly List<string> attributes;

        public AttributeList()
        {
            attributes = new List<string>();
        }

        public AttributeList(string attr)
        {
            attributes = new List<string>(attr.Split(';', ',', ':', ' '));
        }

        public AttributeList(AttributeList attrList)
        {
            attributes = new List<string>(attrList.attributes);
        }

        public void Add(string attr)
        {
            if (!attributes.Contains(attr))
                attributes.Add(attr);
        }

        public void Add(AttributeList attrList)
        {
            foreach (var attribute in attrList.attributes)
            {
                Add(attribute);
            }
        }

        public int Count => attributes.Count;

        public string this[int i] => attributes[i];

        public bool Contains(AttributeList attrList)
        {
            foreach (var a in attrList.attributes)
            {
                if (!attributes.Contains(a))
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsSupersetOf(AttributeList other)
        {
            if (other.Count > Count) return false;
            for (var i = 0; i < other.Count; i++)
            {
                if (attributes[i] != other[i])
                {
                    return false;
                }
            }
            return true;
        }


        public static AttributeList operator +(AttributeList attrList1, AttributeList attrList2)
        {
            var tmp = new AttributeList(attrList1);
            tmp.attributes.AddRange(attrList2.attributes);
            return tmp;
        }

        public override string ToString()
        {
            return string.Join(",", attributes);
        }
    }
}
