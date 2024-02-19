using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn_QuanLyKPI
{
    public class Singleton
    {
        private static Singleton instance;
        private List<DataTable> Tables;
        public List<DataTable> getTable() { return Tables; }
        public void setTable(List<DataTable> table) { Tables = table; }
        private Singleton() { }
        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
