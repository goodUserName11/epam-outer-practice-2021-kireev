using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KireevCustoms
{

    /// <summary>
    /// Class represents string as array of characters
    /// </summary>
    public class CustomString
    {
        private char[] _charsArray;

        /// <summary>
        /// Get character by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public char this[int index]
        {
            get => _charsArray[index];

            set => _charsArray[index] = value;
        }

        /// <summary>
        /// Get lenght of a string
        /// </summary>
        public int Length
        {
            get => _charsArray.Length;
        }

        public CustomString() : this(0) { }

        public CustomString(int startLength) =>
            _charsArray = new char[startLength];

        public CustomString(char[] arrayOfCharacters) =>
            _charsArray = (char[])arrayOfCharacters.Clone();

        public CustomString(string str) :
            this(str.ToCharArray()) { }

        public CustomString(char character, int times) :
            this(new char[] { character }, times) { }

        public CustomString(char[] arrayOfCharacters, int times)
        {
            if (times < 0)
                throw new ArgumentOutOfRangeException("times", "Cannot be negative");

            _charsArray = new char[arrayOfCharacters.Length * times];

            for (int i = 0; i < times; i++)
            {
                for (int j = 0; j < arrayOfCharacters.Length; j++)
                {
                    _charsArray[arrayOfCharacters.Length *
                        i + j] = arrayOfCharacters[j];
                }
            }
        }

        public CustomString(string str, int times) :
            this(str.ToCharArray(), times) { }


        /// <summary>
        /// Create new CustomString from an array of characters
        /// </summary>
        /// <param name="arrayOfCharacters">Array of characters</param>
        /// <returns>New instance of CustomString</returns>
        public static CustomString FromCharArray(char[] arrayOfCharacters) =>
            new CustomString(arrayOfCharacters);

        /// <summary>
        /// Get array of characters from current instance of CustomString
        /// </summary>
        /// <returns>Array of characters</returns>
        public char[] ToCharArray() =>
            (char[])_charsArray.Clone();

        public int IndexOf(char[] value)
        {
            if (_charsArray.Length == 0)
                return -1;

            int count = 0;

            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] == value[count])
                {
                    if (++count == value.Length)
                        return i - value.Length + 1;
                }
                else count = 0;
            }

            return -1;
        }

        public int IndexOf(char value) =>
            IndexOf(new char[]{value});

        public int IndexOf(string value) =>
            IndexOf(value.ToCharArray());

        public int LastIndexOf(char[] value)
        {
            if (_charsArray.Length == 0)
                return -1;

            int count = 0;
            int lastIndexOf = -1;

            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] == value[count])
                {
                    count++;

                    if (count == value.Length)
                    {
                        lastIndexOf = i - value.Length + 1;

                        count = 0;
                    }
                }
                else count = 0;
            }
            
            return lastIndexOf;
        }

        public int LastIndexOf(char value) =>
            LastIndexOf(new char[] {value});

        public int LastIndexOf(string value) =>
            LastIndexOf(value.ToCharArray());

        public bool Contains(string value) =>
            IndexOf(value)> -1 ? true : false;
        

        public CustomString Concat(CustomString string2) =>
            this + string2;

        public CustomString Concat(char[] string2) =>
            this + string2;

        public CustomString Concat(string string2) =>
            this + string2;

        public static CustomString operator +
            (CustomString left, CustomString right)
        {
            CustomString newCustomString =
                new CustomString(left.Length + right.Length);

            for (int i = 0; i < left.Length; i++)
            {
                newCustomString[i] = left[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                newCustomString[left.Length + i] =
                    right[i];
            }

            return newCustomString;
        }

        public static CustomString operator +
            (CustomString left, char[] right) =>
            left + new CustomString(right);

        public static CustomString operator +
            (char[] left, CustomString right) =>
            new CustomString(left) + right;

        public static CustomString operator +
            (CustomString left, string right) =>
            left + new CustomString(right);

        public static CustomString operator +
            (string left, CustomString right) =>
            new CustomString(left) + right;

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj == null || !(obj is CustomString cs) || 
                this.GetHashCode() != cs.GetHashCode() ||
                this.Length != cs.Length)
                return false;


            for (int i = 0; i < this.Length; i++)
            {
                if (this[i] != cs[i])
                    return false;
            }

            return true;
        }

        // override object.GetHashCode
        public override int GetHashCode() =>
            -2060156296 + 
            EqualityComparer<char[]>.Default.GetHashCode(_charsArray);

        public static bool operator ==
            (CustomString left, CustomString right)
        {
            if (left.Length != right.Length)
                return false;

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                    return false;
            }

            return true;
        }

        public static bool operator !=
            (CustomString left, CustomString right) =>
            !(left == right);

        public static implicit operator CustomString(string str) =>
            new CustomString(str);

        public static implicit operator string(CustomString str) =>
            str.ToString();

        public override string ToString() =>
            new string(this.ToCharArray());
    }
}
