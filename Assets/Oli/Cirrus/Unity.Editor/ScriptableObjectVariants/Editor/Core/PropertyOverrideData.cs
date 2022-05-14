using System;

namespace Cirrus.Unity.ScriptableObjectVariants
{
    [Serializable]
    internal struct PropertyOverrideData
    {
        public string propertyPath;
        public bool locked;

        public PropertyOverrideData(string propertyPath)
        {
            this.propertyPath = propertyPath;
            locked = false;
        }
        
        public static implicit operator string(PropertyOverrideData data)
        {
            return data.propertyPath;
        }
        
        public static implicit operator PropertyOverrideData(string propertyPath)
        {
            return new PropertyOverrideData(propertyPath);
        }

        public override bool Equals(object obj)
        {
            if (obj is PropertyOverrideData otherData)
                return otherData.propertyPath == propertyPath;
            return false;
        }

        public override int GetHashCode()
        {
            return propertyPath.GetHashCode();
        }
    }
}
