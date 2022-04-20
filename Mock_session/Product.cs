using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mock_session
{
    internal class Product
    {
        public int PId
        {
            get { return pId; }
            set { pId = value; }

        }
        public String PName
        {
            get { return pName; }
            set { pName = value; }

        }

        public string PCataegory
        {
            get { return pCataegory; }
            set { pCataegory = value; }

        }
       
        int pId;
        string pName;
        string pCataegory;

        public Product( int id,string name,string category)
        {
            pId = id;
            pName = name;
            pCataegory = category;

        }
        public override string ToString()
        {
            return "product id is " + pId + "name of the product is " + pName + " category of the product " + pCataegory;
        }


    }
}
