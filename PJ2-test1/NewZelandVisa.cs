using System.Runtime.Serialization.Formatters;

namespace PJ2_test1
{
    public class NewZelandVisa: IVisa
    {
        public bool? Approved {

            get
            {
                if (Payment == null)
                {
                    return null;
                }
                else
                {
                    return Payment > 4000;
                }
            }
        }
        public string Name { get; set; }
        public double? Payment { get; set; }

        public NewZelandVisa(string name, double? number)
        {
            Name = name;
            Payment = number;
        }
    }
}