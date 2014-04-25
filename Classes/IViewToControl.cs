using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Math_Monkeys
{
    interface IViewToControl
    {
        #region Methods (Send Data To Control)
        // Call front-end input checkers or validate here
        bool IsFormInputValid();
        // Pass input to the Control as strings
        bool SendInput(List<string> inputList);
        
        #endregion
    }
}
