﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit
{
    class PropertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }

    enum PropertyType
    {
        Id,
        Name,
        ClassName
    }
}