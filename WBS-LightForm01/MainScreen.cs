using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBS_LightForm01
{
    using WSService;

    public partial class MainScreen : Form
    {
        private SetupTool setuptool = new SetupTool();
 
        public MainScreen()
        {
            InitializeComponent();
        }

        private void SetupControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name.Contains("tbLine"))
                {
                    tb.BackColor = Color.Navy;
                }
            }
        }

        private void SetupInputBox()
        {
            tbInputData.Font = new Font(tbInputData.Font.FontFamily, 19);
            tbInputData.BackColor = setuptool.ColorFromName("Olive");

            Size s = new System.Drawing.Size(280, 29);
            tbInputData.Size = s;

            tbInputData.Visible = true;

        }

        private void PlaceInputBox(int LineNo, int Column)
        {
            Point p;
            switch (LineNo)
            {
                case 1:
                    {
                        p = tbLine01.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 2:
                    {
                        p = tbLine02.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 3:
                    {
                        p = tbLine03.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 4:
                    {
                        p = tbLine04.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 5:
                    {
                        p = tbLine05.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 6:
                    {
                        p = tbLine06.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 7:
                    {
                        p = tbLine07.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 8:
                    {
                        p = tbLine08.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 9:
                    {
                        p = tbLine09.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 10:
                    {
                        p = tbLine10.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 11:
                    {
                        p = tbLine01.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 12:
                    {
                        p = tbLine02.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 13:
                    {
                        p = tbLine03.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 14:
                    {
                        p = tbLine04.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 15:
                    {
                        p = tbLine05.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 16:
                    {
                        p = tbLine06.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 17:
                    {
                        p = tbLine07.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 18:
                    {
                        p = tbLine08.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 19:
                    {
                        p = tbLine09.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;
                case 20:
                    {
                        p = tbLine10.Location;
                        p.X = Column;
                        tbInputData.Location = p;
                    }
                    break;

                default:

                    break;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupControls();
            PlaceInputBox(3, 250);
            SetupInputBox();
        }

        private void tbScreen_Enter(object sender, EventArgs e)
        {
            tbInputData.Focus();
        }
    }
}
