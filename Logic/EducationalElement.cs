using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class EducationalElement
    {
        private string name;
        private float coefficient;

        public string Name
        {
            get => name;
            set
            {
                if (value == null) throw new Exception("Name can't be null");
                name = value;
            }
        }

        public float Coefficient
        {
            get => coefficient;
            set
            {
                if (value < 0) throw new Exception("Coefficient must be positive");
                coefficient = value;
            }
        }
    }
}
