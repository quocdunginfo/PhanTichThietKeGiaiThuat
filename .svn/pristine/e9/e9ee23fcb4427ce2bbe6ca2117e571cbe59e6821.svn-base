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
    public partial class ChiaDeTriFrm : Form
    {
        List<int> _input = new List<int>();
        public ChiaDeTriFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #region Mergesort
        private void button2_Click(object sender, EventArgs e)
        {
            //tạo ngẫu nhiên
            richTextBox_qd_input.Text = "";
            int n;
            if (Int32.TryParse(textBox_qd_n.Text, out n))
            {
                richTextBox_qd_input.Text += qd_number.tao_ngau_nhien(n, n, " ");
            }
        }

        private void button_qd_sapxep_Click(object sender, EventArgs e)
        {
            this._input = qd_number.string_to_list_int(richTextBox_qd_input.Text, ' ');
            int time;
            qd_mergesort instance = new qd_mergesort();
            instance.set_input(this._input);
            List<int> re= instance.sort(out time);
            textBox_qd_time.Text = time.ToString();
            richTextBox_qd_output.Text = string.Join(" ", re);
        }
        #endregion
        #region Tim kiem nhi phan
        //private void button3_tao_Click(object sender, EventArgs e)
        //{
        //    //tạo ngẫu nhiên
        //    richTextBox_bs_input.Text = "";
        //    int n;
        //    if (Int32.TryParse(textBox_bs_n.Text, out n))
        //    {
        //        richTextBox_bs_input.Text += qd_number.tao_ngau_nhien(n, n, " ");
        //    }
        //}
        //private void button2_sapxep_Click(object sender, EventArgs e)
        //{
        //    this._input = qd_number.string_to_list_int(richTextBox_bs_input.Text, ' ');
        //    qd_mergesort instance = new qd_mergesort();
        //    instance.set_input(this._input);
        //    int time;
        //    List<int> re = instance.sort(out time);
        //    this._input = re.ToList();
        //    richTextBox_bs_input.Text = string.Join(" ", re);
        //}
        //private void button_bs_timkiem_Click(object sender, EventArgs e)
        //{
        //    qd_binarysearch instance = new qd_binarysearch();
        //    instance.set_input(this._input);
        //    int key;
        //    int time;
        //    if (Int32.TryParse(textBox_bs_value.Text, out key))
        //    {
        //        int index = instance.search(key, out time);
        //        if ( index >= 0)
        //        {
        //            textBox_bs_output.Text = "Tìm thấy ở vị trí = " + index;
        //        }
        //        else
        //        {
        //            textBox_bs_output.Text = "Không tìm thấy";
        //        }
        //        textBox_bs_time.Text = time.ToString();
        //    }
        //}
        #endregion
        #region ClosestPair
        diem[] diem;
        int n;
        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_n.Text))
            {
                MessageBox.Show("Vui lòng nhập n");
                return;
            }
            //tạo bộ test ngẫu nhiên
            txtInput5.Text = "";
            n = int.Parse(txt_n.Text);

            diem = new diem[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                diem[i] = new diem(rand.Next(n), rand.Next(n));
                if (IfExist(diem[i], i))
                {
                    continue;
                }
                txtInput5.Text += diem[i].ToString() + " ";
            }
        }
        private bool IfExist(diem b, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (diem[i].x == b.x && diem[i].y == b.y)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnTinh5_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch time = new Stopwatch();
                string input = txtInput5.Text;
                string[] coordinates = input.Split(' ');
                n=coordinates.Length-1;
                diem = new diem[n];
                int i = 0;
                time.Start();
                foreach (string s in coordinates)
                {
                    if (i >= n)
                    {
                        break;
                    }
                    string[] coord = s.Split(',');
                    diem[i++] = new diem(int.Parse(coord[0]), int.Parse(coord[1]));
                    //i++;
                    
                }
                closestpair closest = new closestpair();
                float d = closest.ClosestPair(diem, i);

                time.Stop();
                txtKetQua5.Text = d.ToString();
                textBox1.Text = time.Elapsed.Milliseconds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        

    }
    class qd_number
    {
        public static List<int> string_to_list_int(string input="", char separate = ' ')
        {
            List<int> re = new List<int>();
            string[] tmp = input.Split(separate);
            foreach (string item in tmp)
            {
                int k;
                if (Int32.TryParse(item, out k))
                {
                    re.Add(k);
                }
            }
            return re;
        }
        public static int[,] richtext_to_matrix(int n, string input = "", char lineseparate = '\n')
        {
            int[,] re = new int[n,n];
            string[] lines = input.Split(lineseparate).ToArray();
            int i, j;
            for (i = 0; i < n; i++)
            {
                string[] cell = lines[i].Split(' ');
                for (j = 0; j < n; j++)
                {
                    Int32.TryParse(cell[j], out re[i, j]);
                }
            }
            return re;
        }
        public static string tao_ngau_nhien(int n=100, int max_value=100, string delimiter=" ")
        {
            if (max_value <= 100) max_value = 100;
            Random r = new Random((int)DateTime.Now.Ticks);
            string re = "";
            for (int i = 1; i <= n; i++)
                {
                    re += r.Next(max_value).ToString() + delimiter;
                }
            return re;
        }
    }
    class qd_mergesort
    {
        private List<int> _input = new List<int>();
        public void set_input(List<int> input)
        {
            this._input = input;
        }
        public List<int> sort(out int time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] mang = this._input.ToArray();
            mergeSort(mang);
            timer.Stop();
            time = timer.Elapsed.Milliseconds;
            return mang.ToList();
        }
            
        // Merges the left/right elements into a sorted result.
        // Precondition: left/right are sorted
        private void merge(int[] result, int[] left, int[] right)
        {
            int i1 = 0;   // index into left array
            int i2 = 0;   // index into right array

            for (int i = 0; i < result.Length; i++)
            {
                if (i2 >= right.Length || (i1 < left.Length && left[i1] <= right[i2]))
                {
                    result[i] = left[i1];    // take from left
                    i1++;
                }
                else
                {
                    result[i] = right[i2];   // take from right
                    i2++;
                }
            }
        }

        // Rearranges the elements of a into sorted order using
        // the merge sort algorithm (recursive).
        private void mergeSort(int[] a)
        {
            if (a.Length >= 2)
            {
                // split array into two halves
                int[] left = leftHalf(a);
                int[] right = rightHalf(a);

                // sort the two halves
                mergeSort(left);
                mergeSort(right);

                // merge the sorted halves into a sorted whole
                merge(a, left, right);
            }
        }
        // Returns the first half of the given array.
        private static int[] leftHalf(int[] a)
        {
            int size1 = a.Length / 2;
            int[] left = new int[size1];
            for (int i = 0; i < size1; ++i)
            {
                left[i] = a[i];
            }
            return left;
        }

        // Returns the second half of the given array.
        public static int[] rightHalf(int[] a)
        {
            int size1 = a.Length / 2;
            int size2 = a.Length - size1;
            int[] right = new int[size2];
            for (int i = 0; i < size2; ++i)
            {
                right[i] = a[i + size1];
            }
            return right;
        }
    }
    class qd_binarysearch
    {
        List<int> _input = new List<int>();
        public void set_input(List<int> input)
        {
            this._input=input;
        }
        public int search(int key, out int time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] tmp=this._input.ToArray();
            int r=timkiem(tmp,key);
            timer.Stop();
            time = timer.Elapsed.Milliseconds;
            return r;
        }
        private int timkiem(int[] a, int key)
        {
            int left = 0;
            int right = a.Length - 1;
            while(left<=right)
            {
                int m=(left+right)/2;
                if(a[m]==key) return m;
                if(key<a[m])
                {
                    right=m-1;
                }
                else
                {
                    left = m+1;
                }
            }
            return -1;
        }
    }
    class closestpair
    {
        public float ClosestPair(diem[] diem, int n)
        {
            mergeSortX(diem);
            diem[] p = diem;
            mergeSortY(diem);
            diem[] q = diem;
            float min = Closest(p, q, 0, n);
            return min;
        }
        private float BruteForce(diem[] a, int n)
        {
            float d = float.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (KhoangCach(a[i], a[j]) < d)
                    {
                        d = KhoangCach(a[i], a[j]);
                    }
                }
            }
            return d;
        }
        private float Closest(diem[] p, diem[] q, int l, int r)
        {
            if ((r - l) <= 3)
            {
                return BruteForce(p, r - l);
            }
            else
            {
                int mid = l + (r-l) / 2;
                float dl = Closest(p, q, l, mid);
                float dr = Closest(p, q, mid + 1, r);
                float dmin = Math.Min(dl, dr);
                int num = 0;
                diem[] temp = new diem[r - l];
                float min = dmin * dmin;
                for (int k = l; k < r; k++)
                {
                    if (Math.Abs(q[k].x - p[mid].x) < dmin)
                    {
                        temp[num++] = q[k];
                    }
                }
                
                for (int i = 0; i < num - 1 ; i++)
                {
                    int j = i + 1;
                    while ((j < num ) && ((temp[j].y - temp[i].y) * (temp[j].y - temp[i].y) < min))
                    {
                        min = Math.Min(KhoangCach(temp[j], temp[i]) * KhoangCach(temp[j], temp[i]), min);
                        j++;
                    }
                }
                return (float)Math.Sqrt(min);
            }
        }
        private float KhoangCach(diem diem1, diem diem2)
        {
            return (float)Math.Sqrt((diem1.x - diem2.x) * (diem1.x - diem2.x) + (diem1.y - diem2.y) * (diem1.y - diem2.y));
        }

         #region MergeSort_for_closestpair
        private void mergeX(diem[] result, diem[] left, diem[] right)
        {
            int i1 = 0;   // index into left array
            int i2 = 0;   // index into right array

            for (int i = 0; i < result.Length; i++)
            {
                if (i2 >= right.Length || (i1 < left.Length && left[i1].x <= right[i2].x))
                {
                    result[i] = left[i1];    // take from left
                    i1++;
                }
                else
                {
                    result[i] = right[i2];   // take from right
                    i2++;
                }
            }
        }
        private void mergeY(diem[] result, diem[] left, diem[] right)
        {
            int i1 = 0;   // index into left array
            int i2 = 0;   // index into right array

            for (int i = 0; i < result.Length; i++)
            {
                if (i2 >= right.Length || (i1 < left.Length && left[i1].y <= right[i2].y))
                {
                    result[i] = left[i1];    // take from left
                    i1++;
                }
                else
                {
                    result[i] = right[i2];   // take from right
                    i2++;
                }
            }
        }
        // Rearranges the elements of a into sorted order using
        // the merge sort algorithm (recursive).
        private void mergeSortY(diem[] a)
        {
            if (a.Length >= 2)
            {
                // split array into two halves
                diem[] left = leftHalf(a);
                diem[] right = rightHalf(a);

                // sort the two halves
                mergeSortY(left);
                mergeSortY(right);

                // merge the sorted halves into a sorted whole
                mergeY(a, left, right);
            }
        }
        private void mergeSortX(diem[] a)
        {
            if (a.Length >= 2)
            {
                // split array into two halves
                diem[] left = leftHalf(a);
                diem[] right = rightHalf(a);

                // sort the two halves
                mergeSortX(left);
                mergeSortX(right);

                // merge the sorted halves into a sorted whole
                mergeX(a, left, right);
            }
        }
        private diem[] leftHalf(diem[] a)
        {
            int size1 = a.Length / 2;
            diem[] left = new diem[size1];
            for (int i = 0; i < size1; ++i)
            {
                left[i] = a[i];
            }
            return left;
        }

        // Returns the second half of the given array.
        private diem[] rightHalf(diem[] a)
        {
            int size1 = a.Length / 2;
            int size2 = a.Length - size1;
            diem[] right = new diem[size2];
            for (int i = 0; i < size2; ++i)
            {
                right[i] = a[i + size1];
            }
            return right;
        }

        #endregion
    }
}
