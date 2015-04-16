using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace KPrayogoFinal
{
    public partial class Form1 : Form
    {
        private List<Taxpayer> Taxpayers = new List<Taxpayer>();

        //Separate list to enable data overwrite
        private List<Taxpayer> TaxpayersToSave = new List<Taxpayer>();

        private bool dataEntered = false;
        private bool fileNotSaved = true;

        //FileName
        private string taxpayersFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string numericCheck = salaryTBox.Text + investTBox.Text;

            if (numericCheck.All(char.IsDigit))
            {
                string name = nameTBox.Text;
                decimal salary = decimal.Parse(salaryTBox.Text);
                decimal investment = decimal.Parse(investTBox.Text);
                bool isMarried = marriedCheckBox.Checked;
                int exemptCount = (int)exempNumeric.Value;

                //Create Object with inputs
                Taxpayer taxpayer = new Taxpayer(name, salary, investment, isMarried, exemptCount);

                //Save object in list
                Taxpayers.Add(taxpayer);
                TaxpayersToSave.Add(taxpayer);

                //Update DataGrid
                taxpayerBindingSource.Add(taxpayer);

                //Hide Input controls
                inputGroupBox.Visible = false;

                //Clear Inputs
                ClearInputs();

                //Data entered
                dataEntered = true;
            }
            else
            {
                displayTBox.AppendText("Please enter numeric inputs for Salary and Investment Income.");
                displayTBox.AppendText("\n");
            }


        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            displayTBox.AppendText(Taxpayer.Summary());
            displayTBox.AppendText("\n");
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if (dataEntered)
            {
                foreach (Taxpayer taxpayer in Taxpayers)
                {
                    displayTBox.AppendText(taxpayer.Display());
                    displayTBox.AppendText("\n");
                }
            }
            else
            {
                displayTBox.AppendText("No Data Available.");
                displayTBox.AppendText("\n");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Taxpayer.ResetData();
            displayTBox.Clear();
            ClearInputs();

            //Clear lists and data
            taxpayerBindingSource.Clear();
            Taxpayers.Clear();
            TaxpayersToSave.Clear();

            if (dataEntered && fileNotSaved)
            {
                SaveTaxpayersInfo();
            }

            taxpayersFile = null;
            dataEntered = false;
            fileNotSaved = true;
        }

        private void saveButton_Click ( object sender, EventArgs e )
        {
            if (dataEntered)
            {
                SaveTaxpayersInfo();
            }
            else
            {
                displayTBox.AppendText("No Data Available.");
                displayTBox.AppendText("\n");
            }
        }

        private void exitButton_Click ( object sender, EventArgs e )
        {
            if (dataEntered && fileNotSaved)
            {
                SaveTaxpayersInfo();
            }

            Taxpayers.Clear();
            TaxpayersToSave.Clear();

            Application.Exit();
        }

        private void enterDataButton_Click(object sender, EventArgs e)
        {
            inputGroupBox.Visible = true;
            nameTBox.Focus();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadTaxpayersData();
        }
    //----------------------------------------------Methods---------------------------------------------

        private void SaveTaxpayersInfo ( )
        {
            SaveFileDialog taxpayersFileChooser = new SaveFileDialog();
            taxpayersFileChooser.Filter = "All csv files|*.csv";

            //Default file if data saved previously
            taxpayersFileChooser.FileName = taxpayersFile;

            //Show Save dialog
            taxpayersFileChooser.ShowDialog();

            //Set file name
            taxpayersFile = taxpayersFileChooser.FileName;

            StreamWriter fileWriter = new StreamWriter(taxpayersFile, true);

            foreach (Taxpayer taxpayer in TaxpayersToSave)
            {
                string taxpayerInfoLine =
                    taxpayer.Name + "," +
                    taxpayer.Salary + "," +
                    taxpayer.Investment + "," +
                    taxpayer.Income.ToString() + "," +
                    taxpayer.TaxRate.ToString() + "," +
                    taxpayer.TaxAmt.ToString();

                fileWriter.WriteLine(taxpayerInfoLine);
                
            }

            fileWriter.Close();
            fileNotSaved = false;

            //Clear current list
            TaxpayersToSave.Clear();

            MessageBox.Show("Message saved to " + taxpayersFile);
        }

        private void LoadTaxpayersData()
        {
            OpenFileDialog taxpayersFileChooser = new OpenFileDialog();
            
            taxpayersFileChooser.ShowDialog();

            StreamReader fileReader = new StreamReader(taxpayersFileChooser.FileName);

            while (!fileReader.EndOfStream)
            {
                string line = fileReader.ReadLine();
                string[] fields = line.Split(',');

                string name = fields[0];
                decimal salary = decimal.Parse(fields[1]);
                decimal investment = decimal.Parse(fields[2]);
                bool isMarried = bool.Parse(fields[3]);
                int exemptCount = int.Parse(fields[4]);

                Taxpayer taxpayer = new Taxpayer(name, salary, investment, isMarried, exemptCount);
                Taxpayers.Add(taxpayer);
                TaxpayersToSave.Add(taxpayer);
                taxpayerBindingSource.Add(taxpayer);

            }

            //Data Entered
            dataEntered = true;

            fileReader.Close();
        }

        private void ClearInputs()
        {
            nameTBox.Clear();
            salaryTBox.Clear();
            investTBox.Clear();
            exempNumeric.Value = 0;
            inputGroupBox.Visible = false;
        }



    }
}

