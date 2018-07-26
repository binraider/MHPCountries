using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHPCountries {


    public class CountryItem {

        private int m_iso = 0;
        private string m_name = "";
        private string m_alpha2 = "";
        private string m_alpha3 = "";


        public CountryItem() {
        }

        public CountryItem(int _iso, string _name, string _alpha2, string _alpha3) {
            m_iso = _iso;
            m_name = _name;
            m_alpha2 = _alpha2;
            m_alpha3 = _alpha3;

        }
        public int Iso {
            get { return m_iso; }
            set { m_iso = value; }
        }
        public string Name {
            get { return m_name; }
            set { m_name = value; }
        }
        public string Alpha2 {
            get { return m_alpha2; }
            set { m_alpha2 = value; }
        }
        public string Alpha3 {
            get { return m_alpha3; }
            set { m_alpha3 = value; }
        }

    }
}
