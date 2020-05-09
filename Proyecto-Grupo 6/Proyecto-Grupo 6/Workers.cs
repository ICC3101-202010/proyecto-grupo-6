using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grupo_6
{
    [Serializable]
    class Workers
    {
        private string NameWorker;
        private string SurenameWorker;
        private string SexWorker;
        private int AgeWorker;

        public void SetName(string NameWorker)
        {
            this.NameWorker = NameWorker;
        }
        public string GetName()
        {
            return NameWorker;
        }
        public void SetSurname(string SurenameWorker)
        {
            this.SurenameWorker = SurenameWorker;
        }
        public string GetSurname()
        {
            return SurenameWorker;
        }
        public void SetSex(string SexWorker)
        {
            this.SexWorker = SexWorker;
        }
        public string GetSex()
        {
            return SexWorker;
        }
        public void SetAge(int AgeWorker)
        {
            this.AgeWorker = AgeWorker;
        }
        public int GetAge()
        {
            return AgeWorker;
        }

    }
}
