﻿using System.Management.Automation;

namespace PSRule.Commands
{
    /// <summary>
    /// The Hint keyword.
    /// </summary>
    [Cmdlet(VerbsCommon.Set, RuleLanguageNouns.RuleHint)]
    internal sealed class SetPSRuleHintCommand : RuleKeyword
    {
        [Parameter(Mandatory = false, Position = 0)]
        public string Message { get; set; }

        [Parameter(Mandatory = false)]
        public string TargetName { get; set; }

        protected override void ProcessRecord()
        {
            var result = GetResult();

            if (MyInvocation.BoundParameters.ContainsKey("Message"))
            {
                result.Message = Message;
            }

            if (MyInvocation.BoundParameters.ContainsKey("TargetName"))
            {
                result.TargetName = TargetName;
            }
        }
    }
}