﻿using BashSoft.Attributes;
using BashSoft.Contracts;
using BashSoft.Exceptions;

namespace BashSoft.IO.Commands
{
    [Alias("cdrel")]
    public class ChangeRelativePathCommand : Command
    {
        [InjectAttribute]
        private IDirectoyManager inputOutputManager;

        public ChangeRelativePathCommand(string input, string[] data) : base(input, data)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string relativePath = this.Data[1];

            this.inputOutputManager.ChangeCurrentDirectoryRelative(relativePath);
        }
    }
}
