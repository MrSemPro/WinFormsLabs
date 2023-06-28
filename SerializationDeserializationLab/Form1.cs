using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;
using System.Globalization;
using ClosedXML.Attributes;
using ClosedXML.Excel;



namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        public class Truck
        {
            public string CurBrand;
            public string CurModel;
            public int CurLoadCapacity;

            public Truck() { }
            public Truck(string Brand = "NoBrand", string Model = "NoModel", int LoadCapacity = 0)
            {
                CurBrand = Brand;
                CurModel = Model;
                CurLoadCapacity = LoadCapacity;
            }
            public string Brand
            {
                get { return CurBrand; }
                set { CurBrand = value; }
            }
            public string Model
            {
                get { return CurModel; }
                set { CurModel = value; }
            }
            public int LoadCapacity
            {
                get { return CurLoadCapacity; }
                set { CurLoadCapacity = value; }
            }

            public string AsString()
            {
                return this.Brand + ' ' + this.Model + ' ' + this.LoadCapacity.ToString();
            }
        }

        string sourceText = "";
        private void Open_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;
                // читаем файл в строку
                sourceText = System.IO.File.ReadAllText(filename);
                FileContent.Text = System.IO.File.ReadAllText(filename); ;
                FileName.Text = filename;
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, FileContent.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }

        }

        private void FromJSON_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                FileContent.Text = "";
                string json = sourceText;
                var restoredTrucks = JsonSerializer.Deserialize<List<Truck>>(json);
                foreach (var eachTruck in restoredTrucks)
                {
                    FileContent.AppendText(eachTruck.AsString() + "   \n");
                }

            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }

        }

        private void ToJSON_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                string[] inpLines = FileContent.Lines;
                FileContent.Text = "";
                int i = 0;
                var listTrucks = new List<Truck>();
                int iLength = inpLines.Length;
                while (i <= inpLines.Length - 1 && inpLines[i] != null && inpLines[i] != "")
                {
                    string inp = inpLines[i];
                    inp.Split();
                    Truck truckToJSON = new Truck(inp.Split()[0], inp.Split()[1], int.Parse(inp.Split()[2]));
                    listTrucks.Add(truckToJSON);
                    ++i;
                }
                string json = JsonSerializer.Serialize<List<Truck>>(listTrucks);
                FileContent.AppendText(json + "\n");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }
        }

        private void ToXML_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                string[] inpLines = FileContent.Lines;
                FileContent.Text = "";
                int i = 0;
                var listTrucks = new List<Truck>();
                while (i <= inpLines.Length - 1 && inpLines[i] != null && inpLines[i] != "")
                {
                    string inp = inpLines[i];
                    inp.Split();
                    Truck truckToXML = new Truck(inp.Split()[0], inp.Split()[1], int.Parse(inp.Split()[2]));
                    listTrucks.Add(truckToXML);
                    ++i;
                }
                XmlSerializer formatter = new XmlSerializer(typeof(List<Truck>));
                using (FileStream fs = new FileStream("trucks.xml", FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, listTrucks);
                }
                string stringXML = File.ReadAllText("trucks.xml");
                FileContent.AppendText(stringXML + "\n");
                File.Delete("trucks.xml");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }

        }

        private void FromXML_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                FileContent.Text = "";
                var listTruck = new List<Truck>();
                File.WriteAllText("trucks.xml", sourceText);
                XmlSerializer formatter = new XmlSerializer(typeof(List<Truck>));
                using (FileStream fs = new FileStream("trucks.xml", FileMode.OpenOrCreate))
                {
                    var listTrucks = (List<Truck>)formatter.Deserialize(fs);
                    foreach (var eachTruck in listTrucks)
                    {
                        FileContent.AppendText(eachTruck.AsString() + "   \n");
                    }

                }

                File.Delete("trucks.xml");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }

        }

        private void ToCSV_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                string[] inpLines = FileContent.Lines;
                FileContent.Text = "";
                int i = 0;
                var listTrucks = new List<Truck>();
                while (i <= inpLines.Length - 1 && inpLines[i] != null && inpLines[i] != "")
                {
                    string inp = inpLines[i];
                    inp.Split();
                    Truck truckToCSV = new Truck(inp.Split()[0], inp.Split()[1], int.Parse(inp.Split()[2]));
                    listTrucks.Add(truckToCSV);
                    ++i;
                }


                using (var writer = new StreamWriter("Trucks.csv"))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(listTrucks);
                }
                string stringXML = File.ReadAllText("Trucks.csv");
                FileContent.AppendText(stringXML + "\n");
                File.Delete("Trucks.csv");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }
        }

        private void FromCSV_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                FileContent.Text = "";
                var listTruck = new List<Truck>();
                File.WriteAllText("Trucks.csv", sourceText);
                using (var reader = new StreamReader("Trucks.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var listTrucks = csv.GetRecords<Truck>().ToList();
                    foreach (Truck eachTruck in listTrucks)
                    {
                        FileContent.AppendText(eachTruck.AsString() + "   \n");
                    }

                }
                File.Delete("Trucks.csv");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }
        }

        private void ToXLSX_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                string[] inpLines = FileContent.Lines;
                int i = 0;
                var listTrucks = new List<Truck>();
                while (i <= inpLines.Length - 1 && inpLines[i] != null && inpLines[i] != "")
                {
                    string inp = inpLines[i];
                    inp.Split();
                    Truck truckToXLSX = new Truck(inp.Split()[0], inp.Split()[1], int.Parse(inp.Split()[2]));
                    listTrucks.Add(truckToXLSX);
                    ++i;
                }
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Trucks");
                    worksheet.Cell("A1").Value = "Brand";
                    worksheet.Cell("B1").Value = "Model";
                    worksheet.Cell("C1").Value = "LoadCapacity";
                    i = 2;
                    foreach (Truck eachTruck in listTrucks)
                    {
                        worksheet.Cell("A" + i.ToString()).Value = eachTruck.Brand;
                        worksheet.Cell("B" + i.ToString()).Value = eachTruck.Model;
                        worksheet.Cell("C" + i.ToString()).Value = eachTruck.LoadCapacity;
                        ++i;
                    }
                    workbook.SaveAs("Trucks.xlsx");
                    saveFileDialog1.Filter = "Text files(*.xlsx)|*.xlsx|All files(*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filename = saveFileDialog1.FileName;
                    // сохраняем текст в файл
                    workbook.SaveAs(filename);
                    MessageBox.Show("Файл сохранен");
                }

            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }


        }

        private void FromXLSX_Click(object sender, EventArgs e)
        {
            sourceText = FileContent.Text;
            try
            {
                FileContent.Text = "";
                openFileDialog1.Filter = "Text files(*.xlsx)|*.xlsx|All files(*.*)|*.*";
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл             
                string filename = openFileDialog1.FileName;
                MessageBox.Show("Открытие файла...");
                using var wbook = new XLWorkbook(filename);
                var worksheet = wbook.Worksheet(1);
                List<Truck> listTrucks = new List<Truck>();
                if (worksheet.Cell("A1").GetValue<string>() == "Brand")
                {
                    MessageBox.Show("Cчитывание данных...");
                    int i = 2;
                    while (!worksheet.Cell("A" + i.ToString()).IsEmpty())
                    {
                        string curBrand = worksheet.Cell("A" + i.ToString()).GetValue<string>();
                        string curModel = worksheet.Cell("B" + i.ToString()).GetValue<string>();
                        int curLoadCapacity = worksheet.Cell("C" + i.ToString()).GetValue<int>();
                        listTrucks.Add(new Truck(curBrand, curModel, curLoadCapacity));
                        ++i;
                    }
                    foreach (Truck eachTruck in listTrucks)
                    {
                        FileContent.AppendText(eachTruck.AsString() + "   \n");
                    }
                }
                else
                {
                    MessageBox.Show("Ошибка");
                    FileContent.Text = sourceText;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
                FileContent.Text = sourceText;
            }
        }
    }
}
