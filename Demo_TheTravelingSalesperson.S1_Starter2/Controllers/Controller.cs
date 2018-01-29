using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSalesTracker
{
    /// <summary>
    /// MVC Controller class
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private bool _usingApplication;
        private Salesperson _salesperson;
        private ConsoleView _consoleView;
        //
        // declare ConsoleView and Salesperson objects for the Controller to use
        // Note: There is no need for a Salesperson or ConsoleView property given only the Controller 
        //       will access the ConsoleView object and will pass the Salesperson object to the ConsoleView.
        //


        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            InitializeController();

            //
            // instantiate a Salesperson object
            //
            _salesperson = new Salesperson();

            //
            // instantiate a ConsoleView object
            //
            _consoleView = new ConsoleView();

            //
            // begins running the application UI
            //
            ManageApplicationLoop();
        }

        #endregion
        
        #region METHODS

        /// <summary>
        /// initialize the controller 
        /// </summary>
        private void InitializeController()
        {
            _usingApplication = true;
        }

        /// <summary>
        /// method to manage the application setup and control loop
        /// </summary>
        private void ManageApplicationLoop()
        {
            MenuOption userMenuChoice;

            _consoleView.DisplayWelcomeScreen();

            //
            // setup initial salesperson account
            //
            _salesperson = _consoleView.DisplaySetupAccount();

            //
            //
            // application loope
            //
            while (_usingApplication)
            {
                //
                // get a menu choice from the user
                //
                userMenuChoice = _consoleView.DisplayGetUserMenuChoice();

                //
                // choose an action based on the user menu choice
                //
                switch (userMenuChoice)
                {
                    case MenuOption.None:
                        {
                            break;
                        }
                    case MenuOption.Travel:
                        {
                            Travel();
                            break;
                        }
                    case MenuOption.DisplayCities:
                        {
                            DisplayCities();
                            break;
                        }
                    case MenuOption.DisplayAccountInfo:
                        {
                            DisplayAccountInfo();
                            break;
                        }
                    case MenuOption.Exit:
                        {
                           _consoleView.DisplayExitPrompt();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            // close the application
            //
            Environment.Exit(1);
        }

        /// <summary>
        /// add the next city location to the list of cities
        /// </summary>
        private void Buy(Product product)
        {
          _consoleView.DisplayGetNumberOfUnitsToBuy(product);
            
        }

        /// <summary>
        /// add the next city location to the list of cities
        /// </summary>
        private void Travel()
        {
            string nextCity = _consoleView.DisplayGetNextCity(_salesperson);
            _salesperson.CitiesVisited.Add(nextCity);
        }

        /// <summary>
        /// display all cities traveled to
        /// </summary>
        private void DisplayCities()
        {
            _consoleView.DisplayCitiesTraveled(_salesperson);
        }

        /// <summary>
        /// display account information
        /// </summary>
        private void DisplayAccountInfo()
        {
            _consoleView.DisplayAccountInfo(_salesperson);
        }

        #endregion
    }
}
