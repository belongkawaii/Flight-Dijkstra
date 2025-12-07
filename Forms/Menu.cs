using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Flight_Dijkstra.Forms
{
    public partial class Menu : Form
    {
        List<Point> nodes = new List<Point>();
        List<Edge> edges = new List<Edge>();
        Random rand = new Random();
        public Menu()
        {
            InitializeComponent();
        }

        public class Edge
        {
            public int From;
            public int To;
            public int Weight;

            public Edge(int f, int t, int w)
            {
                From = f;
                To = t;
                Weight = w;
            }
        }
        private void GenerateRandomEdges()
        {
            edges.Clear();

            int edgeCount = rand.Next(nodes.Count - 1, nodes.Count * 2);
            // Số cạnh random (từ gần bằng số nút đến gấp đôi)

            HashSet<string> used = new HashSet<string>();

            for (int i = 0; i < edgeCount; i++)
            {
                int a = rand.Next(0, nodes.Count);
                int b = rand.Next(0, nodes.Count);

                // Không cho cạnh tự nối chính nó
                if (a == b) { i--; continue; }

                // Không cho cạnh trùng (vô hướng)
                string key1 = a + "-" + b;
                string key2 = b + "-" + a;

                if (used.Contains(key1) || used.Contains(key2))
                {
                    i--;
                    continue;
                }

                used.Add(key1);
                used.Add(key2);

                int weight = rand.Next(1, 20);

                edges.Add(new Edge(a, b, weight));
            }

            panelHeader.Invalidate();
        }



        private void GenerateRandomPoints(int count)
        {
            nodes.Clear();

            for (int i = 0; i < count; i++)
            {
                int x = rand.Next(20, panelHeader.Width - 20);
                int y = rand.Next(20, panelHeader.Height - 20);
                nodes.Add(new Point(x, y));
            }

            panelHeader.Invalidate(); // vẽ lại
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // vẽ cạnh + trọng số
            foreach (var edge in edges)
            {
                Point a = nodes[edge.From];
                Point b = nodes[edge.To];

                // vẽ đường
                g.DrawLine(Pens.Blue, a, b);

                // vẽ trọng số ở giữa đường
                int midX = (a.X + b.X) / 2;
                int midY = (a.Y + b.Y) / 2;
                g.DrawString(edge.Weight.ToString(),
                             new Font("Arial", 10),
                             Brushes.Black,
                             midX, midY);
            }

            // vẽ đỉnh
            foreach (var p in nodes)
            {
                g.FillEllipse(Brushes.Red, p.X - 5, p.Y - 5, 10, 10);
                g.DrawEllipse(Pens.Black, p.X - 5, p.Y - 5, 10, 10);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            GenerateRandomPoints(10); // random 10 điểm
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            nodes.Clear();
            edges.Clear();

            int count = 100; // Số điểm random

            // Sinh điểm random
            for (int i = 0; i < count; i++)
            {
                int x = rand.Next(20, panelHeader.Width - 20);
                int y = rand.Next(20, panelHeader.Height - 20);
                nodes.Add(new Point(x, y));
            }

            // Tạo cạnh nối điểm liên tiếp + trọng số random
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                int weight = rand.Next(1, 20);
                edges.Add(new Edge(i, i + 1, weight));
            }

            panelHeader.Invalidate();
        }
    }
}
