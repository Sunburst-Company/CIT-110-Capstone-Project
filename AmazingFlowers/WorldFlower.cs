using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingFlowers
{
    public class WorldFlower
    {
        public enum BlossomSeason
        {
            spring,
            summer,
            fall
        }

        public enum PetalColor
        {
            yellow,
            red,
            blue,
            white,
            purple,
            pink,
            tricolor
        }

        #region FIELDS

        private string _name;
        private int _height;
        private bool _annual;
        private BlossomSeason _currentBlossomSeason;
        private PetalColor _currentPetalColor;
        private bool _validResponse;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public bool Annual
        {
            get { return _annual; }
            set { _annual = value; }
        }

        public BlossomSeason CurrentBlossomSeason
        {
            get { return _currentBlossomSeason; }
            set { _currentBlossomSeason = value; }
        }

        public PetalColor CurrentPetalColor
        {
            get { return _currentPetalColor; }
            set { _currentPetalColor = value; }
        }

        public bool ValidResponse
        {
            get { return _validResponse; }
            set { _validResponse = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public WorldFlower()
        {

        }

        public WorldFlower(string name)
        {
            _name = name;

        }

        #endregion

        #region METHODS

        public string CurrentBlossomSeasonInfo()
        {
            return _name + " is " + _currentBlossomSeason + ".";
        }

        public string CurrentPetalColorInfo()
        {
            return _name + " is " + _currentPetalColor + ".";
        }
        

        #endregion
    }
}
