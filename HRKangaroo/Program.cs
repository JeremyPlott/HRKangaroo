using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HRKangaroo {
    class Program {
        static void Main(string[] args) {

            var x1 = 0;
            var v1 = 3;
            var x2 = 4;
            var v2 = 2;

            var canPass = (v1 > v2);
            var intersect = false;
            if(canPass) {
                intersect = (x1 - x2) % (v2 - v1) == 0;
            }
            return (intersect ? "YES" : "NO");
        }
    }
}
