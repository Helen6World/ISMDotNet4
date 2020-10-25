using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ISMDotNet4
{
    public partial class Form1 : Form
    {
        int arrSize;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void buttonSeeResults_Click(object sender, EventArgs e)
        {

            double[] arr = new double[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                if (dataGridViewArrayEntering.Rows[0].Cells[i].Value != null) {
                    arr[i] = double.Parse(dataGridViewArrayEntering.Rows[0].Cells[i].Value.ToString());
                }
                
            }

            
            double SumOfNegativeArrayElements = MyLibrary.MyClassLibrary.SumOfNegativeArrayElements(arr);
            textBoxSumNegArrElems.Text = SumOfNegativeArrayElements.ToString();

            double MaxArrayElement = MyLibrary.MyClassLibrary.MaxArrayElement(arr);
            textBoxMaxArrElem.Text = MaxArrayElement.ToString();

            int IndexOfMaxArrayElement = MyLibrary.MyClassLibrary.IndexOfMaxArrayElement(arr);
            textBoxIndexMaxArrElem.Text = IndexOfMaxArrayElement.ToString();

            double MaxModuleArrayElement = MyLibrary.MyClassLibrary.MaxModuleArrayElement(arr);
            textBoxMaxModuleArrElem.Text = MaxModuleArrayElement.ToString();

            int IndexesSumOfPositiveArrayElements = MyLibrary.MyClassLibrary.IndexesSumOfPositiveArrayElements(arr);
            textBoxSumIndexesPositiveArrElems.Text = IndexesSumOfPositiveArrayElements.ToString();

            int QuantityOfIntegerArrayElements = MyLibrary.MyClassLibrary.QuantityOfIntegerArrayElements(arr);
            textBoxQuantityIntArrElems.Text = QuantityOfIntegerArrayElements.ToString();

            double[] arrSortedDecreasing = MyLibrary.MyClassLibrary.SortArrayByDecreasing(arr);
            
            dataGridViewSortedArr.ColumnCount = arrSortedDecreasing.Length;
            dataGridViewSortedArr.RowCount = 1;
            for (int i = 0; i < arrSortedDecreasing.Length; i++)
            {
                dataGridViewSortedArr.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewSortedArr[i, 0].Value = arrSortedDecreasing[i];
            }

            double[] arrDeletedNegElem = MyLibrary.MyClassLibrary.DeleteNegativeArrayElements(arr);

            dataGridViewArrDeletedNegElem.ColumnCount = arrDeletedNegElem.Length;
            dataGridViewArrDeletedNegElem.RowCount = 1;
            for (int i = 0; i < arrDeletedNegElem.Length; i++)
            {
                dataGridViewArrDeletedNegElem.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewArrDeletedNegElem[i, 0].Value = arrDeletedNegElem[i];
            }

        }

        private void buttonEnterArrSize_Click(object sender, EventArgs e)
        {
            arrSize = Convert.ToInt32(textBoxArrSize.Text);

            dataGridViewArrayEntering.ColumnCount = arrSize;
            dataGridViewArrayEntering.RowCount = 1;

            for (int i = 0; i < arrSize; i++)
            {
                dataGridViewArrayEntering.Columns[i].HeaderCell.Value = i.ToString();
            }
        }
    }
}
