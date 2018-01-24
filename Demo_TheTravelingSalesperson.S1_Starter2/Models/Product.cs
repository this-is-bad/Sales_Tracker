using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_TheTravelingSalesperson
{
    class Product
    {
        #region FIELDS

        private int _numberOfUnits;
        private bool _onBackorder;
        private ProductType _type;

        #endregion

        #region PROPERTIES
        public int NumberOfUnits
        {
            get { return _numberOfUnits; } 
        }

        public bool OnBackorder
        {
            get { return _onBackorder; }
            set { _onBackorder = value; }
        }

        public ProductType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public enum ProductType
        {
            None,
            Furry,
            Spotted,
            Dancing
        }

        #endregion

        #region CONSTRUCTORS

        public Product()
        {
            
        }

        public Product(ProductType type, int numberOfUnits)
        {
            _type = type;
            _numberOfUnits = numberOfUnits;
        }

        #endregion

        #region METHODS
        static void AddProducts(int unitsToAdd)
        {


        }

        static void SubtractProducts(int unitsToSubtract)
        {


        }

        #endregion
    }
}
