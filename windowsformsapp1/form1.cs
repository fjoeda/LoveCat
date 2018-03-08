using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Faturahman Yudanto |16/400356/TK/45370
namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {

        
        List<Point> kumpulantitik = new List<Point>();
        List<Point> titikAsal = new List<Point>();
        List<Point> titikAkhir = new List<Point>();
        Pen pen = new Pen(Color.Black,8);


        bool set = false;
        

        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kumpulantitik = hati;
            titikAkhir = hati;
            //kumpulantitik.Add(new Point(262, 287));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(kumpulantitik.Count>1)
            e.Graphics.DrawLines(pen, kumpulantitik.ToArray());
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //kumpulantitik.Add(e.Location);
            Console.WriteLine(e.Location.ToString());
            count++;
            Console.WriteLine(count.ToString());
            Invalidate();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < kumpulantitik.Count; i++)
            {
                kumpulantitik[i] = MovePointTo(kumpulantitik[i], titikAkhir[i]);
            }


            Invalidate();
        }

        private void Kucing()
        {
            //kumpulantitik.Clear();
            


            //kumpulantitik = kucing;
        }

        private void Hati()
        {
            //kumpulantitik.Clear();
            
            //kumpulantitik = hati;
        }

        private Point MovePointTo(Point awal, Point akhir)
        {
            double r = Math.Sqrt(Math.Pow((awal.X - akhir.X), 2) + Math.Pow((awal.Y - akhir.Y), 2));
            if (awal != akhir&&set == false)
            {
                
                int dx = (int)Math.Round((akhir.X - awal.X) / r);
                int dy = (int)Math.Round((akhir.Y - awal.Y) / r);
                awal.X += dx;
                awal.Y += dy;
            }

            return awal;
        }


        List<Point> kucing = new List<Point>()
            {
               new Point(262,287),
               new Point(284,291),
               new Point(309,281),
               new Point(330,264),
               new Point(351,245),
               new Point(368,222),
               new Point(384,193),
               new Point(388,161),
               new Point(389,118),
               new Point(409,16),
               new Point(321,79),
               new Point(305,71),
               new Point(278,62),
               new Point(252,52),
               new Point(225,58),
               new Point(193,81),
               new Point(176,80),
               new Point(117,16),
               new Point(125,100),
               new Point(119,107),
               new Point(120,123),
               new Point(115,152),
               new Point(120,181),
               new Point(135,204),
               new Point(147,228),
               new Point(160,246),
               new Point(180,261),
               new Point(194,277),
               new Point(214,286),
               new Point(235,291),
               new Point(262,287)
            };

        // This Code is Faturahman Yudanto's pure works
        List<Point> hati = new List<Point>()
            {
                new Point(262,287),
                new Point(293,285),
                new Point(307,273),
                new Point(334,249),
                new Point(350,234),
                new Point(368,216),
                new Point(378,200),
                new Point(391,178),
                new Point(399,150),
                new Point(399,116),
                new Point(394,74),
                new Point(374,46),
                new Point(340,32),
                new Point(305,29),
                new Point(276,46),
                new Point(256,65),
                new Point(237,48),
                new Point(212,35),
                new Point(184,33),
                new Point(151,43),
                new Point(131,66),
                new Point(121,102),
                new Point(122,121),
                new Point(127,145),
                new Point(139,167),
                new Point(147,180),
                new Point(155,192),
                new Point(164,206),
                new Point(179,220),
                new Point(194,235),
                new Point(262,287)
            };

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            //titikAkhir.Clear();
            
            set = true;
            
            titikAkhir = kucing;
            kumpulantitik = hati;
            Invalidate();
            set = false;
            timer1.Enabled=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
            //titikAkhir.Clear();
            set = true;
            
            titikAkhir = hati;
            kumpulantitik = kucing;
            
            Invalidate();
            set = false;
            timer1.Enabled=true;

        }
    }
}
