using System.Diagnostics;
using System.Xml.Linq;

namespace parallel_ex1
{
    public partial class Form1 : Form
    {
        private class AlgorithmStats
        {
            public int ComparesCount;
            public int SwapsCount;
            public long TotalMillis;

            public AlgorithmStats()
            {
                ComparesCount = 0;
                SwapsCount = 0;
                TotalMillis = 0;
            }

            public override string ToString()
            {
                return $"Compares: {ComparesCount}, Swaps: {SwapsCount}, Elapsed time (ms): {TotalMillis}";
            }
        }

        private int[] elements;

        private int[] bubbleSortArray;
        private int[] selectSortArray;
        private int[] insertionSortArray;

        private AlgorithmStats bubbleSortStats;
        private AlgorithmStats selectSortStats;
        private AlgorithmStats insertionSortStats;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillRandomData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillRandomData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Enabled = false;

            SortData();

            ((Button)sender).Enabled = true;
        }

        private void FillRandomData()
        {
            elements = new int[(int)numericUpDown1.Value];

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                var item = Random.Shared.Next((int)numericUpDown2.Value, (int)numericUpDown3.Value);

                elements[i] = item;

                listBox1.Items.Add(item);
                listBox2.Items.Add(item);
                listBox3.Items.Add(item);
            }
        }

        private void SortData()
        {
            bubbleSortArray = (int[])elements.Clone();
            selectSortArray = (int[])elements.Clone();
            insertionSortArray = (int[])elements.Clone();

            var bubbleSortThread = new Thread(() =>
            {
                bubbleSortStats = BubbleSort(bubbleSortArray);
            });

            var selectSortThread = new Thread(() =>
            {
                selectSortStats = SelectSort(selectSortArray);
            });

            var insertionSortThread = new Thread(() =>
            {
                insertionSortStats = InsertionSort(insertionSortArray);
            });

            bubbleSortThread.Start();
            selectSortThread.Start();
            insertionSortThread.Start();

            bubbleSortThread.Join();
            selectSortThread.Join();
            insertionSortThread.Join();

            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            foreach (var item in bubbleSortArray) listBox4.Items.Add(item);
            foreach (var item in selectSortArray) listBox5.Items.Add(item);
            foreach (var item in insertionSortArray) listBox6.Items.Add(item);

            richTextBox1.Text = $"Bubble Sort: {bubbleSortStats}\n\nSelect Sort: {selectSortStats}\n\nInsertion Sort: {insertionSortStats}";
        }

        private AlgorithmStats BubbleSort(int[] array)
        {
            var stats = new AlgorithmStats();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int temporary;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    stats.ComparesCount++;

                    if (array[i] > array[i + 1])
                    {
                        stats.SwapsCount++;

                        temporary = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temporary;
                    }
                }
            }

            stopwatch.Stop();
            stats.TotalMillis = stopwatch.ElapsedMilliseconds;

            return stats;
        }

        private AlgorithmStats SelectSort(int[] array)
        {
            var stats = new AlgorithmStats();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int smallestVal = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallestVal])
                    {
                        stats.ComparesCount++;

                        smallestVal = j;
                    }
                }

                stats.SwapsCount++;

                int temporary = array[smallestVal];
                array[smallestVal] = array[i];
                array[i] = temporary;
            }

            stopwatch.Stop();
            stats.TotalMillis = stopwatch.ElapsedMilliseconds;

            return stats;
        }

        private AlgorithmStats InsertionSort(int[] array)
        {
            var stats = new AlgorithmStats();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            int value;
            int flag;
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                value = array[i];
                flag = 0;

                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    stats.ComparesCount++;

                    if (value < array[j])
                    {
                        stats.SwapsCount++;

                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                    }
                    else flag = 1;
                }
            }

            stopwatch.Stop();
            stats.TotalMillis = stopwatch.ElapsedMilliseconds;

            return stats;
        }
    }
}
