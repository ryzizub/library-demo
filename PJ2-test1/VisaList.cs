using System;
using System.Collections.Generic;

namespace PJ2_test1
{
    public class VisaList<T> where T : IVisa
    {

        private int index = 0;
        private List<T> visas = new List<T>();

        public T this[int i]
        {
            get
            {
                return visas[i];
            }
        }

        public int PendingCount
        {
            get
            {
                int count = 0;
                foreach (var visa in visas)
                {
                    if (visa.Approved == null)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public void Add(T visa)
        {
            visas.Add(visa);
            index++;
        }

        public bool PrintApproved()
        {
            var count = 0;
            foreach (var visa in visas)
            {
                if (visa.Approved != null && visa.Approved == true)
                {
                    Console.WriteLine(visa.Name);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Žádné schválené visum");
            }
            return true;
        }
    }

}