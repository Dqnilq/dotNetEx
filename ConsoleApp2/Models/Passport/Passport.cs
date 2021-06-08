using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Passport : ValueObject
    {
        public Passport(Series series, Number number, string issued, DateTime date, string registration) {
            if (series == null) {
                throw new ArgumentNullException(nameof(series));
            }
            if (number == null) {
                throw new ArgumentNullException(nameof(number));
            }

            Series = series;
            Number = number;
            Issued = issued;
            Date = date;
            Registration = registration;
        }

        public Series Series { get; set; }
        public Number Number { get; set; }
        
        public string Issued { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Registration { get; set; }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}