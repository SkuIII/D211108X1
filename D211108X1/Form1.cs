using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D211108X1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var MyPeople = new ContactEntities().People;

            
            foreach (Person item in MyPeople)
            {
                listBox1.Items.Add(item.ToString());
            }
        }
    }

    public partial class Person
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
