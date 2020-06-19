using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            numUpDownClusters.Value = 2;
            trackBrushSize.Value = 50;
            rbBrush.Checked = true;

            addColors();
        }

        /* add color for user select */
        private void addColors()
        {
            pictBoxDotsArea.Image = new Bitmap(pictBoxDotsArea.Width, pictBoxDotsArea.Height);
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(10, 10);

            Bitmap bitmap = new Bitmap(10, 10);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Blue);
            }
            imageList.Images.Add(bitmap);

            bitmap = new Bitmap(10, 10);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Red);
            }
            imageList.Images.Add(bitmap);

            bitmap = new Bitmap(10, 10);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Green);
            }
            imageList.Images.Add(bitmap);

            bitmap = new Bitmap(10, 10);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.Orange);
            }
            imageList.Images.Add(bitmap);

            listViewColors.SmallImageList = imageList;
            ListViewItem item = new ListViewItem(new string[] { "", "Blue" });
            item.ImageIndex = 0;
            listViewColors.Items.Add(item);

            item = new ListViewItem(new string[] { "", "Red" });
            item.ImageIndex = 1;
            listViewColors.Items.Add(item);

            item = new ListViewItem(new string[] { "", "Green" });
            item.ImageIndex = 2;
            listViewColors.Items.Add(item);

            item = new ListViewItem(new string[] { "", "Orange" });
            item.ImageIndex = 3;
            listViewColors.Items.Add(item);
        }

        /* add a single dot with offset */
        private void addPointWithOffset(int X, int Y, SolidBrush brush)
        {
            int offsetX = getDotOffset();
            int offsetY = getDotOffset();
            ColoredPoint.points.Add(new ColoredPoint(X + offsetX, Y + offsetY, brush));
        }

        /* add a single dot by cursor position */
        private void addPoint(int X, int Y, SolidBrush brush)
        {
            ColoredPoint.points.Add(new ColoredPoint(X, Y, brush));
        }

        /* draw colored area & centers for each cluster & points */
        private void drawClusters()
        {
            using (Graphics g = Graphics.FromImage(pictBoxDotsArea.Image))
            {
                /* to color areas */
                for (int i = 0; i < pictBoxDotsArea.Width; i++)
                {
                    for (int j = 0; j < pictBoxDotsArea.Height; j++)
                    {                        
                        int clusterIndex = 0;
                        double minDistance = getDistance(i, j, Cluster.clusters[clusterIndex].centerX, Cluster.clusters[clusterIndex].centerY);

                        for (int k = 1; k < Cluster.clusters.Count; k++)
                        {
                            double distance = getDistance(i, j, Cluster.clusters[k].centerX, Cluster.clusters[k].centerY);
                            if (minDistance > distance)
                            {
                                minDistance = distance;
                                clusterIndex = k;
                            }
                        }

                        ((Bitmap)pictBoxDotsArea.Image).SetPixel(i, j, Cluster.clusters[clusterIndex].color);
                    }
                }
                    
                /* draw cluster center */
                Pen pen = new Pen(Color.Black, 2);
                foreach (Cluster c in Cluster.clusters)
                {
                    g.DrawEllipse(pen, c.centerX - 2, c.centerY - 2, 8, 8);
                    //SolidBrush brush = new SolidBrush(Color.Black);
                    //g.FillRectangle(brush, c.centerX - 2, c.centerY - 2, 8, 8);
                }

                /* redraw points */
                foreach (ColoredPoint p in ColoredPoint.points)
                    g.FillEllipse(p.brush, p.X - 2, p.Y - 2, 6, 6);
            }
            pictBoxDotsArea.Refresh();
        }

        /* draw center for each cluster */
        private void drawClustersCenters()
        { }

        private void drawPoints()
        {
            if (listViewColors.SelectedItems.Count == 0)
                return;

            using (Graphics g = Graphics.FromImage(pictBoxDotsArea.Image))
            {
                foreach (ColoredPoint p in ColoredPoint.points)
                    g.FillEllipse(p.brush, p.X - 2, p.Y - 2, 6, 6);
            }
            pictBoxDotsArea.Refresh();
        }

        /* remove all added ot pictureBox dots */
        private void drawPointsClear()
        {
            Graphics g = Graphics.FromImage(pictBoxDotsArea.Image);
            g.FillRectangle(Brushes.White, 0, 0, pictBoxDotsArea.Width, pictBoxDotsArea.Height);
            g.Dispose();
            pictBoxDotsArea.Refresh();
        }

        /* returns brush with user selected color */
        private SolidBrush getBrush()
        {
            if (listViewColors.SelectedItems.Count == 0)
                return null;

            SolidBrush brush = null;
            switch (listViewColors.SelectedItems[0].SubItems[1].Text)
            {
                case "Blue":
                    brush = new SolidBrush(Color.Blue);
                    break;
                case "Red":
                    brush = new SolidBrush(Color.Red);
                    break;
                case "Green":
                    brush = new SolidBrush(Color.Green);
                    break;
                case "Orange":
                    brush = new SolidBrush(Color.Orange);
                    break;
            }

            return brush;
        }

        /* returns distance between point and cluster  */
        private static double getDistance(ColoredPoint p, Cluster c)
        {
            return (p.X - c.centerX) * (p.X - c.centerX) + (p.Y - c.centerY) * (p.Y - c.centerY);
        }

        /* returns distance between two dots  */
        private static double getDistance(double fromX, double fromY, double toX, double toY)
        {
            return (fromX - toX) * (fromX - toX) + (fromY - toY) * (fromY - toY);
        }

        /* returns a random color */
        private Color getRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb((int)(0xFF << 24 ^ (random.Next(0xFFFFFF) & 0x7F7F7F)));
        }

        /* returns dot offset for Brush tool */
        private int getDotOffset()
        {
            return new Random().Next((trackBrushSize.Value * -1), trackBrushSize.Value);
        }

        /* add one dot */
        private void pictBoxDotsArea_MouseDown(object sender, MouseEventArgs e)
        {
            if (!rbPut.Checked)
                return;

            SolidBrush brush = getBrush();

            if (brush == null)
                return;

            addPoint(e.Location.X, e.Location.Y, brush);
            drawPoints();
        }

        /* remove all added dots */
        private void bClear_Click(object sender, EventArgs e)
        {
            ColoredPoint.points.Clear();
            drawPointsClear();
        }

        /**/
        private void pictBoxDotsArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (!rbBrush.Checked)
                return;

            if (e.Button != MouseButtons.Left)
                return;
            
            /* null if no color selected */
            SolidBrush brush = getBrush();

            if (brush == null)
                return;

            addPointWithOffset(e.Location.X, e.Location.Y, brush);
            drawPoints();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nUpDown = (NumericUpDown)sender;

            /* do not set value less than 2 */
            if (nUpDown.Value == 1)
                nUpDown.Value = 2;
        }

        /* show track bar numeric value  */
        private void trackBrushSize_ValueChanged(object sender, EventArgs e)
        {
            tbBrushSize.Text = trackBrushSize.Value.ToString();
        }

        private void bToCluster_Click(object sender, EventArgs e)
        {
            KMeans.toCluster((int)numUpDownClusters.Value);
            drawClusters();
        }
    }
}
