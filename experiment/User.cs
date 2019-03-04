using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.experiment
{
    class User : EventArgs
    {
        private int _age;
        private string _name;
        private string _gneder;

        public string Gneder
        {
            get => _gneder;
            set
            {
                NewPublisher.
                _gneder = value;
            }
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}
