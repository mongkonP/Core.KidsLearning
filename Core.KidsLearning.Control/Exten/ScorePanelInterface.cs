using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace Core.KidsLearning.Control.Exten
{
    [HostProtection(SharedState = true)]
    public delegate void ScoreEventHandler(object sender, ScoreEvent e);
    public class ScoreEvent : EventArgs
    {

        int _right = 0;
        int _count = 0;
        public int Right { get { return _right; } }
        public int Count { get { return _count; } }
        public ScoreEvent(int r, int c)
        {
            _right = r;
            _count = c;
        }
        /* public void AddCout()
         {
             _count++;
         }
         public void AddCout(int c)
         {
             _count+=c ;
         }
         public void AddRight()
         {
             _right++;
         }
         public void AddRight(int r)
         {
             _right += r;
         }*/
    }
}
