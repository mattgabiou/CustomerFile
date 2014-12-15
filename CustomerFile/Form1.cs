// Customers file program created by Matt Gabiou on 8-9-13

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // For the writer
using System.IO;


namespace CustomerFile
{
    // Main here
    public partial class Form1 : Form
    {
        // Form Global Area
         //

        // Create the List that holds each Customer object
        List<Customer> myCustomers = new List<Customer>();

        // Global variable to determine if there is a preexisting customers file or not
        bool xmlExists = false;

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlExists = DatabaseExists();
        }

        // Enter button clicked
        private void buttonEnterData_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (textBoxFullName.Text == "")
            {
                MessageBox.Show("Name field cannot be empty.");
                return;
            }
            else if (textBoxEmpNumber.Text == "")
            {
                MessageBox.Show("Employee number field cannot be empty.");
                return;
            }
            else if (textBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Phone Number field cannot be empty.");
                return;
            }


            // determine last element in Customer list
            //int curCustomer = myCustomers.Count - 1;
            int curCustomer = myCustomers.Count;

            // List based implementation
            //List<Customer> myCustomers = new List<Customer>();

            // Add Customer object to the list
            myCustomers.Add(new Customer(curCustomer, textBoxFullName.Text, textBoxEmpNumber.Text, textBoxPhoneNumber.Text));


            // Write data to xml
            //myCustomers[curCustomer].ShowCustomer();
            myCustomers[curCustomer].WriteToFile(ref xmlExists);

            // Add Customer information to the dataGrid on the form
            AddCustomerGrid(curCustomer, textBoxFullName.Text, textBoxEmpNumber.Text, textBoxPhoneNumber.Text);

            // Clear Input Fields after enter clicked
            ClearFields();



        }// end Enter Button

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            if(myCustomers.Count() == 0)
                MessageBox.Show("The Customers list is empty.");
            else
                // Show the list of Customers in the list
                foreach (var item in myCustomers)
                    item.ShowCustomer();
        }

        // Read from File and put its contents into a List
        private void buttonLoad_Click(object sender, EventArgs e)
        {  
            if (xmlExists)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("customers.xml");

                XmlNodeList custList = doc.GetElementsByTagName("Customer");

                foreach (XmlNode node in custList)
                {
                    XmlElement custElement = (XmlElement)node;

                    int id = Convert.ToInt32(custElement.GetElementsByTagName("ID")[0].InnerText);
                    string name = custElement.GetElementsByTagName("Name")[0].InnerText;
                    string empNumber = custElement.GetElementsByTagName("EmployeeNumber")[0].InnerText;
                    string phoneNum = custElement.GetElementsByTagName("PhoneNumber")[0].InnerText;
                    
                    myCustomers.Add(new Customer(Convert.ToInt32(id), name, empNumber, phoneNum));

                    // Add data to datagrid
                    AddCustomerGrid(Convert.ToInt32(id), name, empNumber, phoneNum);

                    //MessageBox.Show("Name is: " + name + Environment.NewLine + " Employee Number is: " + empNumber + Environment.NewLine + " Phone Number is: " + phoneNum);
                }
            }
                else
                    MessageBox.Show("customers.xml does not exist");  
        }// end Button Load

        // After enter button cliced clear all the text fields
        private void ClearFields()
        {
            textBoxFullName.Clear();
            textBoxPhoneNumber.Clear();
            textBoxEmpNumber.Clear();
        }

        // Checks to see if a previous file exists
        private bool DatabaseExists()
        {
            string curFile = "customers.xml";
            if (File.Exists(curFile))
                xmlExists = true;
            else
                xmlExists = false;

            return xmlExists; 
        }

        // Deletes the customers file if it exists
        private void DelCustomersFile()
        {
            if (DatabaseExists())
            {
                try
                {
                    File.Delete("customers.xml");
                    MessageBox.Show("Customers file deleted");
                }
                catch (IOException)
                {
                    MessageBox.Show("Problem deleting file");
                }
            }
            else
                MessageBox.Show("customers.xml does not exist");

            xmlExists = false;
        }

        // Calls the delete file method
        private void buttonDelFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete the customers file?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DelCustomersFile();
                ClearCustomersList();
                dataGridView1.Rows.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        // Deletes all the customers in the List
        private void ClearCustomersList()
        {
            myCustomers.Clear();
        }

        // Addes a row of customer data to the grid
        private void AddCustomerGrid(int theID, string theName, string theEmpNumber, string thePhoneNum)
        {
            this.dataGridView1.Rows.Add(theID, theName, theEmpNumber, thePhoneNum);
        }

        // Exits the program from the menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Displays help information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Matt Gabiou 8-9-13");
        }

    }// end main class



    class Customer
    {
        // Properties
        private int custID;
        private string custName;
        private string empNumber;
        private string phoneNumber;

        // Constructor
        public Customer(int theID, string theName, string theNumber, string thePhoneNumber)
        {
            this.custID = theID;
            this.custName = theName;
            this.empNumber = theNumber;
            this.phoneNumber = thePhoneNumber;
        }

        // Methods
        public int CustID
        {
            get { return custID; }
            set { custID = value; }
        }
        public string CustName
        { 
            get { return custName; }
            set { custName = value;  } 
        }
        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        // Outputs the value of the current customer 
        public void ShowCustomer()
        {
            MessageBox.Show("The Customer is: " + Environment.NewLine + " ID:  " + this.custID + Environment.NewLine + " Full Name:  " + this.custName + Environment.NewLine + " Employee Number:  " +
                this.empNumber + Environment.NewLine + " Phone Number:  " + this.phoneNumber);
        }

        // Writes the customer to the xml. First it checks if there is already a file and if there is appends to it
        public void WriteToFile(ref bool fileState)
        {

            if (fileState)
            {
                // Load the document
                XmlDocument custXml = new XmlDocument();
                custXml.Load("customers.xml");

                // Create a new element 
                XmlElement custEl = custXml.CreateElement("Customer");
                XmlElement idEl = custXml.CreateElement("ID");
                XmlElement nameEl = custXml.CreateElement("Name");
                XmlElement empEl = custXml.CreateElement("EmployeeNumber");
                XmlElement phoneNumEl = custXml.CreateElement("PhoneNumber");
                idEl.InnerText = custID.ToString();
                phoneNumEl.InnerText = phoneNumber;
                empEl.InnerText = empNumber;
                nameEl.InnerText = custName;
                
                // Add to the form
                custXml.DocumentElement.AppendChild(custEl);
                custEl.AppendChild(idEl);
                custEl.AppendChild(nameEl);
                custEl.AppendChild(empEl);
                custEl.AppendChild(phoneNumEl);

                // Save the File
                custXml.Save("customers.xml");
            }
            else
            {
                
                // Write data to file
                using (XmlWriter writer = XmlWriter.Create("customers.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Customers");

                    //foreach (Customer eachCust in CustomerFile.Form1.myCustomers)
                    //{
                    writer.WriteStartElement("Customer");
                    writer.WriteElementString("ID", custID.ToString());
                    writer.WriteElementString("Name", custName);
                    writer.WriteElementString("EmployeeNumber", empNumber);
                    writer.WriteElementString("PhoneNumber", phoneNumber);

                    writer.WriteEndElement();
                    //}

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    fileState = true;   
                }
                 
            }// end else

            
        }

    }// end class

}// end namespace
