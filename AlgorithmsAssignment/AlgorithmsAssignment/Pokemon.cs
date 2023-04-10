using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment
{
    internal class Pokemon : IComparable<Pokemon>
    {
        private String _name;
        private String _primaryElement;
        private String _secondaryElement;
        private int _totalPower;
        private int _hp;
        private int _attack;

        public Pokemon(string name, string primaryElement, string secondaryElement, int totalPower, int hp, int attack)
        {
            this._name = name;
            this._primaryElement = primaryElement;
            this._secondaryElement = secondaryElement;
            this._totalPower = totalPower;
            this._hp = hp;
            this._attack = attack;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PrimaryElement
        {
            get { return _primaryElement; }
            set { _primaryElement = value; }
        }

        public string SecondaryElement
        {
            get { return _secondaryElement; }
            set { _secondaryElement = value; }
        }

        public int TotalPower
        {
            get { return _totalPower; }
            set { _totalPower = value; }
        }

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int CompareTo(Pokemon other)
        {
            if (other == null)
            {
                return 1;
            }

            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Primary Element: {PrimaryElement}, Secondary Element: {SecondaryElement}, Total Power: {TotalPower}, HP: {Hp}, Attack: {Attack}";
        }
    }
}
