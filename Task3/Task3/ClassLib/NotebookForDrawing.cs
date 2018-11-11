using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class NotebookForDrawing : Notebook
    {
        public int NumberOfSheets { get; set; }
        public Countries CountryManufacturer { get; set; }
        public NotebookForDrawing(int quality, double thickness, int numberOfsheets, Countries countryManufacturer)
        {
            this.Quality = quality;
            this.Thickness = thickness;
            this.NumberOfSheets = numberOfsheets;
            this.CountryManufacturer = countryManufacturer;
            this.TypeOfProduct = "Тетрадь для рисования";
        }

        public override string DefineTypeOfProduct()
        {
            return TypeOfProduct;
        }

        public int OutputSheetsNumber()
        {
            return NumberOfSheets;
        }
        public string OutputCountryManufacturer()
        {
            return String.Format("Страна-производитель: {0}", CountryManufacturer);
        }

    }
}
