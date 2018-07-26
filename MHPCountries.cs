using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHPCountries {
    public class CountryList {
        private List<CountryItem> m_items = null;

        public List<CountryItem> Items {
            get { return m_items; }
            set { m_items = value; }
        }

        public CountryList() {
            m_items = new List<CountryItem>();
        }

        public string GetCountryName(int iso) { 
            foreach(var x in m_items){
                if(iso == x.Iso) {
                    return x.Name;
                }
            }
            return "";
        }

        public CountryItem GetCountrye(int iso) {
            foreach(var x in m_items) {
                if(iso == x.Iso) {
                    return x;
                }
            }
            return new CountryItem();
        }
    }

}
