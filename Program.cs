namespace OOP_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            #region Q1
            #region a
            // 1- Owner and Balance are declared as public, so any other class can change them directly
            // 2- no validation on Balance -> any code can set Balance to a negative value without using Withdraw()
            // 3- Withdraw() has no validation -> The method subtracts the amount without checking if there is enough balance
            #endregion
            #region b

            //- make the fields private instead of public
            //- use properties (get/set) to control access
            //- add validation inside Withdraw()
            //- prevent direct modification of Balance from outside the class

            #endregion
            #region c
            /*
            - it breaks encapsulation
            - it allows invalid data ,like negative balance
            - you lose control over how data is modified
            - if you change the internal design later, other classes may break
             */
            #endregion
            #endregion
            #region Q2
            #endregion
            #region Q3
            #endregion
            #region Q4
            #endregion
            #endregion
            #region part02
            #endregion

        }
    }
}
