using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSortTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = ListTester();
            List<string> sortedList = list.OrderBy(x => x).ToList();

            int indexOfSearchedCode = sortedList.IndexOf("Új...");
            string searchedCode = sortedList[indexOfSearchedCode];
            sortedList.Reverse();
            sortedList.Add(searchedCode);
            sortedList.Reverse();
            Console.WriteLine("First element {0}", searchedCode);
            Console.WriteLine("First element {0}", sortedList[0]);
            Console.ReadLine();
        }
        static void FirstExample()
        {
            // li.Sort((a, b) => a.CompareTo(b));
            // list.OrderBy(x => x).ToList();
            List<string> list = ListTester();
            //Console.WriteLine(list.IndexOf("Új..."));
            //list.Sort((a,b) => a.CompareTo(b));
            List<string> sortedList = list.OrderBy(x => x).ToList();
            Console.WriteLine("Before: " + sortedList[0]);
            int indexOfSearchedCode = sortedList.IndexOf("Új...");
            string searchedCode = sortedList[indexOfSearchedCode];
            sortedList.Insert(0, searchedCode);
            sortedList.RemoveAt(indexOfSearchedCode);
            Console.WriteLine("After: " + sortedList[0]);
            Console.WriteLine("First index: " + sortedList[1]);
            //Console.WriteLine(sortedList.IndexOf("Új..."));
            Console.WriteLine(sortedList[1]);
            Console.ReadKey();
        }
        static List<string> ListTester()
        {
            List<string> projectCodes = new List<string> { "Új...", "ALMERP1TA", "BUDMOP1LA", "TUKUTP1UT", "BIELOB1GY", "AGORAP1IR", "M30EFP1UT",
                                                           "ETEBEP1FE", "BIELOT1GY", "ZUGLOF1TF", "M30MEP1ME", "DEBCOP1GY", "BLE51F1TA",
                                                           "AVLCSP1FE", "VAHOTF1TF", "BIMUNB1TA", "LEATAP1LA", "AND47F1TA", "BLE51F1TA",
                                                           "DTIIGP1TA", "M30ENP1ME", "DEBCOP1GY", "ALPHAP1IR", "VAHOTF1TF", "BKONFP1FE",
                                                           "BMULTF1TF", "BIPORB1GY", "KERMOP1TA", "SOSZEB1IR", "ERDJ2B1JE", "KECSMP1LA",
                                                           "AND47F1TA", "TILAKP1FE", "VNT82B1EB", "BIPORT1GY", "BIELOB1GY", "BIPORB1GY",
                                                           "SOSZEB1IR", "DUNPEP1FE", "BALIGF1SA", "SOSZEB1IR", "BALIGF1SA", "83FOUP1UT",
                                                           "ZUGLOF1TR", "SZEKAP1HU", "TICSEP1LA", "ADPALP1TF", "G0716T1EB", "G0780T1EB",
                                                           "G0708T1EB", "G0262T1EB", "G0339T1EB", "G2000T1EB", "G0259T1EB", "G0351T1EB",
                                                           "G1999T1EB", "G0261T1EB", "NASTAP1ST", "ZMEZOF1TA", "PLAGAF1TA", "BALKEP1LA",
                                                           "BMULTF1KI", "VELZOP1LA", "FONTEP1TF", "VIABOB1TE", "PMZ34T1EB", "SOSMUB1LA",
                                                           "HEPORP1SA", "TP46MP1NE", "ELITPF2TA", "BALGAF1TA", "GERLIB1GY", "GERTEB1TF",
                                                           "GERHOB1SA", "GERBPB1GY", "GERWEB1SA", "GEABUB1CS", "GEABUB2CS", "GEKBUB1CS",
                                                           "GERHBB1GY", "GERTEB3GY", "GERTEB2GY", "GERBUB1CS", "GERFOB1GY", "FEWILP1LG",
                                                           "BMULTP1FE", "EVKSZP1FE", "RELEJP1LA", "BMULTP2FE", "KOFEBP1GY", "NOTINP1LA",
                                                           "M3BETB1GY", "ES50AF1LA", "G1586B1GY", "PMZ60T1EB", "SOBABP1UT", "VAHOTF2TF",
                                                           "GERREB1FU", "SALKOP1IS", "DREVIP1LA", "ZUGLOF1O1", "ZUGLOF1R1", "ZUGLOF2R2",
                                                           "ZUGLOF3R3", "KKLKBB1EL", "SOBOLP1EL", "ARTKBB1EL", "SZEPAP1SA", "UNIBAP1KI",
                                                           "0PN" };

            return projectCodes;
        }
    }
}
