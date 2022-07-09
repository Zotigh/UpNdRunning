﻿/******************************************************
* Programmer: Lance Zotigh (lzotigh1@cnm.edu)
* Purpose: A simple program that calculates what the future depreciable value of an asset will be.
*******************************************************/

using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;

namespace ZotighP5_Cs_II_.Models
{
    public class SuccessfullyCalculatedResults
    {
        //initilizer
        private List<DeprecationStraightLine> calculatedResults = new List<DeprecationStraightLine>();
        //Getter and Settter
        public virtual List<DeprecationStraightLine> CalculatedResults
        {
            get { return calculatedResults; }
            set { calculatedResults = value; }
        }
    }
}

