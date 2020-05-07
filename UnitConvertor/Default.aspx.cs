using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using UnitConvertor.App_Code;


namespace UnitConvertor
{
    public partial class _Default : Page
    {
        String[] length = { "Meter", "Millimeter", "Centimeter", "Kilometer", "Inch", "Foot", "Yard", "Mile" }; //0-7, 8 values ------- 28 combinations
        String[] mass = {"Gram","Milligram", "Kilogram", "Ounce", "Pound" }; //0-3, 4 values ------- 8 combinations
        String[] speed = {"Kilometers per Hour", "Meters per Second", "Miles per Hour", "Feet per Second" }; //0-3, 4 values ------- 8 combinations
        String[] temperature = {"Fahrenheit", "Celsius", "Kelvin" }; //0-2, 3 values ------- 3 combinations
        String[] time = {"Hours", "Minutes", "Seconds", "Milliseconds" }; //0-2, 3 values ------- 3 combinations
        String[] volume = {"Liter", "Milliliter", "Fluid Ounce", "Cup", "Pint", "Quart", "Gallon" }; //0-6, 7 values ------- 21 combinations

        

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownListMeasure_SelectedIndexChanged(object sender, EventArgs e)// sets all dropdown boxes based on selected measurement
        {
            string selectedText = DropDownListMeasure.SelectedItem.Text;
            TextBoxIn.Text = "";
            TextBoxOut.Text = "";

            switch (selectedText)
            {
                
                case "Length": //fills length dropboxes with units
                    Label1.Text = selectedText;
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    for (int i = 0; i < length.Length; i++)
                    {
                        DropDownListIn.Items.Add(length[i]);
                        DropDownListOut.Items.Add(length[i]);
                    }
                    //Length len = new Length();
                    
                    break;

                case "Mass": //fills mass droboxes with units
                    Label1.Text = selectedText;
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    for (int i = 0; i < mass.Length; i++)
                    {
                        DropDownListIn.Items.Add(mass[i]);
                        DropDownListOut.Items.Add(mass[i]);
                    }
                    break;

                case "Speed": //fills speed droboxes with units
                    Label1.Text = selectedText;
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    for (int i = 0; i < speed.Length; i++)
                    {
                        DropDownListIn.Items.Add(speed[i]);
                        DropDownListOut.Items.Add(speed[i]);
                    }
                    break;

                case "Temperature": //fills temp dropboxes with units
                    Label1.Text = selectedText;
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    for (int i = 0; i < temperature.Length; i++)
                    {
                        DropDownListIn.Items.Add(temperature[i]);
                        DropDownListOut.Items.Add(temperature[i]);
                    }
                    break;

                case "Time": //fills time droboxes with units
                    Label1.Text = selectedText;
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    for (int i = 0; i < time.Length; i++)
                    {
                        DropDownListIn.Items.Add(time[i]);
                        DropDownListOut.Items.Add(time[i]);
                    }
                    break;

                case "Volume": //fills volume dropboxes with units
                    DropDownListIn.Items.Clear();
                    DropDownListOut.Items.Clear();
                    Label1.Text = selectedText;
                    for (int i = 0; i < volume.Length; i++)
                    {
                        DropDownListIn.Items.Add(volume[i]);
                        DropDownListOut.Items.Add(volume[i]);
                    }
                    break;

            }
        }

        protected void ButtonEnter_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(TextBoxIn.Text);
            string unit = DropDownListMeasure.SelectedItem.Text;
            string selectedUnitIn = DropDownListIn.SelectedItem.Text;
            string selectedUnitOut = DropDownListOut.SelectedItem.Text;
            double output = 0;
            double temp = 0;            
            
            switch(unit)
            {
                case ("Length"):
                    Length l = new Length(); //create instance of length class for length conversions
                    temp = l.MeterConversion(selectedUnitIn, input);
                    output = l.FinalConversion(selectedUnitOut, temp);                   
                    TextBoxOut.Text = Convert.ToString(output);
                    break;

                case ("Mass"):
                    Mass m = new Mass();
                    temp = m.GramConversion(selectedUnitIn, input);
                    output = m.FinalConversion(selectedUnitOut, temp);
                    TextBoxOut.Text = Convert.ToString(output);
                    break;

                case ("Speed"):
                    Speed s = new Speed();
                    temp = s.SpeedConversion(selectedUnitIn, input);
                    output = s.FinalConversion(selectedUnitOut, temp);
                    TextBoxOut.Text = Convert.ToString(output);
                    break;

                case ("Temperature"):
                    Temperature t = new Temperature();
                    temp = t.TempConversion(selectedUnitIn, input);
                    output = t.FinalConversion(selectedUnitOut, temp);
                    TextBoxOut.Text = Convert.ToString(output);
                    break;

                case ("Time"):
                    Time i = new Time();
                    temp = i.TimeConversion(selectedUnitIn, input);
                    output = i.FinalConversion(selectedUnitOut, temp);
                    TextBoxOut.Text = Convert.ToString(output);
                    break;

                case ("Volume"):
                    Volume v = new Volume();
                    temp = v.VolumeConversion(selectedUnitIn, input);
                    output = v.FinalConversion(selectedUnitOut, temp);
                    TextBoxOut.Text = Convert.ToString(output);
                    break;
            }
            
            
        }
    }
}