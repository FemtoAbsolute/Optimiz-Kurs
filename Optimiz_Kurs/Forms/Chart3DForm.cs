using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimiz_Kurs.Forms
{
    public partial class Chart3DForm : Form
    {
        Func<Dictionary<string, double>, double> function;
        float gx, gy, hx, hy;
        public Chart3DForm(Func<Dictionary<string, double>, double> function, double gx, double gy, double hx, double hy)
        {
            this.gx = (float)gx;
            this.gy = (float)gy;
            this.hx = (float)hx;
            this.hy = (float)hy;
            InitializeComponent();
            Controls.Add(_surfacePlotControl);
            this.function = function;
            Load += Chart3DForm_Load;
        }

        private void Chart3DForm_Load(object sender, EventArgs e)
        {
            buttonSettings.Enabled = false;
            _configuration = new OpenControls.Wpf.SurfacePlot.Model.Configuration();

            OpenControls.Wpf.Serialisation.RegistryItemSerialiser configurationSerialiser = new OpenControls.Wpf.Serialisation.RegistryItemSerialiser(RegKeyPath);
            if (!configurationSerialiser.OpenKey())
            {
                configurationSerialiser.CreateKey();
            }
            IConfigurationSerialiser = configurationSerialiser;
            _configuration.Load(configurationSerialiser);

            _surfacePlotControl.Initialise(_configuration);
            //Run();
        }

        string RegKeyPath
        {
            get
            {
                return System.Environment.Is64BitOperatingSystem ? @"SOFTWARE\Wow6432Node\OpenControls.Wpf.SurfacePlotDemo\RawDataSettings" : @"SOFTWARE\OpenControls.Wpf.SurfacePlotDemo\RawDataSettings";
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (_surfacePlotControl != null)
            {
                _surfacePlotControl.SetBounds(
                    ClientRectangle.X,
                    ClientRectangle.Y,
                    ClientRectangle.Width,
                    ClientRectangle.Height);
            }
        }

        OpenControls.Wpf.SurfacePlot.SurfacePlotControl _surfacePlotControl = new OpenControls.Wpf.SurfacePlot.SurfacePlotControl();
        OpenControls.Wpf.SurfacePlot.Model.Configuration _configuration;
        private OpenControls.Wpf.Serialisation.IConfigurationSerialiser IConfigurationSerialiser;

        private void Run()
        {
            buttonSettings.Enabled = true;

            float YStep = (hy - gy) / 50;
            float XStep = (hx - gx) / 50;

            float zMax = float.MinValue;
            float zMin = float.MaxValue;

            List<List<float>> srcData = new List<List<float>>();
            for (float i = gx; i < hx; i += XStep)
            {
                if (srcData.Count >= 50)
                    break;
                List<float> list = new List<float>(); 
                srcData.Add(list);
                for (float j = gy; j < hy; j += YStep)
                {
                    if (list.Count >= 50)
                        break;
                    float z = (float)function(new Dictionary<string, double>() { { "T1", i }, { "T2", j} });
                    if (z > zMax)
                        zMax = z;
                    if (z < zMin)
                        zMin = z;
                    list.Add(z);
                }
            }
            _surfacePlotControl.SetData(srcData, gx, hx, 21, gy, hy, 21, zMin, zMax, 21);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Run();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenControls.Wpf.SurfacePlot.Exports.ShowConfigurationDialog(_configuration);
            _configuration.Save(IConfigurationSerialiser);
        }
    }
}
