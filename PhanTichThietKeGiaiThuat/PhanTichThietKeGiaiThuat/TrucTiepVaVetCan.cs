﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanTichThietKeGiaiThuat
{
    public partial class TrucTiepVaVetCan : Form
    {
        public TrucTiepVaVetCan()
        {
            InitializeComponent();
        }

        #region 2.SelectionSort
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNhap2.Text))
            {
                MessageBox.Show("Vui lòng nhập n");
                return;
            }
            //tạo bộ test ngẫu nhiên
            txtInput2.Text = "";
            n = int.Parse(txtNhap2.Text);
            txtInput2.Text += qd_number.tao_ngau_nhien(n, n, " ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> _input = new List<int>();
                txtKetQua2.Text = "";
                _input = qd_number.string_to_list_int(txtInput2.Text, ' ');
                string input = txtInput2.Text.ToString().Trim();
                string[] inputs = input.Split(' ');
                int n = inputs.Length;
                SelectionSort(_input, n);
                txtKetQua2.Text = string.Join(" ",_input);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            textBox3.Text = time.Elapsed.Milliseconds.ToString();

        }
        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void Sort(int[] a, int n)
        {
            int min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                swap(ref a[i], ref a[min]);
            }
        }

        #endregion

        #region 4.String Match
        private void button3_Click_1(object sender, EventArgs e)
        {
            string text = txtText.Text;
            string patttern = txtPattern.Text;
            char[] t = text.ToCharArray();
            char[] p = patttern.ToCharArray();
            int n = t.Length;
            int m = p.Length;
            int vitri = StringMatch(t, p, n, m);
            txtKetQua4.Text = vitri.ToString();
        }
        public int StringMatch(char[] T, char[] P, int n, int m)
        {
            for (int i = 0; i <= n - m; i++)
            {
                int j = 0;
                while (j < m && P[j] == T[i + j])
                {
                    j++;
                }
                if (j == m)
                    return i;
            }
            return -1;
        }
        #endregion

        #region 5.ClosestPair
        diem[] diem;
        int n;

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNhap5.Text))
            {
                MessageBox.Show("Vui lòng nhập n");
                return;
            }
            //tạo bộ test ngẫu nhiên
            txtInput5.Text = "";
            n = int.Parse(txtNhap5.Text);

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
        private bool IfExist(diem b,int vt)
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
                string input = txtInput5.Text.ToString().Trim() ;
                string[] coordinates = input.Split(' ');
                n = coordinates.Length;
                diem = new diem[n];
                int i = 0;
                foreach (string s in coordinates)
                {
                    if (i >= n)
                    {
                        break;
                    }
                    string[] coord = s.Split(',');
                    diem[i] = new diem(int.Parse(coord[0]), int.Parse(coord[1]));
                    i++;
                }
                Stopwatch time = new Stopwatch();
                time.Start();
                float d = BruteForce(diem, n);
                time.Stop();
                txtKetQua5.Text = d.ToString();
                textBox1.Text = time.Elapsed.Milliseconds.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        static public float KhoangCach(diem diem1, diem diem2)
        {
            return (float)Math.Sqrt((diem1.x - diem2.x) * (diem1.x - diem2.x) + (diem1.y - diem2.y) * (diem1.y - diem2.y));
        }
        public float BruteForce(diem[] a, int n)
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
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNhapLai1_Click(object sender, EventArgs e)
        {
            txtbox_tbp_n.ResetText();
            textbox_tbp_kq.ResetText();
            textbox_tbp_kq.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnNhapLai3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnNhapLai5_Click(object sender, EventArgs e)
        {
            txtNhap5.ResetText();
            txtKetQua5.ResetText();
            txtNhap5.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        #region NDL
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int time;
                List<int> trail = new List<int>();
                int sum = 0;
                if (Int32.TryParse(textBox_ndl_n.Text, out n))
                {
                    qd_ndl instance = new qd_ndl();
                    instance.set_input(
                    qd_number.richtext_to_matrix(n, richTextBox_ndl_matran.Text),
                    n
                    );
                    instance.calculate(out trail, out sum, out time);
                    textbox_ndl_duongdi.Text = string.Join("->", trail);
                    textBox_ndl_sum.Text = sum.ToString();
                    textBox_ndl_time.Text = time.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi về input");
            }
        }
        #endregion
        #region Tổng bình phương
        private void button_tbp_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                 int n;
                int time;
                if (Int32.TryParse(txtbox_tbp_n.Text, out n))
                {
                    qd_tongbinhphuong instance = new qd_tongbinhphuong();
                    instance.set_input(n);
                    textbox_tbp_kq.Text = instance.calculate(out time).ToString();
                    textBox_tbp_time.Text = time.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi về input");
            }
        }
        #endregion

    }
    class qd_tongbinhphuong
    {
        private int n = 1;
        public void set_input(int _n)
        {
            n = _n;
        }
        public int calculate(out int time)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;

            }
            timer.Stop();
            time = timer.Elapsed.Milliseconds;
            return sum;

        }

    }
    class qd_ndl
    {
        private int[,] mang;
        private int n;
        private int min = 999999999;
        public void set_input(int[,] matran, int n)
        {
            this.mang = matran;
            this.n = n;
        }
        public void calculate(out List<int> trail, out int _sum,out int time)
        {
            Stopwatch timer = new Stopwatch(); timer.Start();
            List<int> chutrinh_min=new List<int>();
            int sum=0;
            foreach (List<int> item in DSHoanVi(n))
            {
                sum = 0;
                for (int i = 0; i < item.Count - 1; i++)
                {
                    sum += mang[item[i], item[i + 1]];
                }
                if (sum < min)
                {
                    min = sum;
                    chutrinh_min = item;
                }
            }
            timer.Stop();
            trail = chutrinh_min;
            _sum = sum;
            time = timer.Elapsed.Milliseconds;
        }
        public List<List<int>> DSHoanVi(int n)
        {
            List<List<int>> re = new List<List<int>>();
            List<int> item = new List<int>();
            for (int i = 0; i < n; i++)
            {
                item.Add(i);
            }
            if (n == 1)
            {
                re.Add(item);
                return re;
            }
            int vitri_hoanvi = n - 2;
            while (true)
            {
                re.Add(Copy(item));
                item = HoanVi(item, vitri_hoanvi, vitri_hoanvi + 1);
                vitri_hoanvi--;
                if (vitri_hoanvi < 0) vitri_hoanvi = n - 2;
                if (check_ketthuc_hoanvi(item) == true) return re;
            }
        }
        public List<int> Copy(List<int> input)
        {
            List<int> re = new List<int>();
            foreach (int item in input)
            {
                re.Add(item);
            }
            return re;
        }
        public List<int> HoanVi(List<int> input, int vitri_hoanvi, int vitri_hoanvi2)
        {
            List<int> backup = Copy(input);
            int tmp;
            tmp = backup[vitri_hoanvi];
            backup[vitri_hoanvi] = backup[vitri_hoanvi2];
            backup[vitri_hoanvi2] = tmp;
            return backup;
        }
        public Boolean check_ketthuc_hoanvi(List<int> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] > input[i + 1]) return false;
            }
            return true;
        }

    }
}
