using System;
using System.Drawing;

namespace lab3
{
    class KMeans
    {
        /* assign dots to clusters */
        private static void assignDotsToClusters()
        {
            foreach (Cluster c in Cluster.clusters)
                c.points.Clear();

            /* find nearest cluster and add point to it */
            foreach (ColoredPoint p in ColoredPoint.points)
            {
                int clusterIndex = 0;
                double minDistance = getDistance(p, Cluster.clusters[clusterIndex]);

                for (int i = 1; i < Cluster.clusters.Count; i++)
                {
                    double distance = getDistance(p, Cluster.clusters[i]);
                    if (minDistance > distance)
                    {
                        minDistance = distance;
                        clusterIndex = i;
                    }
                }

                Cluster.clusters[clusterIndex].points.Add(p);
            }
        }

        /* recalcute clusters centers */
        private static double calculateNewClustersCenters()
        {
            double distance = 0;

            foreach (Cluster cluster in Cluster.clusters)
            {
                if (cluster.points.Count == 0)
                    continue;

                double meanX = 0.0;
                double meanY = 0.0;

                foreach (ColoredPoint point in cluster.points)
                {
                    meanX += point.X;
                    meanY += point.Y;
                }

                meanX /= cluster.points.Count;
                meanY /= cluster.points.Count;

                cluster.centerX = (int)meanX;
                cluster.centerY = (int)meanY;

                distance += getDistance(meanX, cluster.centerX, meanY, cluster.centerY);
            }

            return distance;
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

        private static void setInitialClustersCenters(int K)
        {
            Cluster.clusters.Clear();
            int MaxX = Int32.MinValue;
            int MaxY = Int32.MinValue;
            int MinX = Int32.MaxValue;
            int MinY = Int32.MaxValue;

            /* define min & max coordinates of area */
            foreach (ColoredPoint p in ColoredPoint.points)
            {
                if (p.X > MaxX)
                    MaxX = p.X;
                if (p.X < MinX)
                    MinX = p.X;

                if (p.Y > MaxY)
                    MaxY = p.Y;
                if (p.Y < MinY)
                    MinY = p.Y;
            }

            Random r = new Random();
            /* define clusters and set them centers */
            for (int i = 0; i < K; i++)
            {
                int X = (int)Math.Round(r.NextDouble() * (MaxX - MinX) + MinX);
                int Y = (int)Math.Round(r.NextDouble() * (MaxY - MinY) + MinY);
                Color color = Color.FromArgb((int)(0xFF << 24 ^ (r.Next(0xFFFFFF) & 0x7F7F7F))); ;
                Cluster.clusters.Add(new Cluster(X, Y, color));
            }
        }

        public static void toCluster(int K)
        {
            if (ColoredPoint.points.Count == 0)
                return;

            if (K == 0)
                return;

            setInitialClustersCenters(K);
            double lastDistance = 0.0;
            double Distance = 0.0;

            do
            {
                lastDistance = Distance;
                assignDotsToClusters();
                
                Distance = calculateNewClustersCenters();
            } while (Distance != lastDistance);
        }
    }
}
