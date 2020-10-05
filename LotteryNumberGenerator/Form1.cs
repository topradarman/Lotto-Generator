using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        private NGenerator numGen1 = new NGenerator();
        //private NumberGenerator numGen2 = new NumberGenerator();
        private NHolder numHolder;


        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Items.Clear();

        }

        


        //Generate 5 random numbers, sort and display on button click.
        private void button1_Click(object sender, EventArgs e)
        {          
            listView1.BeginUpdate();
            Random random = new Random();

            //listView1.Items.Clear();     //갱신(없으면 쌓기)
            //ListViewItem item;
            //item = new ListViewItem("1");
            //listView1.Items.Add(item);
            //item.SubItems.Add(label2.Text);
            //listView1.EndUpdate();


            //====================== 1 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();                
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);
                //Console.WriteLine("[{0}]", string.Join(", ", list));

                //item.SubItems.Add(numHolder.NumbersArray[0].ToString());
                //item.SubItems.Add(numHolder.NumbersArray[1].ToString());
                //item.SubItems.Add(numHolder.NumbersArray[2].ToString());
                //item.SubItems.Add(numHolder.NumbersArray[3].ToString());
                //item.SubItems.Add(numHolder.NumbersArray[4].ToString());
                //item.SubItems.Add(numHolder.NumbersArray[5].ToString());

                item.UseItemStyleForSubItems = false;   //이거 꼭 써줘야 함
                //listView1.BackColor = Color.LightSteelBlue;                

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());               
            }
            //====================== 1 ========================


            //====================== 2 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 2 ========================


            //====================== 3 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 3 ========================

            //====================== 4 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 4 ========================

            //====================== 5 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 5 ========================

            //====================== 6 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 6 ========================

            //====================== 7 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 7 ========================

            //====================== 8 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 8 ========================

            //====================== 9 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 9 ========================

            //====================== 10 ========================
            numHolder = new NHolder();
            for (int i = 0; i < 6; i++)
            {
                //int randomNumber1 = numGen1.generateNum1();
                int randomNumber1 = random.Next(Convert.ToInt32(min.Value), Convert.ToInt32(max.Value) + 1);
                if (!numHolder.isDuplicate(randomNumber1))
                    numHolder.addToArray(randomNumber1);
                else
                {
                    i--;
                    randomNumber1 = numGen1.generateNum1();
                }
            }


            {
                int[] src = { numHolder.NumbersArray[0], numHolder.NumbersArray[1], numHolder.NumbersArray[2], numHolder.NumbersArray[3], numHolder.NumbersArray[4], numHolder.NumbersArray[5] };
                var list = new List<int>();
                list.AddRange(src);     // list에 요소 추가                
                list.Sort();            // list 정렬

                ListViewItem item;
                item = new ListViewItem("");
                listView1.Items.Add(item);

                item.SubItems.Add(list[0].ToString());
                item.SubItems.Add(list[1].ToString());
                item.SubItems.Add(list[2].ToString());
                item.SubItems.Add(list[3].ToString());
                item.SubItems.Add(list[4].ToString());
                item.SubItems.Add(list[5].ToString());
                item.SubItems.Add(src.Min().ToString());
                item.SubItems.Add(src.Max().ToString());
                item.SubItems.Add(src.Sum().ToString());
            }
            //====================== 10 ========================

            listView1.EndUpdate();

         

        }


               


        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }






        private void button3_Click(object sender, EventArgs e)
        {
            


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv File|*.csv";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();

            


            if (saveFileDialog1.FileName != "")
            {

                //========= 맨 아랫부분에 붙음=========
                //ListViewItem item;
                //item = new ListViewItem("");
                //listView1.Items.Add(item);
                //item.SubItems.Add("1st");
                //item.SubItems.Add("2nd");     
                
                //listView1.Items.Add(item);
                //listView1.Items.Add("No.");
                


                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)     
                {
                    case 1:
                        for (int i = 0; i < listView1.Items.Count; i++)                        
                        {                           

                            string sTmp = "";
                            for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)                                
                                sTmp += listView1.Items[i].SubItems[j].Text + ", ";                            
                            sTmp += "\n";       //sTmp += "\n";
                            Byte[] Bytes = Encoding.UTF8.GetBytes(sTmp);
                            fs.Write(Bytes, 0, Bytes.Length);                                                     

                        }
                        break;
                }                
                fs.Close();
                
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://92rkskekfk.tistory.com/10");
        }
    }
}