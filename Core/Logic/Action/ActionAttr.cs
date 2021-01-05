using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTile.Core.Logic.Action
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ActionAttr : Attribute
    {
        public ActionManager.Action Action { get; set; }

        public ActionAttr(ActionManager.Action action)
        {
            Action = action;
        }
    }
}
