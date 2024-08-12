using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyChart
{
    public partial class 图表测试demo : Form
    {

        // 生成数据用
        int[] a = new int[50];
        
        // 计数用
        int count = 0;


        // 自动生成随机用
        private int 循环数;

        Random rnd = new Random();//生成随机数种子

        // 在类中定义一个字段来存储所有的图表类型
        private List<SeriesChartType> chartTypes;
        private int currentChartTypeIndex = 0;





        public 图表测试demo()
        {
            InitializeComponent();

            //这段代码的作用是初始化一个整型数组和一个计数器变量，具体解释如下：
            //这两个变量配合使用，数组 a 用来存储数据，而 count 用来记录已经存储了多少数据。这样在后续的代码中，可以利用 count 来控制数据的添加和处理。

            // 初始化图表类型列表
            chartTypes = new List<SeriesChartType>
    {

             
        SeriesChartType.Line,
        SeriesChartType.Spline,
        SeriesChartType.StepLine,
        SeriesChartType.FastLine,
        SeriesChartType.Area,
        SeriesChartType.SplineArea,
        SeriesChartType.StackedArea,
        SeriesChartType.StackedArea100,
        SeriesChartType.Stock,
        SeriesChartType.Range,
        SeriesChartType.SplineRange,
        SeriesChartType.Polar,
        SeriesChartType.ErrorBar,
        SeriesChartType.Kagi,
        SeriesChartType.PointAndFigure,
        SeriesChartType.Pie,
        SeriesChartType.Doughnut
        // 添加其他你想要的图表类型
    };



            循环数 = 0;

            chart1.Series[0].Points.Clear();




            //鼠标停留显示数值
            //chart1.Series[0].ToolTip = "X: #VALX, Y: #VALY";


            //chart1.Series[0].Points.AddXY(1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create cursor object

        }

        private void button1_Click(object sender, EventArgs e)//添加
        {

            // 这段代码是在一个按钮点击事件（`button1_Click`）中执行的。它的作用是将文本框 `textBox2` 中的文本转换为整数，并将其存储在一个数组 `a` 的指定位置（由 `count` 索引指定），然后递增 `count`，最后调用 `updateChart()` 函数更新图表。具体解释如下：
 
            a[count] = Convert.ToInt32(数值.Text);

            count++;


            更新图表();
        }
        void 更新图表()//重新绘制
        {

            //这一行代码清空图表中 Series[0] 的所有数据点。这样做是为了确保在重新绘制图表之前，先移除旧的数据。
            //这是一段循环代码，从 i = 0 开始循环，一直到 i < count 为止，每次循环 i 递增1。count 是一个表示当前数据点数量的变量。
            //在每次循环中，这一行代码将 i 和数组 a 中对应索引 i 的值作为X和Y轴的值，添加到图表的 Series[0] 中。这样就把数据绘制到了图表上。
             
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < count; i++)

                chart1.Series[0].Points.AddXY(i, a[i]);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 插入_Click(object sender, EventArgs e)//插入数据
        {

            int pos = Convert.ToInt32(位置.Text);

            if (pos >= count) pos = count;

            for (int i = count; i > pos; i--)

                a[i] = a[i - 1];

            a[pos] = Convert.ToInt32(位置.Text); //插入数据

            count++;

            更新图表();
        }

        private void 删除_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(位置.Text);
            //将 textBox1 中的文本转换为整数，并存储在变量 pos 中，表示要删除的数据的位置。
            if (pos > count - 1 || pos < 0)
            //这段代码检查 pos 是否在有效范围内。如果 pos 超出了当前数组中的数据范围（即 pos 大于 count - 1 或小于 0），则执行以下代码。
            {
                System.Media.SystemSounds.Beep.Play();
                //播放一个系统提示音，提示用户输入的位置无效。
                return;
                //return;
            }
            for (int i = pos; i <= count - 2; i++) //删除数据
                //这段循环代码从 pos 开始，将 pos 位置之后的数据依次向前移动一位，以覆盖被删除的数据。
                a[i] = a[i + 1];
            //这一行在循环中执行，将数组中 i + 1 位置的值赋给 i 位置，实现数据的前移。
            count--;
            //删除数据后，count 减少 1，表示数组中的数据数量减少。

            更新图表();




        }

        private void 生成_Click(object sender, EventArgs e)//生成
        {

            Random rnd = new Random(); // 生成随机数的对象

            count = 50; //图表数据修改为50个

            for (int i = 0; i < 50; i++)
            {
                a[i] = rnd.Next(1, 36); // 生成1到255之间的随机数
            }

            更新图表();
        }

        private void 排序_Click(object sender, EventArgs e)//排序
        {

            List<int> listValues = new List<int>(); // 创建一个新的整型列表
            listValues.Clear(); // 清空列表中的所有元素

            for (int i = 0; i < count; i++) // 将数组a中的元素添加到列表中
                listValues.Add(a[i]);

            listValues.Sort(); // 对列表中的元素进行升序排序
                               // listValues.Reverse(); // 如果需要逆序排列，可以取消注释这行代码

            for (int i = 0; i < count; i++) // 将排序后的列表中的元素重新放回数组a中
                a[i] = listValues[i];



            更新图表();
        }

        private void 修改_Click(object sender, EventArgs e)//修改
        {
            int pos = Convert.ToInt32(位置.Text); // 将textBox1中的文本转换为整数，表示要修改的位置
            if (pos > count - 1 || pos < 0) // 检查位置是否在有效范围内
            {
                System.Media.SystemSounds.Beep.Play(); // 如果位置无效，播放提示音
                return; // 退出方法，不执行后续代码
            }
            a[pos] = Convert.ToInt32(数值.Text); // 修改数组a中指定位置的值，将其设为textBox2中的值


            更新图表();
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            int pos = Convert.ToInt32(位置.Text); // 将textBox1中的文本转换为整数，表示要查询的位置
            if (pos > count - 1 || pos < 0) // 检查位置是否在有效范围内
            {
                System.Media.SystemSounds.Beep.Play(); // 如果位置无效，播放提示音
                return; // 退出方法，不执行后续代码
            }


            MessageBox.Show(a[pos].ToString());

            更新图表();

        }



        private void 时钟_Tick(object sender, EventArgs e)
        {
 

            int yValue = rnd.Next(3, 25);


            chart1.Series[0].Points.AddXY(循环数, yValue);


            // 假设你要将X轴标题更新为当前时间的字符串表示

            string 电压 = yValue.ToString();

            DateTime currentValue = DateTime.Now;

            // 更新X轴的标题为当前值
            chart1.ChartAreas[0].AxisX.Title = $"电压: {电压} V 时间: {currentValue:HH:mm:ss}";


            // 隐藏所有数据点的标签
            foreach (var point in chart1.Series[0].Points)

            {
                point.Label = string.Empty;
            }

            // 显示最新数据点的标签
            chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].Label = yValue.ToString() + " V";

            // 使X轴滚动，以显示最新的20个数据点
            if (chart1.Series[0].Points.Count > 20)

            {
                chart1.ChartAreas[0].AxisX.Minimum = 循环数 - 19;
                chart1.ChartAreas[0].AxisX.Maximum = 循环数;
            }

            循环数++;

        }



        private void 选择框_CheckedChanged(object sender, EventArgs e)
        {
            if (选择框.Checked)
            {

                chart1.Series[0].Points.Clear();

                时钟.Interval = 200;

                // 重置 X 轴的值为默认值（自动计算）
                chart1.ChartAreas[0].AxisX.Minimum = Double.NaN;

                // 重置 X 轴的最大值为默认值
                chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;
                chart1.Invalidate();


                循环数 = 0;

                时钟.Start();

                Debug.WriteLine("时钟开启了!");
                // 在这里添加你想要执行的逻辑
            }
            else
            {

                时钟.Stop();

                Debug.WriteLine("时钟关闭了!");
                // 在这里添加取消选中时的逻辑
            }

        }//随机输入数据

        private void chart1_MouseMove(object sender, MouseEventArgs e)//实时显示数据
        {

            // 将鼠标坐标转换为图表区域内的坐标
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            // 检查鼠标是否位于数据点上
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint point = chart1.Series[0].Points[result.PointIndex];

                string toolTipText = $"时间: {point.XValue}, 电压: {point.YValues[0]} V";


                // 显示自定义的ToolTip
                toolTip1.Show(toolTipText, chart1, e.X, e.Y - 15);

            }
            else
            {
                // 如果鼠标没有悬停在数据点上，隐藏ToolTip
                toolTip1.Hide(chart1);
            }



        }

        private void 样式_Click(object sender, EventArgs e)//样式切换
        {
            // 切换到下一个图表类型
            currentChartTypeIndex++;
            if (currentChartTypeIndex >= chartTypes.Count)
            {
                currentChartTypeIndex = 0; // 回到第一个类型
            }

            // 设置当前的图表类型
            chart1.Series[0].ChartType = chartTypes[currentChartTypeIndex];
        }

        private void 图表测试demo_FormClosed(object sender, FormClosedEventArgs e)//安全销毁
        {
            chart1.Series[0].Dispose();
        }

        private void button2_Click(object sender, EventArgs e)//清空
        {

            时钟.Stop();

            chart1.Series[0].Points.Clear();

            // 重置 X 轴的值为默认值（自动计算）
            chart1.ChartAreas[0].AxisX.Minimum = Double.NaN;

            // 重置 X 轴的最大值为默认值
            chart1.ChartAreas[0].AxisX.Maximum = Double.NaN;

            chart1.Invalidate();

            循环数 = 0;

        }
    }
}