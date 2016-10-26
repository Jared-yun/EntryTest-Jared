using System;

namespace EntryTest.EntryTestItems.T2_1
{
    public class InvalidOperationOnState : ApplicationException
    {
        public InvalidOperationOnState(string state)
            : base(string.Format("在状态（{0}）下，当前功能无效。 ", state))
        {
        }
    }
}