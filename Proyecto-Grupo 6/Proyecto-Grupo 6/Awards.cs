using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    [Serializable]
    class Awards
    {
        private string awardName;
        private string awardCategory;

        public string getName()
        {
            return awardName;
        }
        public string getCategory()
        {
            return awardCategory;
        }
        public void setName(string awardName)
        {
            this.awardName = awardName;
        }
        public void setCategory(string awardCategory)
        {
            this.awardCategory = awardCategory;
        }
    }
}
