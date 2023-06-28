using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using ClosedXML.Excel;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        class Logger
        {
            List<EventToLog> listEvents = new List<EventToLog>();
            public Logger()
            {
                List<EventToLog> listEvents = new List<EventToLog>();
                File.WriteAllText("log.txt", "");
            }
            public void Clear()
            {
                List<EventToLog> listEvents = new List<EventToLog>();
                File.WriteAllText("log.txt", "");
            }
            public List<EventToLog> ShowLogs(string TypeFilter = "None", string ActionFilter = "None")
            {
                if (ActionFilter == "None" && TypeFilter == "None")
                {
                    return listEvents;
                }
                else if (ActionFilter == "None")
                {
                    var filtredEvent = new List<EventToLog>();
                    foreach (EventToLog eachEvent in listEvents)
                    {
                        if (eachEvent.Type == TypeFilter)
                        {
                            filtredEvent.Add(eachEvent);
                        }
                    }



                    return filtredEvent.ToList();
                }
                else if (TypeFilter == "None")
                {
                    var filtredEvent = new List<EventToLog>();
                    foreach (EventToLog eachEvent in listEvents)
                    {
                        if (eachEvent.Action == ActionFilter)
                        {
                            filtredEvent.Add(eachEvent);
                        }
                    }
                    return filtredEvent.ToList();
                }
                else
                {
                    return listEvents;
                }

            }



            public List<EventToLog> ShowListOfEvents()
            {
                return listEvents;
            }

            public void LogEvent(EventToLog eventToLog)
            {
                listEvents.Add(eventToLog);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("log.txt", true))
                {
                    file.WriteLine($"{eventToLog.Date} - Пользователь {eventToLog.Action} {eventToLog.Type} {eventToLog.Name}");
                }
            }

        }


        class Event
        {
            public string Name { get; set; }
            public string Action { get; set; }

            public Event(string name, string action)
            {
                Name = name;
                Action = action;
                Type = "";
            }

            public string Type { get; set; }


        }

        class EventToLog : Event
        {
            public EventToLog(string name, string action, DateTime date, string type) : base(name, action)
            {
                Date = date;
                Type = type;
            }
            public DateTime Date { get; set; }
        }

        class Test : Event
        {
            public Test(string name, string action) : base(name, action)
            {
                Type = "Тест";
            }

        }

        class Exam : Event
        {
            public Exam(string name, string type) : base(name, type)
            {
                Type = "Экзамен";
            }

        }
        class Question : Event
        {
            public Question(string name, string type) : base(name, type)
            {
                Type = "Вопрос";
            }
        }
        class Trial : Event
        {
            public Trial(string name, string type) : base(name, type)
            {
                Type = "Испытание";
            }
        }

        Logger logger = new Logger();
        Event curEvent = new Event("None", "None");
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (curEvent.Name == "None")
            {
                int numberOfEvent = rand.Next(1, 100000);
                curEvent = new Test("Тест №" + numberOfEvent.ToString(), "начал");
                DateTime curDate = DateTime.Now;
                EventToLog eToLog = new EventToLog(curEvent.Name, curEvent.Action, curDate, curEvent.Type);
                logger.LogEvent(eToLog);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eToLog.Date} - Пользователь {eToLog.Action} {eToLog.Type} {eToLog.Name}"); }));


            }
            else
            {
                MessageBox.Show("Сначала завершите предыдущее событие");
            }
        }

        private void StartExam_Click(object sender, EventArgs e)
        {
            if (curEvent.Name == "None")
            {
                int numberOfEvent = rand.Next(1, 100000);
                curEvent = new Exam("Экзамен №" + numberOfEvent.ToString(), "начал");
                DateTime curDate = DateTime.Now;
                EventToLog eToLog = new EventToLog(curEvent.Name, curEvent.Action, curDate, curEvent.Type);
                logger.LogEvent(eToLog);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eToLog.Date} - Пользователь {eToLog.Action} {eToLog.Type} {eToLog.Name}"); }));

            }
            else
            {
                MessageBox.Show("Сначала завершите предыдущее событие");
            }
        }

        private void StartQuestion_Click(object sender, EventArgs e)
        {
            if (curEvent.Name == "None")
            {
                int numberOfEvent = rand.Next(1, 100000);
                curEvent = new Question("Вопрос №" + numberOfEvent.ToString(), "начал");
                DateTime curDate = DateTime.Now;
                EventToLog eToLog = new EventToLog(curEvent.Name, curEvent.Action, curDate, curEvent.Type);
                logger.LogEvent(eToLog);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eToLog.Date} - Пользователь {eToLog.Action} {eToLog.Type} {eToLog.Name}"); }));

            }
            else
            {
                MessageBox.Show("Сначала завершите предыдущее событие");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (curEvent.Name == "None")
            {
                int numberOfEvent = rand.Next(1, 100000);
                curEvent = new Trial("Испытание №" + numberOfEvent.ToString(), "начал");
                DateTime curDate = DateTime.Now;
                EventToLog eToLog = new EventToLog(curEvent.Name, curEvent.Action, curDate, curEvent.Type);
                logger.LogEvent(eToLog);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eToLog.Date} - Пользователь {eToLog.Action} {eToLog.Type} {eToLog.Name}"); }));

            }
            else
            {
                MessageBox.Show("Сначала завершите предыдущее событие");
            }
        }

        private void StopEvent_Click(object sender, EventArgs e)
        {
            if (curEvent.Name != "None")
            {
                DateTime curDate = DateTime.Now;
                EventToLog eToLog = new EventToLog(curEvent.Name, "завершил", curDate, curEvent.Type);
                curEvent = new Event("None", "None");
                logger.LogEvent(eToLog);
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eToLog.Date} - Пользователь {eToLog.Action} {eToLog.Type} {eToLog.Name}"); }));
            }
            else
            {
                MessageBox.Show("Никакое событие не было запущено");
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void СlearFilters_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("None", "None"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }

        }

        private void OnlyTests_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("Тест", "None"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void OnlyExams_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("Экзамен", "None"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void OnlyQuestions_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("Вопрос", "None"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void OnlyTrials_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("Испытание", "None"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void OnlyStart_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("None", "начал"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void OnlyStop_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var eachEvent in logger.ShowLogs("None", "завершил"))
            {
                listBox1.Invoke(new Action(() => { listBox1.Items.Add($"{eachEvent.Date} - Пользователь {eachEvent.Action} {eachEvent.Type} {eachEvent.Name}"); }));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<EventToLog> listEvents = logger.ShowLogs();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Logs");
                worksheet.Cell("A1").Value = "Date";
                worksheet.Cell("B1").Value = "Name";
                worksheet.Cell("C1").Value = "Type";
                worksheet.Cell("D1").Value = "Action";
                int i = 2;
                foreach (var eachEvent in listEvents)
                {
                    DateTime Date = eachEvent.Date;
                    worksheet.Cell("A" + i.ToString()).Value = Date;
                    ++i;
                }
                i = 2;
                foreach (Event generationEvent in listEvents)
                {
                    worksheet.Cell("B" + i.ToString()).Value = generationEvent.Name;
                    worksheet.Cell("C" + i.ToString()).Value = generationEvent.Type;
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
    }
}