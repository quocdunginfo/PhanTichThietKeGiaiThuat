using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichThietKeGiaiThuat
{
    public partial class ThamLamFrm : Form
    {
        public ThamLamFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        
        #region Đích Cha
        private void button_dj_timduong_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int start;
                int end;
                int time;
                qd_dich_cha instance = new qd_dich_cha();
                if (Int32.TryParse(textBox_dj_n.Text, out n) &&
                    Int32.TryParse(textBox_dj_start.Text, out start) &&
                    Int32.TryParse(textBox_dj_end.Text, out end)
                    )
                {
                    int[,] k = qd_number.richtext_to_matrix(n, richTextBox_dj_matran.Text);
                    List<int> trail;
                    int sum;
                    instance.set_input(k, n, start, end);
                    instance.calculate(out trail, out sum, out time);
                    textBox_dj_time.Text = time.ToString();
                    textBox_dj_duongdi.Text = "";
                    foreach (var item in trail)
                    {
                        textBox_dj_duongdi.Text += item.ToString() + "->";
                    }
                    textBox_dj_tong.Text = sum.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi về input");
            }
            
        }
        #endregion

        private void richTextBox_dj_matran_TextChanged(object sender, EventArgs e)
        {

        }
        #region To Mau
        int[,] dinhke;
        int n;
        int[] dinh;
        private void tbn_tomau_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txt_tomau_dinhke.Text.ToString().Trim();
                dinhke = new int[input.Length + 1, input.Length + 1];
                string[] coordinates = input.Split(' ');
                foreach (string s in coordinates)
                {
                    string[] coord = s.Split(',');
                    dinhke[int.Parse(coord[0]), int.Parse(coord[1])] = 1;
                    dinhke[int.Parse(coord[1]), int.Parse(coord[0])] = 1;
                }
                n = int.Parse(txt_tomau_n.Text);
                int dem = 0;
                int mau = 1;
                dinh = new int[n + 1];
                for (int i = 1; i <= n; i++)
                {
                    dinh[i] = 0;
                }
                do
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (toduoc(i, mau)&&dinh[i]==0)
                        {
                            dinh[i] = mau;
                            dem++;
                        }
                    }
                    mau++;
                } while (dem < n);
                txt_tomau_output1.Text = (mau-1).ToString();
                txt_tomau_output2.Text = "";
                for (int i = 1; i <= n; i++)
                {
                    txt_tomau_output2.Text += "dinh " + i + " to mau " + dinh[i] + "\n";
                }
            }
            catch
            {
                MessageBox.Show("input không hợp lệ");
            }
        }
        public bool toduoc(int i, int mau)
        {
            for (int j = 1; j <= n; j++)
            {
                if (dinhke[i, j] == 1 && dinh[j] == mau)
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        private void ThamLamFrm_Load(object sender, EventArgs e)
        {
            txt_tomau_n.Text = "6";
        }
    }
    class qd_dich_cha
    {
        private int[,] matran;
        private int n;
        private int[] d;//label
        private bool[] dachon;
        private int[] pi;//dinh di truoc
        private int start = 0;
        private int end = 1;
        public void set_input(int[,] matrix, int n, int start, int end)
        {
            matran = matrix;
            this.n = n;
            this.start = start;
            this.end = end;
            d = new int[n];
            pi = new int[n];
            dachon = new bool[n];
        }
        private void init(int start=0)
        {
            for (int i = 0; i < n; i++)
            {
                d[i] = 999999999;
                pi[i] = -1;
                dachon[i] = false;
            }
            d[start] = 0;
        }
        public void calculate(out List<int> _trail, out int _sum, out int time)
        {
            Stopwatch timer = new Stopwatch(); timer.Start();
            List<int> re = new List<int>();
            //set init
            //call main first
            this.main(start);
            //return result
            int tmp = this.end;
            re.Insert(0,tmp);
            int sum = 0;
            while (true)
            {
                int dinhtruoc = pi[tmp];
                re.Insert(0, dinhtruoc);
                sum += matran[dinhtruoc, tmp];
                tmp = dinhtruoc;
                if (dinhtruoc == this.start)
                {
                    _trail = re;
                    _sum = sum;
                    timer.Stop();
                    time = timer.Elapsed.Milliseconds;
                    return;
                }
            }
        }
        private void main(int start=0)
        {
            this.init(start);
            for (int i = 0; i < n; i++)
            {
                int u = extract_min();
                foreach (int v in relation(u))
                {
                    relaxation(u, v);
                }
            }
        }
        private void relaxation(int u, int v)
        {
            if (d[v] > d[u] + matran[u, v])
            {
                d[v] = d[u] + matran[u, v];
                pi[v] = u;
            }
            
        }
        private int[] relation(int vertex=1)
        {
            List<int> tmp = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (matran[vertex, i] > 0)
                {
                    tmp.Add(i);
                }
            }
            return tmp.ToArray();
        }
        private int extract_min()
        {
            int _min = 999999999;
            for(int i=0;i<n;i++)
            {
                if(d[i]<_min && dachon[i]==false)
                {
                    _min = d[i];
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                if (d[i] ==_min  && dachon[i]==false)
                {
                    dachon[i] = true;
                    return i;
                }
            }
            return -1;
        }
    }
}
