﻿using PredicateDecorate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDecorate
{
    public class PredicatedDecoratorExample
    {
        private readonly IComponent component;

        public PredicatedDecoratorExample(IComponent component)
        {
            this.component = component;
        }

        public void Run()
        {
            component.Something();
        }
    }
}
