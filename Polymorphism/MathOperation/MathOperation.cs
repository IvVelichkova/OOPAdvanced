﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MathOperation
{
    /*Add(int, int): int
    Add(double, double, double): double
    Add(decimal, decimal, decimal): decimal */
    public int Add(int a, int b)
    {
        return a + b;
    }
    public double Add(double a, double b,double c)
    {
        return a + b+c;
    }
    public decimal Add(decimal a, decimal b, decimal c)
    {
        return a + b+c;
    }
}

