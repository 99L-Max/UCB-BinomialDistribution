using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCB
{
    public partial class FormMain : Form
    {
        private bool isFinished = true;//Активность потоков и преждевременное завершение
        private Thread[] thread;//Массив задач
        private Simulation[] sim;//Массив объектов
        private short indexOptimalA = -1;//Индекс оптимального а
        public FormMain()
        {
            InitializeComponent();
            numericUpDown_ValueChanged(null, null);
            numericUpDownM_ValueChanged(null, null);
            Simulation.SetValuesD();
        }
        //Блокировка/разблокировка элементов управления
        private void LockUnlockElements()
        {
            numericUpDownK.Enabled =
                numericUpDownM.Enabled =
                numericUpDownCountThreads.Enabled =
                numericUpDownP.Enabled =
                numericUpDownD.Enabled =
                numericUpDownA0.Enabled =
                numericUpDownDeltaA.Enabled =
                menuStrip.Enabled =
                numericUpDownCountOfSimulations.Enabled =
                buttonStart.Enabled = !buttonStart.Enabled;
            buttonCancel.Enabled = !buttonCancel.Enabled;
            progressBar.Visible = labelProgress.Visible = !labelProgress.Visible;
        }
        //Кнопка "Запуск"
        private async void buttonStart_Click(object sender, EventArgs e)
        {
            новыйToolStripMenuItem_Click(null, null);
            LockUnlockElements();
            isFinished = false;
            byte countA = (byte)numericUpDownCountThreads.Value;//Число вариантов а
            double a = (double)numericUpDownA0.Value;//Начальное значение a
            double da = (double)numericUpDownDeltaA.Value;//Шаг изменения а
            Simulation.SetHorizonAndDispersion((int)numericUpDownM.Value, (int)numericUpDownK.Value, (int)numericUpDownD.Value);//Горизонт и дисперсия
            Simulation.NumberOfSimulations = (int)numericUpDownCountOfSimulations.Value;//Число симуляций
            Simulation.P = (double)numericUpDownP.Value;//Вероятность
            thread = new Thread[countA];//Массив задач
            sim = new Simulation[countA];//Массив объектов
            //Вычисление функции потерь при каждом а
            for (byte i = 0; i < countA; i++)
            {
                sim[i] = new Simulation(a);
                thread[i] = new Thread(sim[i].RunSimulation);
                thread[i].Start();
                a += da;
            }
            //Ожидание завершения
            byte j = 0;
            int progress;
            while (j < thread.Length)
            {
                //Отмена операции
                if (isFinished)
                {
                    for (byte i = 0; i < thread.Length; i++)
                        thread[i].Abort();
                    LockUnlockElements();
                    return;
                }
                //Поток завершён?
                if (!thread[j].IsAlive)
                {
                    j++;
                    continue;
                }
                //Обновление progressBar
                progress = 0;
                foreach (var el in sim)
                {
                    progress += el.Progress;
                }
                UpdateProgress(progress * 100 / (Simulation.countOfValuesLd * countA));
                await Task.Delay(1000);
            }
            UpdateProgress(progressBar.Maximum);
            //Работа с результатами. Поиск оптимального а
            double minMaxL = double.MaxValue;
            for (byte i = 0; i < sim.Length; i++)
            {
                if (minMaxL > sim[i].MaxL)
                {
                    minMaxL = sim[i].MaxL;
                    indexOptimalA = i;
                }
            }
            textBoxResult.Text = 
                $"a = {sim[indexOptimalA].A}" + Environment.NewLine +
                $"d_max = {sim[indexOptimalA].MaxD}" + Environment.NewLine +
                $"l_max = {Math.Round(sim[indexOptimalA].MaxL, 2)}";
            //Построение графика
            chart.Series[0].Points.AddXY(0, 0);
            for (int i = 0; i < Simulation.countOfValuesLd; i++)
            {
                chart.Series[0].Points.AddXY(Simulation.GetValueD(i), sim[indexOptimalA].GetValueLd(i));
                //Задержка
                await Task.Delay(40);
            }
            LockUnlockElements();
            UpdateProgress(progressBar.Minimum);
            isFinished = true;
        }
        //Кнопка "Отмена"
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите отменить вычисления?", "Отмена операции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            isFinished = dr == DialogResult.Yes;
        }
        //Диапазон а
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBoxAn.Text = ((double)numericUpDownA0.Value + (double)numericUpDownDeltaA.Value * ((int)numericUpDownCountThreads.Value - 1)).ToString();
        }
        //Горизонт
        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {
            textBoxN.Text = (numericUpDownK.Value * numericUpDownM.Value).ToString();
        }
        //Обновление прогресса
        private void UpdateProgress(int progress)
        {
            progressBar.Value = progress;
            labelProgress.Text = "Выполнено " + progress + "%";
        }
        //Закрытие формы
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFinished)
                return;
            MessageBox.Show("Процесс не завершён.\nДождитесь завершения процесса или отмените его.", "Закрытие невозможно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.Cancel = true;
        }
        //Новый
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            indexOptimalA = -1;
            chart.Series[0].Points.Clear();
            textBoxResult.Text = "";
        }
        //Открыть
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            новыйToolStripMenuItem_Click(null, null);
            OpenFileDialog OFDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
            };
            DialogResult dr = OFDialog.ShowDialog();
            if (dr != DialogResult.OK)
                return;
            try
            {
                using (StreamReader reader = new StreamReader(OFDialog.FileName))
                {
                    chart.Series[0].Points.AddXY(0, 0);
                    numericUpDownCountOfSimulations.Value = Convert.ToDecimal(reader.ReadLine());
                    numericUpDownK.Value = Convert.ToDecimal(reader.ReadLine());
                    numericUpDownM.Value = Convert.ToDecimal(reader.ReadLine());
                    numericUpDownP.Value = Convert.ToDecimal(reader.ReadLine());
                    numericUpDownD.Value = Convert.ToDecimal(reader.ReadLine());
                    textBoxResult.Text =
                        $"a = {reader.ReadLine()}" + Environment.NewLine +
                        $"d_max = {reader.ReadLine()}" + Environment.NewLine +
                        $"l_max = {reader.ReadLine()}";
                    for (int i = 0; i < Simulation.countOfValuesLd; i++)
                    {
                        chart.Series[0].Points.AddXY(Simulation.GetValueD(i), Convert.ToDouble(reader.ReadLine()));
                    }
                }
            }
            catch (Exception exc)
            {
                chart.Series[0].Points.Clear();
                MessageBox.Show(exc.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Запись файла
        private void WriteData(short index, string file)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(Simulation.NumberOfSimulations.ToString());
                    writer.WriteLine(Simulation.CountPakage.ToString());
                    writer.WriteLine(Simulation.PakageSize.ToString());
                    writer.WriteLine(Simulation.P.ToString());
                    writer.WriteLine(Simulation.Dispersion.ToString());
                    writer.WriteLine(Math.Round(sim[index].A, 2));
                    writer.WriteLine(Math.Round(sim[index].MaxD, 2));
                    writer.WriteLine(Math.Round(sim[index].MaxL, 2));
                    for (int i = 0; i < Simulation.countOfValuesLd; i++)
                        writer.WriteLine(sim[index].GetValueLd(i).ToString());
                }//Закрытие файла
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Сохранить
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexOptimalA == -1)
                return;
            SaveFileDialog SFDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы|*.txt"//Шаблон
            };
            DialogResult dr = SFDialog.ShowDialog();
            if (dr != DialogResult.OK)//Была ли нажата кнопка "Сохранить"
                return;
            //Запись файла
            WriteData(indexOptimalA, SFDialog.FileName);
        }
        //Сохранить всё
        private void сохранитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexOptimalA == -1)
                return;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)//Была ли нажата кнопка "Сохранить"
                return;
            for (short i = 0; i < sim.Length; i++)
                WriteData(i, $"{folderBrowserDialog.SelectedPath}{Path.DirectorySeparatorChar}Sim({Simulation.NumberOfSimulations / 1000}k)KxM({Simulation.CountPakage}x{Simulation.PakageSize})A({sim[i].A.ToString("f2")}).txt");
        }
        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}