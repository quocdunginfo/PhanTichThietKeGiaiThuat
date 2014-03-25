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
    public partial class BienDoiDeTriFrm : Form
    {
        public BienDoiDeTriFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void SelectionSort(List<int> a, int n)
        {
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < n - 2; i++)
            {
                int min = i;
                for (int j = i; j < n - 1; j++)
                    if (a[j] < a[min]) min = j;
                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            time.Stop();
            txtSelection.Text = time.Elapsed.Milliseconds.ToString();

        }
        private void MergeSort(int[] a, int n)
        {

        }
        private void Merge(List<int> a, int left, int mid, int right)
        {
            int []temp = new int[right - left + 1];
            int n = 0;
            int i = left;
            int j = mid + 1;
            while (i > mid && j > right)
            {
                if (i <= mid && j <= right && a[i] < a[j] || j > right)
                    temp[n++] = a[i++];
                else temp[n++] = a[j++];
            }
            for ( i = 0; i <n ; i++)
                a[left+1] =temp[i];
        }

        private void MergeSort(List<int> a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                Merge(a, left, mid, right);
            }
        }
        private void button_qd_taongaunhien_Click(object sender, EventArgs e)
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
            qd_heapsort instance = new qd_heapsort();
            instance.set_input(this._input);
            int time;
            List<int> re = instance.sort(out time);
            textBox_qd_time.Text = time.ToString();
            richTextBox_qd_output.Text = string.Join(" ", re);

            SelectionSort(re, re.Count());

            Stopwatch thoigian = new Stopwatch();
            thoigian.Start();
            MergeSort(re, re[0], re[re.Count - 1]);
            thoigian.Stop();
            textBox1.Text = thoigian.Elapsed.Milliseconds.ToString();
        }
        private List<int> _input = new List<int>();
    }
    public class qd_heapsort
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
            int[] tmp = this._input.ToArray();
            this.HeapSort(tmp,tmp.Length);
            if (tmp.Length > 1 && tmp[0] > tmp[1])
            {
                int ttmp = tmp[0];
                tmp[0] = tmp[1];
                tmp[1] = ttmp;
            }
            timer.Stop();
            time = timer.Elapsed.Milliseconds;
            return tmp.ToList();
        }
        public void HeapSort(int[] a, int count) {
            int end = count-1 ;
            //Vun đống cho mảng
            MakeHeap(a,count);
            while (end >= 0)
            {
                //hoán đổi nút gốc và phần tử cuối
                int tmp=a[0];
                a[0]=a[end];
                a[end]=tmp;
                //giảm kích thước mảng xử lý (bỏ đi phần tử cuối)
                end--;
                //gọi lại hàm cho nút gốc
                DownHeap(a,0, end);
            }        
        }
        /*
         * Vun đống từ dưới lên (bắt đầu từ nút nhánh (KHÔNG phải nút lá) xa nhất)
         * Sau đó vun đống dần lên tới gốc
         */
        private void MakeHeap(int[] mang, int count)
        {
            int start = count / 2;
            //vun đống dần lên cho tới gốc
            while (start >= 0)
            {
                DownHeap(mang, start, count);
                start--;
            }
        }
        /*
         * Có nhiệm vụ sắp xếp lại vị trí của nút cha và 2 nút con cho đúng tinh thần
         * nút cha phải lớn hơn 2 nút con
         */
        private void DownHeap(int[] a, int start, int count)
        {
            int i = start, j;
            //đặt j là nút con bên trái
            j = i * 2;
            //trong khi nút cha hiện tại còn nằm trong vùng đang xét
            while (j < count)
            {
                //tìm vị trí nút lớn nhất trong 2 nút con sau đó gán cho j
                if (j + 1 < count && a[j] < a[j + 1])
                {
                    j++;
                }
                //so sánh nút cha với nút lớn nhất trong 2 nút con (nút j)
                if (a[i] < a[j])
                {
                    //hoán đổi
                    int tmp = a[i];
                    a[i] = a[j];
                    a[j] = tmp;
                    //di chuyển nút cha hiện tại sang cho nút mới di chuyển
                    i = j;
                    j = i * 2;
                }
                else
                {
                    return;
                }
            }
        }

       
      
    }
     

}
