using System.Windows.Forms;

namespace Autobazar
{

    public partial class Form1 : Form
    {
        Autoservis autoservis = new Autoservis();
        int temp_index;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            List<string> incorrect = new List<string>();

            string vyrobce = text1.Text;
            string typ = text2.Text;
            int rok;
            int km;

            if (text1.Text == null)
            {
                incorrect.Add("Výrobce");
            }
            if (text2.Text == null)
            {
                incorrect.Add("Typ auta");
            }
            if (!Int32.TryParse(text3.Text, out rok))
            {
                incorrect.Add("Rok výroby");
            }
            if (!Int32.TryParse(text4.Text, out km))
            {
                incorrect.Add("Najeté kilometry");
            }
            if (comboBox.SelectedIndex == -1)
            {
                incorrect.Add("Stav");
            }

            if (incorrect.Count > 0)
            {

                labelError.Text = "Nesprávně zadané informace: ";
                for (int i = 0; i < incorrect.Count; i++)
                {
                    if (incorrect.Count - i == 1)
                    {
                        labelError.Text += incorrect[i];
                    }
                    else
                    {
                        labelError.Text += incorrect[i] + ", ";
                    }

                }

            }
            else
            {
                labelError.Text = "";
                autoservis.AddCar(new Auto
                {
                    Vyrobce = vyrobce,
                    Typ = typ,
                    RokVyroby = rok,
                    NajeteKilometry = km,
                    Stav = comboBox.SelectedIndex switch
                    {
                        0 => "Nové",
                        1 => "Servis",
                        2 => "Opravené",
                        3 => "Vydané"
                    }
                });

                listBox1.DataSource = null;
                listBox1.DataSource = autoservis.PrintSeznamAut();

                text1.Text = "";
                text2.Text = "";
                text3.Text = "";
                text4.Text = "";
                labelError.Text = "";
                comboBox.SelectedIndex = -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            autoservis.DeleteCar(listBox1.SelectedIndex);
            listBox1.DataSource = null;
            listBox1.DataSource = autoservis.PrintSeznamAut();
            if (autoservis.GetSeznamAut().Count == 0)
            {
                edit.Enabled = false;
                delete.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            delete.Enabled = true;
            edit.Enabled = true;

        }

        private void edit_Click(object sender, EventArgs e)
        {
            temp_index = listBox1.SelectedIndex;
            save.Enabled = true;
            discard.Enabled = true;
            add.Enabled = false;
            delete.Enabled = false;
            edit.Enabled = false;
            Auto c = autoservis.GetSeznamAut()[temp_index];
            text1.Text = c.Vyrobce;
            text2.Text = c.Typ;
            text3.Text = c.RokVyroby.ToString();
            text4.Text = c.NajeteKilometry.ToString();
            comboBox.SelectedIndex = c.Stav switch
            {
                "Nové" => 0,
                "Servis" => 1,
                "Opravené" => 2,
                "Vydané" => 3
            };

        }

        private void save_Click(object sender, EventArgs e)
        {
            List<string> incorrect = new List<string>();
            labelError.Text = "";
            string vyrobce = text1.Text;
            string typ = text2.Text;
            int rok;
            int km;

            if (text1.Text == null)
            {
                incorrect.Add("Výrobce");
            }
            if (text2.Text == null)
            {
                incorrect.Add("Typ auta");
            }
            if (!Int32.TryParse(text3.Text, out rok))
            {
                incorrect.Add("Rok výroby");
            }
            if (!Int32.TryParse(text4.Text, out km))
            {
                incorrect.Add("Najeté kilometry");
            }
            if (comboBox.SelectedIndex == -1)
            {
                incorrect.Add("Stav");
            }

            if (incorrect.Count > 0)
            {

                labelError.Text = "Nesprávně zadané informace: ";
                for (int i = 0; i < incorrect.Count; i++)
                {
                    if (incorrect.Count - i == 1)
                    {
                        labelError.Text += incorrect[i];
                    }
                    else
                    {
                        labelError.Text += incorrect[i] + ", ";
                    }

                }

            }
            else
            {
                labelError.Text = "";
                autoservis.EditCar(temp_index, new Auto
                {
                    Vyrobce = vyrobce,
                    Typ = typ,
                    RokVyroby = rok,
                    NajeteKilometry = km,
                    Stav = comboBox.SelectedIndex switch
                    {
                        0 => "Nové",
                        1 => "Servis",
                        2 => "Opravené",
                        3 => "Vydané"
                    }
                });

                listBox1.DataSource = null;
                listBox1.DataSource = autoservis.PrintSeznamAut();

                temp_index = -1;
                save.Enabled = false;
                discard.Enabled = false;
                add.Enabled = true;
                delete.Enabled = true;
                edit.Enabled = true;

                text1.Text = "";
                text2.Text = "";
                text3.Text = "";
                text4.Text = "";
                comboBox.SelectedIndex = -1;

            }
        }

        private void discard_Click(object sender, EventArgs e)
        {
            temp_index = -1;
            save.Enabled = false;
            discard.Enabled = false;
            add.Enabled = true;
            delete.Enabled = true;
            edit.Enabled = true;

            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            labelError.Text = "";
            comboBox.SelectedIndex = -1;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Auto c = autoservis.GetSeznamAut()[listBox1.SelectedIndex];
            labelError.Text = $"{c.Vyrobce} {c.Typ}:\n  Rok výroby: {c.RokVyroby}\n  Najeté kilometry: {c.NajeteKilometry}\n  Stav: {c.Stav}";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public partial class Auto
    {
        public string Vyrobce { get; set; }
        public string Typ { get; set; }
        public int RokVyroby { get; set; }
        public int NajeteKilometry { get; set; }
        public string Stav {  get; set; }
    }


    // Tøída reprezentující autoservis
    public partial class Autoservis
    {
        private List<Auto> seznamAut = new List<Auto>();

        // Metoda pro pøidání nového automobilu
        public void AddCar(Auto auto)
        {
            seznamAut.Add(auto);
        }

        public List<Auto> GetSeznamAut() 
        {  
            return seznamAut; 
        }

        public List<String> PrintSeznamAut()
        {
            List<String> result = new List<String>();
            foreach (Auto i in  seznamAut) 
            {
                result.Add(i.Vyrobce + " " + i.Typ + ": " + i.Stav);
            }
            return result;
            
        }

        // Metoda pro úpravu informací o automobilu
        public void EditCar(int index, Auto noveInfo)
        {
            if (index >= 0 && index < seznamAut.Count)
            {
                seznamAut[index] = noveInfo;
            }
        }

        // Metoda pro získání informací o automobilu
        
        public string[] GetCar(int index)
        {
            if (index >= 0 && index < seznamAut.Count())
            { 
                return new string[] { seznamAut[index].Vyrobce, seznamAut[index].Typ, seznamAut[index].RokVyroby.ToString(), seznamAut[index].NajeteKilometry.ToString(), seznamAut[index].Stav };
            }
            return new string[] { "neplatný index" };

        }

        // Metoda pro smazání automobilu
        public void DeleteCar(int index)
        {
            if (index >= 0 && index < seznamAut.Count)
            {
                seznamAut.RemoveAt(index);
            }
        }
    }


}
