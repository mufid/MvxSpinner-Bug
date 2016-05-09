using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPlatformMenus.Core.ViewModels.Spinner
{
    public class Fruit
    {
        public Fruit(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; private set; }

        public override int GetHashCode()
        {
            return Name?.GetHashCode() ?? -1;
        }

        public override bool Equals(object obj)
        {
            return Name == (obj as Fruit)?.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class SpinnerViewModel : BaseViewModel
    {
        private List<Fruit> _fruits = new List<Fruit>()
        {
            new Fruit("Mango"),
            new Fruit("Orange")
        };
        public List<Fruit> Fruits
        {
            get { return _fruits; }
            set { _fruits = value; RaisePropertyChanged(() => Fruits); }
        }

        public Fruit _fruitSelected = new Fruit("Orange");
        public Fruit FruitSelected
        {
            get { return _fruitSelected; }
            set
            {
                _fruitSelected = value;
                RaisePropertyChanged(() => SelectedText);
                RaisePropertyChanged(() => FruitSelected);
            }
        }

        public string SelectedText
        {
            get { return $"You select {FruitSelected}"; }
        }
    }
}
