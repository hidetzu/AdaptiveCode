using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class CompositeComponent : IComponent
    {
        private ICollection<IComponent> children;

        public CompositeComponent()
        {
            children = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            children.Add(component);
        }

        public void Remove(IComponent component)
        {
            children.Remove(component);
        }


        public void Something()
        {
            foreach(var child in children)
            {
                child.Something();
            }
        }
    }
}
