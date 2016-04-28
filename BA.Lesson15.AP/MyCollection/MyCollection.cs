using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.AP.Examples.MyCollection
{
    
    class MyCollection : IEnumerable<int>
    {

        //public event EventHandler<ErrorDividerEventArgs> ErrorDividerReceived;

        private MyCollectionSettings _myCollectionSettings;        

        public MyCollection(MyCollectionSettings myCollectionSettings) {
            _myCollectionSettings = myCollectionSettings;
        }        
        
        public IEnumerator<int> GetEnumerator() {
            for (int i = _myCollectionSettings.OurBottomLimit; i <= _myCollectionSettings.OurTopLimit; i++)
            {
                if (i % _myCollectionSettings.Divider == 0)
                    yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}
