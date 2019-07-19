using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Neapolis
{
    public static class NameValueExtensions
    {
        public static NameValueArgument SetValuePath(this NameValueArgument nameValue, AbsolutePath path)
        {
            nameValue.SetValuePath(path.Value);

            return nameValue;
        }
    }
}
