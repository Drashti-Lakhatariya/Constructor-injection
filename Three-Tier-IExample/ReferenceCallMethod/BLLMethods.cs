using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Three_Tier_IExample.PLayer;

namespace Three_Tier_IExample.ReferenceCallMethod
{
    public class BLLMethods : IMethodBLL
    {
        private IBussLayer _objBLL;
        public BLLMethods(IBussLayer b)
        {
            _objBLL = b;
        }

        public void InsertData(string _name, string _gender, string _dob)
        {
            _objBLL.InsertData(_name, _gender, _dob);
        }

        public void UpdateData(string _name, string _gender, string _dob)
        {
            _objBLL.UpdateData(_name, _gender, _dob);
        }

        public void DeleteData(string _name)
        {
            _objBLL.DeleteData(_name);
        }

        public object SelectData()
        {
            return _objBLL.SelectData();
        }
        
    }
}