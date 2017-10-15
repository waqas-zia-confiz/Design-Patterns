using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class SongComponent
    {

        public virtual void Add(SongComponent c) {
            throw new NotSupportedException();
        }
        public virtual void Remove(SongComponent c) {
            throw new NotSupportedException();
        }
        public virtual void Display() {
            throw new NotSupportedException();
        }
        public virtual SongComponent GetComponent(int componentIndex) {
            throw new NotSupportedException();
        }
        public virtual string GetComponentName() {
            throw new NotSupportedException();
        }
        public virtual string GetBandName() {
            throw new NotSupportedException();
        }
    }
}
