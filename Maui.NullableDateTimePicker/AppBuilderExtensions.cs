using CommunityToolkit.Maui;
namespace Maui.NullableDateTimePicker
{
    public static class AppBuilderExtensions
    {
        public static MauiAppBuilder ConfigureNullableDateTimePicker(this MauiAppBuilder builder)
        {
#if DEBUG
#pragma warning disable CA1416
	        builder.UseMauiCommunityToolkit();
#pragma warning restore CA1416
#else
            builder.UseMauiCommunityToolkit(options =>
                 {
                     options.SetShouldSuppressExceptionsInConverters(true);
                     options.SetShouldSuppressExceptionsInBehaviors(true);
                     options.SetShouldSuppressExceptionsInAnimations(true);
                 });
#endif
            return builder;
        }
        
    }
}
