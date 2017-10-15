using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //Only lets you push if the top is smaller or equal to value being pushed. Also keeps the count of rejected items
    public class StackHanoi : Stack
    {
        private int totalRejected = 0;

        public StackHanoi():base("array"){}
        public StackHanoi(String s) : base(s) { }
        public int ReportRejected()
        {
            return totalRejected;
        }

        public override void Push(int val)
        {
            if (!IsEmpty() && val > Top()) {
                totalRejected++;
            }
            else {
                base.Push(val);
            }
        }
}
}
