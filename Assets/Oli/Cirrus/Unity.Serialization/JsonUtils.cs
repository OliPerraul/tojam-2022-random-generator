using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine;

namespace Cirrus.Unity.Serialization
{

    public static class JsonUtils
	{
        public static string SerializeScriptableObjects<T>(List<T> SO_List)
        {
            string result = "";
            foreach (T item in SO_List)
            {
                result += JsonUtility.ToJson(item) + ", ";
            }
            return result;
        }

        public static List<object> DeserializeScriptableObjects(string json_string, Type type)
        {            
            string[] stringSeparators = new string[] { "}," };
            List<object> result = new List<object>();
            string[] splitted = json_string.Split(stringSeparators, System.StringSplitOptions.None);
            for (int i = 0; i < splitted.Length - 1; i++)
            {
                string SO_string = splitted[i] + "}";
                Debug.Log(SO_string);
                //T itemBasic = (T)System.Activator.CreateInstance(typeof(T));                
                object obj = JsonUtility.FromJson(SO_string, type);
                result.Add(obj);
            }



            return result;
        }
    }
}
