using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizatorBloodWars
{
    public partial class Form1 : Form
    {
        // temp values
        public string[,] z1temp = new string[2000,3];
        public string z2temp = null;
        public string z3temp = null;
        public string z4temp = null;
        public string z5temp = null;
        public string[] z6temp = new string[2000];
        public string[] z7temp = new string[2000];

        // which was clicked
        bool which = false;

        //items from text box
        public string[] CopyiedItems = new string[4000];

        // items from which new items were connected
        public string[,] preffBeforeItem = new string[2000, 3];
        public string[,] rodzajBeforeItem = new string[2000, 3];
        public string[,] suffBeforeItem = new string[2000, 3];

        // end connections
        public string[] preffEndConnection = new string[2000];
        public string[] rodzajEndConnection = new string[2000];
        public string[] suffEndConnection = new string[2000];

        // Loaded files
        public string[,] preffConnections = new string[2000,3];
        public string[,] rodzajConnections = new string[2000,3];
        public string[,] suffConnections = new string[2000,3];

        // indextes for colections
        int preffindex = 0;
        int nazwaindex = 0;
        int suffindex = 0;

        // for items selected from comboboxes
        public string selectedPref;
        public string selectedNazwa;
        public string selectedSuf;

        // colection of items selected from comboboxtes
        public String[] selectedPreffixes = new String[2000];
        public String[] selectedNazwy = new String[2000];
        public String[] selectedSuffixes = new String[2000];

        // colection of items choosen by checkBoxes
        public String[] checkPreffixes = new String[2000];
        public String[] checkNazwy = new String[2000];
        public String[] checkSuffixes = new String[2000];


        // items to comboboxes
        public String[] itemek = {"Wybierz","Hełmy", "Zbroje", "Amulety", "Pierścienie",
                            "Spodnie","Bronie dwuręczne", "Bronie dystansowe dwuręczne",
                            "Bronie jednoręczne", "Bronie palne dwuręczne",
                            "Bronie palne jednoręczne"};
        public String[] helm = {"Śmiercionośna", "Bojowa","Elegancka","Krwawa",
                            "Kuloodporna","Kunsztowny","Leniwa","Magnetyczny",
                            "Ozdobna","Pomocna","Rogata","Runiczna","Rytualna",
                            "Szamańska","Szturmowa","Tygrysia","Utwardzany",
                            "Wzmocniona","Złośliwa"};
        public String[] rodzajHelmu = {"Brak","Bandana","Czapka","Hełm","Kapelusz","Kask",
                            "Kominiarka","Korona","Maska","Obręcz","Opaska"};
        public String[] suffHelmu = { "Brak", "Adrenaliny", "Gladiatora", "Kary",
                            "Krwi", "Magii", "Mocy", "Narkomana", "Ochrony", "Pasterza",
                            "Podróżnika", "Prekognicji", "Przezorności", "Skorupy Żółwia",
                            "Smoczej Łuski", "Słońca", "Wieszcza", "Wytrzymałości", "Zmysłów" };
        public String[] zbroja = {"Brak","Ćwiekowana","Łowiecka","Łuskowa","Śmiercionośna",
                            "Bojowa","Elfia","Giętka","Krwawa","Kuloodporna",
                            "Lekka","Płytowa","Runiczna","Szamańska","Tygrysia",
                            "Władcza","Wzmocniana"};
        public String[] rodzajZbroi = {"Brak","Gorset","Kolczuga","Kamizelka",
                            "Kurtka","Marynarka","Pełna Zbroja","Peleryna","Smoking",
                            "Zbroja Warstwowa"};
        public String[] suffZbroi = {"Brak","Adepta","Adreanaliny","Centuriona",
                            "Grabieżcy","Gwardzisty","Kaliguli","Kobry","Mistrza",
                            "Narkomana","Odporności","Orchidei","Siłacza",
                            "Siewcy śmierci","Skorupy żółwia","Strażnika","Szermierza",
                            "Szybkości","Uników","Złodzieja","Zabójcy"};
        public String[] preffixSpodnie = {"Aksamitne","Elfi","Giętkie","Kolcze",
                            "Kompozytowe","Krwawe","Krótkie","Kuloodporne","Lekkie",
                            "Pancerne","Pikowane","Runiczne","Szamańskie","Tygrysie",
                            "Wzmocnione","Ćwiekowane","Śmiercionośny"};
        public String[] rodzajSpodnie = { "Kilt", "Spodnie", "Spódnica", "Szorty" };
        public String[] suffixSpodnie ={"Cichych Ruchów","Handlarza Bronią","Inków",
                            "Narkomana","Nocy","Pasterza","Przemytnika","Rzezimieszka",
                            "Siłacza","Skrytości","Słońca","Tropiciela","Uników",
                            "Węża","Łowcy Cieni"};
        public String[] preffixPierscien ={"Archaiczny","Czarny","Diamentowy","Dystyngowany",
                            "Elastyczny","Gwiezdny","Hipnotyczny","Jastrzębi",
                            "Kardynalski","Miedziany","Mściwy","Nekromancki",
                            "Niedzwiedzi","Pajęczy","Plastikowy","Platynowy",
                            "Przebiegły","Rubinowy","Spaczony","Srebny","Szmaragdowy",
                            "Słoneczny","Tańczący","Twardy","Tytanowy","Zdradziecki",
                            "Zwierzęcy","Złoty"};
        public String[] rodzajPierscien = { "Bransoleta", "Pierścień", "Sygnet" };
        public String[] suffixPierscien ={"Celności","Geniuszu","Koncentracaji","Krwi",
                            "Lewitacji","Lisa","Mądrości","Młodości","Przebiegłości",
                            "Siły","Szaleńca","Szczęścia","Sztuki","Twardej Skóry",
                            "Urody","Wilkołaka","Występku","Władzy","Łatwości"};
        public String[] preffixAmulet ={"Archaiczny","Czarny","Diamentowy","Dystyngowany",
                            "Elastyczny","Gwiezdny","Hipnotyczny","Jastrzębi",
                            "Kardynalski","Miedziany","Mściwy","Nekromancki",
                            "Niedzwiedzi","Pajęczy","Plastikowy","Platynowy",
                            "Przebiegły","Rubinowy","Spaczony","Srebny",
                            "Szmaragdowy","Słoneczny","Tańczący","Twardy","Tytanowy",
                            "Zdradziecki","Zwierzęcy","Złoty"};
        public String[] rodzajAmulet = { "Amulet", "Apaszka", "Krawat", "Naszyjnik", "Łańcuch" };
        public String[] suffixAmulet ={"Celności","Geniuszu","Koncentracaji","Krwi",
                            "Lewitacji","Mądrości","Młodości","Pielgrzyma",
                            "Przebiegłości","Siły","Szaleńca","Szczęścia","Sztuki",
                            "Twardej Skóry","Urody","Wilkołaka","Występku","Władzy",
                            "Zdolności","Łatwości"};
        public String[] preffixBiala1h = { "Antyczna", "Demoniczna", "Jadowita",
                            "Kościana", "Kryształowa", "Kąsająca", "Lekka", "Mistyczna",
                            "Okrutna", "Opiekuńcza", "Ostra", "Przeklęta",
                            "Przyjacielska", "Szybka", "Wzmacniająca", "Zabójcza",
                            "Zatruta", "Zwinna", "Zębata", "Świecąca" };
        public String[] rodzajBiala1h ={"Kama","Kastet","Miecz","Nóż","Pałka",
                            "Pięść Niebios","Rapier","Sztylet","Topór","Wakizashi"};
        public String[] suffixBiala1h ={"Biegłości","Bólu","Dowódcy","Drakuli",
                            "Imperatora","Klanu","Kontuzji","Krwi","Mocy","Męstwa",
                            "Odwagi","Podkowy","Precyzji","Przodków","Samobójcy",
                            "Sekty","Trafienia","Władzy","Zarazy","Zdobywcy",
                            "Zemsty","Zwinności"};
        public String[] preffixBiala2h = { "Antyczna", "Demoniczna", "Jadowita",
                            "Kościana", "Kryształowa", "Kąsająca", "Lekka", "Mistyczna",
                            "Okrutna", "Opiekuńcza", "Ostra", "Przeklęta",
                            "Przyjacielska", "Szybka", "Wzmacniająca", "Zabójcza",
                            "Zatruta", "Zwinna", "Zębata", "Świecąca" };
        public String[] rodzajBiala2h ={"Halabarda","Katana","Korbacz","Kosa","Maczuga",
                            "Miecz dwuręczny","Pika","Piła łańcuchowa",
                            "Topór dwuręczny","łom"};
        public String[] suffixBiala2h ={"Autokraty","Bazyliszka","Bólu","Drakuli",
                            "Hazardzisty","Inkwizytora","Krwi","Krwiopijcy","Mocy",
                            "Ołowiu","Podkowy","Podstępu","Samobójcy","Władzy",
                            "Zarazy","Zdobywcy","Zdrady","Zemsty"};
        public String[] rodzajPalna1h ={"Beretta","Desert Eagle","Glock","Magnum","Mp5k",
                            "Skorpion","Uzi"};
        public String[] rodzajPalna2h ={"AK-47","Fn-Fal","Karabin myśliwski",
                            "Karabin snajperski","Miotacz płomieni",
                            "Półautomat snajperski","Strzelba"};
        public String[] rodzajDystans ={"Ciężka kusza","Długi łuk","Krótki łuk","Kusza",
                            "Nóż do rzucania","Oszczep","Pilum","Shuriken",
                            "Toporek do rzucania","Łuk","Łuk refleksyjny"};
        public String[] suffixDystans ={"Dalekiego zasięgu","Doskonałości","Driady",
                            "Precyzji","Reakcji","Szybkostrzelności","Wilka","Zemsty"};
        public String[] suffPreffBrak = { "Brak" };


        public Form1()
        {
            InitializeComponent();
        }

        //loading file with preffixes combination
        public string[,] loadPreffFile(string fileName, string[,] textFile)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            
            int row = 0;
            int column = 0;
            foreach(string line in lines)
            {
                if(line != null)
                {
                    textFile[row, column] = line;
                    column++;
                    if (column == 3)
                    {
                        row++;
                        column = 0;
                    }
                    strWynikuLoczenia.Text = strWynikuLoczenia.Text + line + "\n";
                }
            }
            /*
            for ( row = 0; row < 345; row++)
            {
                if(textFile[row,0] != null)
                {
                    strWynikuWynik.Text = strWynikuWynik.Text + textFile[row, 0] + "\n";
                }
            }
            */

            return textFile;
        }

        //loading file with rodzaj combination
        public string[,] loadRodzaj(string fileName, string[,] textFile)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            int row = 0;
            int column = 0;
            foreach (string line in lines)
            {
                if (line != null)
                {
                    textFile[row, column] = line;
                    column++;
                    if (column == 3)
                    {
                        row++;
                        column = 0;
                    }
                }
                else
                {
                    break;
                }
            }

            return textFile;
        }
        
        // loading file with suffixes combination
        public string[,] loadSuffixes(string fileName, string[,] textFile)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            int row = 0;
            int column = 0;
            foreach (string line in lines)
            {
                if (line != null)
                {
                    textFile[row, column] = line;
                    column++;
                    if (column == 3)
                    {
                        row++;
                        column = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            return textFile;
        }

        //setting new model of combobox cbPreffixItemka
        public ComboBox preffixItemka(ComboBox cBox, String[] nazwa)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nazwa;
            cBox.DataSource = bs;
            return cBox;
        }
       
        //setting new model of combobox cbNazwaItemka
        public ComboBox nazwaItemka(ComboBox cBox, String[] nazwa)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nazwa;
            cBox.DataSource = bs;
            return cBox;
        }
        
        //setting new model of combobox cbSuffixItemka
        public ComboBox suffixItemka(ComboBox cBox, String[] nazwa)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = nazwa;
            cBox.DataSource = bs;
            return cBox;
        }
        
        // searching rodzajItemka in selected items
        public String[] searchName(String[] rodzajName)
        {
            for(int i  = 0; i < checkNazwy.Length; i++)
            {
                checkNazwy[i] = null;
            }

            int index = 0;
            bool tmp = false;
            for (int j = 0; j < selectedNazwy.Length; j++) 
            {
                z3temp = selectedNazwy[j];
                for (int i = 0; i < rodzajName.Length; i++)
                {
                    z2temp = rodzajName[i];
                    tmp = string.Equals(z3temp, z2temp, StringComparison.Ordinal);
                    if(tmp == true && z3temp == z2temp)
                    {
                        checkNazwy[index] = rodzajName[i];
                        index += 1;
                    }
                }
            }
            return checkNazwy;
        }

        // searching rodzajItemka in selected items
        public String[] searchPreff(String[] preffName)
        {
            for (int i = 0; i < checkPreffixes.Length; i++)
            {
                checkPreffixes[i] = null;
            }

            int index = 0;
            bool tmp = false;

            for (int i = 0; i < preffName.Length; i++)
            {
                z3temp = preffName[i];
                for (int j = 0; j < selectedPreffixes.Length; j++)
                {
                    z2temp = selectedPreffixes[j];
                    tmp = string.Equals(z2temp, z3temp, StringComparison.Ordinal);
                    if (selectedPreffixes[j] == preffName[i])
                    {
                        checkPreffixes[index] = preffName[i];
                        index += 1;
                    }
                }

            }
            return checkPreffixes;
        }

        // searching rodzajItemka in selected items
        public String[] searchSuff(String[] suffName)
        {
            for (int i = 0; i < checkSuffixes.Length; i++)
            {
                checkSuffixes[i] = null;
            }
            int index = 0;
            bool tmp = false;

            for (int i = 0; i < suffName.Length; i++)
            {
                z3temp = suffName[i];
                for (int j = 0; j < selectedSuffixes.Length; j++)
                {
                    z2temp = selectedSuffixes[j];
                    tmp = string.Equals(z2temp, z3temp, StringComparison.Ordinal);
                    if (selectedSuffixes[j] == suffName[i])
                    {
                        checkSuffixes[index] = suffName[i];
                        index += 1;
                    }
                }

            }
            return checkSuffixes;
        }

        // set preff or suff value null
        public String[] setNull(String[] value)
        {
            for(int i = 0; i <  value.Length; i++)
            {
                value[i] = null;
            }
            return value;
        }

        // connecting two preffs only even values
        public String[] connectPreffs(String[,] name, string[] choosenPreff, string[] wynik)
        {
            int value = count(choosenPreff);
            //MessageBox.Show(value.ToString(), "value");
            bool tmp = false;
            bool tmp1 = false;
            int index = 0;
            for(int i = 0; i < choosenPreff.Length; i += 2)
            {

                if(choosenPreff[i] != null && choosenPreff[i + 1] != null)
                {
                    for (int j = 0; j < name.Length / 3; j++)
                    {
                        //MessageBox.Show("Weszlo");
                        z4temp = name[j, 0];
                        tmp = string.Equals(name[j, 0], choosenPreff[i], StringComparison.Ordinal);
                        //MessageBox.Show(z2temp + "z2temp ", tmp.ToString() + " " + z4temp + "z4temp");
                        if (tmp == true)
                        {
                            z5temp = name[j, 1];
                            tmp1 = string.Equals(choosenPreff[i + 1], name[j, 1], StringComparison.Ordinal);
                            //MessageBox.Show(choosenPreff[i].ToString(), "choosenPreff " + i.ToString()+ " " + tmp1.ToString());
                            if (tmp1 == true)
                            {
                                wynik[index] = name[j, 2];
                                //MessageBox.Show(index.ToString(), "index");
                                preffBeforeItem[index, 0] = name[j, 2];
                                preffBeforeItem[index, 1] = choosenPreff[i];
                                preffBeforeItem[index, 2] = choosenPreff[i + 1];
                                choosenPreff[value + index] = name[j, 2];
                                index++;
                            }
                        }
                    }
                }
            }

            return wynik;
        }

        // connecting two Base Names only even values
        public String[] connectRodzaj(String[,] name, string[] choosenRodzaj, string[] wynik)
        {
            int value = count(choosenRodzaj);
            //MessageBox.Show(value.ToString(), "value");
            bool tmp = false;
            bool tmp1 = false;
            int index = 0;
            //dla wszystkich wybranych rzeczy
            for (int i = 0; i < choosenRodzaj.Length; i += 2)
            {
                /*
               //MessageBox.Show(choosenRodzaj[i].ToString(), "choosenRodzaj " + i.ToString());
                // jesli maja jakas wartosc przypisz je do zmiennych
                if (choosenRodzaj[i] != null)
                {
                    //z2temp = choosenRodzaj[i];
                   // z3temp = choosenRodzaj[i + 1];
                    
                    /*
                    tmp = string.Equals(z3temp, z2temp, StringComparison.Ordinal);
                    if (tmp == true)
                    {
                        // jeśli dwa kolejne przedmioty są takie same to łączenie daje jeden z nich
                        choosenRodzaj[value + index] = z2temp;
                        wynik[index] = z2temp;
                        index++;
                        continue;
                    }
                    
                  }
                
                else if (choosenRodzaj[i] == null)
                {//inaczej przerwij
                    //MessageBox.Show("break");
                    break;
                }
                */
                // dla wszystkich mozliwych kombinacji
                for (int j = 0; j < name.Length/3; j++)
                {
                    if (name[j, 0] != null)
                    {
                        //MessageBox.Show("Weszlo");
                        //piwerwsza wartosc z kombinacji do zmiennej
                        z4temp = name[j, 0];
                        // porównaj z pierwszą wybraną
                        tmp = string.Equals(z4temp, choosenRodzaj[i], StringComparison.Ordinal);
                        // jeśli są takie same to rób
                        if (tmp == true)
                        {
                            // przypisz wartość drugiego przedmiotu
                            z5temp = name[j, 1];
                            // sprawdź czy drugi wybrany == przedmiotowi z możliwością łączenia
                            tmp1 = string.Equals(z5temp, choosenRodzaj[i + 1], StringComparison.Ordinal);
                            // jeśli tak to przypisz
                           // MessageBox.Show(tmp.ToString() + choosenRodzaj[i], "z4temp " + z4temp);
                            //MessageBox.Show(tmp1.ToString() + choosenRodzaj[i + 1], "z5temp " + z5temp);
                            if (tmp1 == true)
                            {
                                wynik[index] = name[j, 2];
                                // MessageBox.Show(index.ToString(), "indexRodzaj");
                                rodzajBeforeItem[index, 0] = name[j, 2];
                                rodzajBeforeItem[index, 1] = choosenRodzaj[i];
                                rodzajBeforeItem[index, 2] = choosenRodzaj[i+1];
                                choosenRodzaj[value + index] = name[j, 2];
                                index++;
                                break;
                            }
                        }
                    }
                }
            }

            return wynik;
        }

        // connecting two Suffixes only even values
        public String[] connectSuffix(String[,] name, string[] choosenSuffix, string[] wynik)
        {
            int value = count(choosenSuffix);
            //MessageBox.Show(value.ToString(), "value");
            bool tmp = false;
            bool tmp1 = false;
            int index = 0;
            for (int i = 0; i < choosenSuffix.Length; i += 2)
            {
                if(choosenSuffix[i] != null && choosenSuffix[i+1] != null)
                {
                    for (int j = 0; j < name.Length / 3; j++)
                    {
                        z4temp = name[j, 0];
                        tmp = string.Equals(name[j, 0], choosenSuffix[i], StringComparison.Ordinal);
                        if (tmp == true)
                        {
                            z5temp = name[j, 1];
                            tmp1 = string.Equals(name[j, 1], choosenSuffix[i + 1], StringComparison.Ordinal);
                            if (tmp1 == true)
                            {
                                wynik[index] = name[j, 2];
                                //  MessageBox.Show(index.ToString(), "index");
                                suffBeforeItem[index, 0] = name[j, 2];
                                suffBeforeItem[index, 1] = z2temp;
                                suffBeforeItem[index, 2] = z3temp;
                                choosenSuffix[value + index] = name[j, 2];
                                index++;
                            }
                        }
                    }
                }
                
            }
            return wynik;
        }

        // counting elements in array that are not null
        public int count(string[] name)
        {
            int value = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] != null)
                {
                    value++;
                }
                else
                {
                    break;
                }
            }
           // MessageBox.Show(value.ToString(), "val");
            return value;
        }

        // get lines from richTextBox
        public string[] getLineFromTextBox(string [] array)
        {
            string[] temparray = new string[4000];
            for(int i = 0; i < textBoxStrStart.Lines.Length; i++)
            {
                if( i % 3 == 0)
                {
                    temparray[i / 3] = textBoxStrStart.Lines[i];
                }
                
            }
            int j = 0;
            for( int i = 0; i < temparray.Length; i++)
            {
                if(temparray[i] != null)
                {
                    z2temp = temparray[i];
                    z7temp = z2temp.Split(' ');

                    foreach (string line in z7temp)
                    {
                        
                        if(line != "Doskonała" && line != "Legendarna" && line != "Doskonały" && line != "Legendarny" &&
                            line != "(+1)" && line != "(+2)" && line != "(+3)" && line != "(+4)" && line != "(+5)" && line != "(+6)"
                            && line != "(+7)" && line != "(+8)" && line != "(+9)" && line != "Dobry" && line != "Dobra")
                        {
                            /*
                            array[row, column] = line;
                            column++;
                            if (column == 3)
                            {
                                row++;
                                column = 0;
                            }
                            */
                            
                            array[j] = line;
                            //rtbTest.Text = rtbTest.Text + array[j] + "\n";
                            j++;
                        }
                    }
                }
                
            }
            /*
            for(int i = 0; i< array.Length/3; i++)
            {
                if(array[i,0] != null)
                rtbTest.Text = rtbTest.Text + array[i,0] + " " + array[i,1] + " " + array[i,2] +"\n";
            }
           */

            return array;
        }

        // getting items from items copyied by text
        public string[] searchCopyiedItems(string[] arrayOfItems, string[] searchedPreffItems, string[] searchedItems, string[] searchedSuffItems)
        {
            for (int i = 0; i < checkNazwy.Length; i++)
            {
                checkNazwy[i] = null;
            }

            int index = 0;
            bool tmp = false;
            bool tmpp = false;
            bool tmps = false;
            for (int j = 0; j < arrayOfItems.Length; j++)
            {
                z3temp = arrayOfItems[j];
                for (int i = 0; i < searchedItems.Length; i++)
                {
                    z2temp = searchedItems[i];
                    
                    tmp = string.Equals(z3temp, z2temp, StringComparison.Ordinal);
                    //MessageBox.Show(z3temp + " skopiowane itemki", z2temp + " szukaneItemki " +tmp.ToString());
                    if (tmp == true )
                    {
                        checkNazwy[index] = searchedItems[i];
                        if(searchedPreffItems[0] != null)
                        {
                            for (int p = 0; p < searchedPreffItems.Length; p++)
                            {
                                tmpp = string.Equals(arrayOfItems[j - 1], searchedPreffItems[p], StringComparison.Ordinal);
                                //MessageBox.Show(arrayOfItems[j-1] + " skopiowane itemki", searchedPreffItems[p] + " szukaneItemki " + tmp.ToString());
                                if (tmpp == true)
                                {
                                    checkPreffixes[index] = searchedPreffItems[p];
                                    break;
                                }
                            }
                        }
                        if (searchedSuffItems[0] != null)
                        {
                            for (int s = 0; s < searchedSuffItems.Length; s++)
                            {
                                tmps = string.Equals(arrayOfItems[j + 1], searchedSuffItems[s], StringComparison.Ordinal);
                                if (tmps == true)
                                {
                                    checkSuffixes[index] = searchedSuffItems[s];
                                    break;
                                }
                            }
                        }
                        
                        index += 1;
                    }
                }
            }
            return checkNazwy;
        }

        private void StrWyboruDalej_Click(object sender, EventArgs e)
        {
            if(which == false)
            {
                if (chbSpodnie.Checked == true)
                {
                    searchPreff(preffixSpodnie);
                    searchName(rodzajSpodnie);
                    searchSuff(suffixSpodnie);
                }
                else if (chbZbroja.Checked == true)
                {
                    searchPreff(zbroja);
                    searchName(rodzajZbroi);
                    searchSuff(suffZbroi);
                }
                else if (chbPierscien.Checked == true)
                {
                    searchPreff(preffixPierscien);
                    searchName(rodzajPierscien);
                    searchSuff(suffixPierscien);
                }
                else if (chbPalna2h.Checked == true)
                {
                    setNull(checkPreffixes);
                    searchName(rodzajPalna2h);
                    setNull(checkSuffixes);
                }
                else if (chbPalna1h.Checked == true)
                {
                    setNull(checkPreffixes);
                    searchName(rodzajPalna1h);
                    setNull(checkSuffixes);
                }
                else if (chbHelm.Checked == true)
                {
                    searchPreff(helm);
                    searchName(rodzajHelmu);
                    searchSuff(suffHelmu);
                }
                else if (chbDystans.Checked == true)
                {
                    setNull(checkPreffixes);
                    searchName(rodzajDystans);
                    searchSuff(suffixDystans);
                }
                else if (chbBiala2h.Checked == true)
                {
                    searchPreff(preffixBiala2h);
                    searchName(rodzajBiala2h);
                    searchSuff(suffixBiala2h);
                }
                else if (chbBiala1h.Checked == true)
                {
                    searchPreff(preffixBiala1h);
                    searchName(rodzajBiala1h);
                    searchSuff(suffixBiala1h);

                }
                else if (chbAmulet.Checked == true)
                {
                    searchPreff(preffixAmulet);
                    searchName(rodzajAmulet);
                    searchSuff(suffixAmulet);
                }
            }
            else
            {
                if (chbSpodnie.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, preffixSpodnie, rodzajSpodnie, suffixSpodnie);
                }
                else if (chbZbroja.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, zbroja, rodzajZbroi, suffZbroi);
                }
                else if (chbPierscien.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, preffixPierscien, rodzajPierscien, suffixPierscien);
                }
                else if (chbPalna2h.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, null, rodzajPalna2h, null);
                }
                else if (chbPalna1h.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, null, rodzajPalna1h, null);
                }
                else if (chbHelm.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, helm, rodzajHelmu, suffHelmu);
                }
                else if (chbDystans.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, null, rodzajDystans, suffixDystans);
                }
                else if (chbBiala2h.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, preffixBiala2h, rodzajBiala2h, suffixBiala2h);
                }
                else if (chbBiala1h.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, preffixBiala1h, rodzajBiala1h, suffixBiala1h);

                }
                else if (chbAmulet.Checked == true)
                {
                    searchCopyiedItems(CopyiedItems, preffixAmulet, rodzajAmulet, suffixAmulet);
                }
            }
           

            strSprRichTextBox.Text = " ";
            for(int i = 0; i < checkNazwy.Length; i++)
            {
                if(checkNazwy[i] != null)
                {
                    strSprRichTextBox.Text = strSprRichTextBox.Text + checkPreffixes[i] + "  " + checkNazwy[i] + "  " + checkSuffixes[i] + "\n";
                }
            }
            stronaSprawdzenia.Visible = true;
            panelWyboru.Visible = false;
        }

        private void StrWyboruZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StrWyboruWstecz_Click(object sender, EventArgs e)
        {
            panelWyboru.Visible = false;
            panelStartowy.Visible = true;
        }

        private void dalejStrStart_Click(object sender, EventArgs e)
        {
            panelStartowy.Visible = false;
            getLineFromTextBox(CopyiedItems);
            panelWyboru.Visible = true;
        }

        private void zakonczStrStart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strSprWstecz_Click(object sender, EventArgs e)
        {
            stronaSprawdzenia.Visible = false;
            panelWyboru.Visible = true;
        }

        private void strSprDalej_Click(object sender, EventArgs e)
        {
            if(chbHelm.Checked == true)
            {
                loadPreffFile("PreffixHelm.txt", preffConnections);
                loadRodzaj("rodzajHelm.txt", rodzajConnections);
                loadSuffixes("SuffixHelm.txt",suffConnections);
            }
            else if(chbZbroja.Checked == true)
            {
                loadPreffFile("PreffixZbroja.txt", preffConnections);
                loadRodzaj("RodzajZbroja.txt", rodzajConnections);
                loadSuffixes("SuffixZbroja.txt", suffConnections);
            }
            else if(chbSpodnie.Checked == true)
            {
                loadPreffFile("PreffixSpodnie.txt", preffConnections);
                loadRodzaj("RodzajSpodnie.txt", rodzajConnections);
                loadSuffixes("SuffixSpodnie.txt", suffConnections);
            }
            else if(chbPierscien.Checked == true)
            {
                loadPreffFile("PreffixPierscien.txt", preffConnections);
                loadRodzaj("RodzajPierscien.txt", rodzajConnections);
                loadSuffixes("SuffixPierscien.txt", suffConnections);
            }
            else if(chbPalna2h.Checked == true)
            {
                loadRodzaj("RodzajPalna2h.txt", rodzajConnections);
            }
            else if(chbPalna1h.Checked == true)
            {
                loadRodzaj("RodzajPalna1h.txt", rodzajConnections);
            }
            else if(chbDystans.Checked == true)
            {
                loadRodzaj("RodzajDystans.txt", rodzajConnections);
                loadSuffixes("SuffixDystans.txt", suffConnections);
            }
            else if(chbBiala2h.Checked == true)
            {
                loadPreffFile("PreffixBiala2h.txt", preffConnections);
                loadRodzaj("RodzajBiała2h.txt", rodzajConnections);
                loadSuffixes("SuffixBiała2h.txt", suffConnections);
            }
            else if(chbBiala1h.Checked == true)
            {
                loadPreffFile("PreffixBiała1h.txt", preffConnections);
                loadRodzaj("RodzajBiała1h.txt", rodzajConnections);
                loadSuffixes("SuffixBiała1h.txt", suffConnections);
            }
            else if(chbAmulet.Checked == true)
            {
                loadPreffFile("PreffixAmulet.txt",preffConnections);
                loadRodzaj("RodzajAmulet.txt", rodzajConnections);
                loadSuffixes("SuffixAmulet.txt", suffConnections);
            }
            strWynikuWynik.Text = null;
            /*
            foreach (string line in suffConnections)
            {
                strWynikuWynik.Text = strWynikuWynik.Text + line + "\n";
            }
            */
            connectPreffs(preffConnections, checkPreffixes, preffEndConnection);
            connectRodzaj(rodzajConnections, checkNazwy, rodzajEndConnection);
            connectSuffix(suffConnections, checkSuffixes, suffEndConnection);

            /*
            foreach (string line in preffEndConnection)
            {
                if(line != null) strWynikuLoczenia.Text = strWynikuLoczenia.Text + line + "\n";
            }
            foreach (string line in rodzajEndConnection)
            {
                if(line != null)
                strWynikuLoczenia.Text = strWynikuLoczenia.Text + line + "\n";
            }
            foreach (string line in suffEndConnection)
            {
                if(line != null)
                strWynikuLoczenia.Text = strWynikuLoczenia.Text + line + "\n";
            }
            */
            List<string> list = new List<string>();
            
            for (int i = 0; i < preffEndConnection.Length; i++)
            {
                if(preffEndConnection != null || rodzajEndConnection != null || suffEndConnection != null)
                list.Add( preffEndConnection[i] + " " + rodzajEndConnection[i] + " " + suffEndConnection[i] );
            }

            strWynikuWynik.DataSource = list;

            stronaSprawdzenia.Visible = false;
            stronaWyniku.Visible = true;
        }

        private void strSprZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelAnalizatorBW_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void strWynikuWstecz_Click(object sender, EventArgs e)
        {
            stronaWyniku.Visible = false;
            setNull(preffEndConnection);
            setNull(rodzajEndConnection);
            setNull(suffEndConnection);
            stronaSprawdzenia.Visible = true;
        }

        private void strWynikuZakoncz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            which = false;
            pStartpWybieranie.Visible = true;
            rodzajItemka = nazwaItemka(rodzajItemka, itemek);
            textBoxStrStart.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            which = true;
            textBoxStrStart.Visible = true;
            textBoxStrStart.Text = "Skopiuj i wklej tutaj przedmioty ze zbrojowni. \n";
            textBoxStrStart.Text = textBoxStrStart.Text + "Tak powinna wyglądać przykładowa lista: \n\n";
            textBoxStrStart.Text = textBoxStrStart.Text + "Dobre Kolcze Szorty Skrytości (+1)\n" +
            "SPRZEDAJ(39 400 PLN)\n" +
            "EKWIPUJ\n" +
            "Legendarny Dobry Kardynalski Krawat(+1)\n" +
            "SPRZEDAJ(106 950 PLN)\n" +
            "EKWIPUJ";
            //rtbTest.Visible = true;
            pStartpWybieranie.Visible = false;
        }

        // displaying items values selected form combobox  rodzajItemka
        private void rodzajItemka_SelectedIndexChanged(object sender, EventArgs e)
        {

            String item = rodzajItemka.SelectedValue.ToString();
            switch (item)
            {
                case "Hełmy":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, helm);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajHelmu);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffHelmu);
                    break;
                case "Zbroje":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, zbroja);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajZbroi);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffZbroi);
                    break;
                case "Amulety":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, preffixAmulet);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajAmulet);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixAmulet);
                    break;
                case "Pierścienie":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, preffixPierscien);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajPierscien);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixPierscien);
                    break;
                case "Spodnie":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, preffixSpodnie);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajSpodnie);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixSpodnie);
                    break;
                case "Bronie dwuręczne":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, preffixBiala2h);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajBiala2h);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixBiala2h);
                    break;
                case "Bronie dystansowe dwuręczne":
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajDystans);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixDystans);
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, suffPreffBrak); 
                    break;
                case "Bronie jednoręczne":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, preffixBiala1h);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajBiala1h);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffixBiala1h);
                    break;
                case "Bronie palne dwuręczne":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, suffPreffBrak);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajPalna2h);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffPreffBrak);
                    break;
                case "Bronie palne jednoręczne":
                    cbPreffixItemka = preffixItemka(cbPreffixItemka, suffPreffBrak);
                    cbNazwaItemka = nazwaItemka(cbNazwaItemka, rodzajPalna1h);
                    cbSuffixItemka = suffixItemka(cbSuffixItemka, suffPreffBrak);
                    break;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            selectedPref = cbPreffixItemka.SelectedValue.ToString();
            selectedNazwa = cbNazwaItemka.SelectedValue.ToString();
            selectedSuf = cbSuffixItemka.SelectedValue.ToString();

            selectedPreffixes[preffindex += 1] = selectedPref;
            selectedNazwy[nazwaindex += 1] = selectedNazwa;
            selectedSuffixes[suffindex += 1] = selectedSuf;

            rtbItemki.Text = rtbItemki.Text + selectedPref + " + " + selectedNazwa + " + " + selectedSuf + "\n";
        }

        private void strWynikuWynik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int selectedIndex = strWynikuWynik.SelectedIndex;
            strWynikuLoczenia.Text = preffBeforeItem[selectedIndex, 1] + " " + rodzajBeforeItem[selectedIndex, 1] + " " +
                suffBeforeItem[selectedIndex, 1] + " + \n" + preffBeforeItem[selectedIndex,2] + " " + rodzajBeforeItem[selectedIndex,2] +
                " " + suffBeforeItem[selectedIndex,2] + " = \n" + preffBeforeItem[selectedIndex,0] + " "+
                rodzajBeforeItem[selectedIndex,0] + " " + suffBeforeItem[selectedIndex,0];
            
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            getLineFromTextBox(CopyiedItems);
        }

        private void textBoxStrStart_Click(object sender, EventArgs e)
        {
            textBoxStrStart.Text = null;
        }

        private void chbHelm_CheckedChanged(object sender, EventArgs e)
        {
            if(chbHelm.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbZbroja.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbZbroja.Enabled = true;
            }
            
        }

        private void chbZbroja_CheckedChanged(object sender, EventArgs e)
        {
            if (chbZbroja.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbSpodnie_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSpodnie.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbZbroja.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbZbroja.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbPierscien_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPierscien.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbZbroja.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbZbroja.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbAmulet_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAmulet.Checked == true)
            {
                chbZbroja.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbZbroja.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbBiala1h_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBiala1h.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbZbroja.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbZbroja.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbBiala2h_CheckedChanged(object sender, EventArgs e)
        {
            if (chbBiala2h.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbZbroja.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbZbroja.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbPalna1h_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPalna1h.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbZbroja.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbZbroja.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbPalna2h_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPalna2h.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbDystans.Enabled = false;
                chbPalna1h.Enabled = false;
                chbZbroja.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbDystans.Enabled = true;
                chbPalna1h.Enabled = true;
                chbZbroja.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        private void chbDystans_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDystans.Checked == true)
            {
                chbAmulet.Enabled = false;
                chbBiala1h.Enabled = false;
                chbBiala2h.Enabled = false;
                chbZbroja.Enabled = false;
                chbPalna1h.Enabled = false;
                chbPalna2h.Enabled = false;
                chbPierscien.Enabled = false;
                chbSpodnie.Enabled = false;
                chbHelm.Enabled = false;
            }
            else
            {
                chbAmulet.Enabled = true;
                chbBiala1h.Enabled = true;
                chbBiala2h.Enabled = true;
                chbZbroja.Enabled = true;
                chbPalna1h.Enabled = true;
                chbPalna2h.Enabled = true;
                chbPierscien.Enabled = true;
                chbSpodnie.Enabled = true;
                chbHelm.Enabled = true;
            }
        }

        /*
        private void button1_Click_1(object sender, EventArgs e)
        {
            string prefFileName = "KombinacjePreffHelm.txt";

            string[] lines = System.IO.File.ReadAllLines(prefFileName);

            // Display the file contents by using a foreach loop.
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                rtbItemki.Text = rtbItemki.Text + line + "\n";

            }

            // Keep the console window open in debug mode.
        }
        */



    }
}
