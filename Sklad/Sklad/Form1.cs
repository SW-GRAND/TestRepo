using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sklad
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();

        }
        private TSklad MySklad;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySklad = new TSklad();
            DGSklad.DataSource = MySklad.TabSklad;
        }

        private void BAddRowToTable_Click(object sender, EventArgs e)
        {
            Decimal pPcina; Int32 pKilkist;
            try
            {
                pPcina = Convert.ToDecimal(TBCina.Text);}
            catch{
                MessageBox.Show("Введіть у поле кількості числове значення");
                return;
            }
            try
            { pKilkist = Convert.ToInt32(TBKilkist.Text);}
            catch
            {
                MessageBox.Show("Введіть у поле кількості числове значення");
                return;
            }
            MySklad.TSkladAddRow(TBGroup.Text,TBNazva.Text,TBVyrobnyk.Text,pKilkist,pPcina);
            }
            }
        }
    

