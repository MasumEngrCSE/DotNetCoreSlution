using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Others
{
    public class TestListInitializer
    {

        public void ListInitialize()
        {
            List<TestCls> list1 = new List<TestCls>()
        {
            new TestCls(){ itemName = "A", vCount = 1 },
            new TestCls(){ itemName = "B", vCount = 2 }
        };
        }
    }





    public class TestCls
    {
        public string itemName { get; set; }
        public int vCount { get; set; }
    }
}
