using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Range
{
    public class Range
    {
        private char[] _validDelimiters = { '[', ']', '(', ')' };

        public string InputRange
        {
            get;
            set;
        }

        private List<int> _points;
        public List<int> Points
        {
            get
            {
                if (_points == null)
                {
                    _points = new List<int>();
                }
                return _points;
            }
            set
            {
                _points = value;
            }
        }

        public bool ValidInput(string input)
        {
            char[] delimiters = {input[0],
                                    input[input.Length-1]};

            if (_validDelimiters.Contains(delimiters[0]) &&
                _validDelimiters.Contains(delimiters[1]))
            {
                string[] integers = input.TrimEnd(_validDelimiters).TrimStart(_validDelimiters).Split(',');
                bool canParse = true;
                foreach (string i in integers)
                {
                    int parsed;
                    canParse = int.TryParse(i, out parsed);
                }
                return canParse;
            }
            else
            {
                return false;
            }
        }

        public bool ContainsList(List<int> integerList)
        {
            char[] inclusiveDelimiters = { '[', ']' };
            string[] inputRange = InputRange.Split(',');

            //need to determine all numbers within the range, 
            //then can determine if the list supplied is part of that list
        }

        public List<int> GetAllPoints()
        {
            return Points;
        }
    }
}
