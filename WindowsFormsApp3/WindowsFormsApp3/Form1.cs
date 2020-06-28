using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        TPerson resp;
        public Form1()
        {
            InitializeComponent();
        }

       


        class TPerson

        {
            public String fName;
            public String fSome;
            public int Salary;
            public TPerson(String fam, String name, int okl)
            {
                fSome = fam;
                fName = name;
                Salary = okl;
            }
            public virtual String info()
            {
                return fSome + ' ' + fName;
            }
            public virtual double GetSum()
            {
                return Salary;
            }
        }
        class TStud : TPerson
        {
            public double fGr;
            public DateTime fGod;
            public TStud(String fam, String name, int okl, DateTime god, double gr) :
                    base(fam, name, okl)
            {

                fGr = gr;
                fGod = god;
            }

            public override String info()
            {
                return (string.Format("kfhef {0}{1}{2} , dfg sdfsdg {3}, dfszg sthf {5}, бабосы {4}",
                    fSome, ' ', fName, fGod.ToString("D"), Convert.ToDouble(GetSum()), Convert.ToDouble(fGr)));
            }
          
        }

        class TProf : TPerson
        {
            public String fkat;
            public String fDep;
            public TProf(String fam, String name, int okl, String kat, String dep) :
                    base(fam, name, okl)
            {
                fkat = kat;
                fDep = dep;
            }
            public override String info()
            {
                return (string.Format("rаяпвапesh {0}{1}{2} , вxявапdfgид {3}, seяаврrhseg {5}, fывапcg {4}",
                    fSome, ' ', fName, fkat, Convert.ToDouble(GetSum()), fDep));
            }
            public override double GetSum()
            {
                if (fkat == "высшая") return Salary * 1.74513;
                else if (fkat == "первая") return Salary * 1.446153;
                else return Salary;
            }
        }

      
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                resp = new TStud("Петров", "Петр", 10000000, Convert.ToDateTime("12.01.2000"), 3.6);
            }
            if (radioButton2.Checked)

            {
                resp = new TProf("Рыков", "Игнат", 110000, "высшая", "информатика");// ему не повезло(комментарий для 4 ветки)
            }

            textBox5.AppendText(resp.info() + "\n");
        }

       
    }
}
