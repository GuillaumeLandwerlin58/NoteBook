using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Exam
    {
        private string teacher;
        private DateTime date;
        private float coef;
        private float note;
        private bool isAbsent;
        private Module module;

        public string Teacher
        {
            get => teacher;
            set
            {
                if (value == null) throw new Exception("Teacher can't be null");
                teacher = value;

            }
        }

        public float Coef 
        { 
            get => coef;
            set {
                if (value > 0) throw new Exception("Coefficient must be positive");
                coef = value;

            }
        }

        public float Note
        {
            get => note;
            set
            {
                if (value < 0 || value > 20) throw new Exception("Note must be between 0 and 20");
                note = value;
            }
        }

        public bool IsAbsent
        {
            get => isAbsent;
            set
            {
                if (value == true && note != 0) throw new Exception("Student must have 0 note if he is absent");
                isAbsent = value;
            }
        }

        public DateTime Date
        {
            get => date;
            set
            {
                date = value;
            }
        }

        public Module Module
        {
            get => module;
            set
            {
                if (value == null) throw new Exception("Module can't be null");
                module = value;
            }
        }

        public Exam(string teacher, DateTime date, float coef, float note, bool isAbsent)
        {
            this.teacher = teacher;
            this.date = date;
            Coef = coef;
            Note = note;
            IsAbsent = isAbsent;
        }
    }
}
