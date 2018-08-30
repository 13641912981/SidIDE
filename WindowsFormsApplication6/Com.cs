using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    class Com
    {
        public string getCom(string com,int id)
        {
            string[] key = com.Split('(');
            if (key.Length > 1)
            {
                string[] val = key[1].Split(',');
                switch (key[0])
                {
                    case "圆柱":
                        return Cylinder(val[0], val[1].Substring(0, val[1].Length - 1), "Feature" + id.ToString());
                    case "求和":
                        return Unite(val[0], val[1].Substring(0, val[1].Length - 1));
                    case "Punches":
                        return Punches(val[0], val[1], val[2], val[3], val[4], val[5].Substring(0, val[5].Length - 1));
                }
            }
            return com + "\r\n";
        }

        //圆柱
        string Cylinder(string D,string L,string bodyId)
        {
            string a = "\r\nvar result;\r\n";
            a += String.Format("var {0}= AGM.Object();\r\n",bodyId);
            a += "var headBottom = AGM.Position( 0, 0, 0 );\r\n";
            a += String.Format("var headTop = AGM.Position( 0, 0, {0} );\r\n",L);
            a += String.Format("result = AGM.Modelling.CreateSolidCylinder( headBottom, headTop, {0}, {1} );\r\n", D, bodyId);
            a += "if( !result )\r\n";
            a += "{ ExitProgram; }\r\n";
            return a;
        }

        //求和
        string Unite(string body1, string body2)
        {
            return String.Format("\r\nAGM.Modelling.BoolUnite( {0}, {1} );\r\n", body1, body2);
        }

        //求差

        //Punches
        string Punches(string H, string T, string D, string L, string P, string B)
        {
            string a = "AGM.Document.LoadScript(\"C:\\\\SID\\\\Script\\\\Feature.js\");\r\n";
            a += "var result;\r\n";
            a += "var main= AGM.Object();\r\n";
            a += String.Format("Cylinder({0},{1},main);\r\n", H, T);
            a += "var shank= AGM.Object();\r\n";
            a += String.Format("Cylinder({0},{1},shank);\r\n", D, L + "-" + B);
            a += "var tip_p= AGM.Object();\r\n";
            a += String.Format("Cylinder({0},{1},tip_p);\r\n", P, L);
            a += "Unite( main, shank );\r\n";
            a += "Unite( main, tip_p );\r\n";
            return a;
        }

    }

    public class ComTransFrom
    {
        public static string _F(string com)
        {
            string[] temp1 = com.Split('+');      
            if (temp1.Length > 1)
            {
                com = string.Empty;
                com = string.Format("_F({0})", temp1[0]);
                for(int i=1;i<temp1.Length;i++)
                {
                    com += string.Format(" + _F({0})", temp1[i]);
                }
            }
            return com;
        }
    }
}
