using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA_CNTT.Class;

namespace DA_CNTT.Controllers
{
    public class testController
    {
        private CChapters chapter;
        public testController()
        {
            this.chapter = new CChapters();
        }
        public void chap()
        {
            //var ken =this.chapter.findAll();
            this.chapter.Update();
            var a = 1;
        }
    }
}
