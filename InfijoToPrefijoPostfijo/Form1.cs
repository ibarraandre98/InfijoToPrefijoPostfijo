﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfijoToPrefijoPostfijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String cadena = txtInfija.Text;
            operaciones(cadena);
        }

        private void operaciones(String cadena)
        {
            if (cadena == null || cadena.Length == 0)
                return;

            String cadenavolteada = VoltearCadena(cadena);
            String cadenaPrefijaVolteada = CalcularPrefija(cadenavolteada);
            String cadenaPrefija = VoltearCadena(cadenaPrefijaVolteada);
            txtPrefija.Text = cadenaPrefija;


            txtPostfija.Text = CalcularPostfija(cadenavolteada);
        }

        private String VoltearCadena(String cadena)
        {
            char[] arreglocadena = cadena.ToCharArray();
            Array.Reverse(arreglocadena);
            for (int i = 0; i <= arreglocadena.Length - 1; i++)
            {
                if (arreglocadena[i] == '(')
                {
                    arreglocadena[i] = ')';
                }
                else if (arreglocadena[i] == ')')
                {
                    arreglocadena[i] = '(';
                }

                else
                {
                    continue;
                }
            }
            return new String(arreglocadena);
        }

        private String CalcularPrefija(String ExpresionInfija)
        {

            if (ExpresionInfija == null || ExpresionInfija.Length == 0)
                return string.Empty;
            StringBuilder strBuilder = new StringBuilder();
            Stack<char> s = new Stack<char>();

            for (int i = 0; i <= ExpresionInfija.Length - 1; i++)
            {
                if (ExpresionInfija[i] == '(')
                {
                    s.Push(ExpresionInfija[i]);
                }
                else if (ExpresionInfija[i] == ')')
                {
                    while (s.Count > 0 && s.Peek() != '(')
                    {
                        strBuilder.Append(s.Pop());
                    }
                    s.Pop();
                }
                else if (ExpresionInfija[i] == '+' || ExpresionInfija[i] == '-'
                         || ExpresionInfija[i] == '/' || ExpresionInfija[i] == '*')
                {

                    while (s.Count > 0 && MismoOperador(ExpresionInfija[i], s.Peek()) == true)
                    {
                        strBuilder.Append(s.Pop());
                    }
                        

                    while (s.Count > 0 && OperadorMayor(ExpresionInfija[i], s.Peek()) == true)
                    {
                        strBuilder.Append(s.Pop());
                    }
                        

                    s.Push(ExpresionInfija[i]);
                }
                else
                {
                    strBuilder.Append(ExpresionInfija[i]);
                }

            }

            while (s.Count != 0)
            {
                strBuilder.Append(s.Pop());
            }
            return strBuilder.ToString();
        }

        private String CalcularPostfija(String ExpresionInfija)
        {
            if (ExpresionInfija == null || ExpresionInfija.Length == 0)
                return string.Empty;
            MessageBox.Show(ExpresionInfija);
            StringBuilder strBuilder = new StringBuilder();
            Stack<char> s = new Stack<char>();

            for (int i = ExpresionInfija.Length - 1; i >= 0; i--)
            {
                if (ExpresionInfija[i] == ')')
                {
                    s.Push(ExpresionInfija[i]);
                }
                else if (ExpresionInfija[i] == '(')
                {
                    while (s.Count > 0 && s.Peek() != ')')
                    {
                        strBuilder.Append(s.Pop());
                    }
                    s.Pop();
                }
                else if (ExpresionInfija[i] == '+' || ExpresionInfija[i] == '-'
                         || ExpresionInfija[i] == '/' || ExpresionInfija[i] == '*')
                {

                    while (s.Count > 0 && MismoOperador(ExpresionInfija[i], s.Peek()) == true)
                    {
                        strBuilder.Append(s.Pop());
                    }


                    while (s.Count > 0 && OperadorMayor(ExpresionInfija[i], s.Peek()) == true)
                    {
                        strBuilder.Append(s.Pop());
                    }


                    s.Push(ExpresionInfija[i]);
                }
                else
                {
                    strBuilder.Append(ExpresionInfija[i]);
                }

            }

            while (s.Count != 0)
            {
                strBuilder.Append(s.Pop());
            }

            return strBuilder.ToString();
        }

        private bool MismoOperador(char a,char b)
        {
            if ((a == '+' || a == '-') && (b == '+' || b == '-')) return true;
            else if ((a == '*' || a == '/') && (b == '*' || b == '/')) return true;
            else return false;
        }

        private bool OperadorMayor(char a,char b)
        {
            if ((a == '+' || a == '-') && (b == '*' || b == '/')) return true;
            else return false;
        }

        private void BtnCalcularInfija_Click(object sender, EventArgs e)
        {
            if (rbPrefija.Checked == true)
            {
                String cadenaprincipal = txtPrefijaInfija.Text;
                char[] arreglocadena = cadenaprincipal.ToCharArray();
                Array.Reverse(arreglocadena);
                String cadena = new String(arreglocadena);
                MessageBox.Show(cadena);
                String cadenatemp = null;
                Stack<String> pila = new Stack<String>();
                for (int i = 0; i < cadena.Length; i++)
                {
                    if((cadena[i]=='+'|| cadena[i] == '-' || cadena[i] == '*' || cadena[i] == '/')&&pila.Count>0)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (j == 1)
                            {
                                cadenatemp += cadena[i] + pila.Pop();
                            }
                            else
                            {
                                cadenatemp +=  pila.Pop();
                            }
                        }
                        pila.Push("("+cadenatemp+")");
                        cadenatemp = null;
                    }
                    else
                    {
                        pila.Push(cadena[i].ToString());
                    }
                }
                String cadenafinal=null;
                while (pila.Count > 0)
                {
                    cadenafinal += pila.Pop();
                }
                
                txtResultadoInfija.Text = cadenafinal;
            }
            else
            {
                String cadena = txtPostfijaInfija.Text;
                MessageBox.Show(cadena);
                String cadenatemp = null;
                Stack<String> pila = new Stack<String>();
                for (int i = 0; i < cadena.Length; i++)
                {
                    if ((cadena[i] == '+' || cadena[i] == '-' || cadena[i] == '*' || cadena[i] == '/') && pila.Count > 0)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            if (j == 1)
                            {
                                cadenatemp += cadena[i] + pila.Pop();
                            }
                            else
                            {
                                cadenatemp += pila.Pop();
                            }
                        }
                        pila.Push(")"+cadenatemp+"(");
                        cadenatemp = null;
                    }
                    else
                    {
                        pila.Push(cadena[i].ToString());
                    }
                }
                String cadenafinal = null;
                while (pila.Count > 0)
                {
                    cadenafinal += pila.Pop();
                }
                char[] arreglocadena = cadenafinal.ToCharArray();
                Array.Reverse(arreglocadena);
                cadenafinal = new String(arreglocadena);
                txtResultadoInfija.Text = cadenafinal;
            }
        }
    }
}
