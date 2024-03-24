using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orphans.Code
{
    public static class ConfigrationonObjectManager
    {//حقن على مستوى المشروع
        private static Dictionary<string, object> ObjectList = new Dictionary<string, object>();

        //تسجيل الكائنات
        public static void Register(string ObjectName,object ObjectValue)
        {
            ObjectList.Add(ObjectName,ObjectValue);
        }
        //استدعاء الكائنات
        public static object GetObject(string ObjectName)
        {
            return ObjectList[ObjectName];
        
        
        }


    }
}
