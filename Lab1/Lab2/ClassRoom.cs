using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] _pupils)
        {
            pupils = _pupils;
        }

        public void ShowAllPupils()
        {
            foreach (Pupil p in pupils)
            {
                p.Write();
                p.Read();
                p.Study();
                p.Relax();
            }
        }
    }
}
