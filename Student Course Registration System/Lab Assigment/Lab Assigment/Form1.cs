using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Assigment
{
    public partial class Form1 : Form
    {

        // Stores a course name and price so the ListBox can hold both
        private class CourseItem
        {
            public string Name;
            public decimal Price;
            public override string ToString()
            {
                return Name + "  -  " + Price.ToString("C2", Us);
            }
        }

        private static readonly CultureInfo Us = CultureInfo.GetCultureInfo("en-US");
        private const int MaxCourses = 5;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string courseName = NameCourseTxt.Text.Trim();

                // Course name must not be empty
                if (courseName == "")
                {
                    MessageBox.Show("Please enter a course name.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NameCourseTxt.Focus();
                    return;
                }

                // Price must be a valid decimal and greater than zero
                decimal price;
                if (!decimal.TryParse(priceCourseTxt.Text, NumberStyles.Number, Us, out price) || price <= 0)
                {
                    MessageBox.Show("Course price must be a number greater than zero.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    priceCourseTxt.Focus();
                    return;
                }

                // Maximum of 5 courses
                if (Registerlist.Items.Count >= MaxCourses)
                {
                    MessageBox.Show("You can register a maximum of " + MaxCourses + " courses.",
                        "Limit reached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // While loop: check existing courses to prevent duplicate names
                int index = 0;
                bool isDuplicate = false;
                while (index < Registerlist.Items.Count && !isDuplicate)
                {
                    CourseItem existing = (CourseItem)Registerlist.Items[index];
                    if (string.Equals(existing.Name, courseName, StringComparison.OrdinalIgnoreCase))
                    {
                        isDuplicate = true;
                    }
                    index++;
                }

                if (isDuplicate)
                {
                    MessageBox.Show("This course has already been added.", "Duplicate course",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NameCourseTxt.Focus();
                    return;
                }

                // Add the course, update the count, and clear the course inputs
                Registerlist.Items.Add(new CourseItem { Name = courseName, Price = price });
                NameCourseTxt.Clear();
                priceCourseTxt.Clear();
                NameCourseTxt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error while adding the course: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int selectedIndex = Registerlist.SelectedIndex;
                if (selectedIndex < 0)
                {
                    MessageBox.Show("Please select a course to remove.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
               

                

                // A course must be selected first
                if (selectedIndex < 0)
                {
                    MessageBox.Show("Please select a course to remove.", "No selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Remove the selected course and update the registered count
                Registerlist.Items.RemoveAt(selectedIndex);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while removing the course:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate age: int.TryParse and range 16-60
                int age;
                if (!int.TryParse(StudentAge.Text, out age))
                {
                    MessageBox.Show("Student age must be a whole number.");
                   
                }
                if (age < 16 || age > 60)
                {
                    MessageBox.Show("Student age must be between 16 and 60.");
                }

                // Name and ID are required
                if (StudentNameTxt.Text.Trim() == "")
                {
                    MessageBox.Show("Student name cannot be empty.");
                    
                }
                if (StudentId.Text.Trim() == "")
                {
                    MessageBox.Show("Student ID cannot be empty.");
                  
                }

                // At least one course is required
                int courseCount = Registerlist.Items.Count;
                if (courseCount == 0)
                {
                    MessageBox.Show("Please register at least one course.");
                }

                // While loop: add up the prices of all registered courses
                decimal basicFee = 0m;
                int i = 0;
                while (i < courseCount)
                {
                    basicFee += ((CourseItem)Registerlist.Items[i]).Price;
                    i++;
                }

                // if-else-if: discount rate by number of courses
                decimal courseRate;
                if (courseCount == 1) courseRate = 0m;
                else if (courseCount == 2) courseRate = 0.05m;
                else if (courseCount <= 4) courseRate = 0.10m;
                else courseRate = 0.15m;

                // Both discounts are calculated from the basic fee
                decimal courseDiscount = basicFee * courseRate;
                decimal scholarshipDiscount = schoolershipCheck.Checked ? basicFee * 0.20m : 0m;
                decimal finalFee = basicFee - courseDiscount - scholarshipDiscount;

                resultlist.Items.Add("         STUDENT REGISTRATION RESULTS");
                resultlist.Items.Add(new string('=', 44));
                resultlist.Items.Add("Student Name       : " + StudentNameTxt.Text);
                resultlist.Items.Add("Student Age        : " + StudentAge.Text);
                resultlist.Items.Add("Student ID         : " + StudentId.Text);
                resultlist.Items.Add("Course Name        : " + NameCourseTxt.Text);
                resultlist.Items.Add("Basic Fee          : $" + basicFee);
                resultlist.Items.Add("Course Disc.       : $" + courseDiscount);
                resultlist.Items.Add("Scholarship (20%)  : -$" + scholarshipDiscount);
                resultlist.Items.Add(new string('-', 44));
                resultlist.Items.Add("Final Fee : $" + finalFee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error during calculation: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void clearButton_Click(object sender, EventArgs e)
        {
            StudentNameTxt.Clear();
            StudentAge.Clear();
            StudentId.Clear();
            NameCourseTxt.Clear();
            priceCourseTxt.Clear();
            schoolershipCheck.Checked = false;
            Registerlist.Items.Clear();
            resultlist.Items.Clear();
            StudentNameTxt.Focus();
        }

       
        private void exitButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}