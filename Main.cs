using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Othello
{
    public partial class main : Form
    {
        Label[,] b;
        const int WHITE = 1;
        const int BLACK = 0;
        const int EMPTY = -1;
        //image index 1 : 흰색, 0 : 검은색
        public main()
        {

            InitializeComponent();
            

            changeTurn();
        }


        public void startSetting()
        {
            b = new Label[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    b[i, j] = new System.Windows.Forms.Label();
                    b[i, j].BackColor = System.Drawing.Color.FromArgb(52, 173, 93);
                    b[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    b[i, j].Font = new System.Drawing.Font("바탕체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    b[i, j].ForeColor = System.Drawing.Color.White;
                    b[i, j].ImageList = im1;
                    b[i, j].Location = new System.Drawing.Point(132 + (60 * j), 62 + (60 * i));
                    b[i, j].Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                    b[i, j].Name = "b" + i + j;
                    b[i, j].Size = new System.Drawing.Size(60, 60);
                    b[i, j].TabIndex = 0;
                    b[i, j].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    Controls.Add(b[i, j]);
                }
            }

            b[0, 0].Click += b00_Click;
            b[0, 1].Click += b01_Click;
            b[0, 2].Click += b02_Click;
            b[0, 3].Click += b03_Click;
            b[0, 4].Click += b04_Click;
            b[0, 5].Click += b05_Click;
            b[0, 6].Click += b06_Click;
            b[0, 7].Click += b07_Click;
            b[1, 0].Click += b10_Click;
            b[1, 1].Click += b11_Click;
            b[1, 2].Click += b12_Click;
            b[1, 3].Click += b13_Click;
            b[1, 4].Click += b14_Click;
            b[1, 5].Click += b15_Click;
            b[1, 6].Click += b16_Click;
            b[1, 7].Click += b17_Click;
            b[2, 0].Click += b20_Click;
            b[2, 1].Click += b21_Click;
            b[2, 2].Click += b22_Click;
            b[2, 3].Click += b23_Click;
            b[2, 4].Click += b24_Click;
            b[2, 5].Click += b25_Click;
            b[2, 6].Click += b26_Click;
            b[2, 7].Click += b27_Click;
            b[3, 0].Click += b30_Click;
            b[3, 1].Click += b31_Click;
            b[3, 2].Click += b32_Click;
            b[3, 3].Click += b33_Click;
            b[3, 4].Click += b34_Click;
            b[3, 5].Click += b35_Click;
            b[3, 6].Click += b36_Click;
            b[3, 7].Click += b37_Click;
            b[4, 0].Click += b40_Click;
            b[4, 1].Click += b41_Click;
            b[4, 2].Click += b42_Click;
            b[4, 3].Click += b43_Click;
            b[4, 4].Click += b44_Click;
            b[4, 5].Click += b45_Click;
            b[4, 6].Click += b46_Click;
            b[4, 7].Click += b47_Click;
            b[5, 0].Click += b50_Click;
            b[5, 1].Click += b51_Click;
            b[5, 2].Click += b52_Click;
            b[5, 3].Click += b53_Click;
            b[5, 4].Click += b54_Click;
            b[5, 5].Click += b55_Click;
            b[5, 6].Click += b56_Click;
            b[5, 7].Click += b57_Click;
            b[6, 0].Click += b60_Click;
            b[6, 1].Click += b61_Click;
            b[6, 2].Click += b62_Click;
            b[6, 3].Click += b63_Click;
            b[6, 4].Click += b64_Click;
            b[6, 5].Click += b65_Click;
            b[6, 6].Click += b66_Click;
            b[6, 7].Click += b67_Click;
            b[7, 0].Click += b70_Click;
            b[7, 1].Click += b71_Click;
            b[7, 2].Click += b72_Click;
            b[7, 3].Click += b73_Click;
            b[7, 4].Click += b74_Click;
            b[7, 5].Click += b75_Click;
            b[7, 6].Click += b76_Click;
            b[7, 7].Click += b77_Click;

            label64.SendToBack();
            b[3, 3].ImageIndex = WHITE;
            b[3, 4].ImageIndex = BLACK;
            b[4, 3].ImageIndex = BLACK;
            b[4, 4].ImageIndex = WHITE;
        }

        private void Main_Click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Main_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
