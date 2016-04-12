using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        SortedDictionary<string, HashSet<int>> zbiory = new SortedDictionary<string, HashSet<int>>(); 
        public Form1()
        {
            InitializeComponent();
            lbZbiory.Items.Clear();
        }

        /// <summary>
        /// Tworzenie zbiorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreate_Click(object sender, EventArgs e)
        {
            if (lbColection.SelectedItem != null)
            {
                if (tbName.Text != "")
                {
                    if (zbiory.ContainsKey(tbName.Text))
                    {
                        MessageBox.Show("Podana nazwa istanieje, podaj inną!");
                    }
                    else
                    {
                        HashSet<int> lista = new HashSet<int>();
                        foreach (var n in lbColection.SelectedItems)
                        {
                            lista.Add(int.Parse(n.ToString()));
                        }
                        zbiory.Add(tbName.Text, lista);
                        lbZbiory.Items.Add(tbName.Text);
                        tbName.Text = "";
                        lbColection.ClearSelected();
                    }
                }
                else
                {
                    MessageBox.Show("Brak podanej nazwy zbioru!");
                }
            }
            else
            {
                MessageBox.Show("Brak zaznaczonego elementu!");
            }
        }


        /// <summary>
        /// Wyświetlanie zbiorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bShow_Click(object sender, EventArgs e)
        {
            tbResult.Text = "";
            if (lbZbiory.SelectedItem != null)
            {
                foreach (var item in lbZbiory.SelectedItems)
                {
                    foreach (var zbiorek in zbiory.Keys)
                    {
                        if (zbiorek.Equals(item.ToString()))
                        {
                            HashSet<int> temp = new HashSet<int>();
                            zbiory.TryGetValue(item.ToString(), out temp);
                            tbResult.Text += item + ":   ";
                            foreach (var n in temp)
                            {
                                tbResult.Text += n + "   ";
                            }
                        }
                    }
                }
            }
        }


        /// <summary>
        /// Czy należy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bIsBelongs_Click(object sender, EventArgs e)
        {
            if (lbColection.SelectedItems.Count == 1 && lbZbiory.SelectedItems.Count == 1)
            {
                HashSet<int> lista = new HashSet<int>();
                zbiory.TryGetValue(lbZbiory.Text, out lista);

                if (lista.Contains(int.Parse(lbColection.Text)))
                {
                    MessageBox.Show("Zawiera!");
                }
                else
                {
                    MessageBox.Show("Nie zawiera!");
                }
            }
            else
            {
                MessageBox.Show("Zaznacz tylko jeden element!");
            }
        }


        /// <summary>
        /// Dodawanie zbiorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (lbZbiory.SelectedItems.Count == 2)
            {
                string name;
                if (tbName.Text != "")
                    name = tbName.Text;
                else
                    name = lbZbiory.SelectedItems[0].ToString() + lbZbiory.SelectedItems[1]+ "+";

                if (zbiory.ContainsKey(name))
                {
                    MessageBox.Show("Podana nazwa lub domyslna już istanieje podaj inną!");
                }
                else
                {

                    HashSet<int> lista = new HashSet<int>();

                    foreach (var item in lbZbiory.SelectedItems)
                    {
                        HashSet<int> temp = new HashSet<int>();
                        zbiory.TryGetValue(item.ToString(), out temp);

                        foreach (var n in temp)
                        {
                            lista.Add(n);
                        }
                    }

                    zbiory.Add(name, lista);
                    lbZbiory.Items.Add(name);
                }
            }
        }

        /// <summary>
        /// Odejmowanie zbiorów(wykluczenie części wspólnej)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lbZbiory.SelectedItems.Count == 2)
            {
                string name;
                if (tbName.Text != "")
                    name = tbName.Text;
                else
                    name = lbZbiory.SelectedItems[0].ToString() + lbZbiory.SelectedItems[1] + "+";

                if (zbiory.ContainsKey(name))
                {
                    MessageBox.Show("Podana nazwa lub domyslna już istanieje podaj inną!");
                }
                else
                {

                    HashSet<int> lista = new HashSet<int>();
                    zbiory.TryGetValue(lbZbiory.SelectedItems[0].ToString(), out lista);

                    HashSet<int> temp = new HashSet<int>();
                    zbiory.TryGetValue(lbZbiory.SelectedItems[1].ToString(), out temp);

                    HashSet<int> result = new HashSet<int>();

                    foreach (var n in temp)
                    {
                        if (!lista.Contains(n))
                            result.Add(n);
                    }

                    foreach (var m in lista)
                    {
                        if (!temp.Contains(m))
                            result.Remove(m);
                    }

                    zbiory.Add(name, result);
                    lbZbiory.Items.Add(name);
                }
           }

        }

        /// <summary>
        /// Część wspólna zbiorów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (lbZbiory.SelectedItems.Count == 2)
            {
                string name;
                if (tbName.Text != "")
                    name = tbName.Text;
                else
                    name = lbZbiory.SelectedItems[0].ToString() + lbZbiory.SelectedItems[1] + "+";

                if (zbiory.ContainsKey(name))
                {
                    MessageBox.Show("Podana nazwa lub domyslna już istanieje podaj inną!");
                }
                else
                {
                    HashSet<int> lista = new HashSet<int>();
                    zbiory.TryGetValue(lbZbiory.SelectedItems[0].ToString(), out lista);

                    HashSet<int> temp = new HashSet<int>();
                    zbiory.TryGetValue(lbZbiory.SelectedItems[1].ToString(), out temp);

                    HashSet<int> result = new HashSet<int>();
                    foreach (var n in temp)
                    {
                        if (lista.Contains(n))
                            result.Add(n);

                    }

                    zbiory.Add(name, result);
                    lbZbiory.Items.Add(name);
                }
            }
        }
    }
}
