using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication6
{
    class CSV
    {
        public static void Read(string path,string rtext)
        {
            ArrayList Alt = new ArrayList(); 
            Dictionary<string, string> d = new Dictionary<string, string>();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            String line;
            string temp = string.Empty;
            string vartemp = string.Empty;

            while ((line = sr.ReadLine()) != null)
            {
                //MessageBox.Show(line);
                string[] a = line.Split(',');
                if (string.IsNullOrEmpty(a[0]))
                    continue;
                //1111string[] temp1 = Regex.Split(a[0], "_Alt", RegexOptions.IgnoreCase);
                string[] temp1 = Regex.Split(a[0], "_alter", RegexOptions.IgnoreCase);
                if (temp1.Length == 1)
                {
                    if (d.ContainsKey(a[0].Trim())) // True 
                    {
                        //d[temp] += "|" + a[2];
                    }
                    else
                    {
                        vartemp = a[2].Replace("\"", "").Trim();
                        //MessageBox.Show(a[2] + "\r\n" + vartemp);
                        d.Add(a[0].Trim(), vartemp);
                    }
                }
                else
                {
                    //MessageBox.Show(a[2]);
                    //1111if (a[2] != "null")//a[2] != "B0" && a[2] != "A0")
                    if (a[2].Trim() != "B" && a[2].Trim() != "A")
                    {
                        Alt.Add(temp1[0].Trim() + "_" + a[2].Trim() + "(" + temp1[0].Trim() + ")");
                        //MessageBox.Show(temp1[0] + "_" + a[2] + "(" + temp1[0] + ")");
                    }
                    else
                    {
                        if (d.ContainsKey(temp1[0].Trim())) // True 
                        {
                            //d[temp] += "|" + a[2];
                        }
                        else
                        {
                            //MessageBox.Show(temp1[0]);
                            d.Add(temp1[0].Trim(), "0");
                        }
                    }
                }
                a = null;
                temp1 = null;
            }
            sr.Close();
            sr.Dispose();

            //Var
            foreach (string v in d.Keys.ToArray())
            {
                string[] a = v.Split('/');
                if (a.Length > 1)
                {
                    d[a[0].Trim()] = d[v];
                    d.Remove(v);
                    //MessageBox.Show(v);
                }
            }

            string var = string.Empty;
            foreach (string v in d.Keys.ToArray())
            {
                var += "var " + v + " = '" + d[v] + "';" + "\r\n";
            }
            //MessageBox.Show(var);

            ////js摸版
            ////项目路径
            //string ProjectPath = Regex.Split(path, "database", RegexOptions.IgnoreCase)[0];
            //string[] ProjectName = ProjectPath.Split('\\');
            //MessageBox.Show(ProjectPath);
            //MessageBox.Show(ProjectName[ProjectName.Length - 2]);

            //sr = new StreamReader(ProjectPath + "JS\\" + ProjectName[ProjectName.Length - 2] + ".js"); //path是要读取的文件的完整路径
            //String str_read = sr.ReadToEnd(); //从开始到末尾读取文件的所有内容，str_read 存放的就是读取到的文本
            //sr.Close(); //读完文件记得关闭流
            //var += str_read;


            /////////////////////////
            string str = rtext;
            string k = string.Empty;
            string[] temp22 = str.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            int end = temp22.Length;
            //int start = 1 + richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);
            for (int i = 0; i < end - 1; i++)
            {
                if (temp22[i].Length > 0)
                {
                    if (temp22[i].Substring(0, 1) == "●")
                        break;
                    k += temp22[i] + "\r\n";
                }
            }
            var += k;

            //追加工
            for (int i = 0; i < Alt.Count; i++)
            {
                string a = Alt[i].ToString().Split('_')[0];
                //MessageBox.Show(a);
                if (d.ContainsKey(a)) // True 
                {
                    if (d[a] != "0")//追加工值=0时不调用
                    {
                        //MessageBox.Show(d[a]);
                        //MessageBox.Show(Alt[i].ToString());
                        sr = new StreamReader(@"C:\SID\alt\" + Alt[i].ToString().Split('(')[0] + ".js"); //path是要读取的文件的完整路径
                        String str_read = sr.ReadToEnd(); //从开始到末尾读取文件的所有内容，str_read 存放的就是读取到的文本
                        sr.Close(); //读完文件记得关闭流
                        //MessageBox.Show(str_read);
                        var += "\r\n" + str_read;
                    }
                }
            }

            //sat路径+模型颜色
            var += "\r\n" + "AGM.Modelling.SetColor( body1, 16/255, 78/255, 139/255 );";
            var += "\r\n" + "AGM.Modelling.SaveSat(\"C:\\\\SID\\\\SatTemp\\\\SatTemp.sat\");";

            //MessageBox.Show(var + str_read);
            SaveFileDialog sav = new SaveFileDialog();
            sav.Title = "请选择要保存的位置";
            sav.Filter = "文本文件|*.js";
            sav.InitialDirectory = @"C:\SID\";
            sav.ShowDialog();
            string stt = sav.FileName;
            if (stt == "")
                return;

            using (FileStream fil = new FileStream(stt, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] byt = new byte[1024];
                byt = Encoding.Default.GetBytes(var);
                fil.Write(byt, 0, byt.Length);
            }

            
            MessageBox.Show("OK");  


            //MessageBox.Show(var + str_read);
        }
    }
}
