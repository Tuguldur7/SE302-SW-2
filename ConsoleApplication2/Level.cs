﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Level
    {
        public int levelnumber {get;set;}
        public Problem problem;
        public Problem levelOne(int newXCoordinat)
        {
            problem = new Problem(newXCoordinat, 0, ConsoleColor.Blue, new string[] { "#", "#", "#", "#" });
            return problem;
        }
        public Problem levelTwo(int newXCoordinat)
        {
            problem = new Problem(newXCoordinat, 0, ConsoleColor.Blue, new string[] { "#", "#", "#", "#"});
            return problem;
        }
        public Problem levelThree(int newXCoordinat)
        {
            problem = new Problem(newXCoordinat, 0, ConsoleColor.Blue, new string[] { "#", "#", "#", "#"});
            return problem;
        }
    }
}
