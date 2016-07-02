﻿using Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    public class ComponentClient
    {
        private readonly Lazy<IComponent> component;

        public ComponentClient(Lazy<IComponent> component)
        {
            this.component = component;
        }

        public void Run()
        {
            component.Value.Something();
        }

    }
}
