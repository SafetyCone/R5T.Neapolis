using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.Neapolis
{
    public static class IArgumentsBuilderExtensions
    {
        public static T AddPath<T>(this T argumentsBuilder, AbsolutePath path)
            where T : IArgumentsBuilder
        {
            argumentsBuilder.AddPath(path.Value);

            return argumentsBuilder;
        }
    }
}
