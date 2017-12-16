using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class init
    {
        public static List<string> templist = new List<string> { "Anti Diarrheal", "Bromday", "Betadine", "Methylprednisolone", "Oxcarbazepine", "EQUALINE", "HyQvia", "Serotonin", "Zolpidem Tartrate", "Analpram Advanced", "good sense night time", "Tacrolimus", "ANTIBACTERIAL", "Diaper Rash", "Sun Essential", "Calamine Phenolated Topical Suspension", "MedPride", "Ammonia Pad", "Dapsone", "LEADER HYDROCORTISONE", "Acetazolamide", "Lymph 1", "ANTIBACTERIAL FOAMING", "Pramipexole Dihydrochloride", "Lisinopril with Hydrochlorothiazide", "SkinTx Acne Treatment System", "Sulwhasoo Lumitouch Foundation", "Ditropan", "FENTANYL", "head and shoulders", "DEFEND Sinus", "Tandem OB", "Haloperidol", "CORYLUS AMERICANA POLLEN", "Isopropyl alcohol Prep Pad", "Nikzon", "EXSEL SPORT", "Tandem Plus", "Fentanyl Citrate", "Rough Pigweed", "Shopko Antibacterial Foaming Hand Cleanser", "bacitracin zinc", "neomycin sulfate and polymyxin b sulfate", "Amlodipine Besylate and Benazepril Hydrochloride", "Amlodipine Besylate", "Fludarabine Phosphate", "Opana", "Imipramine Pamoate", "Multitrace -4 Pediatric" };
        public Stack<string> phiLibrarymedication = new Stack<string>(templist);
        public static List<string> templist2 = new List<string> { "enibley0@posterous.com", "cbedrosian1@cnn.com", "jhocking2@phpbb.com", "", "lspybey3@japanpost.jp", "ebatch4@histats.com", "fgroll5@sciencedirect.com", "avannacci6@cyberchimps.com", "akupka7@shareasale.com", "fnockalls8@nhs.uk", "cfoyle9@fotki.com", "mcockadaya@canalblog.com", "aheggisonb@ezinearticles.com", "kheistermannc@creativecommons.org", "iheadingtond@google.pl", "bjurcae@sitemeter.com", "rberwickf@blogs.com", "ckleinmintzg@phpbb.com", "asleefordh@wordpress.com", "bpoetzi@dmoz.org", "vcavillaj@bloomberg.com", "sorsik@vkontakte.ru", "lridlerl@bandcamp.com", "emaymondm@amazon.co.uk", "wbryentonn@buzzfeed.com", "ssherlando@cbsnews.com", "cbalderstonep@google.ru", "mbentjensq@cdbaby.com", "kmcsparranr@plala.or.jp", "tcastanhos@chicagotribune.com", "mguillout@simplemachines.org", "jclayworthu@zdnet.com", "hsomerscalesv@twitpic.com", "jmartlandw@chronoengine.com", "bwestleyx@vkontakte.ru", "drobecony@seattletimes.com", "hfavelz@cdc.gov", "bpontain10@cornell.edu", "nbraam11@columbia.edu", "kbromley12@discuz.net", "gantoshin13@bbc.co.uk", "slikely14@rakuten.co.jp", "lscrivener15@artisteer.com", "dmosedill16@domainmarket.com", "jgumbrell17@google.com.br", "hhaughin18@answers.com", "pkarlolak19@nationalgeographic.com", "claurenceau1a@google.plh", "stamp1b@nifty.com", "nbraybrook1c@latimes.com", "rsywell1d@smugmug.com", "dtofful1e@live.com", "epestricke1f@wired.com", "gsailes1g@youtu.be", "pkeightley1h@paginegialle.it", "erayson1i@jiathis.com", "swattins1j@wikimedia.org", "gtimmens1k@marriott.com", "tbaldrey1l@marriott.com", "tveldman1m@cornell.edu", "bdorrity1n@sina.com.cn", "fmiller1o@123-reg.co.uk", "jpadkin1p@ezinearticles.com", "bbessell1q@state.gov", "adomerq1r@wiley.com", "ajenkerson1s@flickr.com", "cmacnucator1t@ycombinator.com", "cclayworth1u@admin.ch", "fguiet1v@globo.com", "ldeldello1w@topsy.com", "aelphick1x@scribd.com", "molekhov1y@ox.ac.uk", "afarbrace1z@gov.uk", "cchopy20@utexas.edu", "dschwant21@51.la", "munsworth22@mtv.com", "rdunford23@twitter.com", "scalender24@wired.com", "fmitcheson25@bravesites.com", "mcockayme26@de.vu", "bkillby27@furl.net", "cdowner28@oakley.com", "ctring29@yale.edu", "enann2a@apple.com", "ibrun2b@ocn.ne.jp", "tredemile2c@technorati.com", "rholburn2d@home.pl", "wwilstead2e@marketwatch.com", "atoffts2f@phpbb.com", "rscafe2g@github.com", "qjachimiak2h@diigo.com", "nmellows2i@loc.gov", "dwenger2j@tinyurl.com", "dwank2k@washington.edu", "nhugues2l@eepurl.com", "rwhitsey2m@samsung.com", "awestfrimley2n@acquirethisname.com", "bguilloux2o@constantcontact.com", "tzorzetti2p@mapy.cz", "pruffler2q@shutterfly.com", "xcordeix2r@ucoz.com" };
        public Stack<string> phiLibraryemail = new Stack<string>(templist2);

    }
    class Program
    {
        static List<string> idColumn = new List<string> { "id", "name", "date", "patientNumber", "jabber", "ticket", "Department", "Description" };
        static List<int> idSize = new List<int> { 2, 25, 6, 11, 50, 15, 40, 100 };
        static tableGenerator blank = new tableGenerator(50000, idSize);
        static insertTool phiDataTool = new insertTool();
        static init init = new init();
        static void Main(string[] args)
        {
            while (init.phiLibraryemail.Count() > 20) { init.phiLibraryemail.Pop(); }
            while (init.phiLibrarymedication.Count() > 20) { init.phiLibrarymedication.Pop(); }
            Stack<string> ssnLibrary = phiDataTool.ssnGen(20);
            Stack<int> xycordssn = phiDataTool.phiYGen(3);
            Stack<string> medLibrary = init.phiLibrarymedication;
            Stack<int> xycordmed = phiDataTool.phiYGen(7);
            Stack<string> mrnLibrary = phiDataTool.mrnGen(20);
            Stack<int> xycordmrn = phiDataTool.phiYGen(6);
            Stack<string> phoneLibrary = phiDataTool.phoneGen(20);
            Stack<int> xycordphone = phiDataTool.phiYGen(5);
            Stack<string> emailLibrary = init.phiLibraryemail;
            Stack<int> xycordemail = phiDataTool.phiYGen(4);

            List<string> a = phiDataTool.stackToList(emailLibrary);
            List<string> b = phiDataTool.stackToList(ssnLibrary);
            List<string> c = phiDataTool.stackToList(mrnLibrary);
            List<string> d = phiDataTool.stackToList(phoneLibrary);
            List<string> e = phiDataTool.stackToList(medLibrary);
            List<List<string>> phicsv = new List<List<string>> { c, e, b, d, a };
            List<string> phiIdcolumn = new List<string> { "medical record number", "medication", "social security number", "phone", "email" };
            string txtphi = blank.csvConstructor(phiIdcolumn, phicsv);
            blank.csvToTxt(txtphi);
            System.IO.File.WriteAllText(@"C:\Users\sanlesso\Desktop\phiInsert.csv", txtphi);
            //


            List<List<string>> table = blank.rowGenerator();
            System.Diagnostics.Debug.WriteLine("table complete phi start");
            table = phiDataTool.phiInsert(table, xycordssn, ssnLibrary);
            table = phiDataTool.phiInsert(table, xycordmrn, mrnLibrary);
            table = phiDataTool.phiInsert(table, xycordmed, medLibrary);
            table = phiDataTool.phiInsert(table, xycordphone, phoneLibrary);
            table = phiDataTool.phiInsert(table, xycordemail, emailLibrary);
            System.Diagnostics.Debug.WriteLine("phi complete csv start");
            string txt = blank.csvConstructor(idColumn, table);
            System.Diagnostics.Debug.WriteLine("csv complete txt start");
            
            blank.csvToTxt(txt);
            System.Diagnostics.Debug.WriteLine("txt complete");

        }
        public class insertTool
        {
            Random rand = new Random();
            public List<List<string>> phiInsert(List<List<string>> table, Stack<int> phiXY, Stack<string> phiData)// is fead from the generators below
            {
                System.Diagnostics.Debug.WriteLine("XXXX");
                for (int ind = 0; ind < phiXY.Count;)
                {
                    int a = phiXY.Pop();
                    int b = phiXY.Pop();
                    string c = phiData.Pop();
                    System.Diagnostics.Debug.WriteLine(c);
                    table[a][b] = c;
                }
                return table;
            }
            public Stack<string> phiDataRandomizer(List<string> phiLibrary)
            {
                List<int> exclude = new List<int>();
                Stack<string> library = new Stack<string>();
                for (int i = 0; i < 20; i++)//i<20 is the count of how many inserts there are.
                {
                    int index = rand.Next(phiLibrary.Count);
                    if (exclude.Exists(num => num == index)) { i--; }
                    else
                    {
                        library.Push(phiLibrary[index]);
                        exclude.Add(index);
                    }
                }
                return library;
            }
            public Stack<int> phiYGen(int x)
            {
                Stack<int> XYCord = new Stack<int>(200);
                int min = 0;
                int max = 10000;
                for (int i = 0; i < 5; i++)// i<5 * j<4 = 20 determins how many intersects
                {
                    for (int j = 0; j < 4; j++) { XYCord.Push(x); XYCord.Push(rand.Next(min, max)); };
                    //System.Diagnostics.Debug.WriteLine((min.ToString()+"<min"), max.ToString());
                    min += 10000; max += 10000;
                }
                return XYCord;
            }
            public Stack<string> ssnGen(int size)
            {
                Stack<string> librarySSN = new Stack<string>(); ;

                for (int i = 0; i < size; i++)
                {
                    List<int> ssn = new List<int>();
                    ssn.Add(rand.Next(100, 999));
                    ssn.Add(rand.Next(10, 99));
                    ssn.Add(rand.Next(1000, 9999));
                    string example = string.Join("-", ssn);
                    //System.Diagnostics.Debug.WriteLine(example);
                    librarySSN.Push(example);

                }
                return librarySSN;

            }
            public Stack<string> mrnGen(int size)
            {
                Stack<string> libraryMrn = new Stack<string>(); ;

                for (int i = 0; i < size; i++)
                {
                    List<int> mrn = new List<int>();
                    mrn.Add(rand.Next(1, 999));
                    mrn.Add(rand.Next(1000, 9999));
                    string example = string.Join("", mrn);
                    //System.Diagnostics.Debug.WriteLine(example);
                    libraryMrn.Push(example);

                }
                return libraryMrn;

            }

            public Stack<string> phoneGen(int size)
            {
                Stack<string> libraryphone = new Stack<string>(); ;

                for (int i = 0; i < size; i++)
                {
                    List<int> phone = new List<int>();
                    phone.Add(rand.Next(1, 999));
                    phone.Add(rand.Next(100, 999));
                    phone.Add(rand.Next(1000, 9999));
                    string example = string.Join("", phone);
                    //System.Diagnostics.Debug.WriteLine(example);
                    libraryphone.Push(example);

                }
                return libraryphone;
            }
            public List<string> stackToList(Stack<string> phistack)
            {
                string[] temp = new string[phistack.Count];
                phistack.CopyTo(temp, 0);
                List<string> forCSVconstructor = new List<string>();
                for (int i = 0; i < phistack.Count; i++)
                {
                    forCSVconstructor.Add(temp[i]);
                }
                return forCSVconstructor;
            }
        }
        public class tableGenerator
        {
            StringBuilder stringbuild = new StringBuilder();
            Random rand = new Random();
            public int rowNumber;
            public List<int> fieldValues;
            public tableGenerator(int rows, List<int> fieldvalues)
            {
                rowNumber = rows;
                fieldValues = fieldvalues;
            }



            //include the inserter and the phi data generator
            public string csvConstructor(List<string> idColumn, List<List<string>> table)
            {
                for (int id = 0; id < idColumn.Count; id++)
                {
                    if (id != 0) { stringbuild.Append(","); }
                    stringbuild.Append(idColumn[id]);
                }
                stringbuild.Append("\n");
                int count = 0;
                foreach (List<string> row in table)
                {
                    count++;
                    //foreach (string x in row) { System.Diagnostics.Debug.WriteLine(row.Count(), "csvconstruct"); }
                    //foreach (string x in row) { System.Diagnostics.Debug.WriteLine(x,"csvconstruct");}
                    for (int x = 0; x < row.Count; x++)
                    {
                        if (x != 0) { stringbuild.Append(","); }
                        stringbuild.Append(row[x]);

                    }
                    stringbuild.Append("\n");
                }
                string csvConstruct = stringbuild.ToString();
                stringbuild.Clear();
                return csvConstruct;

            }
            public void csvToTxt(string txt)
            {
                System.IO.File.WriteAllText(@"C:\Users\sanlesso\Desktop\csv.csv", txt);
            }

            public List<List<string>> rowGenerator()
            {
                List<List<string>> test = new List<List<string>>();
                for (int i = 0; i < rowNumber; i++)
                {
                    var value = columnGenerator();

                    test.Add(value);
                  
                }

                return test;
            }
            public List<string> columnGenerator()
            {
                int rowSize = fieldValues.Count;
                List<string> test = new List<string>();
                for (int i = 0; i < rowSize; i++)
                {
                    int fieldSize = fieldValues[i];
                    test.Add(fieldGenerator(fieldSize));
                }
                return test;
            }
            public string fieldGenerator(int fieldSize)
            {
                for (int i = 0; i < fieldSize; i++)
                {
                    stringbuild.Append(charGenerator());
                }
                string construct = stringbuild.ToString();
                stringbuild.Clear();
                return construct;
            }
            public String charGenerator()
            {
                int next = rand.Next(65, 90);
                char utcChar = Convert.ToChar(next);
                string charecter = utcChar.ToString();
                return charecter;

            }



        }
    }

}
