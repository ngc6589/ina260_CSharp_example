using FtdiSharp;
using ScottPlot;
using ScottPlot.Renderable;
using System.Net;

namespace ina260
{
    public partial class Form1 : Form
    {
        public static int devIndex;
        public static byte i2cAddress;
        public static FtdiDevice dev;
        public static FtdiSharp.Protocols.I2C? i2c;
        public static double[] axisV = new double[0];
        public static double[] axisA = new double[0];
        public static int count = 0;
        public static double sumMAH = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            string str;
            buttonStart.Enabled = false;
            buttonStop.Enabled = false;
            listBox1.Items.Clear();
            foreach (FtdiDevice device in FtdiDevices.Scan())
            {
                str = device.Index.ToString();
                str += " ";
                str += device.Type.ToString();
                str += " ";
                str += device.ID.ToString();
                str += " ";
                str += device.Description.ToString();
                listBox1.Items.Add(str);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            try
            {
                FtdiDevice[] dev1 = FtdiDevices.Scan();
                FtdiSharp.Protocols.I2C i2c = new(dev1[listBox1.SelectedIndex]);
                devIndex = listBox1.SelectedIndex;
                dev = dev1[listBox1.SelectedIndex];
                listBox2.Items.Clear();
                // Show all the I2C addresses in use
                foreach (byte address in i2c.Scan())
                {
                    listBox2.Items.Add(address.ToString("X2"));
                }
                i2c.Dispose();
            }
            catch
            {
                MessageBox.Show("このアダプタは使えません", "ERROR");
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? str;
            if (listBox2.SelectedItem is not null)
            {
                str = listBox2.SelectedItem.ToString();
                i2cAddress = Convert.ToByte(str, 16);
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] i2cData = new byte[2];
            byte[] readData = new byte[4];
            Int32 intValue;
            double current;
            double voltage;
            double power;

            i2c.Write(i2cAddress, 1);
            i2cData = i2c.Read(i2cAddress, 2);
            readData[1] = i2cData[0];
            readData[0] = i2cData[1];
            if (i2cData[0] >= 0x80)
            {
                readData[2] = 0xff;
                readData[3] = 0xff;
            }
            else
            {
                readData[2] = 0x00;
                readData[3] = 0x00;
            }
            intValue = BitConverter.ToInt32(readData, 0);
            current = intValue;
            current = current * 1.25;
            textBoxCurrent.Text = current.ToString("f3");

            i2c.Write(i2cAddress, 2);
            i2cData = i2c.Read(i2cAddress, 2);
            readData[3] = 0x00;
            readData[2] = 0x00;
            readData[1] = i2cData[0];
            readData[0] = i2cData[1];
            intValue = BitConverter.ToInt32(readData, 0);
            voltage = intValue;
            voltage = voltage * 1.25 / 1000;
            textBoxVolt.Text = voltage.ToString("f3");

            i2c.Write(i2cAddress, 3);
            i2cData = i2c.Read(i2cAddress, 2);
            readData[3] = 0x00;
            readData[2] = 0x00;
            readData[1] = i2cData[0];
            readData[0] = i2cData[1];
            intValue = BitConverter.ToInt32(readData, 0);
            power = intValue;
            power = power / 100;
            textBoxPower.Text = power.ToString("f3");

            // mAh
            if(current < 0)
            {
                current = current * (-1);
            }
            sumMAH = sumMAH + (current / 3600);
            textBoxMAH.Text = sumMAH.ToString("f3");

            updatePlot(current, voltage);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            timer1.Enabled = true;
            i2c = new(dev);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            i2c.Dispose();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            timer1.Enabled = false;
        }

        void updatePlot(double current, double voltage)
        {
            count++;
            //axisX = axisX.Append(count).ToArray();
            axisV = axisV.Append(voltage).ToArray();
            axisA = axisA.Append(current).ToArray();
            formsPlot1.Plot.Clear();
            var y1 = formsPlot1.Plot.AddSignal(axisV);
            var y2 = formsPlot1.Plot.AddSignal(axisA);
            y2.YAxisIndex = 2;
            y1.MarkerShape = MarkerShape.none;
            y1.Color = Color.Red;
            y2.MarkerShape = MarkerShape.none;
            y2.Color = Color.Orange;

            formsPlot1.Plot.AxisAutoX();
            double xmax;
            double xmin;
            try
            {
                xmax = Convert.ToDouble(textBoxVMAX.Text);
                xmin = Convert.ToDouble(textBoxVMIN.Text);
                formsPlot1.Plot.SetAxisLimits(yMin: xmin, yMax: xmax, yAxisIndex: 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            try
            {
                xmax = Convert.ToDouble(textBoxIMAX.Text);
                xmin = Convert.ToDouble(textBoxIMIN.Text);
                formsPlot1.Plot.SetAxisLimits(yMin: xmin, yMax: xmax, yAxisIndex: 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            formsPlot1.Refresh();
            formsPlot1.Render();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formsPlot1.Plot.XLabel("Time(s)");

            var y1 = formsPlot1.Plot.AddSignal(axisV);
            y1.YAxisIndex = formsPlot1.Plot.LeftAxis.AxisIndex;
            formsPlot1.Plot.YAxis.Label("電圧(V)");

            var y2 = formsPlot1.Plot.AddSignal(axisA);
            var y2idx = formsPlot1.Plot.AddAxis(Edge.Left);
            y2.YAxisIndex = y2idx.AxisIndex;
            y2idx.Label("電流(mA)");
        }
    }
}
