using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Sklad
{
    class TSklad
    {
        public DataTable TabSklad = new DataTable();
        public TSklad()
        {
            DataColumn cNpp = new DataColumn("N_пп");
            DataColumn cNameGroup = new DataColumn("Група");
            DataColumn cNameProduct = new DataColumn("Назва");
            DataColumn cProduser = new DataColumn("Виробник");
            DataColumn cCount = new DataColumn("кількість");
            DataColumn cPrise = new DataColumn("ціна");
            DataColumn cVartist = new DataColumn("Вартість");

            cNpp.DataType = System.Type.GetType("System.Int32");
            cNameGroup.DataType = System.Type.GetType("System.String");
            cProduser.DataType = System.Type.GetType("System.String");
            cCount.DataType = System.Type.GetType("System.Int32");
            cPrise.DataType = System.Type.GetType("System.Decimal");
            cVartist.DataType = System.Type.GetType("System.Decimal");

            TabSklad.Columns.Add(cNpp);
            TabSklad.Columns.Add(cNameGroup);
            TabSklad.Columns.Add(cNameProduct);
            TabSklad.Columns.Add(cProduser);
            TabSklad.Columns.Add(cCount);
            TabSklad.Columns.Add(cPrise);
            TabSklad.Columns.Add(cVartist);

        }
        public void TSkladAddRow(string pNameGroup, string pNameProduct, string pProduser, int pCount, decimal pPrise)
        {
            int nn;
            nn = TabSklad.Rows.Count;
            DataRow rowSklad = TabSklad.NewRow();
            rowSklad["N_пп"] = nn++;
            rowSklad["Група"] = pNameGroup;
            rowSklad["Назва"] = pNameProduct;
            rowSklad["Виробник"] = pProduser;
            rowSklad["ціна"] = pPrise;
            rowSklad["кількість"] = pCount;
            rowSklad["Вартість"] = pCount*pPrise;
            TabSklad.Rows.Add(rowSklad);
        }
        public void ColumnPropSet(DataGridView DGV)
        {
            DGV.Columns["N_пп"].HeaderText = "№ п/п";
            DGV.Columns["Група"].HeaderText = "Група";
            DGV.Columns["Назва"].HeaderText = "Назва";
            DGV.Columns["Виробник"].HeaderText = "Виробник";
            DGV.Columns["ціна"].HeaderText = "ціна";
            DGV.Columns["кількість"].HeaderText = "кількість";
            DGV.Columns["Вартість"].HeaderText = "Вартість";

            DGV.Columns["N_пп"].ReadOnly = true;
            DGV.Columns["Вартість"].ReadOnly = true;
            DGV.Columns["N_пп"].Width = 40;
            DGV.Columns["Група"].Width = 100;
            DGV.Columns["Назва"].Width = 160;
            DGV.Columns["ціна"].Width = 70;
            DGV.Columns["кількість"].Width = 70;
            DGV.Columns["Вартість"].Width = 70;

            DGV.Columns[0].DefaultCellStyle.BackColor = Color.Green;

        }
    }
}
