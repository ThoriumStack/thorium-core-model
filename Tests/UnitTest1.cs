using System;
using System.Collections.Generic;
using System.Linq;
using MyBucks.Core.Model;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBaseContainment()
        {
           

            CallerMethod();
            return;
        }

        public void CallerMethod()
        {
            var lst = new MyContainer<int>
            {
                MyList = new List<int> { 1,2,3 }
            };
            
            GetObjectList(lst);
        }

        public void GetObjectList(MyContainerBase x)
        {
            var lst = (List<object>) x.MyObjectlist;
            
            
        }

        public abstract class MyContainerBase
        {
            public List<object> MyObjectlist { get; set; }
        }
        
        public class MyContainer<T> : MyContainerBase
        {
            public List<T> MyList
            {
                get { return base.MyObjectlist.Cast<T>(); }
                set { base.MyObjectlist = value; }
            }
        }
    }
}