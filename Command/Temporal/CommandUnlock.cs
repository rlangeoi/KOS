using System;
using System.Text.RegularExpressions;

namespace kOS.Command
{
    [Command("UNLOCK %")]
    public class CommandUnlock : Command
    {
        public CommandUnlock(Match regexMatch, ExecutionContext context) : base(regexMatch, context) { }

        public override void Evaluate()
        {
            String varname = RegexMatch.Groups[1].Value;

            if (varname.ToUpper() == "ALL")
            {
                ParentContext.UnlockAll();
            }
            else
            {
                ParentContext.Unlock(varname);
            }

            State = ExecutionState.DONE;
        }
    }
}