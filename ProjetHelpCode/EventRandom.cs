using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHelpCode
{
    class RoleplayEvent
    {
        Random rnd = new Random();


        int lastEvent;
        int indexEvent;

        public void RandomEvent()
        {
            indexEvent = rnd.Next(0, 5);

            if (indexEvent == lastEvent)
            {
               indexEvent = rnd.Next(0, 5);
            }
            switch (indexEvent)
            {
                case 0:
                    Event01();
                    break;

                case 1:
                    Event02();
                    break;

                case 2:
                    Event03();
                    break;

                case 3:
                    Event04();
                    break;

                case 4:
                    Event05();
                    break;

                case 5:
                    Event06();
                    break;
            }
            lastEvent = indexEvent;
        }
    }
}
