namespace Autobazar
{

    public partial class Form1 : Form
    {
        Autoservis autoservis = new Autoservis();
        List<string> car_show = new List<string>();
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
            if (comboBox.SelectedItem != "Nové" || comboBox.SelectedItem != "Servis" || comboBox.SelectedItem != "Opravené" || comboBox.SelectedItem != "Vydané" || comboBox.SelectedItem == null)
            {
                incorrect.Add("Stav");
            }

            if (incorrect.Count > 0)
            {

                labelError.Text = "Nesprávnì zadané informace: ";
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
                    Stav = (string)comboBox.SelectedItem
                });
                car_show.Append(vyrobce + " " + typ);

                listBox1.DataSource = null;
                listBox1.DataSource = car_show;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
