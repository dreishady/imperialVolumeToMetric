//Author: Andrei Rico
//Purpose: Main class library
//Known bugs: N/A
//Date: 12/10/2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ImperialVolumeToMetric1
{
    public class ImperialVolumeToMetric
    {
        static private Dictionary<string, string> myValues;

        // get the values from the xml file
        public static Dictionary<string, string> writeDictionary()
        {

            if (myValues == null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("D:\\ImperialVolumeToMetric.xml");
                myValues = new Dictionary<string, string>();

                foreach (XmlNode node in doc.DocumentElement)
                {
                    string converting = "";
                    string factor = "";

                    foreach (XmlNode inode in node)
                    {
                        if (inode.Name == "convert")
                        {
                            if (inode.InnerText != null)
                            {
                                converting = inode.InnerText;


                            }
                        } // end of the convert

                        if (inode.Name == "factor")
                        {
                            if (inode.InnerText != null)
                            {
                                factor = inode.InnerText;


                            }

                        }

                    }
                    myValues.Add(converting, factor);
                }
            }

            return myValues;
        } //end of constructor


        public static float flOz(float fluid)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }


            string value = "0.0";
            if (myValues.ContainsKey("flOz"))
            {
                value = myValues["flOz"];

            }

            return fluid * float.Parse(value);
        }
        public static float gillToMl(float gill)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("gillT"))
            {
                value = myValues["gillT"];

            }

            return gill * float.Parse(value);
        }
        public static float cupToMl(float cup)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("cupToMl"))
            {
                value = myValues["cupToMl"];

            }

            return cup * float.Parse(value);

        }
        public static float pintToGill(float pintG)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("pintToGill"))
            {
                value = myValues["pintToGill"];

            }

            return pintG * float.Parse(value);
        }

        public static float pintToFlOz(float pintFl)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("pintToFlOz"))
            {
                value = myValues["pintToFlOz"];

            }

            return pintFl * float.Parse(value);
        }
        public static float quartToMl(float quart)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("quartToMl"))
            {
                value = myValues["quartToMl"];

            }

            return quart * float.Parse(value);
        }
        public static float gallonToQuart(float gallQ)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("gallonToQuart"))
            {
                value = myValues["gallonToQuart"];

            }

            return gallQ * float.Parse(value);
        }
        public static float gallonToPint(float gallP)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("gallonToPint"))
            {
                value = myValues["gallonToPint"];

            }

            return gallP * float.Parse(value);
        }
        public static float barrelToLitres(float barrel)
        {
            if (myValues == null)
            {
                Dictionary<string, string> myvalue1 = writeDictionary();
            }

            string value = "0.0";
            if (myValues.ContainsKey("barrelToLitres"))
            {
                value = myValues["barrelToLitres"];

            }

            return barrel * float.Parse(value);
        }

    }
}