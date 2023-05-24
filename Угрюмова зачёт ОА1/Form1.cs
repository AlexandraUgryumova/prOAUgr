using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Угрюмова_зачёт_ОА1
{
    public partial class Form1 :Form
    {
        IndexName list01 = new IndexName( );
        NumIndNameGroupSale list02 = new NumIndNameGroupSale( );
        List<IndexName> list1 = new List<IndexName>();
        List<NumIndNameGroupSale> list2 = new List<NumIndNameGroupSale>();
        public Form1 ()
        {
            InitializeComponent( );
            try
            {
                if ( File.Exists("text1.txt") && File.Exists("text2.txt") && File.ReadAllText("text1.txt").Length != 0 && File.ReadAllText("text2.txt").Length != 0 )
                {
                    string [ ] s = new string [2];
                    string [ ] m = new string [4];
                    StreamReader sr = new StreamReader("text1.txt");
                    while ( !sr.EndOfStream )
                    {
                        s  = sr.ReadLine( ).Split(',');
                        list01.ItemId = int.Parse(s [ 0 ]);
                        list01.Name = s [ 1 ];
                        list1.Add(list01);
                        listBox1.Items.Add(list01.ItemId + " " + list01.Name);
                    }
                    sr.Close( );
                    StreamReader sr2 = new StreamReader("text2.txt");
                    while ( !sr2.EndOfStream )
                    {
                        m  = sr2.ReadLine( ).Split(',');
                        list02.InvNum = int.Parse(m [ 0 ]);
                        list02.ItemId = int.Parse(m [ 1 ]);
                        list02.NameGroup = m [ 2 ];
                        list02.Sale = int.Parse(m [ 3 ]);
                        list2.Add(list02);
                        listBox1.Items.Add(list02.InvNum + " " + list02.ItemId + " " + list02.NameGroup + " " + list02.Sale);
                    }
                    sr2.Close( );
                }
                else
                {
                    MessageBox.Show("файл пуст", "сообщение");
                }
            }
            catch
            {
                MessageBox.Show("формат файла нарушен","сообщение");
            }
        }
        private void button1_Click (object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = File.CreateText("text1.txt");
                for ( int i = 0; i < list1.Count; i++ )
                {
                    sw.WriteLine(list1 [ i ].ItemId + "," + list1 [ i ].Name);
                }
                StreamWriter sw2 = File.CreateText("text2.txt");
                for ( int i = 0; i < list2.Count; i++ )
                {
                    sw2.WriteLine(list2 [ i ].InvNum + "," + list2 [ i ].ItemId + "," + list2 [ i ].NameGroup + "," + list2 [ i ].Sale);
                }
                sw.Close( );
                sw2.Close( );
            }
            catch
            {

            }
            Application.Exit( );
        }

        private void namepr_txt_TextChanged (object sender, EventArgs e)
        {

        }

        private void add_btn_Click (object sender, EventArgs e)
        {
            string namepr = namepr_txt.Text;
            string grouppr = nmgroup_txt.Text;
            if(namepr == "" || grouppr == "" )
            {
                MessageBox.Show("есть пустые значения", "сообщение");
            }
            else
            {
                for (int i = 0; i<list2.Count;i++ )
                {
                    if(list2[i].NameGroup == namepr )
                    {
                        list01.ItemId = list1.Count;
                        list01.Name = namepr;
                        list1.Add(list01);
                        listBox1.Items.Add(list01);
                        break;
                    }
                }
            }
        }

        private void addgroup_btn_Click (object sender, EventArgs e)
        {
            string nmgr = namegroup_txt.Text;
        }

        private void group_btn_Click (object sender, EventArgs e)
        {
            var innerjoin = from t in list1
                            join d in list2 on t.ItemId equals d.ItemId
                            select new
                            {
                                itid = t.ItemId,
                                itdes = t.Name,
                                salee = d.Sale,
                            };
            foreach(var data in innerjoin )
            {
                listBox1.Items.Add(data.itid + " " + data.itdes + " " + data.salee);
            }
        }

        private void namegroup_txt_TextChanged (object sender, EventArgs e)
        {

        }
    }
}
