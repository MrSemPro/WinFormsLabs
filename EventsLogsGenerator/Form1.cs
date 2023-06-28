using System.Timers;
using System.Threading;
using System;
using ClosedXML.Excel;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Logger
        {
            List<Event> listEvents = new List<Event>();
            List<DateTime> listDate = new List<DateTime>();
            public Logger()
            {
                List<Event> listEvents = new List<Event>();
                List<DateTime> listDate = new List<DateTime>();
                File.WriteAllText("log.txt", "");
            }
            public void Clear()
            {
                List<Event> listEvents = new List<Event>();
                List<DateTime> listDate = new List<DateTime>();
                File.WriteAllText("log.txt", "");
            }
            public string ShowLogs()
            {
                if (File.Exists("log.txt"))
                {
                    return File.ReadAllText("log.txt");
                }
                else
                {
                    return "";
                }
            }

            public List<Event> ShowListOfEvents()
            {
                return listEvents;
            }
            public List<DateTime> ShowListOfDate()
            {
                return listDate;
            }
            public void LogEvent(Event eventToLog)
            {
                DateTime CurDate = DateTime.Now;
                listDate.Add(CurDate);
                listEvents.Add(eventToLog);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("log.txt", true))
                {
                    file.WriteLine($"{CurDate} - {eventToLog.Action} на {eventToLog.Type()} {eventToLog.Name}");
                }
            }

        }


        class Event
        {
            int cost = 0;

            public string Name { get; set; }
            public string Action { get; set; }
            public Event(string name, string action)
            {
                Name = name;
                Action = action;
            }
            public virtual string Type()
            {
                return "";
            }
        }

        class Opera : Event
        {
            public Opera(string name, string type) : base(name, type)
            { }
            public override string Type()
            {
                return "Опера";
            }

        }

        class Ballet : Event
        {
            public Ballet(string name, string type) : base(name, type)
            { }
            public override string Type()
            {
                return "Балет";
            }
        }
        class Generation
        {
            bool curentStatus = false;
            public bool status()
            {
                return curentStatus;
            }
            public void start()
            {
                curentStatus = true;

            }
            public void stop()
            {
                curentStatus = false;
            }
        }

        Generation randomGeneration = new Generation();
        Logger generationLogger = new Logger();
        void EventGeneration()
        {
            var rand = new Random();

            while (randomGeneration.status())
            {
                string eventAction = "";
                int switchAction = rand.Next(1, 4);
                switch (switchAction)
                {
                    case 1:
                        eventAction = "Покупка билета";
                        break;
                    case 2:
                        eventAction = "Возврат билета";
                        break;
                    case 3:
                        eventAction = "Изменение брони";
                        break;
                }
                int numberOfEvent = rand.Next(1, 100000);
                string eventName = "Произведение №" + numberOfEvent.ToString();
                Event newEvent = new Event("", "");

                int switchType = rand.Next(1, 3);
                switch (switchType)
                {
                    case 1:
                        newEvent = new Opera(eventName, eventAction);
                        break;
                    case 2:
                        newEvent = new Ballet(eventName, eventAction);
                        break;
                }
                generationLogger.LogEvent(newEvent);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"Событие {newEvent.Action} на {newEvent.Type()} {newEvent.Name} сгенерировано"); }));


                int timeForTimer = rand.Next(1, 5);
                Thread.Sleep(timeForTimer * 1000);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            bool generationStatus = randomGeneration.status();
            if (generationStatus)
            {
                MessageBox.Show("Генерация уже запущена");
            }
            else
            {
                randomGeneration.start();
                MessageBox.Show("Генерация возобновлена");
                Thread generationThread = new Thread(EventGeneration);
                generationThread.Start();
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            bool generationStatus = randomGeneration.status();
            if (!generationStatus)
            {
                MessageBox.Show("Генерация не была запущена");
            }
            else
            {
                randomGeneration.stop();
                MessageBox.Show("Генерация остановлена");
            }
        }



        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            generationLogger.Clear();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool generationStatus = randomGeneration.status();
            if (generationStatus)
            {
                MessageBox.Show("Генерация уже запущена");
            }
            else
            {
                listBox1.Items.Clear();
                generationLogger.Clear();
                textBox1.Text = "";
                randomGeneration.start();
                MessageBox.Show("Новая генерация запущена");
                Thread generationThread = new Thread(EventGeneration);
                generationThread.Start();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            bool generationStatus = randomGeneration.status();
            if (generationStatus)
            {
                MessageBox.Show("Сначала остановите генерацию");
            }
            else
            {
                textBox1.Text = generationLogger.ShowLogs();
            }
        }

        private void SaveTXT_Click(object sender, EventArgs e)
        {
            string sourceText = textBox1.Text;
            try
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, textBox1.Text);
                MessageBox.Show("Файл сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка");
                textBox1.Text = sourceText;
            }
        }

        private void SaveXML_Click(object sender, EventArgs e)
        {
            string sourceText = textBox1.Text;
            try
            {
                List<DateTime> listDate = generationLogger.ShowListOfDate();
                List<Event> listEvents = generationLogger.ShowListOfEvents();
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Logs");
                    worksheet.Cell("A1").Value = "Date";
                    worksheet.Cell("B1").Value = "Name";
                    worksheet.Cell("C1").Value = "Type";
                    worksheet.Cell("D1").Value = "Action";
                    int i = 2;
                    foreach (DateTime Date in listDate)
                    {
                        worksheet.Cell("A" + i.ToString()).Value = Date;
                        ++i;
                    }
                    i = 2;
                    foreach (Event generationEvent in listEvents)
                    {
                        worksheet.Cell("B" + i.ToString()).Value = generationEvent.Name;
                        worksheet.Cell("C" + i.ToString()).Value = generationEvent.Type();
                        worksheet.Cell("D" + i.ToString()).Value = generationEvent.Action;
                        ++i;
                    }
                    workbook.SaveAs("Logs.xlsx");
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
                textBox1.Text = sourceText;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}