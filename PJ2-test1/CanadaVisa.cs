
namespace PJ2_test1
{
    public class CanadaVisa: IVisa
    {
        public bool? Approved => Payment != null;

        public string Name { get; set; }
        public double? Payment { get; set; }
        
        public CanadaVisa(string name, double? number)
        {
            Name = name;
            Payment = number;
        }
    }
}