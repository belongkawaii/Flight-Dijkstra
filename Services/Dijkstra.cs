using System;
using System.Collections.Generic;
using System.Linq;

namespace Flight_Dijkstra
{
    public class Dijkstra
    {
        private List<double> _dist;
        private List<int> _prev;
        private Graph _graph;

        public List<double> Dist
        {
            get => _dist;
            set => _dist = value;
        }
        public List<int> Prev
        {
            get => _prev;
            set => _prev = value;
        }
        public Graph Graph
        {
            get => _graph;
            set => _graph = value;
        }

        public Dijkstra(List<double> dist, List<int> prev, Graph graph)
        {
            _dist = dist;
            _prev = prev;
            _graph = graph;
        }

        public Dijkstra()
        {
            _dist = new List<double>();
            _prev = new List<int>();
            _graph = new Graph();
        }

        // Hàm Run 
        public void Run(int startId)
        {
            if (_graph == null || _graph.Cities == null || _graph.Adj == null)
                return;

            int n = _graph.Cities.Count;
            _dist = new List<double>(new double[n]);
            _prev = new List<int>(new int[n]);
            bool[] visited = new bool[n];

            // Khởi tạo
            for (int i = 0; i < n; i++)
            {
                _dist[i] = double.MaxValue;
                _prev[i] = -1;
                visited[i] = false;
            }

            _dist[startId] = 0;

            // Dùng SortedSet làm priority queue
            var pq = new SortedSet<(double dist, int id)>(
                Comparer<(double dist, int id)>.Create((a, b) =>
                {
                    int cmp = a.dist.CompareTo(b.dist);
                    return cmp != 0 ? cmp : a.id.CompareTo(b.id);
                }));

            pq.Add((0, startId));

            while (pq.Count > 0)
            {
                var current = pq.Min;
                pq.Remove(current);
                int u = current.id;

                if (visited[u]) continue;
                visited[u] = true;

                // Kiểm tra và lấy danh sách chuyến bay từ thành phố u
                if (u < _graph.Adj.Count && _graph.Adj[u] != null)
                {
                    foreach (var flight in _graph.Adj[u])
                    {
                        int v = flight.DestCityId;

                        if (v < 0 || v >= n || visited[v]) continue;

                        double weight = flight.Price;
                        double newDist = _dist[u] + weight;

                        if (newDist < _dist[v])
                        {
                            _dist[v] = newDist;
                            _prev[v] = u;
                            pq.Add((_dist[v], v));
                        }
                    }
                }
            }
        }

        public List<int> GetShortestPath(int startId, int destId)
        {
            // Kiểm tra đã chạy thuật toán chưa
            if (_dist == null || _dist.Count == 0)
            {
                throw new InvalidOperationException("Chưa chạy thuật toán Dijkstra. Hãy gọi Run() trước.");
            }

            if (Math.Abs(_dist[destId] - Double.MaxValue) < 10e-9)
            {
                return new List<int>();
            }

            var st = new Stack<int>();
            st.Push(destId);

            while (st.Peek() != startId)
            {
                st.Push(_prev[st.Peek()]);
            }

            var res = new List<int>();
            while (st.Count != 0)
            {
                res.Add(st.Pop());
            }

            return res;
        }

        public double GetDistance(int destId)
        {
            if (_dist == null || destId >= _dist.Count)
            {
                throw new ArgumentException("Không tìm thấy thành phố với ID này.");
            }
            return _dist[destId];
        }
    }
}