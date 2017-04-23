using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTradingDataAssignment
{
    public class Country : IComparable<Country>
    {
        public string name;
        private float gdpGrowth = 0f;
        private float inflation = 0f;
        private float tradeBalance = 0f;
        private float hdiRanking = 0f;
        private string[] mainTradePartners;


        public Country() { }
        public Country(
            string _name,
            float _gdpGrowth,
            float _inflation,
            float _tradeBalance,
            float _hdiRanking,
            string[] _mainTradePartners           
        ) {
            this.name = _name;
            this.gdpGrowth = _gdpGrowth;
            this.inflation = _inflation;
            this.tradeBalance = _tradeBalance;
            this.hdiRanking = _hdiRanking;
            this.mainTradePartners = _mainTradePartners;
        }


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public float GdpGrowth
        {
            get { return this.gdpGrowth; }
            set { this.gdpGrowth = value; }
        }

        public float Inflation
        {
            get { return this.inflation; }
            set { this.inflation = value; }
        }

        public float TradeBalance
        {
            get { return this.tradeBalance; }
            set { this.tradeBalance = value; }
        }

        public float HdiRanking
        {
            get { return this.hdiRanking; }
            set { this.hdiRanking = value; }
        }

        public string[] MainTradePartners
        {
            get { return this.mainTradePartners; }
            set { this.mainTradePartners = value; }
        }

        

        public int CompareTo(Country obj)
        {
            return Name.CompareTo(obj.Name);
        }
    }
}
