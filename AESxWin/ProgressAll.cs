using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AESxWin
{
    public partial class ProgressAll : UserControl
    {
        
        public ProgressAll()
        {
            InitializeComponent();
        }
        
        public int Maximum
        {
            get
            {
                return this.progressBar1.Maximum;
            }
            set
            {
                this.progressBar1.Maximum = value;
            }
        }
        
        public int Minimum
        {
            get
            {
                return this.progressBar1.Minimum;

            }
            set
            {
                this.progressBar1.Minimum = value;

            }
        }
        
        public int Value
        {
            get
            {
                return this.progressBar1.Value;
            }
            set
            {
                this.progressBar1.Value = value;
            }
        }
        
        public int Step
        {
            get
            {
                return this.progressBar1.Step;
            }
            set
            {
                this.progressBar1.Step = value;
            }
        }

        public void PerformStep()
        {
            if (this.InvokeRequired)
                this.Invoke(new Action(this.PerformStep));
            else
            {
                this.progressBar1.PerformStep();
                this.label1.Text = $"{this.progressBar1.Value}/{this.progressBar1.Maximum}";
            }
        }

    }
}
