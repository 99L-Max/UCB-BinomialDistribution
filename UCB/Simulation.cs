using System;

namespace UCB
{
    class Simulation
    {
        private readonly Random rnd = new Random();//Генератор случайных чисел
        private static readonly byte J = 2;//Количество вариантов решений
        private readonly int[] k = new int[J];//Количество успешных решений
        private int sumK;//Общее количество успешных решений
        private readonly double[] U = new double[J];//Верхние границы доверительных интервалов
        private static int N, K, M;//Горизонт управления, число пакетов и размер пакета
        private static double D, sqrtDivDN, sqrtMulDN;//Дисперсия и корень из D/N и DN
        private static double p;//Вероятность
        private readonly double[] X = new double[J];//Сумма доходов
        private readonly double[] m = new double[J];//Мат. ожидания
        private readonly double a;//Коэффициент
        private static int numberOfSimulations;//Количество симуляций
        private double maxD = 0d;//Точка максимума функции потерь
        private double maxL = 0d;//Максимум функции потерь
        private static readonly double[] bordersD = { 0.3d, 7.5d, 0.3d };//Границы d. Начало, конец и шаг
        public static readonly int countOfValuesLd = (int)((bordersD[1] - bordersD[0]) / bordersD[2]) + 1;//Длина массивов d и ld
        private static readonly double[] d = new double[countOfValuesLd];//Массив значений d
        private readonly double[] ld = new double[countOfValuesLd];//Массив значений l(d)
        private byte progress = 0;//Индекс массива результатов и "количество" прогресса
        //Свойства
        public double A => a;
        public double MaxD => maxD;
        public double MaxL => maxL;
        public static int PakageSize => M;
        public static int CountPakage => K;
        public static double Dispersion => D;
        //Задание M, K, D
        public static void SetHorizonAndDispersion(int valueM, int valueK, double valueD)
        {
            K = valueK > 0 ? valueK : 1;
            M = valueM > 0 ? valueM : 1;
            N = K * M;
            D = valueD > 0 ? valueD : 1;
            sqrtDivDN = Math.Sqrt(D / N);
            sqrtMulDN = Math.Sqrt(D * N);
        }
        public static int NumberOfSimulations
        {
            set => numberOfSimulations = value > 50000 ? value : 50000;
            get => numberOfSimulations;
        }
        public byte Progress => progress;
        public static double P
        {
            set => p = value >= 0d && value <= 1d ? value : 0.5d;
            get => p;
        }
        public static double GetValueD(int i) => d[i];
        //Инициализация d
        public static void SetValuesD()
        {
            double value = bordersD[0];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = Math.Round(value, 1);
                value += bordersD[2];
            }
        }
        public double GetValueLd(int i) => ld[i];
        //Конструктор
        public Simulation(double a) { this.a = a; }
        //Симуляция
        public void RunSimulation()
        {
            foreach (double d in d)//Цикл перебора d
            {
                ld[progress] = 0d;
                //Мат. ожидание
                for (byte s = 0; s < m.Length; s++)
                    m[s] = (s == 0 ? d : -d) * sqrtDivDN;
                //Цикл симуляций
                for (int num = 0; num < numberOfSimulations; num++)
                {
                    //Сброс старых значений и выбор 1-го действия
                    sumK = 0;
                    for (int i = 0; i < J; i++)
                    {
                        X[i] = 0d;
                        k[i] = 0;
                        //Первое действие
                        StrategySelected(i);
                    }
                    for (int j = J; j < K; j++)
                    {
                        for (byte s = 0; s < J; s++)
                            U[s] = X[s] / k[s] + a * Math.Sqrt(D * M * Math.Log(sumK) / k[s]);
                        StrategySelected(U[0] > U[1] ? 0 : 1);
                    }
                    //Функция потерь
                    ld[progress] += N * Math.Max(p + m[0], p + m[1]);
                    foreach (var el in X)
                        ld[progress] -= el;
                }
                //Конец цикла симуляций
                //Усреднение и нормировка функции потерь l(d)
                ld[progress] /= numberOfSimulations * sqrtMulDN;
                //Проверка на максимум
                if (maxL < ld[progress])
                {
                    maxL = ld[progress];
                    maxD = d;
                }
                progress++;
            }
        }
        //Генератор биномиального распределения
        private int Binary(int i)
        {
            double pl = p + m[i];
            int res = 0;
            for (int j = 0; j < M; j++)
                if (rnd.NextDouble() < pl)
                    res++;
            return res;
        }
        //Выбрана стратегия
        private void StrategySelected(int i)
        {
            X[i] += Binary(i);
            k[i]++;
            sumK++;
        }
    }
}